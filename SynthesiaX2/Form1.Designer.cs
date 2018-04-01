/* 
 * HELLO! Thank you for reading the source code!
 * This was a fun April Fool's joke for 2018 on the LyricWulf channel.
 * Here is the trailer demonstrating what it should do https://youtu.be/pikPcw3A0Ow
 * Join the Discord server for more fun http://piano.dog/discord
 * Love,
 * Lyric
 */

namespace SynthesiaX2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fileOpenButton = new System.Windows.Forms.Button();
            this.fileTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.renderButton = new System.Windows.Forms.Button();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.savePath = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.splashScreen = new System.Windows.Forms.PictureBox();
            this.renderLabel = new System.Windows.Forms.Label();
            this.etaLabel = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.color1 = new System.Windows.Forms.TextBox();
            this.color2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.seedControl = new System.Windows.Forms.TextBox();
            this.velocityControl = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splashScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // fileOpenButton
            // 
            this.fileOpenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.fileOpenButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.fileOpenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileOpenButton.ForeColor = System.Drawing.SystemColors.Control;
            this.fileOpenButton.Location = new System.Drawing.Point(295, 224);
            this.fileOpenButton.Name = "fileOpenButton";
            this.fileOpenButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fileOpenButton.Size = new System.Drawing.Size(75, 22);
            this.fileOpenButton.TabIndex = 0;
            this.fileOpenButton.Text = "Browse...";
            this.fileOpenButton.UseVisualStyleBackColor = false;
            this.fileOpenButton.Click += new System.EventHandler(this.fileOpenButton_Click);
            // 
            // fileTextBox
            // 
            this.fileTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.fileTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.fileTextBox.Location = new System.Drawing.Point(12, 225);
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.ReadOnly = true;
            this.fileTextBox.Size = new System.Drawing.Size(274, 20);
            this.fileTextBox.TabIndex = 1;
            this.fileTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(384, 179);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select MIDI file...";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // renderButton
            // 
            this.renderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.renderButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.renderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.renderButton.ForeColor = System.Drawing.SystemColors.Control;
            this.renderButton.Location = new System.Drawing.Point(295, 429);
            this.renderButton.Name = "renderButton";
            this.renderButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.renderButton.Size = new System.Drawing.Size(75, 22);
            this.renderButton.TabIndex = 5;
            this.renderButton.Text = "Render";
            this.renderButton.UseVisualStyleBackColor = false;
            this.renderButton.Click += new System.EventHandler(this.renderButton_Click);
            // 
            // progress
            // 
            this.progress.ForeColor = System.Drawing.Color.BlueViolet;
            this.progress.Location = new System.Drawing.Point(12, 413);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(358, 10);
            this.progress.Step = 5;
            this.progress.TabIndex = 7;
            // 
            // logTextBox
            // 
            this.logTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.logTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logTextBox.ForeColor = System.Drawing.SystemColors.Control;
            this.logTextBox.Location = new System.Drawing.Point(12, 308);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.Size = new System.Drawing.Size(358, 99);
            this.logTextBox.TabIndex = 8;
            // 
            // savePath
            // 
            this.savePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.savePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.savePath.ForeColor = System.Drawing.SystemColors.Window;
            this.savePath.Location = new System.Drawing.Point(12, 273);
            this.savePath.Name = "savePath";
            this.savePath.ReadOnly = true;
            this.savePath.Size = new System.Drawing.Size(274, 20);
            this.savePath.TabIndex = 9;
            this.savePath.TextChanged += new System.EventHandler(this.savePath_TextChanged);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.ForeColor = System.Drawing.SystemColors.Control;
            this.saveButton.Location = new System.Drawing.Point(295, 272);
            this.saveButton.Name = "saveButton";
            this.saveButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.saveButton.Size = new System.Drawing.Size(75, 22);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Browse...";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Select save destination...";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // splashScreen
            // 
            this.splashScreen.Image = ((System.Drawing.Image)(resources.GetObject("splashScreen.Image")));
            this.splashScreen.Location = new System.Drawing.Point(0, 0);
            this.splashScreen.Name = "splashScreen";
            this.splashScreen.Size = new System.Drawing.Size(640, 360);
            this.splashScreen.TabIndex = 12;
            this.splashScreen.TabStop = false;
            // 
            // renderLabel
            // 
            this.renderLabel.AutoSize = true;
            this.renderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.renderLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.renderLabel.Location = new System.Drawing.Point(12, 434);
            this.renderLabel.Name = "renderLabel";
            this.renderLabel.Size = new System.Drawing.Size(110, 13);
            this.renderLabel.TabIndex = 13;
            this.renderLabel.Text = "Rendering... 00:00:00";
            // 
            // etaLabel
            // 
            this.etaLabel.AutoSize = true;
            this.etaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.etaLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.etaLabel.Location = new System.Drawing.Point(149, 434);
            this.etaLabel.Name = "etaLabel";
            this.etaLabel.Size = new System.Drawing.Size(140, 13);
            this.etaLabel.TabIndex = 14;
            this.etaLabel.Text = "Estimated time left: 00:00:00";
            // 
            // color1
            // 
            this.color1.BackColor = System.Drawing.Color.LimeGreen;
            this.color1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.color1.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.color1.Location = new System.Drawing.Point(402, 97);
            this.color1.Name = "color1";
            this.color1.ReadOnly = true;
            this.color1.Size = new System.Drawing.Size(100, 60);
            this.color1.TabIndex = 15;
            this.color1.Click += new System.EventHandler(this.color1_Click);
            this.color1.GotFocus += new System.EventHandler(this.color1_Focus);
            // 
            // color2
            // 
            this.color2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.color2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.color2.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.color2.Location = new System.Drawing.Point(402, 185);
            this.color2.Name = "color2";
            this.color2.ReadOnly = true;
            this.color2.Size = new System.Drawing.Size(100, 60);
            this.color2.TabIndex = 16;
            this.color2.Click += new System.EventHandler(this.color2_Click);
            this.color2.GotFocus += new System.EventHandler(this.color2_Focus);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(506, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 37);
            this.label3.TabIndex = 17;
            this.label3.Text = "Channel 1 Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(509, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Right Hand";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(508, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Left Hand";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(506, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 37);
            this.label6.TabIndex = 19;
            this.label6.Text = "Channel 2 Color";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(398, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(228, 55);
            this.label7.TabIndex = 21;
            this.label7.Text = "// settings";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(413, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(205, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "// advanced settings";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBox1.Location = new System.Drawing.Point(419, 336);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(97, 17);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.Text = "Erase all temps";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBox2.Location = new System.Drawing.Point(419, 359);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(161, 17);
            this.checkBox2.TabIndex = 24;
            this.checkBox2.Text = "Bind all library lists seperately";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(416, 394);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Random Seed";
            // 
            // seedControl
            // 
            this.seedControl.Location = new System.Drawing.Point(494, 391);
            this.seedControl.Name = "seedControl";
            this.seedControl.Size = new System.Drawing.Size(86, 20);
            this.seedControl.TabIndex = 26;
            this.seedControl.Text = "8148";
            // 
            // velocityControl
            // 
            this.velocityControl.Location = new System.Drawing.Point(494, 423);
            this.velocityControl.Name = "velocityControl";
            this.velocityControl.Size = new System.Drawing.Size(86, 20);
            this.velocityControl.TabIndex = 28;
            this.velocityControl.Text = "auto";
            this.velocityControl.TextChanged += new System.EventHandler(this.velocityControl_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(416, 426);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Velocity Offset";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(782, 476);
            this.Controls.Add(this.splashScreen);
            this.Controls.Add(this.velocityControl);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.seedControl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.color2);
            this.Controls.Add(this.color1);
            this.Controls.Add(this.etaLabel);
            this.Controls.Add(this.renderLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.savePath);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.renderButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.fileTextBox);
            this.Controls.Add(this.fileOpenButton);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "LW Synthesia Engine X V2.4.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splashScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        bool rendering;
        bool locked;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button fileOpenButton;
        private System.Windows.Forms.TextBox fileTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button renderButton;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.TextBox savePath;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox splashScreen;
        private System.Windows.Forms.Label renderLabel;
        private System.Windows.Forms.Label etaLabel;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.TextBox color1;
        private System.Windows.Forms.TextBox color2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox seedControl;
        private System.Windows.Forms.TextBox velocityControl;
        private System.Windows.Forms.Label label10;
    }
}

