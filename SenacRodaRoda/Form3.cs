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
   public partial class Form3 : Form
   {
      private Form activeForm;
      public Form3()
      {
         InitializeComponent();
      }

      private void OpenChildForm(Form childForm)
      {
         SuspendLayout();
         if (activeForm != null)

            activeForm.Close();
         //ActivateButton(btnSender);
         activeForm = childForm;
         childForm.TopLevel = false;
         childForm.FormBorderStyle = FormBorderStyle.None;
         childForm.Dock = DockStyle.Fill;
         this.panelDesktopPane.Controls.Add(childForm);
         this.panelDesktopPane.Tag = childForm;
         childForm.BringToFront();
         childForm.Show();

         ResumeLayout();
      }

      private void button1_Click(object sender, EventArgs e)
      {
         OpenChildForm(new Form4());
      }
   }
}
