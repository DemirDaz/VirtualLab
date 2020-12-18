using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace labaratorija
{
    public partial class Registracija : Form

    {
        Entities ctx = new Entities();
        public Registracija()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            var regex = new Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$"); // provera mejla



            if ((ValidujSifru(maskedTextBox1.Text)) && (maskedTextBox1.Text == maskedTextBox2.Text) && (regex.IsMatch(textBox5.Text))) {
                profili trazi = ctx.profilis.Where(x => x.username == textBox4.Text).FirstOrDefault();
                if (trazi == null)
                {
                    try
                    {

                        profili novi = new profili()
                        {

                            username = textBox4.Text,
                            password = maskedTextBox1.Text,
                            ImeiPrez = textBox1.Text,
                            Fakultet = textBox2.Text,
                            Smer = textBox3.Text,
                            Email = textBox5.Text


                        };
                        ctx.profilis.Add(novi);
                        ctx.SaveChanges();
                        getUser.user = novi.username;
                        MessageBox.Show("Uspesno ste se registrovali!");
                        Form2 f2 = new Form2();
                        f2.ShowDialog();
                        this.Close();
                    }
                    catch
                    {

                        if (textBox4.Text == null)
                            MessageBox.Show("Unesite zeljeno ime");
                        else if (maskedTextBox1.Text == null)
                            MessageBox.Show("Sifra ne zadovoljava uslove(minimalno 8 karaktera, jedno veliko slovo,dva broja,dozvoljena su samo slova i brojevi");
                    }
                }
                else MessageBox.Show("Vec je registrovan korisnik sa ovim imenom. Probajte neko drugo.");
            } else { MessageBox.Show("1)Sifra ne zadovoljava uslove(minimalno 8 karaktera, jedno veliko slovo, dva broja, dozvoljena su samo slova i brojevi)."+
                                       "2)Sifre se ne poklapaju" +
                                       "3)Uneti email ne postoji");
                maskedTextBox1.Text = "";
                maskedTextBox2.Text = "";
            }
        }

        private void Registracija_Load(object sender, EventArgs e)
        {

        }
        public Boolean ValidujSifru(string pass)
        {
            if (pass.Length < 8)
                return false;
            else
            {
                char c;
                int brojac = 0; // broji brojeve
                int veliko = 0; // broji velika slova

                for (int i = 0; i < pass.Length; i++)
                {
                    c = pass[i];
                    if (!Char.IsLetterOrDigit(c))
                        return false;
                    else if (Char.IsUpper(c))
                    {
                        veliko++;

                    }
                    else if (Char.IsDigit(c))
                    {
                        brojac++;
                    }
                }
                if (veliko < 1)
                    return false;
                if (brojac < 2)
                    return false;


            }
            return true;    

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

            this.Close();
            
        }
    }
}
