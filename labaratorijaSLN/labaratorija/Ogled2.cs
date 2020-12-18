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
    public partial class Ogled2 : UserControl
    {
        static int sem = 0;
        static int birac = 0;
        static int podiumklik = 0;
        static int fenol = 0;
       
        
        Entities con = new Entities();
        public Ogled2()
        {
            InitializeComponent();
            OcistiKorake();
           
            Natrijum.Enabled = false;
            Litijum.Enabled = false;
            Kalijum.Enabled = false;
            Rubidijum.Enabled = false;
            Cezijum.Enabled = false;
            Supstanca.Visible = false;
            Vodica.Visible = false;
            Staklo.Enabled = false;
            Kanta.Enabled = true;

        }

        private void Ogled2_Load(object sender, EventArgs e)
        {

        }
        private void OcistiKorake()
        {
            List<koraciigraca> svi = con.koraciigracas.ToList();
            foreach (var r in svi)
                con.koraciigracas.Remove(r);
            con.SaveChanges();
        }
        public string ID2
        {
            get { return Bodovi.broj.ToString(); }
        }

        private void Rukavice_Click(object sender, EventArgs e)
        {
            string igrac = getUser.user;
            Rukavice.Visible = false;
            Rukavice.Enabled = false;



            try
            {
                koraciigraca prvi = new koraciigraca()
                {
                    username = igrac,
                    korakid = 60,
                    redbrkoraka = 0

                };
                con.koraciigracas.Add(prvi);
                con.SaveChanges();

                koraci trazeni = con.koracis.Where(x => x.korakid == prvi.korakid).FirstOrDefault();
                profili pom = con.profilis.Where(x => x.username == igrac).FirstOrDefault();
                koraci pogresan = con.koracis.Where(x => x.opis == "\"napravio gresku\"").First();
                if (prvi.redbrkoraka == 0)
                {
                    MessageBox.Show("Sada stavite naocare!");
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

        private void naocare_Click(object sender, EventArgs e)
        {

            string igrac = getUser.user;

            try
            {

                koraciigraca sledeci = con.koraciigracas.OrderByDescending(x => x.redbrkoraka).FirstOrDefault();
                var pome = sledeci.redbrkoraka + 1;
                koraciigraca treci = new koraciigraca()
                {
                    username = igrac,
                    korakid = 61,
                    redbrkoraka = pome
                };
                con.koraciigracas.Add(treci);
                con.SaveChanges();
                koraci trazeni = con.koracis.Where(x => x.korakid == treci.korakid).FirstOrDefault();
                profili pom = con.profilis.Where(x => x.username == igrac).FirstOrDefault();
                koraci pogresan = con.koracis.Where(x => x.opis == "\"napravio gresku\"").First();
                if (treci.redbrkoraka >= 0)
                {
                    MessageBox.Show("Mozete poceti sa ogledom!");
                    Cursor = Cursors.Default;
                    naocare.Enabled = false;
                    naocare.Visible = false;

                    papiri.Enabled = true;
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
            }

        }

        private void papiri_Click(object sender, EventArgs e)
        {
            string igrac = getUser.user;

            sem = 1;
            this.BackgroundImage = Properties.Resources.ODLGED2papir;
            PincetaNoz.Enabled = true;

            koraciigraca sledeci = con.koraciigracas.OrderByDescending(x => x.redbrkoraka).FirstOrDefault();
            var pome = sledeci.redbrkoraka + 1;
            koraciigraca treci = new koraciigraca()
            {
                username = igrac,
                korakid = 62,
                redbrkoraka = pome
            };
            con.koraciigracas.Add(treci);
            con.SaveChanges();
            koraci trazeni = con.koracis.Where(x => x.korakid == treci.korakid).FirstOrDefault();
            profili pom = con.profilis.Where(x => x.username == igrac).FirstOrDefault();
            koraci pogresan = con.koracis.Where(x => x.opis == "\"napravio gresku\"").First();
            if (treci.redbrkoraka >= 1)
            {

                Cursor = Cursors.Hand;

                //pale se pincete
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

        private void PincetaNoz_Click(object sender, EventArgs e)
        {
            string igrac = getUser.user;
            PinceNoz.Enabled = false;
            
            
            Natrijum.Enabled = true;
            Litijum.Enabled = true;
            Kalijum.Enabled = true;
            Rubidijum.Enabled = true;
            Cezijum.Enabled = true;
            if (sem == 1)
            {
                PinceNoz.Visible = true;
                PinceNoz.Image = Properties.Resources.Pinceta;
                PinceNoz.BringToFront();
            }
            else if (sem == 2)
            {
                PinceNoz.Visible = true;
                PinceNoz.Image = Properties.Resources.Nozic;
                Supstanca.Enabled = true;
                PinceNoz.BringToFront();
            }



            koraciigraca sledeci = con.koraciigracas.OrderByDescending(x => x.redbrkoraka).FirstOrDefault();
            var pome = sledeci.redbrkoraka + 1;
            koraciigraca treci = new koraciigraca()
            {
                username = igrac,
                korakid = 63,
                redbrkoraka = pome
            };
            con.koraciigracas.Add(treci);
            con.SaveChanges();
            koraci trazeni = con.koracis.Where(x => x.korakid == treci.korakid).FirstOrDefault();
            profili pom = con.profilis.Where(x => x.username == igrac).FirstOrDefault();
            koraci pogresan = con.koracis.Where(x => x.opis == "\"napravio gresku\"").First();
            if (treci.redbrkoraka >= 2)
            {

                Cursor = Cursors.Hand;

                //pale se pincete
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

        private void Ogled2_MouseMove(object sender, MouseEventArgs e)
        {


            Point a = new Point();
            a = PointToClient(Cursor.Position);
            PinceNoz.Location = a;

        }

        private void Natrijum_Click(object sender, EventArgs e)
        {
            string igrac = getUser.user;

            Natrijum.Enabled = false;
            Litijum.Enabled = false;
            Kalijum.Enabled = false;
            Rubidijum.Enabled = false;
            Cezijum.Enabled = false;
            Supstanca.Enabled = true;
            Supstanca.Visible = true;
            Supstanca.Image = Properties.Resources.NatrijumParce;
            PinceNoz.Enabled = false;
            PinceNoz.Visible = false;
            PincetaNoz.Enabled = true;
            birac = 1;
            sem = 2;
            podiumklik = 1;



            koraciigraca sledeci = con.koraciigracas.OrderByDescending(x => x.redbrkoraka).FirstOrDefault();
            var pome = sledeci.redbrkoraka + 1;
            koraciigraca treci = new koraciigraca()
            {
                username = igrac,
                korakid = 64,
                redbrkoraka = pome
            };
            con.koraciigracas.Add(treci);
            con.SaveChanges();
            koraci trazeni = con.koracis.Where(x => x.korakid == treci.korakid).FirstOrDefault();
            profili pom = con.profilis.Where(x => x.username == igrac).FirstOrDefault();
            koraci pogresan = con.koracis.Where(x => x.opis == "\"napravio gresku\"").First();
            if (treci.redbrkoraka >= 2)
            {

                Cursor = Cursors.Default;


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

        private void Supstanca_Click(object sender, EventArgs e)
        {
            string igrac = getUser.user;

            if (podiumklik == 1)
            {
                PinceNoz.Enabled = false;
                PinceNoz.Visible = false;
                
                sem = 1;
                switch (birac)

                {
                    case 1:
                        
                        Supstanca.Image = Properties.Resources.NatrijumVeceParce;
                        

                        break;
                    case 2:
                        Supstanca.Image = Properties.Resources.LitijumVeciSec;
                        break;
                    case 3:
                        Supstanca.Image = Properties.Resources.kalijumVeceParce;
                        break;
                    case 4:
                        Supstanca.Image = Properties.Resources.RubidiumvelikoParce;
                        break;
                    case 5:
                        Supstanca.Image = Properties.Resources.CezijumVelikoParce;
                        break;
                }
            }
            else if (podiumklik == 2)
            {
                Voda.Enabled = true;
                MessageBox.Show("Pripremite rastvor pre nego nastavite rad sa supstancom.");
                

                switch (birac)
                {
                    case 1:
                        Supstanca.Image = Properties.Resources.Natrijum_Parcence;
                        break;
                    case 2:
                        Supstanca.Image = Properties.Resources.LitijumManjeParcence;
                        break;
                    case 3:
                        Supstanca.Image = Properties.Resources.KalijumParcence;
                        break;
                    case 4:
                        Supstanca.Image = Properties.Resources.RubidiumMaloParce;
                        break;
                    case 5:
                        Supstanca.Image = Properties.Resources.CezijumParcence;
                        break;
                }
            }
            else if (podiumklik == 3 && sem == 1 && fenol == 1)
            {
                Supstanca.Visible = false;
                podiumklik = 0;
                PinceNoz.Visible = true;
                PinceNoz.BringToFront();
               
                
                switch (birac)
                {
                    case 1:
                        PinceNoz.Image = Properties.Resources.Natrijum3;
                        break;
                    case 2:
                        PinceNoz.Image = Properties.Resources.Litijum3;
                        break;
                    case 3:
                        PinceNoz.Image = Properties.Resources.Kalijum3;
                        break;
                    case 4:
                        PinceNoz.Image = Properties.Resources.Rubidijum3;
                        break;
                    case 5:
                        PinceNoz.Image = Properties.Resources.Cezijum3;
                        break;
                }
            }


            koraciigraca sledeci = con.koraciigracas.OrderByDescending(x => x.redbrkoraka).FirstOrDefault();
            var pome = sledeci.redbrkoraka + 1;
            koraciigraca treci = new koraciigraca()
            {
                username = igrac,
                korakid = 67,
                redbrkoraka = pome
            };
            con.koraciigracas.Add(treci);
            con.SaveChanges();
            koraci trazeni = con.koracis.Where(x => x.korakid == treci.korakid).FirstOrDefault();
            profili pom = con.profilis.Where(x => x.username == igrac).FirstOrDefault();
            koraci pogresan = con.koracis.Where(x => x.opis == "\"napravio gresku\"").First();
            if (treci.redbrkoraka >= 2)
            {

                Cursor = Cursors.Hand;
                if (podiumklik < 3)
                    podiumklik++;

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

        private void Voda_Click(object sender, EventArgs e)
        {
            string igrac = getUser.user;
            Supstanca.Enabled = true;
            Vodica.Visible = true;
            Vodica.Image = Properties.Resources.water_glass_PNG15229;
            Vodica.Enabled = true;
            Fenol.Enabled = true;
            podiumklik = 3;

            koraciigraca sledeci = con.koraciigracas.OrderByDescending(x => x.redbrkoraka).FirstOrDefault();
            var pome = sledeci.redbrkoraka + 1;
            koraciigraca treci = new koraciigraca()
            {
                username = igrac,
                korakid = 69,
                redbrkoraka = pome
            };
            con.koraciigracas.Add(treci);
            con.SaveChanges();
            koraci trazeni = con.koracis.Where(x => x.korakid == treci.korakid).FirstOrDefault();
            profili pom = con.profilis.Where(x => x.username == igrac).FirstOrDefault();
            koraci pogresan = con.koracis.Where(x => x.opis == "\"napravio gresku\"").First();
            if (treci.redbrkoraka >= 2)
            {

                Cursor = Cursors.Hand;

                MessageBox.Show("Ne zaboravi fenolftalein!");
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

        private void Fenol_Click(object sender, EventArgs e)
        {
            string igrac = getUser.user;

            fenol = 1;
            koraciigraca sledeci = con.koraciigracas.OrderByDescending(x => x.redbrkoraka).FirstOrDefault();
            var pome = sledeci.redbrkoraka + 1;
            koraciigraca treci = new koraciigraca()
            {
                username = igrac,
                korakid = 70,
                redbrkoraka = pome
            };
            con.koraciigracas.Add(treci);
            con.SaveChanges();
            koraci trazeni = con.koracis.Where(x => x.korakid == treci.korakid).FirstOrDefault();
            profili pom = con.profilis.Where(x => x.username == igrac).FirstOrDefault();
            koraci pogresan = con.koracis.Where(x => x.opis == "\"napravio gresku\"").First();
            if (treci.redbrkoraka >= 5)
            {

                Cursor = Cursors.Hand;

                MessageBox.Show("Sada mozes staviti supstancu u vodu ,ali sa pincetom, ne rukom! ");
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

        private void Vodica_Click(object sender, EventArgs e)
        {
            string igrac = getUser.user;
            Staklo.Enabled = true;
            PinceNoz.Visible = false;
            PinceNoz.Enabled = false;
            fenol = 0;
            koraciigraca sledeci = con.koraciigracas.OrderByDescending(x => x.redbrkoraka).FirstOrDefault();
            var pome = sledeci.redbrkoraka + 1;
            koraciigraca treci = new koraciigraca()
            {
                username = igrac,
                korakid = 72,
                redbrkoraka = pome
            };
            con.koraciigracas.Add(treci);
            con.SaveChanges();
            koraci trazeni = con.koracis.Where(x => x.korakid == treci.korakid).FirstOrDefault();
            profili pom = con.profilis.Where(x => x.username == igrac).FirstOrDefault();
            koraci pogresan = con.koracis.Where(x => x.opis == "\"napravio gresku\"").First();
            if (treci.redbrkoraka >= 5)
            {

                Cursor = Cursors.Hand;

                MessageBox.Show("Brzo, prekrij casu sa sahatnim staklom!");
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

        public void Staklo_Click(object sender, EventArgs e)
        {
            
            string igrac = getUser.user;
            Staklo.Location = new Point(510, 346);
            this.BackgroundImage = Properties.Resources.OGLEDsaFlenolom;
           


            switch (birac)

            {
                case 1:
                    Gif.Image = Properties.Resources.dimce;
                    Vodica.Image = Properties.Resources.reakcija;
                    Gif.BringToFront();
                    break;
                case 2:
                    Gif.Image = Properties.Resources.dimce;
                    Vodica.Image = Properties.Resources.bubbles;
                    
                    Gif.BringToFront();
                    break;
                case 3:
                    Gif.Image = Properties.Resources.dimce;
                    Vodica.Image = Properties.Resources.vatricii;
                    Gif.BringToFront();
                    break;
                case 4:
                    Gif.Image = Properties.Resources.dimce;
                    Vodica.Image = Properties.Resources.Eksplozija;
                    timer1.Enabled = true;
                    
                    Gif.BringToFront();
                    break;
                case 5:
                    Gif.Image = Properties.Resources.dimce;
                    Vodica.Image = Properties.Resources.Eksplozija;
                    timer1.Enabled = true;
                    Gif.BringToFront();

                    break;
            }

            Staklo.BringToFront();

            koraciigraca sledeci = con.koraciigracas.OrderByDescending(x => x.redbrkoraka).FirstOrDefault();
            var pome = sledeci.redbrkoraka + 1;
            koraciigraca treci = new koraciigraca()
            {
                username = igrac,
                korakid = 75,
                redbrkoraka = pome
            };
            con.koraciigracas.Add(treci);
            con.SaveChanges();
            koraci trazeni = con.koracis.Where(x => x.korakid == treci.korakid).FirstOrDefault();
            profili pom = con.profilis.Where(x => x.username == igrac).FirstOrDefault();
            koraci pogresan = con.koracis.Where(x => x.opis == "\"napravio gresku\"").First();
            if (treci.redbrkoraka >= 5)
            {

                Cursor = Cursors.Hand;


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
    
        

        private void RESET()
        {
            this.BackgroundImage = Properties.Resources.ODLGED2;
            Natrijum.Enabled = false;
            Litijum.Enabled = false;
            Kalijum.Enabled = false;
            Rubidijum.Enabled = false;
            Cezijum.Enabled = false;
            sem = 0;
            birac = 0;
            podiumklik = 0;
            fenol = 0;
            timer1.Enabled = false;
            Vodica.Visible = false;
            Voda.Enabled = false;
            Fenol.Enabled = false;
            PinceNoz.Image = null;
            PinceNoz.Visible = false;
            
            Staklo.Location=new Point(741, 397);
            Gif.Visible = false;
            papiri.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Doslo je do eksplozije. Nije strasno, pokusajte sa nekom drugom supstancom.");
            RESET();
            
        }

        private void Kanta_Click(object sender, EventArgs e)
        {
            RESET();
        }

        private void Litijum_Click(object sender, EventArgs e)
        {
            string igrac = getUser.user;

            
            Natrijum.Enabled = false;
            Litijum.Enabled = false;
            Kalijum.Enabled = false;
            Rubidijum.Enabled = false;
            Cezijum.Enabled = false;
            Supstanca.Enabled = true;
            Supstanca.Visible = true;
            Supstanca.Image = Properties.Resources.ParceLitijuma;
            PinceNoz.Enabled = false;
            PinceNoz.Visible = false;
            PincetaNoz.Enabled = true;
            birac = 2;
            sem = 2;
            podiumklik = 1;



            koraciigraca sledeci = con.koraciigracas.OrderByDescending(x => x.redbrkoraka).FirstOrDefault();
            var pome = sledeci.redbrkoraka + 1;
            koraciigraca treci = new koraciigraca()
            {
                username = igrac,
                korakid = 64,
                redbrkoraka = pome
            };
            con.koraciigracas.Add(treci);
            con.SaveChanges();
            koraci trazeni = con.koracis.Where(x => x.korakid == treci.korakid).FirstOrDefault();
            profili pom = con.profilis.Where(x => x.username == igrac).FirstOrDefault();
            koraci pogresan = con.koracis.Where(x => x.opis == "\"napravio gresku\"").First();
            if (treci.redbrkoraka >= 2)
            {

                Cursor = Cursors.Default;


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

        private void Kalijum_Click(object sender, EventArgs e)
        {
            string igrac = getUser.user;

            Natrijum.Enabled = false;
            Litijum.Enabled = false;
            Kalijum.Enabled = false;
            Rubidijum.Enabled = false;
            Cezijum.Enabled = false;
            Supstanca.Enabled = true;
            Supstanca.Visible = true;
            Supstanca.Image = Properties.Resources.soda_feldspar;
            PinceNoz.Enabled = false;
            PinceNoz.Visible = false;
            PincetaNoz.Enabled = true;
            birac = 3;
            sem = 2;
            podiumklik = 1;



            koraciigraca sledeci = con.koraciigracas.OrderByDescending(x => x.redbrkoraka).FirstOrDefault();
            var pome = sledeci.redbrkoraka + 1;
            koraciigraca treci = new koraciigraca()
            {
                username = igrac,
                korakid = 64,
                redbrkoraka = pome
            };
            con.koraciigracas.Add(treci);
            con.SaveChanges();
            koraci trazeni = con.koracis.Where(x => x.korakid == treci.korakid).FirstOrDefault();
            profili pom = con.profilis.Where(x => x.username == igrac).FirstOrDefault();
            koraci pogresan = con.koracis.Where(x => x.opis == "\"napravio gresku\"").First();
            if (treci.redbrkoraka >= 2)
            {

                Cursor = Cursors.Default;


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

        private void Rubidijum_Click(object sender, EventArgs e)
        {
            string igrac = getUser.user;

            Natrijum.Enabled = false;
            Litijum.Enabled = false;
            Kalijum.Enabled = false;
            Rubidijum.Enabled = false;
            Cezijum.Enabled = false;
            Supstanca.Enabled = true;
            Supstanca.Visible = true;
            Supstanca.Image = Properties.Resources.Rubidium;
            PinceNoz.Enabled = false;
            PinceNoz.Visible = false;
            PincetaNoz.Enabled = true;
            birac = 4;
            sem = 2;
            podiumklik = 1;



            koraciigraca sledeci = con.koraciigracas.OrderByDescending(x => x.redbrkoraka).FirstOrDefault();
            var pome = sledeci.redbrkoraka + 1;
            koraciigraca treci = new koraciigraca()
            {
                username = igrac,
                korakid = 64,
                redbrkoraka = pome
            };
            con.koraciigracas.Add(treci);
            con.SaveChanges();
            koraci trazeni = con.koracis.Where(x => x.korakid == treci.korakid).FirstOrDefault();
            profili pom = con.profilis.Where(x => x.username == igrac).FirstOrDefault();
            koraci pogresan = con.koracis.Where(x => x.opis == "\"napravio gresku\"").First();
            if (treci.redbrkoraka >= 2)
            {

                Cursor = Cursors.Default;


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

        private void Cezijum_Click(object sender, EventArgs e)
        {
            string igrac = getUser.user;

            Natrijum.Enabled = false;
            Litijum.Enabled = false;
            Kalijum.Enabled = false;
            Rubidijum.Enabled = false;
            Cezijum.Enabled = false;
            Supstanca.Enabled = true;
            Supstanca.Visible = true;
            Supstanca.Image = Properties.Resources.CezijumParce;
            PinceNoz.Enabled = false;
            PinceNoz.Visible = false;
            PincetaNoz.Enabled = true;
            birac = 5;
            sem = 2;
            podiumklik = 1;



            koraciigraca sledeci = con.koraciigracas.OrderByDescending(x => x.redbrkoraka).FirstOrDefault();
            var pome = sledeci.redbrkoraka + 1;
            koraciigraca treci = new koraciigraca()
            {
                username = igrac,
                korakid = 64,
                redbrkoraka = pome
            };
            con.koraciigracas.Add(treci);
            con.SaveChanges();
            koraci trazeni = con.koracis.Where(x => x.korakid == treci.korakid).FirstOrDefault();
            profili pom = con.profilis.Where(x => x.username == igrac).FirstOrDefault();
            koraci pogresan = con.koracis.Where(x => x.opis == "\"napravio gresku\"").First();
            if (treci.redbrkoraka >= 2)
            {

                Cursor = Cursors.Default;


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
    }
}
    
    
   
    
    
    

