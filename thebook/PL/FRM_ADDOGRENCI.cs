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
    public partial class FRM_ADDOGRENCI : Form
    {
        public int ID;
        public FRM_ADDOGRENCI()
        {
            InitializeComponent();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_ADDOGRENCI_Load(object sender, EventArgs e)
        {

        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            
            if (txtOgrenciNO.Text == "" || txtOgrenciAd.Text == "" || txtOgrenciSoyad.Text == ""
                || txtOgrenciTel.Text == ""|| txtOgrenciTarih.Text == "" || txtBolum.Text=="")
            {
                PL.FRM_ERRORINSERT Ferror = new FRM_ERRORINSERT();
                Ferror.Show();
            }
            else
            {
                if (ID == 0)
                {
                    /// add
                    BL.CLC_OGRENCI BLOGRENCI = new BL.CLC_OGRENCI();

                    
                    BLOGRENCI.Insert(Convert.ToInt32(txtOgrenciNO.Text) ,txtOgrenciAd.Text.Trim(), txtOgrenciSoyad.Text.Trim(), txtOgrenciTel.Text.Trim(), txtOgrenciTarih.Text.Trim(),txtBolum.Text.Trim());
                    PL.FRM_DADD Fadd = new FRM_DADD();
                    Fadd.Show();
                    this.Close();
                }
                else
                {
                    /// edit
                    BL.CLC_OGRENCI BLOGRENCI = new BL.CLC_OGRENCI();
                    BLOGRENCI.Update(txtOgrenciAd.Text.Trim(), txtOgrenciSoyad.Text.Trim(), txtOgrenciTel.Text.Trim(),txtBolum.Text.Trim(), ID);
                    PL.FRM_DEDIT Fedit = new FRM_DEDIT();
                    Fedit.Show();
                    this.Close();
                }

            }
        }
    }
}
