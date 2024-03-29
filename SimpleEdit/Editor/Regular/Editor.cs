using SimpleEdit.Dialogs;
using SimpleEdit.Lib;
using SimpleEdit;
using System.Diagnostics;
using System.Windows.Forms;
using static SimpleEdit.Lib.Layer;


namespace SimpleEdit
{
    public partial class Editor : Form
    {
        public event Action OnFileChanged;
        bool PauseActions = false;
        CancellationTokenSource RenderToken = new CancellationTokenSource();
        IO IO = new IO();
        Bitmap OpenImage;
        LayerTree ILayerTree = new LayerTree();

        List<LayerOnRender> LayerTree = new List<LayerOnRender>();
        Dictionary<string, int> TrackbarValues = new Dictionary<string, int>();
        public Editor()
        {
            InitializeComponent();

            OnFileChanged += () =>
            {
                ClearAllEffects();
                this.Text = $"Simple Edit : {IO.LastFilePath.Split('\\').Last()}";
                imheight.Text = OpenImage.Height.ToString();
                imwidht.Text = OpenImage.Width.ToString();
                Program.editor.LastFilePath = IO.LastFilePath;
                SaveEditor();

                if (Program.editor.AutoPreviewScale)
                {
                    var _Screen = Screen.PrimaryScreen.Bounds.Size.Width * Screen.PrimaryScreen.Bounds.Size.Height;
                    var _Image = OpenImage.Size.Width * OpenImage.Size.Height;

                    if (_Screen > _Image)
                        Program.editor.PreviewScale = 0.8f;
                    else if (_Screen == _Image)
                        Program.editor.PreviewScale = 0.45f;
                    else
                    {
                        Program.editor.PreviewScale = (float)(1 / Math.Ceiling((double)_Image / _Screen * 1.5f));
                    }
                }

            };
            foreach (var control in tabPage1.Controls)
            {

                if (control is TrackBar)
                {
                    TrackBar tb = (TrackBar)control;
                    TrackbarValues.Add(tb.Name, tb.Value);
                }
            }
            //    LayerTree.Add(BuildInLayers.Invert());

            Canvas.SizeMode = Program.editor.CanvasSizeMode;
            Canvas.BackColor = Program.editor.CanvasBackgroundColor;
        }
        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (IO.ReadBitmap(out OpenImage) != DialogResult.OK)
                return;

            Canvas.Image = ImageProcess.ResizeImage(OpenImage, Program.editor.PreviewScale);
            OnFileChanged?.Invoke();
        }
        async Task RenderImage(bool ForSave = false)
        {
            if (OpenImage is null)
                return;

            if (PauseActions && !RenderToken.IsCancellationRequested)
            {
                RenderToken.Cancel();
                RenderView.Visible = false;
                Options.Enabled = true;
                return;
            }
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            RenderView.Visible = true;
            Options.Enabled = false;
            RenderToken = new CancellationTokenSource();
            PauseActions = true;

            if (MirrorEffect.Checked)
                ILayerTree.Mirror = BuildInLayers.MirrorEffect();
            else
                ILayerTree.Mirror = null;

            if (verticalflip.Checked)
                ILayerTree.FlipVertically = BuildInLayers.FlipVertically();
            else
                ILayerTree.FlipVertically = null;

            if (BlackOnly.Checked)
                ILayerTree.GrayScale = BuildInLayers.GrayScale();
            else
                ILayerTree.GrayScale = null;

            if (Invert.Checked)
                ILayerTree.Invert = BuildInLayers.Invert();
            else
                ILayerTree.Invert = null;


            if (!ForSave)
                Canvas.Image = await ImageProcess.ReDrawBitmap(OpenImage, ILayerTree, Remaning, RenderToken.Token, Program.editor.PreviewScale);
            else
                Canvas.Image = await ImageProcess.ReDrawBitmap(OpenImage, ILayerTree, Remaning, RenderToken.Token, 1, "Resizing & Rendering For Saving.. ");
            stopwatch.Stop();
            taskinf.Text = $"Task Completed in {stopwatch.ElapsedMilliseconds}ms";
            RenderView.Visible = false;
            Options.Enabled = true;
            RenderToken = new CancellationTokenSource();
            PauseActions = false;


        }
        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (PauseActions)
                return;

            if (OpenImage == null)
                return;
            info.Text = $" Image Size (Width: {OpenImage.Width} Height: {OpenImage.Height}) Cursor Position : (X : {e.X} Y : {e.Y}) |";
            return;
            //DrawGrid();
            //if (Program.editor.DrawCursorGrid)
            //{
            //    Canvas.Refresh();
            //    using (var g = Canvas.CreateGraphics())
            //    {
            //        // Draw on X Axis
            //        g.DrawLine(new Pen(Program.editor.CursorLineColor, Program.editor.CursorLineTickness), new Point(e.X, 0), new Point(e.X, e.Y));
            //        // Draw on Y Axis
            //        g.DrawLine(new Pen(Program.editor.CursorLineColor, Program.editor.CursorLineTickness), new Point(0, e.Y), new Point(e.X, e.Y));
            //    }
            //}

            //if (ColorPreview)
            //{
            //    using (var bmap = new Bitmap(1, 1))
            //    {
            //        using (var g = Graphics.FromImage(bmap))
            //        {
            //            g.CopyFromScreen(e.Location, Point.Empty, new Size(1, 1));
            //            using (var hx = Canvas.CreateGraphics())
            //            {
            //                hx.FillEllipse(new SolidBrush(bmap.GetPixel(0, 0)), e.X + 5, e.Y + 10, 40, 40);
            //            }
            //        }
            //    }
            //}


            return;
        }
        void DrawGrid()
        {
            using (var g = Canvas.CreateGraphics())
            {
                var p = new Pen(Color.DarkGray, 1.5f);
                for (int i = 0; i < Canvas.Width; i += 40)
                {
                    var wf = new Point(i, 0);
                    var ws = new Point(i, Canvas.Height);
                    g.DrawLine(p, ws, wf);
                    g.DrawString(i.ToString(), new Font("Arial", 8), new SolidBrush(Color.Green), wf);
                    g.DrawLine(p, new Point(0, i), new Point(Canvas.Width, i));
                    g.DrawString(i.ToString(), new Font("Arial", 8), new SolidBrush(Color.Green), new Point(0, i));


                }
                // g.DrawString(($"X:{e.X},\nY:{e.Y}"), new Font("Arial", 8), new SolidBrush(Color.Green), new Point(e.X + 10, e.Y + 5));
            }
        }
        void ClearAllEffects()
        {
            ILayerTree = new LayerTree();
            foreach (var control in tabPage1.Controls)
            {
                if (control is TrackBar)
                {
                    TrackBar tb = (TrackBar)control;
                    if (TrackbarValues.TryGetValue(tb.Name, out int val))
                        tb.Value = val;
                }
            }
        }

        private void Canvas_Resize(object sender, EventArgs e)
        {
            DrawGrid();
        }
    }
}
