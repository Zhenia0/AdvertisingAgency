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
    public partial class Report2 : Form
    {
        public Report2()
        {
            InitializeComponent();
        }

        private void Report2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advertising_agencyDataSet.fullOrder". При необходимости она может быть перемещена или удалена.
            this.fullOrderTableAdapter.Fill(this.advertising_agencyDataSet.fullOrder);
            dateTimePicker1.Value = dateTimePicker1.MinDate;
            dateTimePicker2.Value = dateTimePicker2.MaxDate;
            SetParam();
            this.reportViewer1.RefreshReport();
        }

        private void SetParam() 
        {
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] {
                new ReportParameter("count", fullOrderBindingSource.Count.ToString()),
                new ReportParameter("startDate", dateTimePicker1.Value.ToString("dd-MMM-yyyy")),
                new ReportParameter("endDate", dateTimePicker2.Value.ToString("dd-MMM-yyyy")),
                new ReportParameter("sumPrice", fullOrderBindingSource.Cast<DataRowView>().Select(x=>int.Parse(x.Row["servPrice"].ToString())).Sum().ToString())
            });
        }
        private void button1_Click(object sender, EventArgs e)
        {
            fullOrderBindingSource.Filter = $"orderDate >= '{dateTimePicker1.Value}' and orderDate <= '{dateTimePicker2.Value}'";
            SetParam();
            reportViewer1.RefreshReport();
        }
    }
}
