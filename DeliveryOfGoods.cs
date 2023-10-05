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
    public partial class DeliveryOfGoods : Form
    {
        public DeliveryOfGoods()
        {
            InitializeComponent();
        }

        private void deliveryOfGoodsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.deliveryOfGoodsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.advertising_agencyDataSet);

        }

        private void DeliveryOfGoods_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advertising_agencyDataSet.Supplier". При необходимости она может быть перемещена или удалена.
            this.supplierTableAdapter.Fill(this.advertising_agencyDataSet.Supplier);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advertising_agencyDataSet.DeliveryOfGoods". При необходимости она может быть перемещена или удалена.
            this.deliveryOfGoodsTableAdapter.Fill(this.advertising_agencyDataSet.DeliveryOfGoods);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            deliveryOfGoodsBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deliveryOfGoodsBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            deliveryOfGoodsBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            deliveryOfGoodsBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            deliveryOfGoodsBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            deliveryOfGoodsBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            deliveryOfGoodsBindingSource.CancelEdit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.deliveryOfGoodsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.advertising_agencyDataSet);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var form = new Suppliers();
            form.FormClosed += Form_FormClosed;
            form.ShowDialog();
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            var row = (DataRowView)supplierBindingSource.Current;
            var id = (int)row.Row["supId"];
            supplierTableAdapter.Fill(advertising_agencyDataSet.Supplier);
            comboBox1.SelectedItem = comboBox1.Items.Cast<DataRowView>().Single(c => (int)c.Row["supId"] == id);
        }
    }
}
