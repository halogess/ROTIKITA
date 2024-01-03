﻿using ROTIKITA.Contracts;
using ROTIKITA.Controller;
using ROTIKITA.Services;
using System;
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
    public partial class Owner_register : Form
    {
        public Owner_register()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            loadListUser();
        }

        private db_rotiEntities db = DatabaseService.GetDbContext();


        private void loadListUser()
        {
            listPegawaiView.DataSource = UserHandler.GetAllUsersVisible();
        }
        private void menuDaftarRotiButton_Click(object sender, EventArgs e)
        {
            string namaPegawai = TBNamaPegawai.Text;
            string password = TBPassPegawai.Text;
            string role = "";
            if (kasirRadioButton.Checked)
            {
                role = UserRole.KASIR;
            }
            else if (adminRadioButton.Checked)
            {
                role = UserRole.ADMIN;
            }
            UserHandler.AddUser(namaPegawai, password, role);
            loadListUser();
        }
    }
}
