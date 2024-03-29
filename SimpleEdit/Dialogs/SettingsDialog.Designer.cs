namespace SimpleEdit.Dialogs
{
    partial class SettingsDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            pratiotext = new Label();
            previewRatio = new TrackBar();
            label4 = new Label();
            cursonlines = new CheckBox();
            label1 = new Label();
            label3 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            ticknessTrackbar = new TrackBar();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            auto = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)previewRatio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ticknessTrackbar).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(22, 18);
            label2.Name = "label2";
            label2.Size = new Size(112, 18);
            label2.TabIndex = 21;
            label2.Text = "Image Settings";
            // 
            // button4
            // 
            button4.Location = new Point(246, 450);
            button4.Name = "button4";
            button4.Size = new Size(183, 23);
            button4.TabIndex = 20;
            button4.Text = "Save Changes";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Location = new Point(134, 450);
            button2.Name = "button2";
            button2.Size = new Size(106, 23);
            button2.TabIndex = 19;
            button2.Text = "Discard";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(22, 450);
            button1.Name = "button1";
            button1.Size = new Size(106, 23);
            button1.TabIndex = 18;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pratiotext
            // 
            pratiotext.AutoSize = true;
            pratiotext.Font = new Font("Arial", 12F);
            pratiotext.ForeColor = Color.DimGray;
            pratiotext.Location = new Point(361, 77);
            pratiotext.Name = "pratiotext";
            pratiotext.Size = new Size(37, 18);
            pratiotext.TabIndex = 17;
            pratiotext.Text = "0.5x";
            // 
            // previewRatio
            // 
            previewRatio.Location = new Point(32, 77);
            previewRatio.Maximum = 100;
            previewRatio.Minimum = 1;
            previewRatio.Name = "previewRatio";
            previewRatio.Size = new Size(323, 45);
            previewRatio.TabIndex = 16;
            previewRatio.TickStyle = TickStyle.None;
            previewRatio.Value = 10;
            previewRatio.ValueChanged += previewRatio_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(32, 47);
            label4.Name = "label4";
            label4.Size = new Size(150, 16);
            label4.TabIndex = 15;
            label4.Text = "Preview Resolution Ratio";
            // 
            // cursonlines
            // 
            cursonlines.AutoSize = true;
            cursonlines.Location = new Point(154, 196);
            cursonlines.Name = "cursonlines";
            cursonlines.Size = new Size(15, 14);
            cursonlines.TabIndex = 22;
            cursonlines.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(32, 194);
            label1.Name = "label1";
            label1.Size = new Size(116, 16);
            label1.TabIndex = 23;
            label1.Text = "Draw Curson Lines";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(22, 162);
            label3.Name = "label3";
            label3.Size = new Size(112, 18);
            label3.TabIndex = 24;
            label3.Text = "Image Settings";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(32, 226);
            label5.Name = "label5";
            label5.Size = new Size(116, 16);
            label5.TabIndex = 25;
            label5.Text = "Draw Curson Lines";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 192, 192);
            panel1.Location = new Point(154, 228);
            panel1.Name = "panel1";
            panel1.Size = new Size(15, 14);
            panel1.TabIndex = 26;
            panel1.Click += panel1_Click;
            // 
            // ticknessTrackbar
            // 
            ticknessTrackbar.LargeChange = 1;
            ticknessTrackbar.Location = new Point(175, 226);
            ticknessTrackbar.Name = "ticknessTrackbar";
            ticknessTrackbar.Size = new Size(180, 45);
            ticknessTrackbar.TabIndex = 27;
            ticknessTrackbar.TickStyle = TickStyle.None;
            ticknessTrackbar.ValueChanged += trackBar1_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(361, 228);
            label6.Name = "label6";
            label6.Size = new Size(17, 18);
            label6.TabIndex = 28;
            label6.Text = "1";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(175, 194);
            label7.Name = "label7";
            label7.Size = new Size(87, 16);
            label7.TabIndex = 29;
            label7.Text = "Line Tickness";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(71, 106);
            label8.Name = "label8";
            label8.Size = new Size(252, 16);
            label8.TabIndex = 31;
            label8.Text = "Automatically decide based on image size";
            // 
            // auto
            // 
            auto.AutoSize = true;
            auto.Location = new Point(379, 108);
            auto.Name = "auto";
            auto.Size = new Size(15, 14);
            auto.TabIndex = 30;
            auto.UseVisualStyleBackColor = true;
            // 
            // SettingsDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 479);
            Controls.Add(label8);
            Controls.Add(auto);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(ticknessTrackbar);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(cursonlines);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pratiotext);
            Controls.Add(previewRatio);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettingsDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            Load += SettingsDialog_Load;
            Shown += SettingsDialog_Shown;
            ((System.ComponentModel.ISupportInitialize)previewRatio).EndInit();
            ((System.ComponentModel.ISupportInitialize)ticknessTrackbar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button button4;
        private Button button2;
        private Button button1;
        private Label pratiotext;
        private TrackBar previewRatio;
        private Label label4;
        private CheckBox cursonlines;
        private Label label1;
        private Label label3;
        private Label label5;
        private Panel panel1;
        private TrackBar ticknessTrackbar;
        private Label label6;
        private Label label7;
        private Label label8;
        private CheckBox auto;
    }
}