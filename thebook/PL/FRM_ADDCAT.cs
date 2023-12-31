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
    public partial class FRM_ADDCAT : Form
    {
        public int ID;
        public FRM_ADDCAT()
        {
            InitializeComponent();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lb_Title_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtKategoriName.Text == "")
            {
                PL.FRM_ERRORINSERT Ferror = new FRM_ERRORINSERT();
                Ferror.Show();
            }
            else
            {
                if (ID == 0)
                {
                    /// add
                    BL.CLC_CAT BLCAT = new BL.CLC_CAT();
                    BLCAT.Insert(txtKategoriName.Text.Trim(), txtKategoriAyrinti.Text.Trim());
                    PL.FRM_DADD Fadd = new FRM_DADD();
                    Fadd.Show();
                    this.Close();
                }
                else
                {
                    /// edit
                    BL.CLC_CAT BLCAT = new BL.CLC_CAT();
                    BLCAT.Update(txtKategoriName.Text.Trim(), txtKategoriAyrinti.Text.Trim(),ID);
                    PL.FRM_DEDIT Fedit = new FRM_DEDIT();
                    Fedit.Show();
                    this.Close();
                }
                
            }
            

        }
    }
}
