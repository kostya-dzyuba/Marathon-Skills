﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marathon_Skills.Forms
{
    public partial class SponsorConfirmForm : Form
    {
        public SponsorConfirmForm()
        {
            InitializeComponent();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            Program.MoveToForm<SponsorForm>(this);
        }
    }
}
