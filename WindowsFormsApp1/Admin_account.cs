﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Admin_account : UserControl
    {
        private static Admin_account _instance;
        public static Admin_account Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Admin_account();
                return _instance;
            }
        }

        public Admin_account()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
