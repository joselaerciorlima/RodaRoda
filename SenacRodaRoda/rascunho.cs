//using System;
//using System.Drawing;
//using System.Windows.Forms;
//using System.Media;

//namespace SenacRodaRoda
//{
//   public partial class frmJogo : Form
//   {
//      int qtdLetrasA, qtdLetrasB, qtdErros, qtdAcertos;

//      =================== VARIAVEIS GLOBAIS ====================================================
//      bool primeiraLetraA = true;
//      bool primeiraLetraB = true;
//      bool interromperSom = false;
//      bool acertou = false;
//      bool novoJogo = true;

//      int posicaoX = 0;
//      int posicaoY = 0;
//      int pointXblcB = 0;
//      int pointYblcB = 0;
//      int index = 1;
//      int segundo;
//      int tabulacao = 0;

//      string localPasta;
//      string tema;
//      string palavraSorteadaA;
//      string palavraSorteadaB;
//      string premioSorteado;

//      char letraEscolhida;

//      string[] letrasReveladasA;
//      string[] letrasReveladasB;

//      char[] palavraQuebradaA;
//      char[] palavraQuebradaB;

//      Label blocoBranco;
//      Control blocoBrancoA;
//      Control blocoAzulA;

//      =================== MONTAGEM DO FORMULARIO ===============================================
//      public frmJogo()
//      {
//         InitializeComponent();

//         pcbLogo.BackgroundImage = Image.FromFile(Application.StartupPath + @"\..\..\..\Arquivos\logo.png");
//         localPasta = Application.StartupPath + @"\..\..\..\Arquivos\Sons\";
//         playSimpleSound("abertura.wav");
//         pcbPainel.BackgroundImage = Image.FromFile(Application.StartupPath + @"\..\..\..\Arquivos\painel.png");
//      }
//      ======================== MÉTODOS =========================================================
//      void criarLabelA(int i)
//      {
//         tabulacao = 0;
//         Control[] blocos = pnlPainelLetrasA.Controls.Find("blcA" + index, false);

//         if (string.IsNullOrEmpty(letrasReveladasA[i]))
//         {
//            foreach (var item in blocos)
//            {
//               if (tabulacao <= letrasReveladasA.Length)
//               {
//                  item.BackColor = Color.White;
//                  SelectNextControl(item, true, false, true, false);
//                  tabulacao++;
//               }
//            }
//            index++;
//         }
//         else
//         {
//            foreach (var item in blocos)
//            {
//               item.BackColor = Color.White;
//               item.Text = letrasReveladasA[i];
//            }
//            index++;
//         }
//      }
//      ------------------------------------------------------------------------------------------
//      void criarLabelB(int numeroOrdem, int posicaoX, int posicaoY)
//      {
//         if (string.IsNullOrEmpty(letrasReveladasB[numeroOrdem]))
//         {
//            Label lblB = new Label();

//            lblB.BackColor = Color.White;
//            lblB.BorderStyle = BorderStyle.FixedSingle;
//            lblB.Font = new Font("Arial", 34F);
//            lblB.Location = new Point(posicaoX, posicaoY);
//            lblB.Name = "lblA" + numeroOrdem;
//            lblB.Size = new Size(45, 60);
//            lblB.TextAlign = ContentAlignment.MiddleCenter;

//            pnlPainelLetrasB.Controls.Add(lblB);
//         }
//         else
//         {
//            Label lblB = new Label();

//            lblB.BackColor = Color.White;
//            lblB.BorderStyle = BorderStyle.FixedSingle;
//            lblB.Font = new Font("Arial", 34F);
//            lblB.Location = new Point(posicaoX, posicaoY);
//            lblB.Name = "lblA" + numeroOrdem;
//            lblB.Size = new Size(45, 60);
//            lblB.TextAlign = ContentAlignment.MiddleCenter;
//            lblB.Text = letrasReveladasB[numeroOrdem];

//            pnlPainelLetrasB.Controls.Add(lblB);
//         }
//      }
//      ------------------------------------------------------------------------------------------Ok
//      public void criarBlocoA()
//      {
//         pnlPainelLetrasA.Controls.Clear();
//         posicaoX = 0;
//         posicaoY = 0;

//         for (int i = 1; i <= 11; i++)
//         {
//            this.SuspendLayout();
//            Label blcA = new Label();
//            blcA.BackColor = Color.Blue;
//            blcA.BorderStyle = BorderStyle.None;
//            blcA.Font = new Font("Arial", 34F);
//            blcA.Location = new Point(posicaoX, posicaoY);
//            blcA.Name = "blcA" + i;
//            blcA.Size = new Size(45, 60);
//            blcA.TextAlign = ContentAlignment.MiddleCenter;
//            blcA.TabIndex = tabulacao;

//            pnlPainelLetrasA.Controls.Add(blcA);
//            posicaoX += 46;
//            this.ResumeLayout();
//            tabulacao++;
//         }
//      }
//      ------------------------------------------------------------------------------------------OK
//      public void criarBlocoB()
//      {
//         pnlPainelLetrasB.Controls.Clear();
//         posicaoX = 0;
//         posicaoY = 0;

//         for (int i = 1; i <= 11; i++)
//         {
//            this.SuspendLayout();
//            Label blcB = new Label();
//            blcB.BackColor = Color.Blue;
//            blcB.BorderStyle = BorderStyle.None;
//            blcB.Font = new Font("Arial", 34F);
//            blcB.Location = new Point(posicaoX, posicaoY);
//            blcB.Name = "blcB" + i;
//            blcB.Size = new Size(45, 60);
//            blcB.TextAlign = ContentAlignment.MiddleCenter;

//            pnlPainelLetrasB.Controls.Add(blcB);
//            posicaoX += 46;
//            this.ResumeLayout();
//         }
//      }
//      ------------------------------------------------------------------------------------------OK
//      void excluirBlocoA()
//      {
//         for (int i = 1; i <= palavraSorteadaA.Length; i++)
//         {
//            Control[] blocos = pnlPainelLetrasA.Controls.Find("blcA" + i, false);

//            foreach (var item in blocos)
//            {
//               pnlPainelLetrasA.Controls.RemoveAt(0);
//            }
//         }
//         primeiraLetraA = false;
//      }
//      ------------------------------------------------------------------------------------------OK
//      void excluirBlocoB()
//      {
//         for (int i = 1; i <= palavraSorteadaB.Length; i++)
//         {
//            Control[] blocos = pnlPainelLetrasB.Controls.Find("blcB" + i, false);

//            foreach (var item in blocos)
//            {
//               pnlPainelLetrasB.Controls.RemoveAt(0);
//            }
//         }
//         primeiraLetraB = false;
//      }
//      ------------------------------------------------------------------------------------------OK
//      private void playSimpleSound(string arquivo)
//      {
//         SoundPlayer simpleSound = new SoundPlayer(localPasta + arquivo);
//         if (interromperSom)
//         {
//            simpleSound.Stop();
//            interromperSom = false;
//         }
//         else
//         {
//            simpleSound.Play();
//         }
//      }
//      ------------------------------------------------------------------------------------------
//      void Sorteador()
//      {
//         string[] temas = { "informatica", "animal", "objeto" };

//         Random randomTemas = new Random();
//         tema = temas[randomTemas.Next(0, temas.Length)];

//         Random random = new Random();

//         switch (tema)
//         {
//            case "informatica":
//               string[] informatica = { "internet", "gabinete", "processador", "mouse", "teclado", "monitor", "memoria", "roteador", "navegador", "cabo", "alicate", "conector" };

//               palavraSorteadaA = informatica[random.Next(0, informatica.Length)];
//               palavraSorteadaB = informatica[random.Next(0, informatica.Length)];

//               palavraQuebradaA = palavraSorteadaA.ToCharArray();
//               palavraQuebradaB = palavraSorteadaB.ToCharArray();

//               while (palavraSorteadaB == palavraSorteadaA)
//               {
//                  palavraSorteadaB = informatica[random.Next(0, informatica.Length)];

//                  palavraQuebradaB = palavraSorteadaB.ToCharArray();
//               }

//               letrasReveladasA = new string[palavraQuebradaA.Length];
//               letrasReveladasB = new string[palavraQuebradaB.Length];
//               break;

//            case "animal":
//               string[] animal = { "tatu", "iguana", "dromedario", "rato", "camaleao", "jararaca", "baiacu", "sapo", "aranha", "lagarto", "zebra", "hiena" };

//               palavraSorteadaA = animal[random.Next(0, animal.Length)];
//               palavraSorteadaB = animal[random.Next(0, animal.Length)];

//               palavraQuebradaA = palavraSorteadaA.ToCharArray();
//               palavraQuebradaB = palavraSorteadaB.ToCharArray();

//               while (palavraSorteadaB == palavraSorteadaA)
//               {
//                  palavraSorteadaB = animal[random.Next(0, animal.Length)];
//                  palavraQuebradaB = palavraSorteadaB.ToCharArray();
//               }

//               letrasReveladasA = new string[palavraQuebradaA.Length];
//               letrasReveladasB = new string[palavraQuebradaB.Length];
//               break;

//            case "objeto":
//               string[] objeto = { "caixao", "marcapasso", "apagador", "chave", "tapete", "quadro", "fogao", "mesa", "ventilador", "panela", "oculos", "chuveiro" };

//               palavraSorteadaA = objeto[random.Next(0, objeto.Length)];
//               palavraSorteadaB = objeto[random.Next(0, objeto.Length)];

//               palavraQuebradaA = palavraSorteadaA.ToCharArray();
//               palavraQuebradaB = palavraSorteadaB.ToCharArray();

//               while (palavraSorteadaB == palavraSorteadaA)
//               {
//                  palavraSorteadaB = objeto[random.Next(0, objeto.Length)];
//                  palavraQuebradaB = palavraSorteadaB.ToCharArray();
//               }

//               letrasReveladasA = new string[palavraQuebradaA.Length];
//               letrasReveladasB = new string[palavraQuebradaB.Length];
//               break;
//         }
//         PainelPalavrasA();
//         PainelPalavrasB();
//         novoJogo = true;
//      }
//      ------------------------------------------------------------------------------------------
//      void Roleta()
//      {
//         string[] premios = { "1000", "900", "800", "700", "600", "500", "950", "850", "750", "650", "550", "900", "800", "700", "600", "500", "950", "850", "750", "650", "550", "PERDEU TUDO!", "PASSOU A VEZ!", "GIRE NOVAMENTE" };

//         Random randomPremios = new Random();
//         premioSorteado = premios[randomPremios.Next(0, premios.Length)];

//         Random random = new Random();

//         if (premioSorteado == "PERDEU TUDO!" || premioSorteado == "PASSOU A VEZ!" || premioSorteado == "GIRE NOVAMENTE")
//         {
//            lblValorSorteado.Text = premioSorteado;
//         }
//         else
//         {
//            lblValorSorteado.Text = "R$ " + premioSorteado;
//         }
//      }
//      ------------------------------------------------------------------------------------------
//      void PainelPalavrasA()
//      {
//         Juntar o criar label nesse metodo!!!!

//         excluirBlocoA();
//         Reset();

//         for (int i = 0; i <= letrasReveladasA.Length; i++)
//         {
//            if (primeiraLetraA)
//            {
//               posicaoX = 0;
//               posicaoY = 0;
//               primeiraLetraA = false;
//            }
//            else
//            {
//               posicaoX += 46;
//               posicaoY = 0;
//            }
//            criarLabelA(i);
//         }
//      }
//      ------------------------------------------------------------------------------------------
//      void PainelPalavrasB()
//      {
//         excluirBlocoB();

//         for (int i = 0; i < letrasReveladasB.Length; i++)
//         {
//            if (!primeiraLetraB)
//            {
//               posicaoXLabelB = 0;
//               posicaoYLabelB = 0;
//               primeiraLetraB = true;
//            }
//            else
//            {
//               posicaoXLabelB += 46;
//               posicaoYLabelB = 0;
//            }
//            criarLabelB(i, posicaoXLabelB, posicaoYLabelB);
//         }
//      }
//      ------------------------------------------------------------------------------------------
//      void verificarLetra(char letra)
//      {
//         letraEscolhida = letra;

//         for (int i = 0; i < letrasReveladasA.Length; i++)
//         {
//            if (palavraQuebradaA[i] == letraEscolhida)
//            {
//               acertou = true;
//               qtdAcertos++;
//               letrasReveladasA[i] = letraEscolhida.ToString().ToUpper();
//            }
//         }
//      }
//      ------------------------------------------------------------------------------------------
//      void Reset()
//      {
//         for (int i = 1; i <= palavraSorteadaA.Length; i++)
//         {
//            Control[] blocos = pnlPainelLetrasA.Controls.Find(, true);
//            int tamanho = 1;

//            while (tamanho <= palavraSorteadaA.Length)
//            {
//               Control[] blocosBrancos = pnlPainelLetrasA.Controls.Find("blcA" + tamanho, true);

//               foreach (var blocos in blocosBrancos)
//               {
//                  blocos.BackColor = Color.Blue;
//                  blocos.Text = "d";
//               }
//               tamanho++;
//            }
//            primeiraLetraA = false;
//            novoJogo = true;
//         }
//         ------------------------------------------------------------------------------------------
//         void revelarLetra()
//      {
//            pnlPainelLetrasA.Controls.RemoveAt(0);
//            blocoBranco.Dispose();
//         }
//      ========================= CONTROLES ======================================================
//      private void timer1_Tick(object sender, EventArgs e)
//         {
//            lblValorSorteado.Text = "Girando...";
//            segundo--;
//            if (segundo == 0)
//            {
//               timer1.Enabled = false;
//               Roleta();
//               pcbGif.Image = null;
//            }
//         }
//         ------------------------------------------------------------------------------------------
//      private void btnGirar_Click(object sender, EventArgs e)
//         {
//            interromperSom = true;
//            playSimpleSound("abertura.wav");

//            pcbGif.Image = Image.FromFile(Application.StartupPath + @"\..\..\..\Arquivos\roleta.gif");

//            playSimpleSound("roleta girando.wav");

//            segundo = 8;
//            timer1.Enabled = true;
//         }
//         ------------------------------------------------------------------------------------------
//      private void btnA_Click(object sender, EventArgs e)
//         {
//            verificarLetra('a');
//            excluirBlocoA();
//         }
//         ------------------------------------------------------------------------------------------
//      private void frmJogo_Load(object sender, EventArgs e)
//         {
//            criarBlocoA();
//            criarBlocoB();
//         }
//         ------------------------------------------------------------------------------------------
//      private void btnNovoJogo_Click(object sender, EventArgs e)
//         {
//            Sorteador();


//            if (novoJogo)
//            {
//               Sorteador();
//               lblDica.Text = tema.ToUpper();
//               novoJogo = false;
//            }
//            else
//            {
//               Reset();
//               pnlPainelLetrasA.Controls.Clear();
//               novoJogo = true;
//            }
//         }
//      }
//   }
