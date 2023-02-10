using System;
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
    public partial class AddClientForm : Form
    {
        public AddClientForm()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                UserService userService = new UserService();
                userService.AddClient(FioTb.Text, PassportTb.Text, birthDateTimePicer.Value, AdressTb.Text, EmailTb.Text);
                MessageBox.Show("Клиент добавлен", "Уведомление");
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
            
            
        }
    }
}
