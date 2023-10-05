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
    public partial class Suppliers : Form
    {
        public Suppliers()
        {
            InitializeComponent();
        }

        private void supplierBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.supplierBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.advertising_agencyDataSet);

        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advertising_agencyDataSet.Supplier". При необходимости она может быть перемещена или удалена.
            this.supplierTableAdapter.Fill(this.advertising_agencyDataSet.Supplier);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            supplierBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            supplierBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            supplierBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            supplierBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            supplierBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            supplierBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            supplierBindingSource.CancelEdit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.supplierBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.advertising_agencyDataSet);
        }
    }
}
