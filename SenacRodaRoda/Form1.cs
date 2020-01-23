using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace SenacRodaRoda
{
   public partial class frmJogo : Form
   {

      bool acertou = false;
      int segundo, qtdLetrasA, qtdLetrasB, qtdErros, qtdAcertos;
      string tema, palavraSorteadaA, palavraSorteadaB;
      char[] palavraQuebradaA, palavraQuebradaB;
      string[] letrasReveladasA, letrasReveladasB;
      char letraEscolhida;

      //=================== VARIAVEIS GLOBAIS ==================================================
      bool primeiraLetraA = false;
      bool primeiraLetraB = false;
      bool interromperSom = false;

      int posicaoXLabelA = 0;
      int posicaoYLabelA = 0;
      int posicaoXLabelB = 0;
      int posicaoYLabelB = 0;
      int index;

      string localPasta;


      //=================== MONTAGEM DO FORMULARIO =============================================
      public frmJogo()
      {
         InitializeComponent();

         pcbLogo.BackgroundImage = Image.FromFile(Application.StartupPath + @"\..\..\..\Arquivos\logo.png");
         localPasta = Application.StartupPath + @"\..\..\..\Arquivos\Sons\";
         playSimpleSound("abertura.wav");

      }
      //======================== MÉTODOS ==============================
      void criarLabelA(int numeroOrdem, int posicaoX, int posicaoY)
      {
         Label lblA = new Label();

         lblA.BackColor = Color.White;
         lblA.BorderStyle = BorderStyle.FixedSingle;
         lblA.Font = new Font("Arial", 34F);
         lblA.Location = new Point(posicaoX, posicaoY);
         lblA.Name = "lblA" + numeroOrdem;
         lblA.Size = new Size(45, 60);
         lblA.TextAlign = ContentAlignment.MiddleCenter;

         pnlPainelLetrasA.Controls.Add(lblA);
      }
      //---------------------------------------------------------------------------------------------
      void criarLabelB(int numeroOrdem, int posicaoX, int posicaoY)
      {
         Label lblB = new Label();

         lblB.BackColor = Color.White;
         lblB.BorderStyle = BorderStyle.FixedSingle;
         lblB.Font = new Font("Arial", 34F);
         lblB.Location = new Point(posicaoX, posicaoY);
         lblB.Name = "lblA" + numeroOrdem;
         lblB.Size = new Size(45, 60);
         lblB.TextAlign = ContentAlignment.MiddleCenter;

         pnlPainelLetrasB.Controls.Add(lblB);
      }
      //---------------------------------------------------------------------------------------------
      void criarBlocoA(int numeroOrdem, int posicaoX, int posicaoY, int index)
      {
         Label blocoA = new Label();

         blocoA.BackColor = Color.Blue;
         blocoA.BorderStyle = BorderStyle.FixedSingle;
         blocoA.Font = new Font("Arial", 34F);
         blocoA.Location = new Point(posicaoX, posicaoY);
         blocoA.Name = "lblA" + numeroOrdem;
         blocoA.Size = new Size(45, 60);
         blocoA.TextAlign = ContentAlignment.MiddleCenter;
         blocoA.TabIndex = index;

         pnlPainelLetrasA.Controls.Add(blocoA);
      }
      //---------------------------------------------------------------------------------------------
      void criarBlocoB(int numeroOrdem, int posicaoX, int posicaoY, int index)
      {
         Label blocoB = new Label();

         blocoB.BackColor = Color.Blue;
         blocoB.BorderStyle = BorderStyle.FixedSingle;
         blocoB.Font = new Font("Arial", 34F);
         blocoB.Location = new Point(posicaoX, posicaoY);
         blocoB.Name = "lblA" + numeroOrdem;
         blocoB.Size = new Size(45, 60);
         blocoB.TextAlign = ContentAlignment.MiddleCenter;
         blocoB.TabIndex = index;

         pnlPainelLetrasB.Controls.Add(blocoB);
      }
      //-------------------------------------------------------------------------------------------------
      void excluirBlocoA()
      {
         for (int i = 0; i < letrasReveladasA.Length; i++)
         {
            pnlPainelLetrasA.Controls.RemoveAt(0);
         }
         primeiraLetraA = false;
      }
      //-------------------------------------------------------------------------------------------------
      //-------------------------------------------------------------------------------------------------
      void excluirBlocoB()
      {
         for (int i = 0; i < letrasReveladasB.Length; i++)
         {
            pnlPainelLetrasB.Controls.RemoveAt(0);
         }
         primeiraLetraB = false;
      }
      //------------------------------------------------------------------------------------------------

      //------------------------------------------------------------------------------------------------
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
      //----------------------------------------------------------------
      void PainelPalavrasA()
      {
         //Montar a lista de letras reveladas
         pnlPainelLetrasA.Controls.Clear();

         string[] temas = { "informatica", "animal", "objeto" };

         Random randomTemas = new Random();
         tema = temas[randomTemas.Next(0, temas.Length)];

         Random random = new Random();

         switch (tema)
         {
            case "informatica":
               string[] informatica = { "internet", "gabinete", "processador", "mouse", "teclado", "monitor", "memoria", "roteador", "navegador", "cabo", "alicate", "conector" };

               palavraSorteadaA = informatica[random.Next(0, informatica.Length)];

               palavraQuebradaA = palavraSorteadaA.ToCharArray();

               letrasReveladasA = new string[palavraQuebradaA.Length];
               qtdLetrasA = letrasReveladasA.Length;
               break;

            case "animal":
               string[] animal = { "tatu", "iguana", "dromedario", "rato", "camaleao", "jararaca", "baiacu", "sapo", "aranha", "lagarto", "zebra", "hiena" };

               palavraSorteadaA = animal[random.Next(0, animal.Length)];

               palavraQuebradaA = palavraSorteadaA.ToCharArray();

               letrasReveladasA = new string[palavraQuebradaA.Length];
               qtdLetrasA = letrasReveladasA.Length;
               break;

            case "objeto":
               string[] objeto = { "caixao", "marcapasso", "apagador", "chave", "tapete", "quadro", "fogao", "mesa", "ventilador", "panela", "oculos", "chuveiro" };

               palavraSorteadaA = objeto[random.Next(0, objeto.Length)];

               palavraQuebradaA = palavraSorteadaA.ToCharArray();

               letrasReveladasA = new string[palavraQuebradaA.Length];
               qtdLetrasA = letrasReveladasA.Length;
               break;
         }

         if (pnlPainelLetrasA.Controls.Count == 0)
         {
            primeiraLetraA = false;

            for (int i = 1; i <= 11; i++)
            {
               if (!primeiraLetraA)
               {
                  posicaoXLabelA = 0;
                  posicaoYLabelA = 0;
                  primeiraLetraA = true;
               }
               else
               {
                  posicaoXLabelA += 46;
                  posicaoYLabelA = 0;

                  index++;
               }
               criarBlocoA(i, posicaoXLabelA, posicaoYLabelA, index);
            }
         }
         excluirBlocoA();

         for (int i = 0; i < letrasReveladasA.Length; i++)
         {
            if (!primeiraLetraA)
            {
               posicaoXLabelA = 0;
               posicaoYLabelA = 0;
               primeiraLetraA = true;
            }
            else
            {
               posicaoXLabelA += 46;
               posicaoYLabelA = 0;
            }
            criarLabelA(i, posicaoXLabelA, posicaoYLabelA);
         }
      }
      //-----------------------------------------------------------------------------------------------------------
      void PainelPalavrasB()
      {
         //Montar a lista de letras reveladas
         pnlPainelLetrasB.Controls.Clear();

         string[] temas = { "informatica", "animal", "objeto" };

         Random randomTemas = new Random();
         tema = temas[randomTemas.Next(0, temas.Length)];

         Random random = new Random();

         switch (tema)
         {
            case "informatica":
               string[] informatica = { "internet", "gabinete", "processador", "mouse", "teclado", "monitor", "memoria", "roteador", "navegador", "cabo", "alicate", "conector" };

               palavraSorteadaB = informatica[random.Next(0, informatica.Length)];

               palavraQuebradaB = palavraSorteadaB.ToCharArray();

               letrasReveladasB = new string[palavraQuebradaB.Length];
               qtdLetrasB = letrasReveladasB.Length;
               break;

            case "animal":
               string[] animal = { "tatu", "iguana", "dromedario", "rato", "camaleao", "jararaca", "baiacu", "sapo", "aranha", "lagarto", "zebra", "hiena" };

               palavraSorteadaB = animal[random.Next(0, animal.Length)];

               palavraQuebradaB = palavraSorteadaB.ToCharArray();

               letrasReveladasB = new string[palavraQuebradaB.Length];
               qtdLetrasB = letrasReveladasB.Length;
               break;

            case "objeto":
               string[] objeto = { "caixao", "marcapasso", "apagador", "chave", "tapete", "quadro", "fogao", "mesa", "ventilador", "panela", "oculos", "chuveiro" };

               palavraSorteadaB = objeto[random.Next(0, objeto.Length)];

               palavraQuebradaB = palavraSorteadaB.ToCharArray();

               letrasReveladasB = new string[palavraQuebradaB.Length];
               qtdLetrasB = letrasReveladasB.Length;
               break;
         }

         if (pnlPainelLetrasB.Controls.Count == 0)
         {

            primeiraLetraB = false;

            for (int i = 1; i <= 11; i++)
            {
               if (!primeiraLetraB)
               {
                  posicaoXLabelB = 0;
                  posicaoYLabelB = 0;
                  primeiraLetraB = true;
               }
               else
               {
                  posicaoXLabelB += 46;
                  posicaoYLabelB = 0;

                  index++;
               }
               criarBlocoB(i, posicaoXLabelB, posicaoYLabelB, index);
            }
         }
         excluirBlocoB();

         for (int i = 0; i < letrasReveladasB.Length; i++)
         {
            if (!primeiraLetraB)
            {
               posicaoXLabelB = 0;
               posicaoYLabelB = 0;
               primeiraLetraB = true;
            }
            else
            {
               posicaoXLabelB += 46;
               posicaoYLabelB = 0;
            }
            criarLabelB(i, posicaoXLabelB, posicaoYLabelB);
         }
      }
      //----------------------------------------------------------------
      void verificarLetra(char letra)
      {
         letraEscolhida = letra;

         for (int i = 0; i < letrasReveladasA.Length; i++)
         {
            if (palavraQuebradaA[i] == letraEscolhida)
            {
               acertou = true;
               qtdAcertos++;
               letrasReveladasA[i] = letraEscolhida.ToString().ToUpper();
            }
         }
      }
      //----------------------------------------------------------------







      //========================= CONTROLES ============================
      private void timer1_Tick(object sender, EventArgs e)
      {
         lblValorSorteado.Text = "Girando...";
         segundo--;
         if (segundo == 0)
         {
            timer1.Enabled = false;
            //faz o ramdom do array com os valores
            lblValorSorteado.Text = "1000";
            pcbGif.Image = null;
            //PainelPalavras();
         }
      }
      //-------------------------------------------------------------------------------------------------
      private void btnGirar_Click(object sender, EventArgs e)
      {
         interromperSom = true;
         playSimpleSound("abertura.wav");

         pcbGif.Image = Image.FromFile(Application.StartupPath + @"\..\..\..\Arquivos\roleta.gif");

         playSimpleSound("roleta girando.wav");

         segundo = 8;
         timer1.Enabled = true;
      }
      //--------------------------------------------------------------------------------------------------
      private void btnSortearPalavra_Click(object sender, EventArgs e)
      {
         PainelPalavrasA();
         PainelPalavrasB();


      }
      //----------------------------------------------------------------
      private void btnA_Click(object sender, EventArgs e)
      {
         //verificarLetra('a');
         //excluirBloco();
      }
      //------------------------------------------------------------------------------------------------------
      private void frmJogo_Load(object sender, EventArgs e)
      {
         for (int i = 1; i <= 11; i++)
         {
            if (!primeiraLetraA)
            {
               posicaoXLabelA = 0;
               posicaoYLabelA = 0;
               primeiraLetraA = true;
            }
            else
            {
               posicaoXLabelA += 46;
               posicaoYLabelA = 0;
               index++;
            }
            criarBlocoA(i, posicaoXLabelA, posicaoYLabelA, index);
         }
         for (int i = 1; i <= 11; i++)
         {
            if (!primeiraLetraB)
            {
               posicaoXLabelB = 0;
               posicaoYLabelB = 0;
               primeiraLetraB = true;
            }
            else
            {
               posicaoXLabelB += 46;
               posicaoYLabelB = 0;
               index++;
            }
            criarBlocoB(i, posicaoXLabelB, posicaoYLabelB, index);
         }
      }
   }
}
