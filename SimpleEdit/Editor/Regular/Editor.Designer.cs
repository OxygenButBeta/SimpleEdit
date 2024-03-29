namespace SimpleEdit
{
    partial class Editor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Canvas = new PictureBox();
            panel1 = new Panel();
            checkBox1 = new CheckBox();
            Options = new TabControl();
            tabPage1 = new TabPage();
            button3 = new Button();
            panel3 = new Panel();
            button2 = new Button();
            BrightnessBar = new TrackBar();
            label8 = new Label();
            button5 = new Button();
            gamma_Track = new TrackBar();
            label2 = new Label();
            button4 = new Button();
            UndoSaturation = new Button();
            Saturation_t = new TrackBar();
            label6 = new Label();
            B_Track = new TrackBar();
            label5 = new Label();
            G_Track = new TrackBar();
            label4 = new Label();
            label3 = new Label();
            R_Track = new TrackBar();
            label1 = new Label();
            tabPage2 = new TabPage();
            Invert = new CheckBox();
            BlackOnly = new CheckBox();
            button1 = new Button();
            verticalflip = new CheckBox();
            MirrorEffect = new CheckBox();
            label12 = new Label();
            ImHei = new Label();
            imheight = new TextBox();
            ImWid = new Label();
            button7 = new Button();
            label7 = new Label();
            imwidht = new TextBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            canvasToolStripMenuItem = new ToolStripMenuItem();
            sizeModeToolStripMenuItem = new ToolStripMenuItem();
            normalToolStripMenuItem = new ToolStripMenuItem();
            strectToolStripMenuItem = new ToolStripMenuItem();
            zoomToolStripMenuItem = new ToolStripMenuItem();
            centerToolStripMenuItem = new ToolStripMenuItem();
            backgroundColorToolStripMenuItem = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            visualSettingsToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            taskinf = new Label();
            info = new Label();
            Remaning = new Label();
            RenderView = new Panel();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)Canvas).BeginInit();
            panel1.SuspendLayout();
            Options.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BrightnessBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gamma_Track).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Saturation_t).BeginInit();
            ((System.ComponentModel.ISupportInitialize)B_Track).BeginInit();
            ((System.ComponentModel.ISupportInitialize)G_Track).BeginInit();
            ((System.ComponentModel.ISupportInitialize)R_Track).BeginInit();
            tabPage2.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            RenderView.SuspendLayout();
            SuspendLayout();
            // 
            // Canvas
            // 
            Canvas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Canvas.BackColor = Color.Transparent;
            Canvas.BackgroundImageLayout = ImageLayout.Zoom;
            Canvas.ImageLocation = "";
            Canvas.Location = new Point(34, 24);
            Canvas.Name = "Canvas";
            Canvas.Size = new Size(1162, 548);
            Canvas.SizeMode = PictureBoxSizeMode.Zoom;
            Canvas.TabIndex = 0;
            Canvas.TabStop = false;
            Canvas.SizeModeChanged += Canvas_SizeModeChanged;
            Canvas.MouseMove += Canvas_MouseMove;
            Canvas.Resize += Canvas_Resize;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(checkBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(34, 576);
            panel1.TabIndex = 2;
            // 
            // checkBox1
            // 
            checkBox1.Appearance = Appearance.Button;
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(8, 12);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(23, 25);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "T";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged_1;
            // 
            // Options
            // 
            Options.Controls.Add(tabPage1);
            Options.Controls.Add(tabPage2);
            Options.Dock = DockStyle.Right;
            Options.Location = new Point(1198, 24);
            Options.Name = "Options";
            Options.SelectedIndex = 0;
            Options.Size = new Size(248, 576);
            Options.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(panel3);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(BrightnessBar);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(button5);
            tabPage1.Controls.Add(gamma_Track);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(UndoSaturation);
            tabPage1.Controls.Add(Saturation_t);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(B_Track);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(G_Track);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(R_Track);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(240, 548);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Color";
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom;
            button3.Font = new Font("Segoe UI", 8.25F);
            button3.Location = new Point(23, 504);
            button3.Name = "button3";
            button3.Size = new Size(203, 20);
            button3.TabIndex = 24;
            button3.Text = "Clear All Effects";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Location = new Point(6, 170);
            panel3.Name = "panel3";
            panel3.Size = new Size(231, 5);
            panel3.TabIndex = 23;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 8.25F);
            button2.Location = new Point(101, 144);
            button2.Name = "button2";
            button2.Size = new Size(125, 20);
            button2.TabIndex = 22;
            button2.Text = "Revert";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // BrightnessBar
            // 
            BrightnessBar.LargeChange = 3;
            BrightnessBar.Location = new Point(80, 119);
            BrightnessBar.Maximum = 255;
            BrightnessBar.Minimum = -255;
            BrightnessBar.Name = "BrightnessBar";
            BrightnessBar.Size = new Size(146, 45);
            BrightnessBar.SmallChange = 0;
            BrightnessBar.TabIndex = 21;
            BrightnessBar.TickStyle = TickStyle.None;
            BrightnessBar.ValueChanged += trackBar1_ValueChanged;
            BrightnessBar.MouseUp += TrackMouseUp;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9.75F);
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(6, 119);
            label8.Name = "label8";
            label8.Size = new Size(69, 16);
            label8.TabIndex = 20;
            label8.Text = "Brightness";
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 8.25F);
            button5.Location = new Point(101, 90);
            button5.Name = "button5";
            button5.Size = new Size(125, 20);
            button5.TabIndex = 19;
            button5.Text = "Revert";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // gamma_Track
            // 
            gamma_Track.LargeChange = 3;
            gamma_Track.Location = new Point(80, 68);
            gamma_Track.Minimum = -10;
            gamma_Track.Name = "gamma_Track";
            gamma_Track.Size = new Size(146, 45);
            gamma_Track.TabIndex = 17;
            gamma_Track.TickStyle = TickStyle.None;
            gamma_Track.Scroll += gamma_Track_Scroll;
            gamma_Track.MouseUp += TrackMouseUp;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(6, 68);
            label2.Name = "label2";
            label2.Size = new Size(63, 16);
            label2.TabIndex = 16;
            label2.Text = "Contrasat";
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 8.25F);
            button4.Location = new Point(101, 301);
            button4.Name = "button4";
            button4.Size = new Size(125, 20);
            button4.TabIndex = 15;
            button4.Text = "Revert";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // UndoSaturation
            // 
            UndoSaturation.Font = new Font("Segoe UI", 8.25F);
            UndoSaturation.Location = new Point(101, 30);
            UndoSaturation.Name = "UndoSaturation";
            UndoSaturation.Size = new Size(125, 20);
            UndoSaturation.TabIndex = 14;
            UndoSaturation.Text = "Revert";
            UndoSaturation.UseVisualStyleBackColor = true;
            UndoSaturation.Click += UndoSaturation_Click;
            // 
            // Saturation_t
            // 
            Saturation_t.LargeChange = 3;
            Saturation_t.Location = new Point(80, 8);
            Saturation_t.Minimum = -10;
            Saturation_t.Name = "Saturation_t";
            Saturation_t.Size = new Size(146, 45);
            Saturation_t.TabIndex = 12;
            Saturation_t.TickStyle = TickStyle.None;
            Saturation_t.MouseDown += Saturation_t_MouseDown;
            Saturation_t.MouseUp += TrackMouseUp;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 8.25F);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(23, 281);
            label6.Name = "label6";
            label6.Size = new Size(28, 14);
            label6.TabIndex = 10;
            label6.Text = "Blue";
            // 
            // B_Track
            // 
            B_Track.LargeChange = 3;
            B_Track.Location = new Point(70, 273);
            B_Track.Maximum = 100;
            B_Track.Name = "B_Track";
            B_Track.Size = new Size(162, 45);
            B_Track.TabIndex = 9;
            B_Track.TickStyle = TickStyle.None;
            B_Track.ValueChanged += B_Track_ValueChanged;
            B_Track.MouseUp += TrackMouseUp;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 8.25F);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(19, 253);
            label5.Name = "label5";
            label5.Size = new Size(37, 14);
            label5.TabIndex = 8;
            label5.Text = "Green";
            // 
            // G_Track
            // 
            G_Track.LargeChange = 3;
            G_Track.Location = new Point(70, 250);
            G_Track.Maximum = 100;
            G_Track.Name = "G_Track";
            G_Track.Size = new Size(162, 45);
            G_Track.TabIndex = 7;
            G_Track.TickStyle = TickStyle.None;
            G_Track.ValueChanged += G_Track_ValueChanged;
            G_Track.MouseUp += TrackMouseUp;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 8.25F);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(24, 222);
            label4.Name = "label4";
            label4.Size = new Size(26, 14);
            label4.TabIndex = 6;
            label4.Text = "Red";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(80, 190);
            label3.Name = "label3";
            label3.Size = new Size(88, 16);
            label3.TabIndex = 5;
            label3.Text = "Color Balance";
            // 
            // R_Track
            // 
            R_Track.LargeChange = 3;
            R_Track.Location = new Point(70, 225);
            R_Track.Maximum = 100;
            R_Track.Name = "R_Track";
            R_Track.Size = new Size(162, 45);
            R_Track.TabIndex = 4;
            R_Track.TickStyle = TickStyle.None;
            R_Track.ValueChanged += R_Track_ValueChanged;
            R_Track.MouseUp += TrackMouseUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(3, 8);
            label1.Name = "label1";
            label1.Size = new Size(66, 16);
            label1.TabIndex = 0;
            label1.Text = "Saturation";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(Invert);
            tabPage2.Controls.Add(BlackOnly);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(verticalflip);
            tabPage2.Controls.Add(MirrorEffect);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(ImHei);
            tabPage2.Controls.Add(imheight);
            tabPage2.Controls.Add(ImWid);
            tabPage2.Controls.Add(button7);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(imwidht);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(240, 548);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Image";
            // 
            // Invert
            // 
            Invert.AutoSize = true;
            Invert.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Invert.ForeColor = Color.DimGray;
            Invert.Location = new Point(115, 143);
            Invert.Name = "Invert";
            Invert.Size = new Size(95, 19);
            Invert.TabIndex = 24;
            Invert.Text = "Invert Colors";
            Invert.UseVisualStyleBackColor = true;
            Invert.MouseClick += MirrorEffect_MouseClick;
            // 
            // BlackOnly
            // 
            BlackOnly.AutoSize = true;
            BlackOnly.Font = new Font("Arial", 8.25F);
            BlackOnly.ForeColor = Color.DimGray;
            BlackOnly.Location = new Point(115, 168);
            BlackOnly.Name = "BlackOnly";
            BlackOnly.Size = new Size(104, 18);
            BlackOnly.TabIndex = 23;
            BlackOnly.Text = "Black And White";
            BlackOnly.UseVisualStyleBackColor = true;
            BlackOnly.MouseClick += MirrorEffect_MouseClick;
            // 
            // button1
            // 
            button1.Location = new Point(119, 63);
            button1.Name = "button1";
            button1.Size = new Size(113, 24);
            button1.TabIndex = 22;
            button1.Text = "Back To Original";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // verticalflip
            // 
            verticalflip.AutoSize = true;
            verticalflip.Font = new Font("Arial", 8.25F);
            verticalflip.ForeColor = Color.DimGray;
            verticalflip.Location = new Point(16, 168);
            verticalflip.Name = "verticalflip";
            verticalflip.Size = new Size(92, 18);
            verticalflip.TabIndex = 21;
            verticalflip.Text = "Flipt Vertically";
            verticalflip.UseVisualStyleBackColor = true;
            verticalflip.MouseClick += MirrorEffect_MouseClick;
            // 
            // MirrorEffect
            // 
            MirrorEffect.AutoSize = true;
            MirrorEffect.Font = new Font("Arial", 8.25F);
            MirrorEffect.ForeColor = Color.DimGray;
            MirrorEffect.Location = new Point(16, 143);
            MirrorEffect.Name = "MirrorEffect";
            MirrorEffect.Size = new Size(86, 18);
            MirrorEffect.TabIndex = 20;
            MirrorEffect.Text = "Mirror Effect";
            MirrorEffect.UseVisualStyleBackColor = true;
            MirrorEffect.MouseClick += MirrorEffect_MouseClick;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 9.75F);
            label12.ForeColor = Color.DimGray;
            label12.Location = new Point(83, 112);
            label12.Name = "label12";
            label12.Size = new Size(83, 16);
            label12.TabIndex = 19;
            label12.Text = "Image Shape";
            // 
            // ImHei
            // 
            ImHei.AutoSize = true;
            ImHei.Font = new Font("Arial", 9.75F);
            ImHei.ForeColor = Color.DimGray;
            ImHei.Location = new Point(119, 35);
            ImHei.Name = "ImHei";
            ImHei.Size = new Size(52, 16);
            ImHei.TabIndex = 18;
            ImHei.Text = "Height :";
            // 
            // imheight
            // 
            imheight.BorderStyle = BorderStyle.FixedSingle;
            imheight.Font = new Font("Arial", 9.75F);
            imheight.Location = new Point(174, 33);
            imheight.Name = "imheight";
            imheight.Size = new Size(47, 22);
            imheight.TabIndex = 17;
            // 
            // ImWid
            // 
            ImWid.AutoSize = true;
            ImWid.Font = new Font("Arial", 9.75F);
            ImWid.ForeColor = Color.DimGray;
            ImWid.Location = new Point(7, 35);
            ImWid.Name = "ImWid";
            ImWid.Size = new Size(49, 16);
            ImWid.TabIndex = 16;
            ImWid.Text = "Width :";
            // 
            // button7
            // 
            button7.Location = new Point(7, 63);
            button7.Name = "button7";
            button7.Size = new Size(113, 24);
            button7.TabIndex = 15;
            button7.Text = "Resize";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(103, 9);
            label7.Name = "label7";
            label7.Size = new Size(33, 16);
            label7.TabIndex = 14;
            label7.Text = "Size";
            // 
            // imwidht
            // 
            imwidht.BorderStyle = BorderStyle.FixedSingle;
            imwidht.Font = new Font("Arial", 9.75F);
            imwidht.Location = new Point(62, 33);
            imwidht.Name = "imwidht";
            imwidht.Size = new Size(47, 22);
            imwidht.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.White;
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, canvasToolStripMenuItem, settingsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1446, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem });
            fileToolStripMenuItem.ForeColor = Color.DimGray;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(114, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click_1;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(114, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(114, 22);
            saveAsToolStripMenuItem.Text = "Save As";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // canvasToolStripMenuItem
            // 
            canvasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sizeModeToolStripMenuItem, backgroundColorToolStripMenuItem });
            canvasToolStripMenuItem.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            canvasToolStripMenuItem.ForeColor = Color.DimGray;
            canvasToolStripMenuItem.Name = "canvasToolStripMenuItem";
            canvasToolStripMenuItem.Size = new Size(61, 20);
            canvasToolStripMenuItem.Text = "Canvas";
            // 
            // sizeModeToolStripMenuItem
            // 
            sizeModeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { normalToolStripMenuItem, strectToolStripMenuItem, zoomToolStripMenuItem, centerToolStripMenuItem });
            sizeModeToolStripMenuItem.Name = "sizeModeToolStripMenuItem";
            sizeModeToolStripMenuItem.Size = new Size(140, 22);
            sizeModeToolStripMenuItem.Text = "Size Mode";
            // 
            // normalToolStripMenuItem
            // 
            normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            normalToolStripMenuItem.Size = new Size(115, 22);
            normalToolStripMenuItem.Text = "Normal";
            normalToolStripMenuItem.Click += normalToolStripMenuItem_Click;
            // 
            // strectToolStripMenuItem
            // 
            strectToolStripMenuItem.Name = "strectToolStripMenuItem";
            strectToolStripMenuItem.Size = new Size(115, 22);
            strectToolStripMenuItem.Text = "Strecth";
            strectToolStripMenuItem.Click += strectToolStripMenuItem_Click;
            // 
            // zoomToolStripMenuItem
            // 
            zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            zoomToolStripMenuItem.Size = new Size(115, 22);
            zoomToolStripMenuItem.Text = "Zoom";
            zoomToolStripMenuItem.Click += zoomToolStripMenuItem_Click_1;
            // 
            // centerToolStripMenuItem
            // 
            centerToolStripMenuItem.Name = "centerToolStripMenuItem";
            centerToolStripMenuItem.Size = new Size(115, 22);
            centerToolStripMenuItem.Text = "Center";
            centerToolStripMenuItem.Click += centerToolStripMenuItem_Click;
            // 
            // backgroundColorToolStripMenuItem
            // 
            backgroundColorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { colorToolStripMenuItem });
            backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            backgroundColorToolStripMenuItem.Size = new Size(140, 22);
            backgroundColorToolStripMenuItem.Text = "Background";
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(104, 22);
            colorToolStripMenuItem.Text = "Color";
            colorToolStripMenuItem.Click += colorToolStripMenuItem_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { visualSettingsToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(61, 20);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // visualSettingsToolStripMenuItem
            // 
            visualSettingsToolStripMenuItem.Name = "visualSettingsToolStripMenuItem";
            visualSettingsToolStripMenuItem.Size = new Size(150, 22);
            visualSettingsToolStripMenuItem.Text = "Visual Settings";
            visualSettingsToolStripMenuItem.Click += visualSettingsToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(taskinf);
            panel2.Controls.Add(info);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(34, 578);
            panel2.Name = "panel2";
            panel2.Size = new Size(1164, 22);
            panel2.TabIndex = 3;
            // 
            // taskinf
            // 
            taskinf.AutoSize = true;
            taskinf.Dock = DockStyle.Right;
            taskinf.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            taskinf.ForeColor = Color.Black;
            taskinf.Location = new Point(1071, 0);
            taskinf.Name = "taskinf";
            taskinf.Size = new Size(93, 15);
            taskinf.TabIndex = 24;
            taskinf.Text = "Rendering %60";
            taskinf.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // info
            // 
            info.AutoSize = true;
            info.Dock = DockStyle.Left;
            info.ForeColor = Color.Black;
            info.Location = new Point(0, 0);
            info.Name = "info";
            info.Size = new Size(91, 15);
            info.TabIndex = 0;
            info.Text = "Curson Position";
            // 
            // Remaning
            // 
            Remaning.AutoSize = true;
            Remaning.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Remaning.ForeColor = Color.Black;
            Remaning.Location = new Point(3, 8);
            Remaning.Name = "Remaning";
            Remaning.Size = new Size(226, 16);
            Remaning.TabIndex = 1;
            Remaning.Text = "Resizing & Rendering For Saving.. %60";
            Remaning.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RenderView
            // 
            RenderView.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RenderView.AutoSize = true;
            RenderView.BackColor = Color.WhiteSmoke;
            RenderView.Controls.Add(Remaning);
            RenderView.Controls.Add(button6);
            RenderView.Location = new Point(455, 495);
            RenderView.Name = "RenderView";
            RenderView.Size = new Size(360, 32);
            RenderView.TabIndex = 5;
            RenderView.Visible = false;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button6.Font = new Font("Segoe UI", 8.25F);
            button6.Location = new Point(283, 4);
            button6.Name = "button6";
            button6.Size = new Size(74, 24);
            button6.TabIndex = 23;
            button6.Text = "Cancel ";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Editor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1446, 600);
            Controls.Add(RenderView);
            Controls.Add(panel2);
            Controls.Add(Options);
            Controls.Add(panel1);
            Controls.Add(Canvas);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Editor";
            Text = "Simple Edit : Untitled";
            FormClosing += Form1_FormClosing;
            Shown += Editor_Shown;
            ((System.ComponentModel.ISupportInitialize)Canvas).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            Options.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BrightnessBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)gamma_Track).EndInit();
            ((System.ComponentModel.ISupportInitialize)Saturation_t).EndInit();
            ((System.ComponentModel.ISupportInitialize)B_Track).EndInit();
            ((System.ComponentModel.ISupportInitialize)G_Track).EndInit();
            ((System.ComponentModel.ISupportInitialize)R_Track).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            RenderView.ResumeLayout(false);
            RenderView.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Canvas;
        private Panel panel1;
        private TabControl Options;
        private TabPage tabPage1;
        private Label label1;
        private TrackBar R_Track;
        private Label label3;
        private Label label6;
        private TrackBar B_Track;
        private Label label5;
        private TrackBar G_Track;
        private Label label4;
        private TrackBar Saturation_t;
        private Button button4;
        private Button UndoSaturation;
        private Button button5;
        private TrackBar gamma_Track;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem canvasToolStripMenuItem;
        private ToolStripMenuItem sizeModeToolStripMenuItem;
        private ToolStripMenuItem normalToolStripMenuItem;
        private ToolStripMenuItem strectToolStripMenuItem;
        private ToolStripMenuItem zoomToolStripMenuItem;
        private ToolStripMenuItem centerToolStripMenuItem;
        private ToolStripMenuItem backgroundColorToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private TabPage tabPage2;
        private Label ImWid;
        private Button button7;
        private Label label7;
        private TextBox imwidht;
        private Label ImHei;
        private TextBox imheight;
        private Panel panel2;
        private Label info;
        private CheckBox MirrorEffect;
        private Label label12;
        private CheckBox verticalflip;
        private Button button1;
        private Button button2;
        private TrackBar BrightnessBar;
        private Label label8;
        private CheckBox BlackOnly;
        private CheckBox Invert;
        private Label Remaning;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem visualSettingsToolStripMenuItem;
        private Panel RenderView;
        private Button button6;
        private CheckBox checkBox1;
        private Panel panel3;
        private Button button3;
        private Label taskinf;
    }
}
