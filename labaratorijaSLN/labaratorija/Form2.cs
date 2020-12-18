using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;
using Spire.Pdf.Annotations;
using Spire.Pdf.Widget;
using Spire.Pdf;

namespace labaratorija
{

    public partial class Form2 : Form
    {

      
        public Form2()
        {
            InitializeComponent();

            Bodovi.broj = 0;
        }

        private void oGLED1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ogled1 o = new Ogled1();
            Naslov.Location = new Point(287, 28);
            Naslov.Text = "Obojenje plamena jonima zemnoalkalnih metala";
            Naslov.Invalidate();
            Naslov.Visible = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(o);

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Da li ste zavrsili?", "Ako ste zavrsili sa ogledima, molimo ugasite vatru! :)", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Samo nastavite!");
            }

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void bodovibox_OnValueChanged(object sender, EventArgs e)
        {

        }
        public string ID2
        {
            set { bodovibox.Text = value.ToString(); }
        }

        private void oGLED2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ogled2 r = new Ogled2();
            Naslov.Location = new Point(341, 28);

            Naslov.Text = "Dejstvo vode na alkalne metale";
            Naslov.Invalidate();

            Naslov.Visible = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(r);
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (Naslov.Text == "Obojenje plamena jonima zemnoalkalnih metala")
            {

                PdfDocument doc = new PdfDocument();
               
                doc.LoadFromFile("Obojenje plamena jonima zemnoalkalnih metala.pdf");
                doc.Print();
            }
            else if (Naslov.Text == "Dejstvo vode na alkalne metale")
            {
                PdfDocument doc = new PdfDocument();

                doc.LoadFromFile("Dejstvo vode na alkalne metale.pdf");
                doc.Print();

            }
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            if ((Naslov.Visible) == true && (Naslov.Text == "Obojenje plamena jonima zemnoalkalnih metala"))
            {
                Praktikum novi = new Praktikum();
                novi.ShowDialog();
                Show();

            }
            else if ((Naslov.Visible) == true && (Naslov.Text == "Dejstvo vode na alkalne metale"))
            {
                Praktikum2 novi = new Praktikum2();
                novi.ShowDialog();
                Show();
            }
            else MessageBox.Show("Prvo odaberite jedan od ponudjena dva ogleda, pre nego opet zatrazite pomoc.");
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
    


