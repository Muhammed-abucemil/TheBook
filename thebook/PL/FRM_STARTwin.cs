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
    public partial class FRM_STARTwin : Form
    {
        DAL.CLS_DAL DAL = new DAL.CLS_DAL();
        public FRM_STARTwin()
        {
            InitializeComponent();
            DAL.open();
            DAL.close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PL.FRM_LOGIN Login = new FRM_LOGIN();
            Login.Show();
            timer1.Stop();
            this.Hide();
            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
