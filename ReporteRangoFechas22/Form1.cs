using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReporteRangoFechas22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void getSalesReport(DateTime starDate, DateTime endDate)
        {
            SalesReport reportModel = new SalesReport();
            reportModel.createSalesOrderReport(starDate, endDate);

            salesReportBindingSource.DataSource = reportModel;
            salesListingBindingSource.DataSource = reportModel.salesListing;
            netSalesByPeriodBindingSource.DataSource = reportModel.netSalesByPeriod;

            this.reportViewer1.RefreshReport();
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            //var fromDate = DateTime.Today;
            //var toDate = DateTime.Now;

            string fromDate = "03/11/2019 00:00:00";
            string toDate = "03/11/2019 23:59:00";

            getSalesReport(Convert.ToDateTime(fromDate), Convert.ToDateTime(toDate));
        }

        private void btnLast7days_Click(object sender, EventArgs e)
        {
            //var fromDate = DateTime.Today.AddDays(-7);
            //var toDate = DateTime.Now;

            string fromDate = "26/10/2019 00:00:00";
            string toDate = "03/11/2019 23:59:00";

            getSalesReport(Convert.ToDateTime(fromDate), Convert.ToDateTime(toDate));
        }

        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            //var fromDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            //var toDate = DateTime.Now;

            string fromDate = "01/10/2019 00:00:00";
            string toDate = "03/11/2019 23:59:00";

            getSalesReport(Convert.ToDateTime(fromDate), Convert.ToDateTime(toDate));
        }

        private void btnLast30Days_Click(object sender, EventArgs e)
        {
            //var fromDate = DateTime.Today.AddDays(-30);
            //var toDate = DateTime.Now;

            string fromDate = "05/10/2019 00:00:00";
            string toDate = "03/11/2019 23:59:00";

            getSalesReport(Convert.ToDateTime(fromDate), Convert.ToDateTime(toDate));
        }

        private void btnThisYear_Click(object sender, EventArgs e)
        {
            //var fromDate = new DateTime(DateTime.Now.Year, 1, 1);
            //var toDate = DateTime.Now;

            string fromDate = "01/01/2019 00:00:00";
            string toDate = "03/11/2019 23:59:00";

            getSalesReport(Convert.ToDateTime(fromDate),Convert.ToDateTime(toDate));
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var fromDate = dTPStartDate.Value;
            var toDate = dTPToDate.Value;

            getSalesReport(fromDate, new DateTime(toDate.Year, toDate.Month, toDate.Day, 23, 59, 59));
        }
    }
}
