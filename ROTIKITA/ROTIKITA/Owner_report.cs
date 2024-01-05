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
    public partial class Owner_report : Form
    {
        public Owner_report()
        {
            InitializeComponent();
        }

        private void Owner_report_Load(object sender, EventArgs e)
        {

        }

        private void startDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrystalReport1  cr = new CrystalReport1();
            cr.SetParameterValue("Awal", startDateTimePicker.Value);
            cr.SetParameterValue("Akhir", endDateTimePicker.Value);
            crystalReportViewer1.ReportSource = cr;
        }
    }
}
