using ROTIKITA.Contracts;
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
    public partial class Kasir_transaksi : Form
    {
        public Kasir_transaksi()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void LoadListRoti()
        {
            listRotiGridView.DataSource = RotiHandler.GetAllRotiInCart();
            listRotiGridView.Columns["Expiration"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }
        private void loadCart()
        {
            keranjangDataGridView.Columns["KodeRoti"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            keranjangDataGridView.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            keranjangDataGridView.Columns["Expiration"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }
        private void reloadCart()
        {

        }

        private void FormTransaksi_Load(object sender, EventArgs e)
        {
            LoadListRoti();
            loadCart();
        }

        private void listRotiGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.listRotiGridView.Rows[e.RowIndex];
                string kodeRoti = row.Cells["Kode"].Value.ToString();
                string namaRoti = row.Cells["Name"].Value.ToString();
                string expired = row.Cells["Expiration"].Value.ToString();
                string stock = row.Cells["Quantity"].Value.ToString();
                string hargaRoti = row.Cells["Price"].Value.ToString();

                kodeRotiLabel.Text = kodeRoti;
                namaJenisRoti.Text = namaRoti;
                tanggalExpiredLabel.Text = expired;
                qtyNumericUpDown.Value = 0;
                qtyNumericUpDown.Maximum = int.Parse(stock);
                hargaLabel.Text = hargaRoti;
            }
        }
        private void addToCartButton_Click(object sender, EventArgs e)
        {
            string kode_roti = kodeRotiLabel.Text;
            string jenis_roti = namaJenisRoti.Text;
            string tanggal_expired = tanggalExpiredLabel.Text;
            int quantity_label = int.Parse(qtyNumericUpDown.Value.ToString());
            string harga_label = hargaLabel.Text;

            if (!ValidateInput(kode_roti, jenis_roti, tanggal_expired, harga_label, quantity_label))
            {
                return;
            }

            if (!UpdateCartIfItemExists(kode_roti, quantity_label))
            {
                AddNewItemToCart(kode_roti, jenis_roti, harga_label, quantity_label, tanggal_expired);
            }
            int diskonValue = RotiHandler.CekDiskon(kode_roti);
            if (diskonValue != 0)
            {
                bool exists = false;
                for (int i = 0; i < diskonDataGridView.Rows.Count; i++)
                {
                    DataGridViewRow item = diskonDataGridView.Rows[i];
                    if (item.Cells[0].Value.ToString().Equals(kode_roti))
                    {
                        diskonDataGridView.Rows[i].Cells[3].Value = int.Parse(item.Cells[3].Value.ToString()) + quantity_label;
                        diskonDataGridView.Rows[i].Cells[4].Value = diskonValue * int.Parse(diskonDataGridView.Rows[i].Cells[3].Value.ToString());
                        exists = true;
                    }
                }

                if (!exists)
                {
                    diskonDataGridView.Rows.Add(kode_roti, jenis_roti, diskonValue, quantity_label, diskonValue * quantity_label);
                }
            }
            UpdateCartSummary();
        }

        private bool ValidateInput(string kode_roti, string jenis_roti, string tanggal_expired, string harga_label, int quantity_label)
        {
            if (kode_roti == "" || jenis_roti == "" || tanggal_expired == "" || harga_label == "")
            {
                MessageBox.Show("Belum Memilih Roti");
                return false;
            }
            else if (quantity_label == 0)
            {
                MessageBox.Show("Quantity tidak boleh 0");
                return false;
            }
            else if (quantity_label > qtyNumericUpDown.Maximum)
            {
                MessageBox.Show("Quantity melebihi stock");
                return false;
            }
            return true;
        }

        private bool UpdateCartIfItemExists(string kode_roti, int quantity_label)
        {
            foreach (DataGridViewRow item in keranjangDataGridView.Rows)
            {
                if (item.Cells[0].Value.ToString().Equals(kode_roti))
                {
                    UpdateItemQuantityIfValid(item, kode_roti, quantity_label);
                    return true;
                }
            }
            return false;
        }

        private void UpdateItemQuantityIfValid(DataGridViewRow item, string kode_roti, int quantity_label)
        {
            string currentQty = item.Cells[3].Value.ToString();
            int currentQtyInt = int.Parse(currentQty) + quantity_label;
            if (IsQuantityValid(kode_roti, currentQtyInt))
            {
                item.Cells[3].Value = currentQtyInt;
                float harga = float.Parse(item.Cells[2].Value.ToString());
                item.Cells[5].Value = harga * currentQtyInt;
            }
            else
            {
                MessageBox.Show("Permintaan Melebihi Stok");
            }
        }

        private bool IsQuantityValid(string kode_roti, int currentQtyInt)
        {
            foreach (DataGridViewRow item in listRotiGridView.Rows)
            {
                if (item.Cells[0].Value.ToString().Equals(kode_roti))
                {
                    return int.Parse(item.Cells[3].Value.ToString()) >= currentQtyInt;
                }
            }
            return false;
        }

        private void AddNewItemToCart(string kode_roti, string jenis_roti, string harga_label, int quantity_label, string tanggal_expired)
        {
            float harga = float.Parse(harga_label);
            keranjangDataGridView.Rows.Add(kode_roti, jenis_roti, harga_label, quantity_label, tanggal_expired, quantity_label * harga);
        }

        private void UpdateCartSummary()
        {
            float totalHarga = 0;
            int jumlahItem = 0;
            foreach (DataGridViewRow item in keranjangDataGridView.Rows)
            {
                jumlahItem++;
                totalHarga += float.Parse(item.Cells[5].Value.ToString());
            }
            int totalDiskon = 0;
            foreach (DataGridViewRow item in diskonDataGridView.Rows)
            {
                //string kode = item.Cells[0].Value.ToString();
                //string namaRoti = item.Cells[1].Value.ToString();
                //int potonganPerQty = int.Parse(item.Cells[2].Value.ToString());
                //int quantity = int.Parse(item.Cells[3].Value.ToString());
                totalDiskon += int.Parse(item.Cells[4].Value.ToString());
                //diskonList.Add(new DiskonItemVo(kode, namaRoti, potonganPerQty, quantity, totalDiskon));
            }
            jumlahItemLabel.Text = jumlahItem.ToString();
            totalHargaLabel.Text = (totalHarga - totalDiskon).ToString();
        }

        private void butButton_Click(object sender, EventArgs e)
        {
            List<BuyRotiItemVo> cartList = new List<BuyRotiItemVo>();
            List<DiskonItemVo> diskonList = new List<DiskonItemVo>();
            foreach (DataGridViewRow item in keranjangDataGridView.Rows)
            {
                string kode = item.Cells[0].Value.ToString();
                string nama = item.Cells[1].Value.ToString();
                int harga = int.Parse(item.Cells[2].Value.ToString());
                int quantity = int.Parse(item.Cells[3].Value.ToString());
                int subtotal = int.Parse(item.Cells[5].Value.ToString());
                cartList.Add(new BuyRotiItemVo(kode, nama, harga, quantity, subtotal));
            }
            int totalHarga = int.Parse(totalHargaLabel.Text);
            RotiHandler.BuyRoti(cartList, totalHarga);
            keranjangDataGridView.Rows.Clear();
            diskonDataGridView.Rows.Clear();
            LoadListRoti();
        }
    }

}

