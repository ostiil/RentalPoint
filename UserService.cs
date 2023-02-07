using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalPoint
{
    public class UserService
    {
       

        public void GeneratedCaptcha()
        {
            MainForm form = new MainForm();
            var captcha = "";
            var random = new Random();
            Bitmap image = new Bitmap(form.CaptchapictureBox.Width, form.CaptchapictureBox.Height);
            var font = new Font ("TimesNewRoman", 30, FontStyle.Underline, GraphicsUnit.Pixel);
            var graphics = Graphics.FromImage (image);
            form.CaptchapictureBox.Image = image;

            for (int i = 0; i < 6; i++)
            {
                int num = random.Next(0, 9);
                captcha += num;
                graphics.DrawString(num.ToString(), font, Brushes.Bisque, new Point(4+ i * 20, num + form.CaptchapictureBox.Height / 5));
                form.CaptchapictureBox.Refresh();

            }

            var color = new Color[] { Color.Tomato, Color.Violet };

            for (int i = 0; i < form.CaptchapictureBox.Width; i++)
            {
                for (int j = 0; j < form.CaptchapictureBox.Height; j++)
                {
                    if (random.Next() % 8 == 0)
                    {
                        image.SetPixel(i, j, color[j%2]);
                    }
                }
            }

            form.CaptchapictureBox.Refresh();
        }
    }
}
