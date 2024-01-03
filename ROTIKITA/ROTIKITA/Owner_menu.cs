﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROTIKITA
{
    public partial class Owner_menu : Form
    {
        public Owner_menu()
        {
            InitializeComponent();
        }

        private void btn_pegawai_Click(object sender, EventArgs e)
        {
            Hide();
            Owner_register owner_Register = new Owner_register();
            owner_Register.ShowDialog();
            Show();
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            Hide();
            Owner_report owner_Report = new Owner_report();
            owner_Report.ShowDialog();
            Show();

        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            Hide();
            FormHistory owner_History = new FormHistory();
            owner_History.ShowDialog();
            Show();
        }
    }
}