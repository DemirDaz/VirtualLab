using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labaratorija
{
   
    public partial class Ogled1 : UserControl
    {
        static int sem = 0;
        Entities con = new Entities();

        public Ogled1()
        {
            InitializeComponent();
            OcistiKorake();
            pictureBox2.Enabled = false;
            Baimg.Enabled = false;
            Caimg.Enabled = false;
            Srimg.Enabled = false;
            


        }
      
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            string igrac = getUser.user;
            koraciigraca sledeci = con.koraciigracas.OrderByDescending(x => x.redbrkoraka).FirstOrDefault();
            var pome = sledeci.redbrkoraka + 1;
            koraciigraca drugi = new koraciigraca()
            {
                username = igrac,
                korakid = 51,
                redbrkoraka = pome
            };
            con.koraciigracas.Add(drugi);
            con.SaveChanges();

            koraci trazeni = con.koracis.Where(x => x.korakid == drugi.korakid).FirstOrDefault();
            profili pom = con.profilis.Where(x => x.username == igrac).FirstOrDefault();
            koraci pogresan = con.koracis.Where(x => x.opis == "\"napravio gresku\"").First();
            if (drugi.redbrkoraka >= 1)
            {
                MessageBox.Show("Upalite gornionik!");
                Bodovi.broj += trazeni.brpoena;
                pom.poeni = Bodovi.broj;
                con.SaveChanges();
            }
            else
            {
                MessageBox.Show("Ovo nije sledeci korak, proverite upustvo!");
                Bodovi.broj -= pogresan.brpoena;
                pom.poeni = Bodovi.broj;
                con.SaveChanges();
            }

            var parent = this.ParentForm as Form2;  //KOLIKO JE OVO BITNO, DVA SATA POKUSAVAM DA OVO URADIM!
            parent.ID2 = ID2;




        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            string igrac = getUser.user;
            koraciigraca sledeci = con.koraciigracas.OrderByDescending(x => x.redbrkoraka).FirstOrDefault();
            var pome = sledeci.redbrkoraka + 1;
            koraciigraca treci = new koraciigraca()
            {
                username = igrac,
                korakid = 52,
                redbrkoraka = pome
            };
            con.koraciigracas.Add(treci);
            con.SaveChanges();
            koraci trazeni = con.koracis.Where(x => x.korakid == treci.korakid).FirstOrDefault();
            profili pom = con.profilis.Where(x => x.username == igrac).FirstOrDefault();
            koraci pogresan = con.koracis.Where(x => x.opis == "\"napravio gresku\"").First();
            if (treci.redbrkoraka >= 2)
            {
                MessageBox.Show("Bravo!");
                Cursor = Cursors.Default;
                Plamenimg.Enabled = true;   //OVDE PALIMO SLIKO ZA PLAMEN

                Plamenimg.Visible = true;
                Bodovi.broj += trazeni.brpoena;
                pom.poeni = Bodovi.broj;
                con.SaveChanges();
            }
            else
            {
                MessageBox.Show("Ovo nije sledeci korak, proverite upustvo!");
                Bodovi.broj -= pogresan.brpoena;
                pom.poeni = Bodovi.broj;
                con.SaveChanges();
            }

            var parent = this.ParentForm as Form2;  //KOLIKO JE OVO BITNO, DVA SATA POKUSAVAM DA OVO URADIM!
            parent.ID2 = ID2;




         
            
        }
        private void OcistiKorake()
        {
            List<koraciigraca> svi = con.koraciigracas.ToList();
            foreach (var r in svi)
                con.koraciigracas.Remove(r);
            con.SaveChanges();
        }

        private void PustiGas_Click(object sender, EventArgs e)
        {
            string igrac = getUser.user;



            try
            {
                koraciigraca prvi = new koraciigraca()
                {
                    username = igrac,
                    korakid = 50,
                    redbrkoraka = 0

                };
                con.koraciigracas.Add(prvi);
                con.SaveChanges();

                koraci trazeni = con.koracis.Where(x => x.korakid == prvi.korakid).FirstOrDefault();
                profili pom = con.profilis.Where(x => x.username == igrac).FirstOrDefault();
                koraci pogresan = con.koracis.Where(x => x.opis == "\"napravio gresku\"").First();
                if (prvi.redbrkoraka == 0)
                {
                    MessageBox.Show("Gas pusten!");
                    Bodovi.broj += trazeni.brpoena;
                    pom.poeni = Bodovi.broj;
                    con.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Ovo nije sledeci korak, proverite upustvo!");
                    Bodovi.broj -= pogresan.brpoena;
                    pom.poeni = Bodovi.broj;
                    con.SaveChanges();
                }



                var parent = this.ParentForm as Form2;  //KOLIKO JE OVO BITNO, DVA SATA POKUSAVAM DA OVO URADIM!
                parent.ID2 = ID2;
            }

            catch
            {



                profili pom = con.profilis.Where(x => x.username == igrac).FirstOrDefault();
                koraci pogresan = con.koracis.Where(x => x.opis == "\"napravio gresku\"").First();

                MessageBox.Show("Ovo nije sledeci korak, proverite upustvo!");
                Bodovi.broj -= pogresan.brpoena;
                pom.poeni = Bodovi.broj;
                con.SaveChanges();

                var parent = this.ParentForm as Form2;  //KOLIKO JE OVO BITNO, DVA SATA POKUSAVAM DA OVO URADIM!
                parent.ID2 = ID2;

            }
        }
        public string ID2
        {
            get { return Bodovi.broj.ToString(); }
        }

        private void Ogled1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UzmiIglu_Click(object sender, EventArgs e)  /////////////OVDEW UZIMA IGLU PRVI PUT
        {
            

            pictureBox2.Image = Properties.Resources.iglica;
            pictureBox2.BringToFront();
            if (pictureBox2.Enabled == false)
            {
                pictureBox2.Enabled = true;
                pictureBox2.Visible = true;
                pictureBox2.BringToFront();
                UzmiIglu.Enabled = false;
                bunifuImageButton1.Enabled = false;
                bunifuImageButton2.Enabled = false;
                PustiGas.Enabled = false;
                string igrac = getUser.user;
                koraciigraca sledeci = con.koraciigracas.OrderByDescending(x => x.redbrkoraka).FirstOrDefault();
                var pome = sledeci.redbrkoraka + 1;
                koraciigraca cetvrti = new koraciigraca()
                {
                    username = igrac,
                    korakid = 53,
                    redbrkoraka = pome
                };
                con.koraciigracas.Add(cetvrti);
                con.SaveChanges();
                koraci trazeni = con.koracis.Where(x => x.korakid == cetvrti.korakid).FirstOrDefault();
                profili pom = con.profilis.Where(x => x.username == igrac).FirstOrDefault();
                koraci pogresan = con.koracis.Where(x => x.opis == "\"napravio gresku\"").First();
                if (cetvrti.redbrkoraka >= 3)
                {

                    Bodovi.broj += trazeni.brpoena;
                    pom.poeni = Bodovi.broj;
                    con.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Ovo nije sledeci korak, proverite upustvo!");
                    Bodovi.broj -= pogresan.brpoena;
                    pom.poeni = Bodovi.broj;
                    con.SaveChanges();
                }



                var parent = this.ParentForm as Form2;  //KOLIKO JE OVO BITNO, DVA SATA POKUSAVAM DA OVO URADIM!
                parent.ID2 = ID2;

            }
            else if (pictureBox2.Enabled == true) {

                string igrac = getUser.user;
                koraciigraca sledeci = con.koraciigracas.OrderByDescending( x => x.redbrkoraka).FirstOrDefault();
                var pome = sledeci.redbrkoraka + 1;
                koraciigraca sedmi = new koraciigraca()
                {
                    username = igrac,
                    korakid = 58,
                    redbrkoraka = pome
                };
                con.koraciigracas.Add(sedmi);
                con.SaveChanges();
                koraci trazeni = con.koracis.Where(x => x.korakid == sedmi.korakid).FirstOrDefault();
                profili pom = con.profilis.Where(x => x.username == igrac).FirstOrDefault();
                koraci pogresan = con.koracis.Where(x => x.opis == "\"napravio gresku\"").First();
                if (sedmi.redbrkoraka >= 5)
                {

                    Bodovi.broj += trazeni.brpoena;
                    pom.poeni = Bodovi.broj;
                    con.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Ovo nije sledeci korak, proverite upustvo!");
                    Bodovi.broj -= pogresan.brpoena;
                    pom.poeni = Bodovi.broj;
                    con.SaveChanges();
                }



                var parent = this.ParentForm as Form2;  //KOLIKO JE OVO BITNO, DVA SATA POKUSAVAM DA OVO URADIM!
                parent.ID2 = ID2;

                pictureBox2.Visible = false;
                pictureBox2.Enabled = false;
                    if(Plamenimg.Enabled==true)
                    Plamenimg.Visible = true;
                    Baimg.Enabled = false;
                    Baimg.Visible = false;
                    Caimg.Enabled = false;
                    Caimg.Visible = false;
                    Srimg.Enabled = false;
                    Srimg.Visible = false;
    
            }
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void Barijum_Click(object sender, EventArgs e)
        {
           
                string igrac = getUser.user;
            koraciigraca sledeci = con.koraciigracas.OrderByDescending(x => x.redbrkoraka).FirstOrDefault();
            var pome = sledeci.redbrkoraka + 1;
                koraciigraca peti = new koraciigraca()
                {
                    username = igrac,
                    korakid = 54,
                    redbrkoraka = pome
                };
                con.koraciigracas.Add(peti);
                con.SaveChanges();
                koraci trazeni = con.koracis.Where(x => x.korakid == peti.korakid).FirstOrDefault();
                profili pom = con.profilis.Where(x => x.username == igrac).FirstOrDefault();
                koraci pogresan = con.koracis.Where(x => x.opis == "\"napravio gresku\"").First();
                if (peti.redbrkoraka >= 4)
                {

                    Bodovi.broj += trazeni.brpoena;
                    pom.poeni = Bodovi.broj;
                    con.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Ovo nije sledeci korak, proverite upustvo!");
                    Bodovi.broj -= pogresan.brpoena;
                    pom.poeni = Bodovi.broj;
                    con.SaveChanges();
                }



                var parent = this.ParentForm as Form2;  //KOLIKO JE OVO BITNO, DVA SATA POKUSAVAM DA OVO URADIM!
                parent.ID2 = ID2;
            
            
            pictureBox2.Image.Dispose();
            pictureBox2.Image = Properties.Resources.Igla_Barijum;
            pictureBox2.BringToFront();
            Barijum.Enabled = false;
            Kalcijum.Enabled = false;
            Stroncijum.Enabled = false;
            sem = 1;

            
           
        }

        private void Ogled1_MouseMove(object sender, MouseEventArgs e)
        {
            Point a = new Point();
           a = PointToClient(Cursor.Position);
            pictureBox2.Location = a;

            
           

        }

        private void Plamenimg_Click(object sender, EventArgs e)
        {
            switch (sem)
            {
                case 1 :
                    {
                        Plamenimg.Visible = false;
                        Baimg.Enabled = true;
                        Baimg.Visible = true;
                        break;
                    }
                case 2:
                    {
                        Plamenimg.Visible = false;
                        Caimg.Enabled = true;
                        Caimg.Visible = true;
                        break;
                    }
                case 3:
                    {
                        Plamenimg.Visible = false;
                        Srimg.Enabled = true;
                        Srimg.Visible = true;
                        break;
                    }
            }//zatvoren switch

        }

        private void Caimg_Click(object sender, EventArgs e)
        {

        }

        private void Srimg_Click(object sender, EventArgs e)
        {

        }

        private void Baimg_Click(object sender, EventArgs e)
        {

        }

        private void Kalcijum_Click(object sender, EventArgs e)
        {
            try
            {
                string igrac = getUser.user;
                koraciigraca sledeci = con.koraciigracas.OrderByDescending(x => x.redbrkoraka).FirstOrDefault();
                var pome = sledeci.redbrkoraka + 1;
                koraciigraca peti = new koraciigraca()
                {
                    username = igrac,
                    korakid = 54,
                    redbrkoraka = pome
                };
                con.koraciigracas.Add(peti);
                con.SaveChanges();
                koraci trazeni = con.koracis.Where(x => x.korakid == peti.korakid).FirstOrDefault();
                profili pom = con.profilis.Where(x => x.username == igrac).FirstOrDefault();
                koraci pogresan = con.koracis.Where(x => x.opis == "\"napravio gresku\"").First();
                if (peti.redbrkoraka >= 4)
                {

                    Bodovi.broj += trazeni.brpoena;
                    pom.poeni = Bodovi.broj;
                    con.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Ovo nije sledeci korak, proverite upustvo!");
                    Bodovi.broj -= pogresan.brpoena;
                    pom.poeni = Bodovi.broj;
                    con.SaveChanges();
                }



                var parent = this.ParentForm as Form2;  //KOLIKO JE OVO BITNO, DVA SATA POKUSAVAM DA OVO URADIM!
                parent.ID2 = ID2;
            }
            catch { MessageBox.Show("Doslo je do greske"); }


            pictureBox2.Image.Dispose();
            pictureBox2.Image = Properties.Resources.Igla_zaOstale;
            pictureBox2.BringToFront();
            sem = 2;
            Barijum.Enabled = false;
            Kalcijum.Enabled = false;
            Stroncijum.Enabled = false;
        }

        private void Stroncijum_Click(object sender, EventArgs e)
        {
            try
            {
                string igrac = getUser.user;
                koraciigraca sledeci = con.koraciigracas.OrderByDescending(x => x.redbrkoraka).FirstOrDefault();
                var pome = sledeci.redbrkoraka + 1;
                koraciigraca peti = new koraciigraca()
                {
                    username = igrac,
                    korakid = 54,
                    redbrkoraka = pome
                };
                con.koraciigracas.Add(peti);
                con.SaveChanges();
                koraci trazeni = con.koracis.Where(x => x.korakid == peti.korakid).FirstOrDefault();
                profili pom = con.profilis.Where(x => x.username == igrac).FirstOrDefault();
                koraci pogresan = con.koracis.Where(x => x.opis == "\"napravio gresku\"").First();
                if (peti.redbrkoraka >= 4)
                {

                    Bodovi.broj += trazeni.brpoena;
                    pom.poeni = Bodovi.broj;
                    con.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Ovo nije sledeci korak, proverite upustvo!");
                    Bodovi.broj -= pogresan.brpoena;
                    pom.poeni = Bodovi.broj;
                    con.SaveChanges();
                }



                var parent = this.ParentForm as Form2;  //KOLIKO JE OVO BITNO, DVA SATA POKUSAVAM DA OVO URADIM!
                parent.ID2 = ID2;
            }
            catch { MessageBox.Show("Doslo je do greske"); }
            pictureBox2.Image.Dispose();
            pictureBox2.Image = Properties.Resources.Igla_zaOstale;
            pictureBox2.BringToFront();
            sem = 3;
            Barijum.Enabled = false;
            Kalcijum.Enabled = false;
            Stroncijum.Enabled = false;
        }

        private void Rastvor_Click(object sender, EventArgs e)
        {
            pictureBox2.Image.Dispose();
            pictureBox2.Image = Properties.Resources.iglica;
            pictureBox2.BringToFront();
            sem = 0;
            UzmiIglu.Enabled = true;
            Barijum.Enabled = true;
            Kalcijum.Enabled = true;
            Stroncijum.Enabled = true;


        }
    }
}
