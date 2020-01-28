using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace SenacRodaRoda
{
   public partial class frmJogo : Form
   {
      //=================== VARIAVEIS GLOBAIS ====================================================
      string palavraSorteadaA;
     
      char[] palavraQuebrada;
      string[] tempPalavraA;

      int X;
      int Y;
      int qtdLetras = 0;

      bool primeiraPalavra = true;
      bool encontrou = false;


      Button currentButton;

      //=================== MONTAGEM DO FORMULARIO ===============================================
      public frmJogo()
      {
         InitializeComponent();
      }

      //======================== MÉTODOS =========================================================
      void Sorteador()
      {
         string[] informatica = { "internet", "gabinete", "processador", "mouse", "teclado", "monitor", "memoria", "roteador", "navegador", "cabo", "alicate", "conector" };

         Random sorteio = new Random();

         palavraSorteadaA = informatica[sorteio.Next(0, informatica.Length)];

         palavraQuebrada = palavraSorteadaA.ToCharArray();

         tempPalavraA = new string[palavraQuebrada.Length];

         X = 0;
         Y = 0;

         for (int i = 0; i < palavraSorteadaA.Length; i++)
         {
            pnlPainelLetrasA.GetChildAtPoint(new Point(X, Y)).BackColor = Color.White;
            X += 46;
         }
         primeiraPalavra = false;
         lblDica.Text = palavraSorteadaA;
      }
      //******************************************************************************************
      void VerificarLetra(char letra, object btnSender)
      {
         X = 0;
         Y = 0;

         encontrou = false;

         for (int i = 0; i < palavraSorteadaA.Length; i++)
         {
            if (palavraQuebrada[i] == letra)
            {
               pnlPainelLetrasA.GetChildAtPoint(new Point(X, Y)).Text = letra.ToString().ToUpper();
               X += 46;
               encontrou = true;
               tempPalavraA[i] = palavraQuebrada[i].ToString();
               qtdLetras++;
            }
            else
            {
               X += 46;
            }
         }
         botaoAtivo(btnSender);
         ValidarRodada();
      }
      //******************************************************************************************
      void Resetar()
      {
         X = 0;
         Y = 0;

         for (int i = 0; i < palavraSorteadaA.Length; i++)
         {
            pnlPainelLetrasA.GetChildAtPoint(new Point(X, Y)).BackColor = Color.Blue;
            pnlPainelLetrasA.GetChildAtPoint(new Point(X, Y)).Text = "";

            X += 46;
         }
         ResetarTeclado();
         encontrou = false;
         currentButton = null;
         
      }
      //******************************************************************************************
      void ResetarTeclado()
      {
         foreach (Control botoes in pnlTeclado.Controls)
         {
            if (botoes.GetType() == typeof(Button))
            {
               botoes.Enabled = true;
               botoes.BackColor = Color.White;
            }
         }
      }
      //******************************************************************************************
      void botaoAtivo(object btnSender)
      {
         if (btnSender != null)
         {
            if (currentButton != (Button)btnSender)
            {
               currentButton = (Button)btnSender;
               currentButton.Enabled = false;

               if (encontrou)
               {
                  currentButton.BackColor = Color.Green;
               }
               else
               {
                  currentButton.BackColor = Color.Red;
               }
            }
         }
      }
      void ValidarRodada()
      {
         if (qtdLetras == palavraSorteadaA.Length)
         {
            var form = new Form2(lblPlacar.Text, palavraSorteadaA);
            form.ShowDialog();
         }
      }
      void NovoJogo()
      {
         if (primeiraPalavra)
         {
            Sorteador();
         }
         else
         {
            Resetar();
            Sorteador();
         }
      }
      //========================= CONTROLES ======================================================
      private void btnNovoJogo_Click(object sender, EventArgs e)
      {
         NovoJogo();
      }
      //******************************************************************************************
      private void btnA_Click(object sender, EventArgs e)
      {
         VerificarLetra('a', sender);
      }
      //******************************************************************************************
      private void btnB_Click(object sender, EventArgs e)
      {
         VerificarLetra('b', sender);
      }
      //******************************************************************************************
      private void btnC_Click(object sender, EventArgs e)
      {
         VerificarLetra('c', sender);
      }
      //******************************************************************************************
      private void btnD_Click(object sender, EventArgs e)
      {
         VerificarLetra('d', sender);
      }
      //******************************************************************************************
      private void btnE_Click(object sender, EventArgs e)
      {
         VerificarLetra('e', sender);
      }
      //******************************************************************************************
      private void btnF_Click(object sender, EventArgs e)
      {
         VerificarLetra('f', sender);
      }
      //******************************************************************************************
      private void btnG_Click(object sender, EventArgs e)
      {
         VerificarLetra('g', sender);
      }
      //******************************************************************************************
      private void btnH_Click(object sender, EventArgs e)
      {
         VerificarLetra('h', sender);
      }
      //******************************************************************************************
      private void btnI_Click(object sender, EventArgs e)
      {
         VerificarLetra('i', sender);
      }
      //******************************************************************************************
      private void btnJ_Click(object sender, EventArgs e)
      {
         VerificarLetra('j', sender);
      }
      //******************************************************************************************
      private void btnK_Click(object sender, EventArgs e)
      {
         VerificarLetra('k', sender);
      }
      //******************************************************************************************
      private void btnL_Click(object sender, EventArgs e)
      {
         VerificarLetra('l', sender);
      }
      //******************************************************************************************
      private void btnM_Click(object sender, EventArgs e)
      {
         VerificarLetra('m', sender);
      }
      //******************************************************************************************
      private void btnN_Click(object sender, EventArgs e)
      {
         VerificarLetra('n', sender);
      }
      //******************************************************************************************
      private void btnO_Click(object sender, EventArgs e)
      {
         VerificarLetra('o', sender);
      }
      //******************************************************************************************
      private void btnP_Click(object sender, EventArgs e)
      {
         VerificarLetra('p', sender);
      }
      //******************************************************************************************
      private void btnQ_Click(object sender, EventArgs e)
      {
         VerificarLetra('q', sender);
      }
      //******************************************************************************************
      private void btnR_Click(object sender, EventArgs e)
      {
         VerificarLetra('r', sender);
      }
      //******************************************************************************************
      private void btnS_Click(object sender, EventArgs e)
      {
         VerificarLetra('s', sender);
      }
      //******************************************************************************************
      private void btnT_Click(object sender, EventArgs e)
      {
         VerificarLetra('t', sender);
      }
      //******************************************************************************************
      private void btnU_Click(object sender, EventArgs e)
      {
         VerificarLetra('u', sender);
      }
      //******************************************************************************************
      private void btnV_Click(object sender, EventArgs e)
      {
         VerificarLetra('v', sender);
      }
      //******************************************************************************************
      private void btnW_Click(object sender, EventArgs e)
      {
         VerificarLetra('w', sender);
      }
      //******************************************************************************************
      private void btnX_Click(object sender, EventArgs e)
      {
         VerificarLetra('x', sender);
      }
      //******************************************************************************************
      private void btnY_Click(object sender, EventArgs e)
      {
         VerificarLetra('y', sender);
      }
      //******************************************************************************************
      private void btnZ_Click(object sender, EventArgs e)
      {
         VerificarLetra('z', sender);
      }
      //******************************************************************************************
   }
}
