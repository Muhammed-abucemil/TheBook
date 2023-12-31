﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace thebook.PL
{
    public partial class FRM_ADDYAZAR : Form
    {
        public int ID;
        public FRM_ADDYAZAR()
        {
            InitializeComponent();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYazar_Click(object sender, EventArgs e)
        {
            if (txtYazarAd.Text == "" || txtYazarTel.Text == "")
            {
                PL.FRM_ERRORINSERT Ferror = new FRM_ERRORINSERT();
                Ferror.Show();
            }
            else
            {
                if (ID == 0)
                {
                    /// add
                    BL.CLC_YAZAR BLYAZAR = new BL.CLC_YAZAR();
                    BLYAZAR.Insert(txtYazarAd.Text.Trim(), txtYazarEmail.Text.Trim(), txtYazarTel.Text.Trim(), txtYazarAdres.Text.Trim());
                    PL.FRM_DADD Fadd = new FRM_DADD();
                    Fadd.Show();
                    this.Close();
                }
                else
                {
                    /// edit
                    BL.CLC_YAZAR BLYAZAR = new BL.CLC_YAZAR();
                    BLYAZAR.Update(txtYazarAd.Text.Trim(), txtYazarEmail.Text.Trim(), txtYazarTel.Text.Trim(), txtYazarAdres.Text.Trim(), ID);
                    PL.FRM_DEDIT Fedit = new FRM_DEDIT();
                    Fedit.Show();
                    this.Close();
                }

            }
        }
    }
}
