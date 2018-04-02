using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace letsCinema
{
    public partial class Salon_Three : Form
    {
        public static List<Button> seatList = new List<Button>();

        public Button btn3;
        public int top = 0;
        public int left = 0;
        public int count = 10;
        public int seatNumber = 1;
        public static double Qiymet3;


        public Salon_Three()
        {
            InitializeComponent();
            CreateOnix();
        }


        public void CreateOnix()
        {

            for (int i = 0; i < count * 2; i++)
            {
                count -= 2;
                left = (50 * i);
                for (int j = 0; j < count; j++)
                {
                    btn3 = new Button();
                    btn3.Height = 50;
                    btn3.Width = 50;
                    btn3.Left = left;
                    btn3.Top = top;

                    btn3.Text = seatNumber.ToString();
                    btn3.ForeColor = Color.FromArgb(235, 244, 66);
                    btn3.BackColor = Color.Black;
                    btn3.FlatAppearance.BorderSize = 5;
                    btn3.FlatAppearance.BorderColor = Color.White;
                    btn3.Click += new EventHandler(clicked);
                    btn3.FlatStyle = FlatStyle.Flat;
                    Controls.Add(btn3);
                    left += 50;

                    seatNumber++;

                }
                left = 0;
                top += 50;

            }


        }

        public void clicked(object sender, EventArgs e)
        {
            var btn = sender as Button; // click olunan obj obyektine button imis kimi davran

            btn.BackColor = Color.Red;
            btn.Enabled = false;
            seatList.Add(btn);
            textBox1.Text = "";
            foreach (Button item in seatList)
            {
                textBox1.Text += item.Text + ",";
            }
            if (Welcome.sayClick1 == true)
            {
                Qiymet3 += 5;
            }
            else if (Welcome.sayClick2 == true)
            {
                Qiymet3 += 10;
            }
            else if (Welcome.sayClick3 == true)
            {
                Qiymet3 += 15;
            }
            else if (Welcome.sayClick4 == true)
            {
                Qiymet3 += 20;
            }

            else
            {
                MessageBox.Show("Closed");
            }


        }

        private void reserveSeats3_Click(object sender, EventArgs e)
        {
            ReserveSeats rs = new ReserveSeats();
            rs.Show();
        }
    }
}
