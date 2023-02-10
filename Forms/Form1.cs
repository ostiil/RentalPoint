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
        private int countSignIn = 0;
        private string captcha = "";
        public MainForm()
        {
            InitializeComponent();
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {

            List<users> user = RentalPointEntities.GetContext().users.ToList();
            List<role> roles = RentalPointEntities.GetContext().role.ToList();
            if (countSignIn ==1)
            {
                CheckCapcha(CapchaTb.Text);
                
            }
            else
                Autorize(user, roles);
        }

        private void CheckCapcha(string textBox)
        {
            List<users> user = RentalPointEntities.GetContext().users.ToList();
            List<role> roles = RentalPointEntities.GetContext().role.ToList();
            if (captcha == textBox)
            {
                Autorize(user, roles);
               
            }
            else
            {
                MessageBox.Show("Неверно введена капча");
                captcha = "";
                Capcha();
                
            }
        }

        private void Autorize(List<users> user, List<role> roles)
        {
            
            users u = user.FirstOrDefault(x => x.login == LoginTextBox.Text && x.password == PasswordTextBox.Text);
            if (u == null)
            {
                MessageBox.Show("Пользователь не найден", "Ошибка");
                countSignIn=1;
                Capcha();
            }
            else
            {
                role r = roles.FirstOrDefault(y => y.id_role == u.role_id);
                AcountForm acount = new AcountForm();
                acount.labelUser.Text = u.fio;
                acount.labelRole.Text = r.role1;

                acount.Show();
                this.Hide();
            }
            
        }

        private void Capcha()
        {
            CapchaTb.Visible = true;
            var random = new Random();
            Bitmap image = new Bitmap(CaptchapictureBox.Width, CaptchapictureBox.Height);
            var font = new Font("Arial", 30, FontStyle.Underline, GraphicsUnit.Pixel);
            var graphics = Graphics.FromImage(image);
            CaptchapictureBox.Image = image;

            for (int i = 0; i < 5; i++)
            {
                int num = random.Next(0, 9);
                captcha += num;
                graphics.DrawString(num.ToString(), font, Brushes.Bisque, new Point( i * 20, num + CaptchapictureBox.Height / 5));
                CaptchapictureBox.Refresh();

            }

            var color = new Color[] { Color.Tomato, Color.Violet };

            for (int i = 0; i < CaptchapictureBox.Width; i++)
            {
                for (int j = 0; j < CaptchapictureBox.Height; j++)
                {
                    if (random.Next() % 10 == 0)
                    {
                        image.SetPixel(i, j, color[j % 2]);
                    }
                }
            }

            CaptchapictureBox.Refresh();
            

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

        private void CapchaBtn_Click(object sender, EventArgs e)
        {
            Capcha();
        }
    }
}
