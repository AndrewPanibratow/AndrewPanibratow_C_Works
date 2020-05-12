using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
        "Кнопка “Ок” була натиснута",
        "Повідомлення на екрані",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1,
        MessageBoxOptions.DefaultDesktopOnly);
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            button1.Left = r.Next(0, this.Size.Width - button1.Width);
            button1.Top = r.Next(0, this.Size.Height - button1.Height);
            button1.Width = button1.Width - 4;
            button1.Height = button1.Height - 1;
            button1.Location = new Point(button1.Location.X - 50, button1.Location.Y - 50);
            if (button1.Height <= 1)
            {
                   MessageBox.Show(
                   "Кнопка “Ок” не може бути натиснута",
                   "Ой-йой!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
            if (button1.Location.X <= 0)
                button1.Location = new Point(button1.Location.X + button1.Width + 80, button1.Location.Y);
            
            if (button1.Location.Y <= 0)
                button1.Location = new Point(button1.Location.Y + button1.Height + 80, button1.Location.X);
            
            //if (button1.Location.X > 590)
                //button1.Location = new Point(button1.Location.X - 300, button1.Location.Y);
            
            //if (button1.Location.Y < 470)
                //button1.Location = new Point(button1.Location.Y - 300, button1.Location.X);
        }

        
    }
}
