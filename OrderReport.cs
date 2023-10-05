using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvertisingAgency
{
    public partial class OrderReport : Form
    {
        public OrderReport()
        {
            InitializeComponent();
        }

        public OrderReport(DataRowView curEmp, DataRowView curClient, DataRowView curProvider, DataRowView curOrder) : this()
        {
            CurEmp = curEmp;
            CurClient = curClient;
            CurProvider = curProvider;
            CurOrder = curOrder;
        }

        public DataRowView CurEmp { get; private set; }
        public DataRowView CurClient { get; private set; }
        public DataRowView CurProvider { get; private set; }
        public DataRowView CurOrder { get; private set; }

        private void OrderReport_Load(object sender, EventArgs e)
        {
            var orderDate = (DateTime)CurOrder.Row["orderDate"];
            var servName = CurOrder.Row["servName"];
            var clientFIO = $"{CurClient.Row["surname"]} {CurClient.Row["fName"]} {CurClient.Row["lName"]}";
            var employeeFIO = $"{CurEmp.Row["surname"]} {CurEmp.Row["fName"]} {CurEmp.Row["lName"]}";
            var servProvider = CurProvider.Row["servProvider"];
            var servType = CurOrder.Row["servType"];

            var empFIOParam = new ReportParameter("EmpFIO", employeeFIO);
            var clientFIOParam = new ReportParameter("ClientFIO", clientFIO);
            var servNameParam = new ReportParameter("ServName", servName.ToString());
            var servTypeParam = new ReportParameter("ServType", servType.ToString());
            var servProviderParam = new ReportParameter("ServProvider", servProvider.ToString());
            var orderDateParam = new ReportParameter("OrderDate", orderDate.ToString("dd/MMMM/yyyy"));

            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { empFIOParam, clientFIOParam, servNameParam,
                servTypeParam, servProviderParam, orderDateParam});
            this.reportViewer1.RefreshReport();
        }
    }
}
