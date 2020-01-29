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
      string palavraSorteadaB;
      string premioSorteado;
      string localPasta;
      string tema;

      char[] palavraQuebradaA;
      char[] palavraQuebradaB;
      string[] tempPalavraA;
      string[] tempPalavraB;

      int X;
      int Y;
      int qtdLetras = 0;
      
      int qtdErros;
      int qtdAcertos;
      int premiacao;
      int placar;
      int rodadaAtual;
      int segundo;

      bool primeiraPalavra = true;
      bool encontrou = false;
      bool interromperSom = false;

      const int limitErros = 3;
      const int limitRodada = 5;

      Button currentButton;

      //=================== MONTAGEM DO FORMULARIO ===============================================
      public frmJogo()
      {
         InitializeComponent();

         localPasta = Application.StartupPath + @"\..\..\..\Arquivos\Sons\";
         playSimpleSound("abertura.wav");
         pcbErro1.BackgroundImage = Image.FromFile(Application.StartupPath + @"\..\..\..\Arquivos\errado.disable.png");
         pcbErro2.BackgroundImage = Image.FromFile(Application.StartupPath + @"\..\..\..\Arquivos\errado.disable.png");
         pcbErro3.BackgroundImage = Image.FromFile(Application.StartupPath + @"\..\..\..\Arquivos\errado.disable.png");
      }

      //======================== MÉTODOS =========================================================
      private void playSimpleSound(string arquivo)
      {
         SoundPlayer simpleSound = new SoundPlayer(localPasta + arquivo);
         if (interromperSom)
         {
            simpleSound.Stop();
            interromperSom = false;
         }
         else
         {
            simpleSound.Play();
         }
      }
      //******************************************************************************************
      void Sorteador()
      {
         string[] temas = { "informatica", "animal", "objeto" };

         Random randomTemas = new Random();
         tema = temas[randomTemas.Next(0, temas.Length)];

         Random sorteio = new Random();

         switch (tema)
         {
            case "informatica":
               string[] informatica = { "internet", "gabinete", "processador", "mouse", "teclado", "monitor", "memoria", "roteador", "navegador", "cabo", "alicate", "conector" };

               palavraSorteadaA = informatica[sorteio.Next(0, informatica.Length)];

               palavraQuebradaA = palavraSorteadaA.ToCharArray();

               palavraSorteadaB = informatica[sorteio.Next(0, informatica.Length)];

               palavraQuebradaB = palavraSorteadaB.ToCharArray();

               while (palavraSorteadaB == palavraSorteadaA)
               {
                  palavraSorteadaB = informatica[sorteio.Next(0, informatica.Length)];

                  palavraQuebradaB = palavraSorteadaB.ToCharArray();
               }

               tempPalavraA = new string[palavraQuebradaA.Length];
               tempPalavraB = new string[palavraQuebradaA.Length];

               break;

            case "animal":
               string[] animal = { "tatu", "iguana", "dromedario", "rato", "camaleao", "jararaca", "baiacu", "sapo", "aranha", "lagarto", "zebra", "hiena" };

               palavraSorteadaA = animal[sorteio.Next(0, animal.Length)];

               palavraQuebradaA = palavraSorteadaA.ToCharArray();

               palavraSorteadaB = animal[sorteio.Next(0, animal.Length)];

               palavraQuebradaB = palavraSorteadaB.ToCharArray();

               while (palavraSorteadaB == palavraSorteadaA)
               {
                  palavraSorteadaB = animal[sorteio.Next(0, animal.Length)];

                  palavraQuebradaB = palavraSorteadaB.ToCharArray();
               }

               tempPalavraA = new string[palavraQuebradaA.Length];
               tempPalavraB = new string[palavraQuebradaA.Length];
               break;

            case "objeto":
               string[] objeto = { "caixao", "marcapasso", "apagador", "chave", "tapete", "quadro", "fogao", "mesa", "ventilador", "panela", "oculos", "chuveiro" };

               palavraSorteadaA = objeto[sorteio.Next(0, objeto.Length)];

               palavraQuebradaA = palavraSorteadaA.ToCharArray();

               palavraSorteadaB = objeto[sorteio.Next(0, objeto.Length)];

               palavraQuebradaB = palavraSorteadaB.ToCharArray();

               while (palavraSorteadaB == palavraSorteadaA)
               {
                  palavraSorteadaB = objeto[sorteio.Next(0, objeto.Length)];

                  palavraQuebradaB = palavraSorteadaB.ToCharArray();
               }

               tempPalavraA = new string[palavraQuebradaA.Length];
               tempPalavraB = new string[palavraQuebradaA.Length];
               break;
         }

         X = 0;
         Y = 0;

         for (int i = 0; i < palavraSorteadaA.Length; i++)
         {
            pnlPainelLetrasA.GetChildAtPoint(new Point(X, Y)).BackColor = Color.White;
            X += 46;
         }
         
         X = 0;
         Y = 0;

         for (int i = 0; i < palavraSorteadaB.Length; i++)
         {
            pnlPainelLetrasB.GetChildAtPoint(new Point(X, Y)).BackColor = Color.White;
            X += 46;
         }

         primeiraPalavra = false;
         lblDica.Text = tema;
      }
      //******************************************************************************************
      void Roleta()
      {
         string[] premios = { "1000", "900", "800", "700", "600", "500", "950", "850", "750", "650", "550", "900", "800", "700", "600", "500", "950", "850", "750", "650", "550", "PERDEU TUDO!", "PASSOU A VEZ!" };

         Random randomPremios = new Random();
         premioSorteado = premios[randomPremios.Next(0, premios.Length)];

         if (premioSorteado == "PERDEU TUDO!")
         {
            lblValorSorteado.Text = premioSorteado;
            lblPlacar.Text = "0";
         }
         else if (premioSorteado == "PASSOU A VEZ!")
         {
            lblValorSorteado.Text = premioSorteado;
            qtdErros++;
            ValidarErros();

            if (qtdErros == limitErros)
            {
               var form = new frmPerdedor(palavraSorteadaA,palavraSorteadaB);
               form.ShowDialog();
            }
         }
         else
         {
            lblValorSorteado.Text = "R$ " + premioSorteado;
            pnlRoleta.Enabled = false;
            pnlTeclado.Enabled = true;
            pnlSeta.Visible = false;
         }
      }
      //******************************************************************************************
      void VerificarLetra(char letra, object btnSender)
      {
         X = 0;
         Y = 0;

         encontrou = false;
         qtdAcertos = 0;

         for (int i = 0; i < palavraSorteadaA.Length; i++)
         {
            if (palavraQuebradaA[i] == letra)
            {
               pnlPainelLetrasA.GetChildAtPoint(new Point(X, Y)).Text = letra.ToString().ToUpper();
               X += 46;
               encontrou = true;
               tempPalavraA[i] = palavraQuebradaA[i].ToString();
               qtdLetras++;
               qtdAcertos++;
            }
            else
            {
               X += 46;
            }
         }

         X = 0;
         Y = 0;

         for (int i = 0; i < palavraSorteadaB.Length; i++)
         {
            if (palavraQuebradaB[i] == letra)
            {
               pnlPainelLetrasB.GetChildAtPoint(new Point(X, Y)).Text = letra.ToString().ToUpper();
               X += 46;
               encontrou = true;
               tempPalavraB[i] = palavraQuebradaB[i].ToString();
               qtdLetras++;
               qtdAcertos++;
            }
            else
            {
               X += 46;
            }
         }
         botaoAtivo(btnSender);
         ValidarRodada();
         pnlRoleta.Enabled = true;
         pnlTeclado.Enabled = false;
         pnlSeta.Visible = true;
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
         qtdErros = 0;
         qtdLetras = 0;
         pnlRoleta.Enabled = true;

         pcbErro1.BackgroundImage = Image.FromFile(Application.StartupPath + @"\..\..\..\Arquivos\errado.disable.png");
         pcbErro2.BackgroundImage = Image.FromFile(Application.StartupPath + @"\..\..\..\Arquivos\errado.disable.png");
         pcbErro3.BackgroundImage = Image.FromFile(Application.StartupPath + @"\..\..\..\Arquivos\errado.disable.png");
      }
      //******************************************************************************************
      void ResetarTeclado()
      {
         pnlTeclado.Enabled = true;
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

                  premiacao = (qtdAcertos * Convert.ToInt32(lblValorSorteado.Text.Substring(3)));

                  placar = Convert.ToInt32(lblPlacar.Text) + premiacao;

                  lblPlacar.Text = placar.ToString();

                  playSimpleSound("acertou letra.wav");
               }
               else
               {
                  currentButton.BackColor = Color.Red;
                  qtdErros++;
                  playSimpleSound("errou letra.wav");
                  ValidarErros();
               }
            }
         }
      }
      //******************************************************************************************
      void ValidarRodada()
      {
         if (qtdLetras == (palavraSorteadaA.Length + palavraSorteadaB.Length))
         {
            if (rodadaAtual == limitRodada)
            {
               var form = new frmVencedor(lblPlacar.Text);
               form.ShowDialog();
            }
            else
            {
               NovoJogo();
               lblRodada.Text = (Convert.ToInt32(lblRodada.Text) + 1).ToString();
               rodadaAtual = Convert.ToInt32(lblRodada.Text);
            }
         }
         if (qtdErros == limitErros)
         {
            var form = new frmPerdedor(palavraSorteadaA,palavraSorteadaB);
            form.ShowDialog();
         }
      }
      //******************************************************************************************
      void ValidarErros()
      {
         switch (qtdErros)
         {
            case 1:
               pcbErro1.BackgroundImage = Image.FromFile(Application.StartupPath + @"\..\..\..\Arquivos\errado.png");
               break;
            case 2:
               pcbErro2.BackgroundImage = Image.FromFile(Application.StartupPath + @"\..\..\..\Arquivos\errado.png");
               break;
            case 3:
               pcbErro3.BackgroundImage = Image.FromFile(Application.StartupPath + @"\..\..\..\Arquivos\errado.png");
               break;
         }
      }
      //******************************************************************************************
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
         pnlRoleta.Enabled = true;
         pnlSeta.Visible = true;
      }
      //========================= CONTROLES ======================================================
      private void btnNovoJogo_Click(object sender, EventArgs e)
      {
         NovoJogo();
         btnNovoJogo.Enabled = false;
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
      private void btnGirar_Click(object sender, EventArgs e)
      {
         interromperSom = true;
         playSimpleSound("abertura.wav");

         pcbRoleta.Image = Image.FromFile(Application.StartupPath + @"\..\..\..\Arquivos\roleta.gif");

         playSimpleSound("roleta girando.wav");

         segundo = 8;
         timer1.Enabled = true;
      }
      //******************************************************************************************
      private void timer1_Tick(object sender, EventArgs e)
      {
         lblValorSorteado.Text = "Girando...";
         segundo--;
         if (segundo == 0)
         {
            timer1.Enabled = false;
            Roleta();
            pcbRoleta.Image = null;
         }
      }
   }
}
