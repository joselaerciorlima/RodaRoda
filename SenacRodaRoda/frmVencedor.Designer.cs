namespace SenacRodaRoda
{
   partial class frmVencedor
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVencedor));
         this.panel1 = new System.Windows.Forms.Panel();
         this.panel2 = new System.Windows.Forms.Panel();
         this.lblPlacar = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.lblGirar = new System.Windows.Forms.Label();
         this.btnSair = new System.Windows.Forms.Button();
         this.pcbGif = new System.Windows.Forms.PictureBox();
         this.panel1.SuspendLayout();
         this.panel2.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pcbGif)).BeginInit();
         this.SuspendLayout();
         // 
         // panel1
         // 
         this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.panel1.Controls.Add(this.panel2);
         this.panel1.Controls.Add(this.lblGirar);
         this.panel1.Controls.Add(this.btnSair);
         this.panel1.Controls.Add(this.pcbGif);
         this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
         this.panel1.Location = new System.Drawing.Point(12, 12);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(620, 481);
         this.panel1.TabIndex = 0;
         // 
         // panel2
         // 
         this.panel2.BackColor = System.Drawing.Color.Yellow;
         this.panel2.Controls.Add(this.lblPlacar);
         this.panel2.Controls.Add(this.label3);
         this.panel2.Location = new System.Drawing.Point(351, 153);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(253, 119);
         this.panel2.TabIndex = 23;
         // 
         // lblPlacar
         // 
         this.lblPlacar.BackColor = System.Drawing.Color.Yellow;
         this.lblPlacar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.lblPlacar.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblPlacar.ForeColor = System.Drawing.Color.Red;
         this.lblPlacar.Location = new System.Drawing.Point(14, 57);
         this.lblPlacar.Name = "lblPlacar";
         this.lblPlacar.Size = new System.Drawing.Size(224, 49);
         this.lblPlacar.TabIndex = 1;
         this.lblPlacar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(26, 14);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(200, 29);
         this.label3.TabIndex = 6;
         this.label3.Text = "Pontuação Final";
         // 
         // lblGirar
         // 
         this.lblGirar.AutoSize = true;
         this.lblGirar.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblGirar.ForeColor = System.Drawing.Color.Black;
         this.lblGirar.Location = new System.Drawing.Point(126, 18);
         this.lblGirar.Name = "lblGirar";
         this.lblGirar.Size = new System.Drawing.Size(366, 34);
         this.lblGirar.TabIndex = 22;
         this.lblGirar.Text = "Parabéns, você ganhou!!!";
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
         // frmVencedor
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(173)))), ((int)(((byte)(191)))));
         this.ClientSize = new System.Drawing.Size(644, 505);
         this.Controls.Add(this.panel1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "frmVencedor";
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         this.panel2.ResumeLayout(false);
         this.panel2.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pcbGif)).EndInit();
         this.ResumeLayout(false);

      }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label lblPlacar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGirar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pcbGif;
    }
}