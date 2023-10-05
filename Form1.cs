﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new Clients()).ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new Employees()).ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new DeliveryOfGoods()).ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            (new Suppliers()).ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            (new ServicesExecution()).ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            (new Orders()).ShowDialog();
        }
    }
}
