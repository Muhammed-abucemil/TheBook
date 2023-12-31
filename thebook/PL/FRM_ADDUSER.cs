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
    public partial class FRM_ADDUSER : Form
    {
        public int ID;
        public FRM_ADDUSER()
        {
            InitializeComponent();
        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            if (txtUserAd.Text == "" || txtUserSoyad.Text == "" || txtUserSifre.Text == "" || txtUserYetki.Text == "" || txtUserTel.Text == "")
            {
                PL.FRM_ERRORINSERT Ferror = new FRM_ERRORINSERT();
                Ferror.Show();
            }
            else
            {
                if (ID == 0)
                {
                    /// add
                    BL.CLC_USER BLUSER = new BL.CLC_USER();
                    BLUSER.Insert(txtUserAd.Text.Trim(), txtUserSoyad.Text.Trim(), txtUserEmail.Text.Trim(), txtUserTel.Text.Trim(), txtUserAdres.Text.Trim(), txtUserYetki.Text.Trim(), txtUserSifre.Text.Trim());
                    PL.FRM_DADD Fadd = new FRM_DADD();
                    Fadd.Show();
                    this.Close();
                }
                else
                {
                    /// edit
                    BL.CLC_USER BLUSER = new BL.CLC_USER();
                    BLUSER.Update(txtUserAd.Text.Trim(), txtUserSoyad.Text.Trim(), txtUserEmail.Text.Trim(), txtUserTel.Text.Trim(), txtUserAdres.Text.Trim(), txtUserYetki.Text.Trim(), ID);
                    PL.FRM_DEDIT Fedit = new FRM_DEDIT();
                    Fedit.Show();
                    this.Close();
                }

            }
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
