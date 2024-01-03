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
    public partial class FormLogin : Form
    {
        private db_rotiEntities db = DatabaseService.GetDbContext();
        public FormLogin()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (TBUserID.Text == "Owner" && TBPassword.Text == "Owner")
            {
                UserHandler.user_ID = "OWNER";
                UserHandler.nama = "Owner";
                UserHandler.user_ID = "OWNER00000";
                UserHandler.role = "Owner";
                //MainForm mainForm = new MainForm("Owner");
                //mainForm.ShowDialog();
            }
            else
            {
                if (!UserHandler.LoginHandler(TBUserID.Text, TBPassword.Text))
                {
                    MessageBox.Show("Salah Login");
                }
                else
                {
                    //MainForm mainForm = new MainForm(UserHandler.role, UserHandler.nama);
                    //mainForm.ShowDialog();
                }
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }

}
