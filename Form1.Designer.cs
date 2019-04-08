namespace ZBoard
{
    partial class ZBoard
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.editplay1 = new System.Windows.Forms.Button();
            this.editplay2 = new System.Windows.Forms.Button();
            this.edit_play = new System.Windows.Forms.Button();
            this.play2 = new System.Windows.Forms.Button();
            this.play1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editplay1
            // 
            this.editplay1.Location = new System.Drawing.Point(290, 119);
            this.editplay1.Name = "editplay1";
            this.editplay1.Size = new System.Drawing.Size(100, 23);
            this.editplay1.TabIndex = 3;
            this.editplay1.Text = "edit";
            this.editplay1.UseVisualStyleBackColor = true;
            this.editplay1.Visible = false;
            this.editplay1.Click += new System.EventHandler(this.editplay1_Click);
            // 
            // editplay2
            // 
            this.editplay2.Location = new System.Drawing.Point(396, 119);
            this.editplay2.Name = "editplay2";
            this.editplay2.Size = new System.Drawing.Size(100, 23);
            this.editplay2.TabIndex = 4;
            this.editplay2.Text = "edit";
            this.editplay2.UseVisualStyleBackColor = true;
            this.editplay2.Visible = false;
            this.editplay2.Click += new System.EventHandler(this.editplay2_Click);
            // 
            // edit_play
            // 
            this.edit_play.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.edit_play.Location = new System.Drawing.Point(677, 78);
            this.edit_play.Name = "edit_play";
            this.edit_play.Size = new System.Drawing.Size(75, 23);
            this.edit_play.TabIndex = 5;
            this.edit_play.Text = "EDIT";
            this.edit_play.UseVisualStyleBackColor = true;
            this.edit_play.Click += new System.EventHandler(this.edit_play_Click);
            // 
            // play2
            // 
            this.play2.BackgroundImage = global::ZBoard.Properties.Resources.tmp_img;
            this.play2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.play2.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.play2.Image = global::ZBoard.Properties.Resources.vutton_nobg2;
            this.play2.Location = new System.Drawing.Point(396, 119);
            this.play2.Name = "play2";
            this.play2.Size = new System.Drawing.Size(101, 100);
            this.play2.TabIndex = 1;
            this.play2.Text = "play2";
            this.play2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.play2.UseVisualStyleBackColor = true;
            this.play2.Click += new System.EventHandler(this.play2_Click);
            // 
            // play1
            // 
            this.play1.BackgroundImage = global::ZBoard.Properties.Resources.tmp_img;
            this.play1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.play1.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.play1.Image = global::ZBoard.Properties.Resources.vutton_nobg2;
            this.play1.Location = new System.Drawing.Point(290, 119);
            this.play1.Name = "play1";
            this.play1.Size = new System.Drawing.Size(101, 100);
            this.play1.TabIndex = 0;
            this.play1.Text = "play1";
            this.play1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.play1.UseVisualStyleBackColor = true;
            this.play1.Click += new System.EventHandler(this.play1_Click);
            // 
            // ZBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(803, 486);
            this.Controls.Add(this.edit_play);
            this.Controls.Add(this.editplay2);
            this.Controls.Add(this.editplay1);
            this.Controls.Add(this.play2);
            this.Controls.Add(this.play1);
            this.Name = "ZBoard";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ZBoard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button play1;
        private System.Windows.Forms.Button play2;
        private System.Windows.Forms.Button editplay1;
        private System.Windows.Forms.Button editplay2;
        private System.Windows.Forms.Button edit_play;
    }
}

