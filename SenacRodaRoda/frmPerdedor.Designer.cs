namespace SenacRodaRoda
{
    partial class frmPerdedor
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPerdedor));
         this.panel1 = new System.Windows.Forms.Panel();
         this.lblGirar = new System.Windows.Forms.Label();
         this.btnSair = new System.Windows.Forms.Button();
         this.pcbGif = new System.Windows.Forms.PictureBox();
         this.panel3 = new System.Windows.Forms.Panel();
         this.lblPalavra = new System.Windows.Forms.Label();
         this.panel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pcbGif)).BeginInit();
         this.panel3.SuspendLayout();
         this.SuspendLayout();
         // 
         // panel1
         // 
         this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.panel1.Controls.Add(this.lblGirar);
         this.panel1.Controls.Add(this.btnSair);
         this.panel1.Controls.Add(this.pcbGif);
         this.panel1.Controls.Add(this.panel3);
         this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
         this.panel1.Location = new System.Drawing.Point(12, 12);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(620, 481);
         this.panel1.TabIndex = 1;
         // 
         // lblGirar
         // 
         this.lblGirar.AutoSize = true;
         this.lblGirar.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblGirar.ForeColor = System.Drawing.Color.Black;
         this.lblGirar.Location = new System.Drawing.Point(77, 18);
         this.lblGirar.Name = "lblGirar";
         this.lblGirar.Size = new System.Drawing.Size(470, 34);
         this.lblGirar.TabIndex = 22;
         this.lblGirar.Text = "Que pena, você errou a palavra...";
         // 
         // btnSair
         // 
         this.btnSair.BackColor = System.Drawing.Color.Red;
         this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnSair.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnSair.ForeColor = System.Drawing.Color.White;
         this.btnSair.Location = new System.Drawing.Point(351, 410);
         this.btnSair.Name = "btnSair";
         this.btnSair.Size = new System.Drawing.Size(253, 53);
         this.btnSair.TabIndex = 21;
         this.btnSair.TabStop = false;
         this.btnSair.Text = "Sair";
         this.btnSair.UseVisualStyleBackColor = false;
         this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
         // 
         // pcbGif
         // 
         this.pcbGif.BackColor = System.Drawing.Color.Transparent;
         this.pcbGif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
         this.pcbGif.Image = ((System.Drawing.Image)(resources.GetObject("pcbGif.Image")));
         this.pcbGif.Location = new System.Drawing.Point(17, 67);
         this.pcbGif.Name = "pcbGif";
         this.pcbGif.Size = new System.Drawing.Size(318, 396);
         this.pcbGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pcbGif.TabIndex = 20;
         this.pcbGif.TabStop = false;
         // 
         // panel3
         // 
         this.panel3.BackColor = System.Drawing.Color.Transparent;
         this.panel3.Controls.Add(this.lblPalavra);
         this.panel3.Location = new System.Drawing.Point(341, 184);
         this.panel3.Name = "panel3";
         this.panel3.Size = new System.Drawing.Size(263, 83);
         this.panel3.TabIndex = 24;
         // 
         // lblPalavra
         // 
         this.lblPalavra.BackColor = System.Drawing.Color.Gray;
         this.lblPalavra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.lblPalavra.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblPalavra.ForeColor = System.Drawing.Color.Black;
         this.lblPalavra.Location = new System.Drawing.Point(12, 17);
         this.lblPalavra.Name = "lblPalavra";
         this.lblPalavra.Size = new System.Drawing.Size(238, 49);
         this.lblPalavra.TabIndex = 1;
         this.lblPalavra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // frmPerdedor
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
         this.ClientSize = new System.Drawing.Size(644, 505);
         this.Controls.Add(this.panel1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "frmPerdedor";
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pcbGif)).EndInit();
         this.panel3.ResumeLayout(false);
         this.ResumeLayout(false);

        }

      #endregion

      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Label lblGirar;
      private System.Windows.Forms.Button btnSair;
      private System.Windows.Forms.PictureBox pcbGif;
      private System.Windows.Forms.Panel panel3;
      public System.Windows.Forms.Label lblPalavra;
   }
}