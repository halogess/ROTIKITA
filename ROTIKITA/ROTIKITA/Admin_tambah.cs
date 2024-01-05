using ROTIKITA.Controller;
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
    public partial class Admin_tambah : Form
    {
        public Admin_tambah()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }


        private void loadListJenisRoti()
        {
            jenisRotiGriwView.DataSource = RotiHandler.GetAllJenisRotiActive();
        }
        private void loadListRoti()
        {
            listRotiGridView.DataSource = RotiHandler.GetAllRoti();
            listRotiGridView.Columns["Expiration"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private void FormTambahRoti_Load(object sender, EventArgs e)
        {
            loadListJenisRoti();
            loadListRoti();
        }

        private void addRotiButton_Click(object sender, EventArgs e)
        {
            string kodeJenis = labelJenisRotiValue.Text;
            int quantity = 0;
            try
            {
                quantity = int.Parse(qtyNumericUpDown.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Quantity harus angka");
                return;
            }
            RotiHandler.AddRoti(kodeJenis, quantity);
            clear();
            loadListRoti();
        }


        private void jenisRotiGriwView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.jenisRotiGriwView.Rows[e.RowIndex];
                string kodeJenis = row.Cells["JenisCode"].Value.ToString();
                RotiHandler.currentKodeJenisRoti = kodeJenis;
                labelJenisRotiValue.Text = kodeJenis;
                loadListJenisRoti();
                AddMode();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RotiHandler.DeleteAllRoti();
        }

        private void listRotiGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                labelJenisRotiValue.Text = listRotiGridView.Rows[e.RowIndex].Cells["JenisCode"].Value.ToString();
                labelKodeRotiValue.Text = listRotiGridView.Rows[e.RowIndex].Cells["KodeRoti"].Value.ToString();
                qtyNumericUpDown.Value = int.Parse(listRotiGridView.Rows[e.RowIndex].Cells["Quantity"].Value.ToString());
                EditMode();
            }
        }
        private void EditMode()
        {
            addRotiButton.Enabled = false;
            editRotiButton.Enabled = true;
        }

        private void AddMode()
        {
            addRotiButton.Enabled = true;
            editRotiButton.Enabled = false;
        }
        private void clear()
        {
            labelJenisRotiValue.Text = "";
            labelKodeRotiValue.Text = "";
            qtyNumericUpDown.Value = 0;
            AddMode();
        }

        private void editRotiButton_Click(object sender, EventArgs e)
        {
            string kodeRoti = labelKodeRotiValue.Text;
            int quantity = 0;
            try
            {
                quantity = int.Parse(qtyNumericUpDown.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Quantity harus angka");
                return;
            }
            RotiHandler.EditRoti(labelKodeRotiValue.Text, quantity);
            clear();
            loadListRoti();
        }
    }
}
