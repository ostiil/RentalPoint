﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalPoint
{
    public partial class AcountForm : Form
    {
        public AcountForm()
        {
            InitializeComponent();
             
        }
        private order order = new order();
        private void AcountForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rentalPointDataSet.status". При необходимости она может быть перемещена или удалена.
            this.statusTableAdapter.Fill(this.rentalPointDataSet.status);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rentalPointDataSet.order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this.rentalPointDataSet.order);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rentalPointDataSet.client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.rentalPointDataSet.client);

        }

        private void OrderBtn_Click(object sender, EventArgs e)
        {
            //try
            //{
                order.code_order = CodeOrderTb.Text;
                order.date_order_open = dateOpenTimePicker.Value;
                order.time_order = maskedTextBox1.Text;
                order.code_client = (int)ClientCb.SelectedValue;
                order.status_id = (int)StatusCb.SelectedValue;
                order.date_order_close = dateCloseTimePicker.Value;
                //order.time_order = maskedTextBox1.Text;

                RentalPointEntities.GetContext().order.Add(order);
                RentalPointEntities.GetContext().SaveChanges();
                MessageBox.Show("Заказ сформирован");
            //}
            /*catch(Exception ex)
            {
                //MessageBox.Show(ex.Message);    
            }*/
            
        }
    }
}
