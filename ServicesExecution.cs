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
    public partial class ServicesExecution : Form
    {
        public ServicesExecution()
        {
            InitializeComponent();
        }

        private void serviceExecutionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.serviceExecutionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.advertising_agencyDataSet);

        }

        private void ServicesExecution_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advertising_agencyDataSet.DeliveryOfGoods". При необходимости она может быть перемещена или удалена.
            this.deliveryOfGoodsTableAdapter.Fill(this.advertising_agencyDataSet.DeliveryOfGoods);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advertising_agencyDataSet.ServiceExecution". При необходимости она может быть перемещена или удалена.
            this.serviceExecutionTableAdapter.Fill(this.advertising_agencyDataSet.ServiceExecution);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            serviceExecutionBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serviceExecutionBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            serviceExecutionBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            serviceExecutionBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            serviceExecutionBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            serviceExecutionBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            serviceExecutionBindingSource.CancelEdit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.serviceExecutionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.advertising_agencyDataSet);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var form = new DeliveryOfGoods();
            form.FormClosed += Form_FormClosed;
            form.ShowDialog();
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            var row = (DataRowView)deliveryOfGoodsBindingSource.Current;
            var id = (int)row.Row["delId"];
            deliveryOfGoodsTableAdapter.Fill(advertising_agencyDataSet.DeliveryOfGoods);
            comboBox1.SelectedItem = comboBox1.Items.Cast<DataRowView>().Single(c => (int)c.Row["delId"] == id);
        }
    }
}
