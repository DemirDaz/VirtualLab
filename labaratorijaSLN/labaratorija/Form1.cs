using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labaratorija
{
    public partial class Form1 : Form
    {
        Entities  ctx = new Entities();
        public Form1()
        {
            InitializeComponent();
           
            this.BackgroundImage = Properties.Resources.loginnn;
            loginbtn.BackColor = Color.Transparent;
            registerbtn.BackColor = Color.Transparent;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txt1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            
                profili naso = ctx.profilis.Where(x => x.username == txt1.Text).FirstOrDefault();
                if (naso == null)
                    MessageBox.Show("Niste registrovani."); 
                else
                    if ((naso.username == txt1.Text) && (naso.password == txt2.Text))
                {
                     getUser.user = naso.username;
                        Form2 f2 = new Form2();
                    f2.ShowDialog();
                    this.Close();
                }
                else MessageBox.Show("Pogresna sifra!");
         


            }


        public void upali()
        {
            this.Show();
        } 

        private void registerbtn_Click(object sender, EventArgs e)
        {

            Registracija Reg = new Registracija();
            Reg.ShowDialog();
            

     }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; //da minimizuje
        }
    }
    public static class getUser
    {
        public static string user { get; set; }
    }

    public static class Bodovi
    {
        public static int broj { get; set; }

    }

    
}
