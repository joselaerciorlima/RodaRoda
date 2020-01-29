using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenacRodaRoda
{
   public partial class frmPerdedor : Form
   {
      string localPasta;

      public frmPerdedor(string palavraA, string palavraB)
      {
         InitializeComponent();
         lblPalavra.Text = palavraA.ToUpper();
         lblPalavra2.Text = palavraB.ToUpper();
         localPasta = Application.StartupPath + @"\..\..\..\Arquivos\Sons\";
         playSimpleSound("perdeu.wav");
      }
      private void playSimpleSound(string arquivo)
      {
         SoundPlayer simpleSound = new SoundPlayer(localPasta + arquivo);
         simpleSound.Play();
      }

      private void btnSair_Click(object sender, EventArgs e)
      {
         Application.Exit();
      }

   }
}
