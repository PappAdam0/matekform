namespace matekform
{
    partial class frmFo
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
            this.lbEred = new System.Windows.Forms.ListBox();
            this.btnHany = new System.Windows.Forms.Button();
            this.btnAtlag = new System.Windows.Forms.Button();
            this.btnHanyszor = new System.Windows.Forms.Button();
            this.btnVane = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnKilepes = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.StatusStrip();
            this.SuspendLayout();
            // 
            // lbEred
            // 
            this.lbEred.FormattingEnabled = true;
            this.lbEred.ItemHeight = 20;
            this.lbEred.Location = new System.Drawing.Point(145, 12);
            this.lbEred.Name = "lbEred";
            this.lbEred.Size = new System.Drawing.Size(286, 344);
            this.lbEred.TabIndex = 0;
            // 
            // btnHany
            // 
            this.btnHany.Location = new System.Drawing.Point(26, 63);
            this.btnHany.Name = "btnHany";
            this.btnHany.Size = new System.Drawing.Size(85, 33);
            this.btnHany.TabIndex = 2;
            this.btnHany.Text = "Hányadik";
            this.btnHany.UseVisualStyleBackColor = true;
            this.btnHany.Click += new System.EventHandler(this.btnHany_Click);
            // 
            // btnAtlag
            // 
            this.btnAtlag.Location = new System.Drawing.Point(26, 24);
            this.btnAtlag.Name = "btnAtlag";
            this.btnAtlag.Size = new System.Drawing.Size(85, 33);
            this.btnAtlag.TabIndex = 3;
            this.btnAtlag.Text = "Átlag";
            this.btnAtlag.UseVisualStyleBackColor = true;
            this.btnAtlag.Click += new System.EventHandler(this.btnAtlag_Click);
            // 
            // btnHanyszor
            // 
            this.btnHanyszor.Location = new System.Drawing.Point(26, 102);
            this.btnHanyszor.Name = "btnHanyszor";
            this.btnHanyszor.Size = new System.Drawing.Size(85, 33);
            this.btnHanyszor.TabIndex = 4;
            this.btnHanyszor.Text = "Hányszor";
            this.btnHanyszor.UseVisualStyleBackColor = true;
            this.btnHanyszor.Click += new System.EventHandler(this.btnHanyszor_Click);
            // 
            // btnVane
            // 
            this.btnVane.Location = new System.Drawing.Point(26, 141);
            this.btnVane.Name = "btnVane";
            this.btnVane.Size = new System.Drawing.Size(85, 33);
            this.btnVane.TabIndex = 5;
            this.btnVane.Text = "Van-e";
            this.btnVane.UseVisualStyleBackColor = true;
            this.btnVane.Click += new System.EventHandler(this.btnVane_Click);
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(26, 180);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(85, 33);
            this.btnMax.TabIndex = 6;
            this.btnMax.Text = "Maximum";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(26, 219);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(85, 33);
            this.btnMin.TabIndex = 7;
            this.btnMin.Text = "Minimum";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnKilepes
            // 
            this.btnKilepes.Location = new System.Drawing.Point(26, 316);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(85, 33);
            this.btnKilepes.TabIndex = 8;
            this.btnKilepes.Text = "Kilépés";
            this.btnKilepes.UseVisualStyleBackColor = true;
            this.btnKilepes.Click += new System.EventHandler(this.btnKilepes_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.SystemColors.Control;
            this.lblStatus.Location = new System.Drawing.Point(0, 339);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(443, 22);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "statusStrip1";
            // 
            // frmFo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 361);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnKilepes);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnVane);
            this.Controls.Add(this.btnHanyszor);
            this.Controls.Add(this.btnAtlag);
            this.Controls.Add(this.btnHany);
            this.Controls.Add(this.lbEred);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmFo";
            this.Text = "Matek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbEred;
        private System.Windows.Forms.Button btnHany;
        private System.Windows.Forms.Button btnAtlag;
        private System.Windows.Forms.Button btnHanyszor;
        private System.Windows.Forms.Button btnVane;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnKilepes;
        private System.Windows.Forms.StatusStrip lblStatus;
    }
}

