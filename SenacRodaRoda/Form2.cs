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
   public partial class Form2 : Form
   {
      string localPasta;
      public Form2(string placar, string palavra)
      {
         InitializeComponent();
         
         lblPlacar.Text = placar;
         lblPalavra.Text = palavra.ToUpper();
         localPasta = Application.StartupPath + @"\..\..\..\Arquivos\Sons\";
         playSimpleSound("aplausos.wav");

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
