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
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void order_BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.order_BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.advertising_agencyDataSet);
            this.realOrderTableAdapter.Fill(this.advertising_agencyDataSet.RealOrder);
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advertising_agencyDataSet.RealOrder". При необходимости она может быть перемещена или удалена.
            this.realOrderTableAdapter.Fill(this.advertising_agencyDataSet.RealOrder);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advertising_agencyDataSet.ServiceExecution". При необходимости она может быть перемещена или удалена.
            this.serviceExecutionTableAdapter.Fill(this.advertising_agencyDataSet.ServiceExecution);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advertising_agencyDataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.advertising_agencyDataSet.Employee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advertising_agencyDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.advertising_agencyDataSet.Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advertising_agencyDataSet.Order_". При необходимости она может быть перемещена или удалена.
            this.order_TableAdapter.Fill(this.advertising_agencyDataSet.Order_);

            dateTimePicker1.Value = dateTimePicker1.MinDate;
            dateTimePicker2.Value = dateTimePicker2.MaxDate;

            /*comboBox4.Items.Add("Все");

            for (int i = 0; i < serviceExecutionBindingSource.Count; i++)
            {
                var row = (DataRowView)serviceExecutionBindingSource.Current;
                comboBox4.Items.Add(row.Row["servProvider"].ToString());
                serviceExecutionBindingSource.MoveNext();
            }

            comboBox4.SelectedIndex = 0;*/
        }

        private void MoveRealOrderView()
        {
            var row = ((DataRowView)order_BindingSource.Current).Row;

            var index = realOrderBindingSource.Find("orderId", row["orderId"]);

            realOrderBindingSource.MoveFirst();
            Enumerable.Range(0, index).ToList().ForEach(x => realOrderBindingSource.MoveNext());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            order_BindingSource.MoveFirst();
            MoveRealOrderView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            order_BindingSource.MovePrevious();
            MoveRealOrderView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            order_BindingSource.MoveNext();
            MoveRealOrderView();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            order_BindingSource.MoveLast();
            MoveRealOrderView();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            order_BindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            order_BindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            order_BindingSource.CancelEdit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.order_BindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.advertising_agencyDataSet);
            order_BindingNavigatorSaveItem_Click(sender, e);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var form = new Employees();
            form.FormClosed += Form_FormClosed;
            form.ShowDialog();
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            var row = (DataRowView)employeeBindingSource.Current;
            var id = (int)row.Row["empId"];
            employeeTableAdapter.Fill(advertising_agencyDataSet.Employee);
            comboBox2.SelectedItem = comboBox2.Items.Cast<DataRowView>().Single(c => (int)c.Row["empId"] == id);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var form = new Clients();
            form.FormClosed += Form_FormClosed1;
            form.ShowDialog();
        }
        private void Form_FormClosed1(object sender, FormClosedEventArgs e)
        {
            var row = (DataRowView)clientBindingSource.Current;
            var id = (int)row.Row["clientId"];
            clientTableAdapter.Fill(advertising_agencyDataSet.Client);
            comboBox3.SelectedItem = comboBox3.Items.Cast<DataRowView>().Single(c => (int)c.Row["clientId"] == id);
        }
        private void button11_Click(object sender, EventArgs e)
        {
            var form = new ServicesExecution();
            form.FormClosed += Form_FormClosed2;
            form.ShowDialog();
        }
        private void Form_FormClosed2(object sender, FormClosedEventArgs e)
        {
            var row = (DataRowView)serviceExecutionBindingSource.Current;
            var id = (int)row.Row["servId"];
            serviceExecutionTableAdapter.Fill(advertising_agencyDataSet.ServiceExecution);
            comboBox1.SelectedItem = comboBox1.Items.Cast<DataRowView>().Single(c => (int)c.Row["servId"] == id);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            order_BindingSource.Filter = $"orderDate >= '{dateTimePicker1.Value}' and orderDate <= '{dateTimePicker2.Value}'";
            realOrderBindingSource.Filter = $"orderDate >= '{dateTimePicker1.Value}' and orderDate <= '{dateTimePicker2.Value}'";

           /* if (comboBox4.SelectedItem.ToString() == "Все")
            {
                order_BindingSource.Filter += "";
                realOrderBindingSource.Filter += "";
            }
            else
            {
                var index = serviceExecutionBindingSource.Find("servProvider", comboBox4.SelectedItem.ToString());

                var row = (DataRowView)serviceExecutionBindingSource[index];

                order_BindingSource.Filter += $" and servId = {row.Row["servId"]}";
                realOrderBindingSource.Filter += $" and servId = {row.Row["servId"]}";
            }*/
        }

        private void button15_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.MinDate;
            dateTimePicker2.Value = dateTimePicker2.MaxDate;

            order_BindingSource.Filter = "";
            //comboBox4.SelectedIndex = 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var form = new OrderReport((DataRowView)employeeBindingSource.Current,
                                        (DataRowView)clientBindingSource.Current,
                                        (DataRowView)serviceExecutionBindingSource.Current,
                                        (DataRowView)order_BindingSource.Current);

            form.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            (new Report2()).ShowDialog();
        }
    }
}
