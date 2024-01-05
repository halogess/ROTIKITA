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
    public partial class FormStruk : Form
    {
        string id = string.Empty;
        public FormStruk(string htID)
        {
            InitializeComponent();
            id = htID;
        }

        private void FormStruk_Load(object sender, EventArgs e)
        {
            CrystalReport2 cr2 = new CrystalReport2();
            cr2.SetParameterValue("Htrans_id", id);
            crystalReportViewer1.ReportSource = cr2;
        }
    }
}
