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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
            
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            List<users> user= RentalPointEntities.GetContext().users.ToList();
            List<role> roles = RentalPointEntities.GetContext().role.ToList();
            users u = user.FirstOrDefault(x => x.login == LoginTextBox.Text && x.password == PasswordTextBox.Text);
            role r = roles.FirstOrDefault(y => y.id_role == u.role_id);
            if (u != null)
            {
                AcountForm acount = new AcountForm();
                acount.labelUser.Text = u.fio;
                acount.labelRole.Text = r.role1;

                acount.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Пользователь не найден", "Ошибка");
            }

            
        }

        private void ViewPasscheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ViewPasscheckBox.Checked)
            {
                PasswordTextBox.PasswordChar = (char)0;
            }
            else
            {
                PasswordTextBox.PasswordChar = '*';
            }
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            userService.GeneratedCaptcha();
        }
    }
}
