using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleEdit.Dialogs
{
    public partial class SettingsDialog : Form
    {
        public static bool HasChanged = false;
        public SettingsDialog()
        {
            InitializeComponent();
        }

        // Save settings
        private void button4_Click(object sender, EventArgs e)
        {
            Program.editor.PreviewScale = previewRatio.Value / 100f;
            Program.editor.DrawCursorGrid = cursonlines.Checked;
            Program.editor.CursorLineColor = panel1.BackColor;
            Program.editor.CursorLineTickness = ticknessTrackbar.Value;
            Program.editor.AutoPreviewScale = auto.Checked;
            EditorConfig.SaveToLocal(Program.editor);
            HasChanged = true;
            this.Close();
        }

        private void previewRatio_ValueChanged(object sender, EventArgs e)
        {
            pratiotext.Text = $"{previewRatio.Value / 100f}x";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.editor = new EditorConfig();
            HasChanged = true;
            EditorConfig.SaveToLocal(Program.editor);
            this.Close();
        }

        // Load settings
        private void SettingsDialog_Shown(object sender, EventArgs e)
        {
            try
            {
                previewRatio.Value = Convert.ToInt32(Program.editor.PreviewScale * 100);

            }
            catch (Exception)
            {
                previewRatio.Value = previewRatio.Maximum;
            }
            pratiotext.Text = $"{previewRatio.Value / 100f}x";
            panel1.BackColor = Program.editor.CursorLineColor;
            cursonlines.Checked = Program.editor.DrawCursorGrid;
            ticknessTrackbar.Value = Program.editor.CursorLineTickness;
            auto.Checked = Program.editor.AutoPreviewScale;
            HasChanged = false;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            using (var clr = new ColorDialog())
            {
                var result = clr.ShowDialog();
                if (result == DialogResult.OK)
                    panel1.BackColor = clr.Color;
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            label6.Text = $"{ticknessTrackbar.Value}";
        }

        private void SettingsDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
