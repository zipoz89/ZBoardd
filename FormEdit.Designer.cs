namespace ZBoard
{
    partial class FormEdit
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
            this.save = new System.Windows.Forms.Button();
            this.discard = new System.Windows.Forms.Button();
            this.openImg = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openWav = new System.Windows.Forms.Button();
            this.Jpgpath = new System.Windows.Forms.TextBox();
            this.wavPath = new System.Windows.Forms.TextBox();
            this.playTest = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trackWave = new System.Windows.Forms.TrackBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackWave)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(97, 424);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 0;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // discard
            // 
            this.discard.Location = new System.Drawing.Point(178, 424);
            this.discard.Name = "discard";
            this.discard.Size = new System.Drawing.Size(75, 23);
            this.discard.TabIndex = 1;
            this.discard.Text = "Discard";
            this.discard.UseVisualStyleBackColor = true;
            this.discard.Click += new System.EventHandler(this.discard_Click);
            // 
            // openImg
            // 
            this.openImg.Location = new System.Drawing.Point(113, 22);
            this.openImg.Name = "openImg";
            this.openImg.Size = new System.Drawing.Size(101, 21);
            this.openImg.TabIndex = 4;
            this.openImg.Text = "Select Image";
            this.openImg.UseVisualStyleBackColor = true;
            this.openImg.Click += new System.EventHandler(this.openImg_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openWav
            // 
            this.openWav.Location = new System.Drawing.Point(7, 22);
            this.openWav.Name = "openWav";
            this.openWav.Size = new System.Drawing.Size(101, 21);
            this.openWav.TabIndex = 5;
            this.openWav.Text = "Select wav file";
            this.openWav.UseVisualStyleBackColor = true;
            this.openWav.Click += new System.EventHandler(this.openWav_Click);
            // 
            // Jpgpath
            // 
            this.Jpgpath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(35)))), ((int)(((byte)(83)))));
            this.Jpgpath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Jpgpath.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jpgpath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.Jpgpath.Location = new System.Drawing.Point(6, 128);
            this.Jpgpath.Name = "Jpgpath";
            this.Jpgpath.ReadOnly = true;
            this.Jpgpath.Size = new System.Drawing.Size(220, 16);
            this.Jpgpath.TabIndex = 6;
            this.Jpgpath.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // wavPath
            // 
            this.wavPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(35)))), ((int)(((byte)(83)))));
            this.wavPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wavPath.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wavPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.wavPath.Location = new System.Drawing.Point(7, 78);
            this.wavPath.Name = "wavPath";
            this.wavPath.ReadOnly = true;
            this.wavPath.Size = new System.Drawing.Size(220, 16);
            this.wavPath.TabIndex = 7;
            this.wavPath.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // playTest
            // 
            this.playTest.Enabled = false;
            this.playTest.Location = new System.Drawing.Point(114, 22);
            this.playTest.Name = "playTest";
            this.playTest.Size = new System.Drawing.Size(113, 21);
            this.playTest.TabIndex = 8;
            this.playTest.Text = "Play";
            this.playTest.UseVisualStyleBackColor = true;
            this.playTest.Click += new System.EventHandler(this.playTest_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ZBoard.Properties.Resources.tmp_img;
            this.pictureBox1.Image = global::ZBoard.Properties.Resources.vutton_nobg2;
            this.pictureBox1.Location = new System.Drawing.Point(6, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 100);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // trackWave
            // 
            this.trackWave.Location = new System.Drawing.Point(7, 49);
            this.trackWave.Maximum = 100;
            this.trackWave.Minimum = 1;
            this.trackWave.Name = "trackWave";
            this.trackWave.Size = new System.Drawing.Size(219, 45);
            this.trackWave.TabIndex = 9;
            this.trackWave.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackWave.Value = 1;
            this.trackWave.Scroll += new System.EventHandler(this.trackWave_Scroll);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(35)))), ((int)(((byte)(83)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.textBox1.Location = new System.Drawing.Point(15, 43);
            this.textBox1.MaxLength = 16;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 23);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.playTest);
            this.groupBox1.Controls.Add(this.wavPath);
            this.groupBox1.Controls.Add(this.openWav);
            this.groupBox1.Controls.Add(this.trackWave);
            this.groupBox1.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(35)))), ((int)(((byte)(83)))));
            this.groupBox1.Location = new System.Drawing.Point(4, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 109);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Jpgpath);
            this.groupBox2.Controls.Add(this.openImg);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(35)))), ((int)(((byte)(83)))));
            this.groupBox2.Location = new System.Drawing.Point(4, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 155);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(35)))), ((int)(((byte)(83)))));
            this.groupBox3.Location = new System.Drawing.Point(4, 315);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(249, 95);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(35)))), ((int)(((byte)(83)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 33);
            this.panel1.TabIndex = 16;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(265, 459);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.discard);
            this.Controls.Add(this.save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEdit";
            this.ShowIcon = false;
            this.Text = "EDIT";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackWave)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button discard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button openImg;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button openWav;
        private System.Windows.Forms.TextBox Jpgpath;
        private System.Windows.Forms.TextBox wavPath;
        private System.Windows.Forms.Button playTest;
        private System.Windows.Forms.TrackBar trackWave;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
    }
}