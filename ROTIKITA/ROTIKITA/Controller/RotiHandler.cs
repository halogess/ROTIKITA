﻿using ROTIKITA.Contracts;
using ROTIKITA.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROTIKITA.Controller
{
    public class RotiHandler
    {
        private static db_rotiEntities db = DatabaseService.GetDbContext();
        public static string currentKodeJenisRoti;
        private static string KODE_JENIS_ROTI_PREFIX = "J_R";
        private static string KODE_ROTI_PREFIX = "ROTI";
        public static string EXPIRED_SUFFIX = "Hari";
        public static void ResetState()
        {
            currentKodeJenisRoti = "";
        }
        public static string getNewKodeJenisRoti()
        {
            var latestJenisRoti = db.jenis_roti.OrderByDescending(jr => jr.kode_jenis).FirstOrDefault();

            if (latestJenisRoti != null)
            {
                string lastId = latestJenisRoti.kode_jenis;
                string roleCode = "";
                string idCount = "";
                for (int i = 0; i < lastId.Length; i++)
                {
                    if (char.IsDigit(lastId[i]))
                    {
                        idCount += lastId[i];
                    }
                }
                int newIdCount = int.Parse(idCount) + 1;
                return DatabaseService.PadLeftZero(KODE_JENIS_ROTI_PREFIX, newIdCount, 10);
            }
            return DatabaseService.PadLeftZero(KODE_JENIS_ROTI_PREFIX, 1, 10);
        }

        public static int CekDiskon(string kode_roti)
        {
            diskon diskon = db.diskons.Where(d=>d.kode_diskon == kode_roti && d.tanggal_mulai >= DateTime.Now && d.tanggal_selesai <= DateTime.Now).FirstOrDefault();
            if(diskon == null)
            {
                return 0;
            }
            return (int)diskon.potongan;
        }
        public static void DeleteAllRoti()
        {
            // Assuming db is your DbContext instance
            List<roti> allRoti = db.rotis.ToList();

            foreach (var roti in allRoti)
            {
                db.rotis.Remove(roti);
            }
            db.SaveChanges();
        }

        public static string getNewKodeRoti()
        {
            var latestJenisRoti = db.rotis.OrderByDescending(jr => jr.kode_roti).FirstOrDefault();

            if (latestJenisRoti != null)
            {
                string lastId = latestJenisRoti.kode_roti;
                string roleCode = "";
                string idCount = "";
                for (int i = 0; i < lastId.Length; i++)
                {
                    if (char.IsDigit(lastId[i]))
                    {
                        idCount += lastId[i];
                    }
                }
                int newIdCount = int.Parse(idCount) + 1;
                return DatabaseService.PadLeftZero(KODE_ROTI_PREFIX, newIdCount, 10);
            }
            return DatabaseService.PadLeftZero(KODE_ROTI_PREFIX, 1, 10);
        }

        public static int GetJenisRotiExpired(string kodeJenisRoti)
        {
            var jenisRoti = db.jenis_roti.Where(jr => jr.kode_jenis == kodeJenisRoti).FirstOrDefault();
            int exp = 0;
            if (jenisRoti != null)
            {
                exp = int.Parse(jenisRoti.exp.ToString());
            }
            return exp;
        }
        public static void AddRoti(string kodeJenisRoti, int quantity)
        {
            if (kodeJenisRoti == "")
            {
                MessageBox.Show("Kode Jenis Roti tidak boleh kosong.");
                return;
            }
            else if (quantity <= 0)
            {
                MessageBox.Show("Quantity should be greater than 0.");
                return;
            }
            roti roti = new roti()
            {
                kode_jenis = kodeJenisRoti,
                kode_roti = getNewKodeRoti(),
                created_at = DateTime.Now,
                expired_at = DateTime.Now.AddDays(GetJenisRotiExpired(kodeJenisRoti)),
                qty = quantity
            };
            db.rotis.Add(roti);
            db.SaveChanges();
        }

        public static void EditRoti(string kodeRoti, int quantity)
        {
            var roti = db.rotis.Where(r => r.kode_roti == kodeRoti).FirstOrDefault();
            if (roti != null)
            {
                roti.qty = quantity;
                db.SaveChanges();
            }
        }
        public static List<RotiVisible> GetAllRoti()
        {
            var roti = (from r in db.rotis select r).OrderBy(r => r.kode_jenis).ToList();
            List<RotiVisible> visibleRotiList = new List<RotiVisible>();
            foreach (var r in roti)
            {
                var jenisRoti = db.jenis_roti.Where(jr => jr.status != JenisRotiStatus.INACTIVE).Where(jr => jr.kode_jenis == r.kode_jenis).FirstOrDefault();
                if (jenisRoti != null)
                {
                    int parsedHarga = 0;
                    int parsedQty = 0;
                    DateTime parsedExpired = DateTime.Now;

                    int.TryParse(jenisRoti.harga.ToString(), out parsedHarga);
                    int.TryParse(r.qty.ToString(), out parsedQty);
                    DateTime.TryParse(r.expired_at.ToString(), out parsedExpired);

                    visibleRotiList.Add(new RotiVisible(r.kode_jenis, r.kode_roti, jenisRoti.nama, parsedHarga, parsedQty, parsedExpired));
                }

            }
            return visibleRotiList;
        }
        public static List<RotiCartVisible> GetAllRotiInCart()
        {
            var roti = (from r in db.rotis select r).OrderBy(r => r.kode_jenis).ToList();
            List<RotiCartVisible> visibleRotiList = new List<RotiCartVisible>();
            foreach (var r in roti)
            {
                var jenisRoti = db.jenis_roti.Where(jr => jr.status != JenisRotiStatus.INACTIVE).Where(jr => jr.kode_jenis == r.kode_jenis).FirstOrDefault();
                if (jenisRoti != null)
                {
                    int parsedHarga = 0;
                    int parsedQty = 0;
                    DateTime parsedExpired = DateTime.Now;

                    int.TryParse(jenisRoti.harga.ToString(), out parsedHarga);
                    int.TryParse(r.qty.ToString(), out parsedQty);
                    DateTime.TryParse(r.expired_at.ToString(), out parsedExpired);

                    visibleRotiList.Add(new RotiCartVisible(r.kode_roti, jenisRoti.nama, parsedHarga, parsedQty, parsedExpired));
                }
            }
            return visibleRotiList;
        }
        public static void AddJenisRoti(string nama, int harga, int lama_expired)
        {
            string kodeJenis = getNewKodeJenisRoti();
            jenis_roti newJenis = new jenis_roti()
            {
                kode_jenis = kodeJenis,
                nama = nama,
                exp = lama_expired,
                status = JenisRotiStatus.ACTIVE,
                harga = harga
            };
            db.jenis_roti.Add(newJenis);
            db.SaveChanges();
        }
        public static List<jenis_roti> GetAllJenisRoti()
        {
            var jenisRoti = (from jr in db.jenis_roti
                             select jr).OrderBy(jr => jr.status).OrderBy(jr => jr.kode_jenis).ToList();
            return jenisRoti;
        }
        public static List<JenisRotiVisible> GetAllJenisRotiActive()
        {
            var activeJenisRoti = (from jr in db.jenis_roti
                                   select jr)
                             .Where(jr => jr.status != JenisRotiStatus.INACTIVE)
                             .OrderBy(jr => jr.status)
                             .OrderBy(jr => jr.kode_jenis)
                             .ToList();
            List<JenisRotiVisible> visibleJenisRotiList = new List<JenisRotiVisible>();
            foreach (var jenisRoti in activeJenisRoti)
            {
                int parsedHarga = 0;
                int parsedExpired = 0;
                int.TryParse(jenisRoti.harga.ToString(), out parsedHarga);
                int.TryParse(jenisRoti.exp.ToString(), out parsedExpired);
                visibleJenisRotiList.Add(new JenisRotiVisible(jenisRoti.kode_jenis, jenisRoti.nama, parsedHarga, parsedExpired));
            }

            return visibleJenisRotiList;
        }
        public static string FormatHarga(int harga)
        {
            return string.Format("{0:#,##0}", harga);
        }
        public static int ReformatHarga(string harga)
        {
            return int.Parse(harga.Replace(".", ""));
        }
        public static string ReformatExpired(string hari)
        {
            return hari.Replace(" " + EXPIRED_SUFFIX, "");
        }
        public static void DeleteJenisRoti()
        {
            jenis_roti jr = db.jenis_roti.Where(jenis => jenis.kode_jenis == currentKodeJenisRoti).FirstOrDefault();
            if (jr != null)
            {
                jr.status = JenisRotiStatus.INACTIVE;
                db.SaveChanges();
            }
        }
        public static jenis_roti GetCurrentJenisRoti()
        {
            jenis_roti jr = db.jenis_roti.Where(jenis => jenis.kode_jenis == currentKodeJenisRoti).FirstOrDefault();
            return jr;
        }
        public static void UpdateJenisRoti(string nama, int harga, int lama_expired)
        {
            jenis_roti jr = db.jenis_roti.Where(jenis => jenis.kode_jenis == currentKodeJenisRoti).FirstOrDefault();
            if (jr != null)
            {
                jr.nama = nama;
                jr.harga = harga;
                jr.exp = lama_expired;
                db.SaveChanges();
            }
        }

        public static string GetHtransNewID()
        {
            var dbContext = DatabaseService.GetDbContext();
            var latestHtran = dbContext.htrans.OrderByDescending(h => h.htrans_id).FirstOrDefault();

            string year = DateTime.Now.Year.ToString().Substring(2);
            string month = DateTime.Now.Month.ToString("D2");
            string prefix = "IV" + year + month;

            int newId = 1;
            if (latestHtran != null && latestHtran.htrans_id.StartsWith(prefix))
            {
                string lastId = latestHtran.htrans_id.Substring(prefix.Length);
                newId = int.Parse(lastId) + 1;
            }

            return prefix + newId.ToString("D4");
        }

        public static string GetDtransLatestID()
        {
            dtran dtran = DatabaseService.GetDbContext().dtrans.OrderByDescending(d => d.dtrans_id).FirstOrDefault();
            if (dtran != null)
            {
                string latest_id = dtran.dtrans_id.ToString();
                return latest_id;
            }
            else
            {
                return "0";
            }
        }
        public static int GetLatestDtransIDCount(string latestID)
        {
            string text = "";
            string counter = "";
            for (int i = 0; i < latestID.Length; i++)
            {
                int a;
                if (int.TryParse(latestID[i].ToString(), out a))
                {
                    counter += latestID[i];
                }
                else
                {
                    text += latestID[i];
                }
            }
            return int.Parse(counter);
        }
        public static string FormatLatestDtransID(int idCount)
        {
            return "D" + idCount.ToString("D9");
        }
        public static void BuyRoti(List<BuyRotiItemVo> cartList, int total)
        {
            var transaction = db.Database.BeginTransaction();
            try
            {
                string htID = GetHtransNewID();
                htran htran = new htran();
                htran.htrans_id = htID;
                htran.user_id = UserHandler.user_ID;
                htran.subtotal = total;
                htran.tanggal = DateTime.Now;
                db.htrans.Add(htran);
                db.SaveChanges();
                string latestHtransID = GetDtransLatestID();
                int latestIDCount = GetLatestDtransIDCount(latestHtransID);
                for (int i = 0; i < cartList.Count; i++)
                {
                    BuyRotiItemVo item = cartList[i];
                    dtran dtran = new dtran();
                    dtran.dtrans_id = FormatLatestDtransID(latestIDCount + i + 1);
                    dtran.htrans_id = htID;
                    var roti = db.rotis.Where(r => r.kode_roti == item.KodeRoti).FirstOrDefault();
                    roti.qty -= item.Qty;
                    dtran.kode_roti = item.KodeRoti;
                    dtran.qty = item.Qty;
                    dtran.harga = item.Harga;
                    dtran.subtotal = item.Subtotal;
                    db.dtrans.Add(dtran);
                }
                db.SaveChanges();
                transaction.Commit();
            }
            catch (Exception)
            {
                transaction.Rollback();
                throw;
            }


        }

    }
}