﻿using System;
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
    public partial class FRM_ADDYAYINEV : Form
    {
        public int ID;
        public FRM_ADDYAYINEV()
        {
            InitializeComponent();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            if (txtYayinEvAd.Text == "" || txtYayinEvTel.Text == "" || txtYayinEvAdres.Text == "")
            {
                PL.FRM_ERRORINSERT Ferror = new FRM_ERRORINSERT();
                Ferror.Show();
            }
            else
            {
                if (ID == 0)
                {
                    /// add
                    BL.CLC_YAYINEV BLYAYINEV = new BL.CLC_YAYINEV();
                    BLYAYINEV.Insert(txtYayinEvAd.Text.Trim(), txtYayinEvAdres.Text.Trim(), txtYayinEvTel.Text.Trim());
                    PL.FRM_DADD Fadd = new FRM_DADD();
                    Fadd.Show();
                    this.Close();
                }
                else
                {
                    /// edit
                    BL.CLC_YAYINEV BLYAYINEV = new BL.CLC_YAYINEV();
                    BLYAYINEV.Update(txtYayinEvAd.Text.Trim(), txtYayinEvAdres.Text.Trim(), txtYayinEvTel.Text.Trim(), ID);
                    PL.FRM_DEDIT Fedit = new FRM_DEDIT();
                    Fedit.Show();
                    this.Close();
                }

            }
        }

        private void FRM_ADDYAYINEV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thebookDataSet.kategori' table. You can move, or remove it, as needed.
            

        }
    }
}
