using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenacRodaRoda
{
   public partial class Form2 : Form
   {
      public Form2()
      {
         InitializeComponent();
      }

      private void button4_Click(object sender, EventArgs e)
      {
         Bitmap imgBack = new Bitmap(panel1.Width, panel1.Height);
         Graphics desenhador = Graphics.FromImage(imgBack);

         desenhador.Clear(Color.FromArgb(4, 173, 191));

         // Create pen.
         Pen blackPen = new Pen(Color.White, 19);

         // Create points that define line.
         Point[] pontos = new Point[]
         {
            new Point(99,23), //Ponto inicial
            new Point(668,23), //Ponto final 
            new Point(668,84), //Linha vertical 
            new Point(714,84), //Linha horizontal
            new Point(714,255), //Linha vertical
            new Point(668,255), //Linha horizontal
            new Point(668,316), //Linha vertical
            new Point(99,316), //Linha horizontal
            new Point(99,255), //Linha vertical
            new Point(53,255), //Linha horizontal
            new Point(53,84), //Linha vertical
            new Point(99,84), //Linha horizontal
            new Point(99,14), //Linha vertical
         };
         
         // Draw line to screen.
         desenhador.DrawLines(blackPen,pontos);
          
         panel1.BackgroundImage = imgBack;
      }
   }
}
