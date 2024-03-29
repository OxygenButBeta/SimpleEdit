using SimpleEdit.Dialogs;
using SimpleEdit.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEdit
{
    public partial class Editor : Form
    {
        private async void button6_Click(object sender, EventArgs e)
        {
            await RenderToken.CancelAsync();

            RenderView.Visible = false;
            Options.Enabled = true;
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            ILayerTree.Contrast = null;
            await RenderImage();
        }
        private async void UndoSaturation_Click(object sender, EventArgs e)
        {
            ILayerTree.Saturation = null;
            await RenderImage();
        }
        private async void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (OpenImage == null)
                return;
            await RenderImage(true);
            var path = IO.LastFilePath.Split('\\');
            string format = path[path.Length - 1].Split('.')[1];
            string name = path[path.Length - 1].Split('.')[0];
            string dir = string.Empty;
            for (int i = 0; i < path.Length - 1; i++)
                dir += path[i] + "\\";
            var comppath = $"{dir}{DateTime.Now:yy_MM_dd_HH_mm}{name}.{format}";
            IO.Save((Bitmap)Canvas.Image, comppath);
            OpenImage = (Bitmap)Bitmap.FromFile(comppath);
            OnFileChanged?.Invoke();
            await RenderImage();
        }
        private async void button7_Click(object sender, EventArgs e)
        {
            OpenImage = ImageProcess.ResizeImage(IO.ReadLast(), Convert.ToInt32(imwidht.Text), Convert.ToInt32(imheight.Text));
            await RenderImage();
        }
        private async void button2_Click(object sender, EventArgs e)
        {
            ILayerTree.Brightness = null;
            await RenderImage();
        }
        private async void button4_Click(object sender, EventArgs e)
        {
            ILayerTree.ColorBalance = null;
            await RenderImage();
        }
        private void SaveEditor()
        {
            Program.editor.CanvasSizeMode = Canvas.SizeMode;
            Program.editor.CanvasBackgroundColor = Canvas.BackColor;
            EditorConfig.SaveToLocal(Program.editor);
        }
        bool ColorPreview = false;
        private void checkBox1_CheckedChanged_1(object sender, EventArgs e) => ColorPreview = checkBox1.Checked;

        private void Editor_Shown(object sender, EventArgs e)
        {

            if (Program.editor.LastFilePath != string.Empty)
            {
                if (File.Exists(Program.editor.LastFilePath))
                {
                    Canvas.Image = OpenImage = IO.DirectRead(Program.editor.LastFilePath);
                    OnFileChanged?.Invoke();
                }
            }
        }


        private async void button3_Click(object sender, EventArgs e)
        {
            ClearAllEffects();
            await RenderImage();
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            OpenImage = IO.ReadLast();
            OnFileChanged?.Invoke();
            await RenderImage();
        }


        private async void visualSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SettingsDialog().ShowDialog();
            if (!Program.editor.DrawCursorGrid)
                Canvas.Refresh();
            if (!SettingsDialog.HasChanged)
                return;
            await RenderImage();
        }
        #region Lambdas
        private void Canvas_SizeModeChanged(object sender, EventArgs e) => SaveEditor();
        private void normalToolStripMenuItem_Click(object sender, EventArgs e) => Canvas.SizeMode = PictureBoxSizeMode.Normal;
        private void strectToolStripMenuItem_Click(object sender, EventArgs e) => Canvas.SizeMode = PictureBoxSizeMode.StretchImage;
        private void zoomToolStripMenuItem_Click_1(object sender, EventArgs e) => Canvas.SizeMode = PictureBoxSizeMode.Zoom;
        private void centerToolStripMenuItem_Click(object sender, EventArgs e) => Canvas.SizeMode = PictureBoxSizeMode.CenterImage;
        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GUI.PickColor(out Color c) == DialogResult.OK)
                Program.editor.CanvasBackgroundColor = Canvas.BackColor = c;
        }
        private async void TrackMouseUp(object sender, MouseEventArgs e) => await RenderImage();
        private void Saturation_t_MouseDown(object sender, MouseEventArgs e) => ILayerTree.Saturation = BuildInLayers.Saturation(Saturation_t.Value);
        private void gamma_Track_Scroll(object sender, EventArgs e) => ILayerTree.Contrast = BuildInLayers.Contrast(gamma_Track.Value);
        private async void MirrorEffect_MouseClick(object sender, MouseEventArgs e) => await RenderImage();
        private void trackBar1_ValueChanged(object sender, EventArgs e) => ILayerTree.Brightness = BuildInLayers.Brightness(BrightnessBar.Value);
        private async void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await RenderImage(true);
            IO.SaveAs((Bitmap)Canvas.Image.Clone());
        }
        private void R_Track_ValueChanged(object sender, EventArgs e) => ILayerTree.ColorBalance = BuildInLayers.ColorBalance(R_Track.Value, G_Track.Value, B_Track.Value);
        private void G_Track_ValueChanged(object sender, EventArgs e) => ILayerTree.ColorBalance = BuildInLayers.ColorBalance(R_Track.Value, G_Track.Value, B_Track.Value);
        private void B_Track_ValueChanged(object sender, EventArgs e) => ILayerTree.ColorBalance = BuildInLayers.ColorBalance(R_Track.Value, G_Track.Value, B_Track.Value);
        private void Form1_FormClosing(object sender, FormClosingEventArgs e) => RenderToken.Cancel();

        #endregion

    }
}