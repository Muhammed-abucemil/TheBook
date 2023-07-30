using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thebook.PL
{
    public partial class FRM_AYRINTILAR : Form
    {
        public FRM_AYRINTILAR()
        {
            InitializeComponent();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yazadir_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void yazadirmaGozleme_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void yazdirmaAyarlari_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // yadırma işlemi 
            Bitmap image = new Bitmap(panel_Yazdirma_Sayfa.Width,panel_Yazdirma_Sayfa.Height);
            panel_Yazdirma_Sayfa.DrawToBitmap(image,new Rectangle(Point.Empty,panel_Yazdirma_Sayfa.Size));
            e.Graphics.DrawImage(image, 0, 0);
        }

        private void FRM_AYRINTILAR_Load(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            rapor_tarihi.Text = date.ToString("dd/MM/yyyy");


        }

        private void panel_Yazdirma_Sayfa_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
