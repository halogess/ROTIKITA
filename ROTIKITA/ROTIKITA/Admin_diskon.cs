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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ROTIKITA
{
    public partial class Admin_diskon : Form
    {
        db_rotiEntities db = DatabaseService.GetDbContext();
        diskon selectedDiskon;
        DataGridViewRow row;
        public Admin_diskon()
        {
            InitializeComponent();
            resetEditDiskon();
        }

        private void dgv_roti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormDiskon_Load(object sender, EventArgs e)
        {

            load_DgvRoti();
            load_DgvDiskon();

        }

        public void load_DgvRoti()
        {
            dgv_roti.Columns.Clear();
            dgv_roti.Columns.Add(new DataGridViewCheckBoxColumn());
            var rdiskon = (from d in db.diskons
                           where d.tanggal_selesai > DateTime.Now
                           select d.kode_roti).ToList();

            dgv_roti.DataSource = (from p in db.rotis
                                   join j in db.jenis_roti on p.kode_jenis equals j.kode_jenis
                                   where !rdiskon.Contains(p.kode_roti)
                                   select new
                                   {
                                       Kode_Produksi = p.kode_roti,
                                       Nama_Roti = j.nama,
                                       Stok = p.qty,
                                       Harga = j.harga,
                                       Tanggal_Produksi = p.created_at,
                                       Tanggal_Exp = p.expired_at

                                   }).ToList();

            dgv_roti.AutoResizeColumn(0, DataGridViewAutoSizeColumnMode.AllCells);
            dgv_roti.AutoResizeColumn(3, DataGridViewAutoSizeColumnMode.AllCells);
            dgv_roti.AutoResizeColumn(4, DataGridViewAutoSizeColumnMode.AllCells);

            dgv_roti.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_roti.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_roti.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_roti.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        public void load_DgvDiskon()
        {
            dgv_diskon.Columns.Clear();
            dgv_diskon.DataSource = (from d in db.diskons
                                     join r in db.rotis on d.kode_roti equals r.kode_roti
                                     join j in db.jenis_roti on r.kode_jenis equals j.kode_jenis
                                     where d.tanggal_selesai > DateTime.Now
                                     select new
                                     {
                                         Kode_Diskon = d.kode_diskon,
                                         Diskon = d.nama,
                                         Keterangan = d.keterangan,
                                         Kode_Produksi = d.kode_roti,
                                         Nama_Roti = j.nama,
                                         Stok = r.qty,
                                         Sebelum_Diskon = d.harga_before,
                                         Setelah_Diskon = d.harga_after,
                                         Mulai = d.tanggal_mulai,
                                         Selesai = d.tanggal_selesai,
                                     }).ToList();

            dgv_diskon.AutoResizeColumn(0, DataGridViewAutoSizeColumnMode.AllCells);
            dgv_diskon.AutoResizeColumn(1, DataGridViewAutoSizeColumnMode.AllCells);
            dgv_diskon.AutoResizeColumn(3, DataGridViewAutoSizeColumnMode.AllCells);
            dgv_diskon.AutoResizeColumn(5, DataGridViewAutoSizeColumnMode.AllCells);
            dgv_diskon.AutoResizeColumn(6, DataGridViewAutoSizeColumnMode.AllCells);
            dgv_diskon.AutoResizeColumn(7, DataGridViewAutoSizeColumnMode.AllCells);

            dgv_diskon.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_diskon.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_diskon.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_diskon.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_diskon.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_diskon.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }

        private void btn_diskon_Click(object sender, EventArgs e)
        {
            List<string> selected = new List<string>();
            foreach (DataGridViewRow row in dgv_roti.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    selected.Add(row.Cells[1].Value.ToString());
                }
            }

            if (selected.Count > 0)
            {
                Admin_diskon_dialog d = new Admin_diskon_dialog(selected);
                Hide();
                d.ShowDialog();
                Show();
                load_DgvDiskon();
                load_DgvRoti();
            }
            else
            {
                MessageBox.Show("Tidak ada roti yang dipilih");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_diskon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            groupBox2.Enabled = true;
            row = dgv_diskon.Rows[e.RowIndex];

            string kode = row.Cells[0].Value.ToString();
            selectedDiskon = db.diskons.Where(x => x.kode_diskon == kode).FirstOrDefault();

            diskon_nama.Text = row.Cells[4].Value.ToString();

            string p = String.Empty;
            for (int i = 0; i < row.Cells[1].Value.ToString().Length; i++)
            {
                if (int.TryParse(row.Cells[1].Value.ToString()[i].ToString(), out _))
                {
                    p += row.Cells[1].Value.ToString()[i].ToString();
                }
                else
                {
                    break;
                }
            }
            diskon_num.Value = Convert.ToInt16(p);

            if (selectedDiskon.nama.Contains("%"))
            {
                diskon_cb.SelectedIndex = 0;
            }
            else
            {
                diskon_cb.SelectedIndex = 1;
            }

            diskon_keterangan.Text = selectedDiskon.keterangan.ToString();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void diskon_num_ValueChanged(object sender, EventArgs e)
        {
            cekMax();
        }

        private void cekMax()
        {
            if (diskon_cb.Text.Contains("%"))
            {
                diskon_num.Maximum = 100;
            }
            else
            {
                diskon_num.Maximum = Convert.ToInt16(selectedDiskon.harga_before.ToString());
            }
        }

        private void diskon_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            cekMax();
        }

        private void diskon_date_ValueChanged(object sender, EventArgs e)
        {
            if (diskon_date.Value < DateTime.Now.Date)
            {
                MessageBox.Show("Tanggal harus sama atau lebih besar dari sekarang!");
                diskon_date.Value = DateTime.Now;

            }
        }

        private void resetEditDiskon()
        {
            selectedDiskon = null;
            groupBox2.Enabled = false;
            diskon_cb.SelectedIndex = 0;
            diskon_num.Value = 0;
            diskon_date.Value = DateTime.Now.Date;
            diskon_keterangan.Text = string.Empty;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (diskon_keterangan.Text == string.Empty)
            {
                MessageBox.Show("Keterangan tidak boleh kosong");
            }
            else
            {
                selectedDiskon.keterangan = diskon_keterangan.Text;
                selectedDiskon.nama = diskon_num.Value.ToString() + " " + diskon_cb.Text;

                if (diskon_cb.Text.Equals("%"))
                {
                    selectedDiskon.potongan = (int)selectedDiskon.harga_before * (int)diskon_num.Value / 100;
                }
                else
                {
                    selectedDiskon.potongan = (int)diskon_num.Value;
                }

                selectedDiskon.harga_after = selectedDiskon.harga_before - selectedDiskon.potongan;
                db.SaveChanges();
                load_DgvDiskon();
                resetEditDiskon();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedDiskon.tanggal_selesai = DateTime.Now;
            db.SaveChanges();
            resetEditDiskon();
            load_DgvDiskon();
            load_DgvRoti();
        }

        private void btn_cancel_diskon_Click(object sender, EventArgs e)
        {
            resetEditDiskon();
        }
    }
}

    

