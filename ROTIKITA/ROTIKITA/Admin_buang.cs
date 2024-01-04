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
    public partial class Admin_buang : Form
    {
        db_rotiEntities db = DatabaseService.GetDbContext();
        public Admin_buang()
        {
            InitializeComponent();
        }

        private void Admin_buang_Load(object sender, EventArgs e)
        {
            load_dgv_roti();
            dgv_buang.DataSource = (from p in db.buangs
                                    join j in db.jenis_roti on p.kode_jenis equals j.kode_jenis
                                    select new
                                   {
                                       Kode_Pembuangan = p.kode_buang,
                                       Kode_Roti = p.kode_jenis,
                                       Nama_Roti = j.nama,
                                       QTY = p.qty,
                                       Harga = p.harga,
                                       Tanggal_Dibuang = p.dibuang_at
                                   }).ToList();
        }

        private void load_dgv_roti()
        {
            dgv_roti.Columns.Clear();
            dgv_roti.Columns.Add(new DataGridViewCheckBoxColumn());
            dgv_roti.DataSource = (from p in db.rotis
                                   join j in db.jenis_roti on p.kode_jenis equals j.kode_jenis
                                   select new
                                   {
                                       Kode_Produksi = p.kode_roti,
                                       Kode_Roti = p.kode_jenis,
                                       Nama_Roti = j.nama,
                                       QTY = p.qty,
                                       Harga = j.harga,
                                       Tanggal_Produksi = p.created_at,
                                       Tanggal_Expired = p.expired_at
                                   }).ToList();
        }

        private void dgv_roti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
