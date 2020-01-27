namespace SenacRodaRoda
{
   partial class Form4
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
         this.panel = new System.Windows.Forms.Panel();
         this.pnlPainelLetrasA = new System.Windows.Forms.Panel();
         this.pnlPainelLetrasB = new System.Windows.Forms.Panel();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.panel.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // panel
         // 
         this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(173)))), ((int)(((byte)(191)))));
         this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.panel.Controls.Add(this.pnlPainelLetrasA);
         this.panel.Controls.Add(this.pnlPainelLetrasB);
         this.panel.Controls.Add(this.pictureBox1);
         this.panel.Cursor = System.Windows.Forms.Cursors.Arrow;
         this.panel.Location = new System.Drawing.Point(12, 12);
         this.panel.Name = "panel";
         this.panel.Size = new System.Drawing.Size(840, 417);
         this.panel.TabIndex = 6;
         // 
         // pnlPainelLetrasA
         // 
         this.pnlPainelLetrasA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(173)))), ((int)(((byte)(191)))));
         this.pnlPainelLetrasA.Location = new System.Drawing.Point(98, 110);
         this.pnlPainelLetrasA.Name = "pnlPainelLetrasA";
         this.pnlPainelLetrasA.Size = new System.Drawing.Size(507, 60);
         this.pnlPainelLetrasA.TabIndex = 2;
         // 
         // pnlPainelLetrasB
         // 
         this.pnlPainelLetrasB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(173)))), ((int)(((byte)(191)))));
         this.pnlPainelLetrasB.Location = new System.Drawing.Point(98, 171);
         this.pnlPainelLetrasB.Name = "pnlPainelLetrasB";
         this.pnlPainelLetrasB.Size = new System.Drawing.Size(507, 60);
         this.pnlPainelLetrasB.TabIndex = 3;
         // 
         // pictureBox1
         // 
         this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
         this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
         this.pictureBox1.Location = new System.Drawing.Point(0, 0);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(705, 349);
         this.pictureBox1.TabIndex = 4;
         this.pictureBox1.TabStop = false;
         // 
         // Form4
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(938, 521);
         this.Controls.Add(this.panel);
         this.Name = "Form4";
         this.Text = "Form4";
         this.panel.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);

      }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel pnlPainelLetrasA;
        private System.Windows.Forms.Panel pnlPainelLetrasB;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}