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
    public partial class Salon_Four : Form
    {

        public static List<Button> seatList = new List<Button>();

        public Button btn4;
        public int top = 0;
        public int left = 0;
        public int count = 10;
        public int seatNumber = 1;
        public static double Qiymet4;
        public static bool birdir = false;
        public Salon_Four()
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
                    btn4 = new Button();
                    btn4.Height = 50;
                    btn4.Width = 50;
                    btn4.Left = left;
                    btn4.Top = top;

                    btn4.Text = seatNumber.ToString();
                    btn4.ForeColor = Color.FromArgb(235, 244, 66);
                    btn4.BackColor = Color.Black;
                    btn4.FlatAppearance.BorderSize = 5;
                    btn4.FlatAppearance.BorderColor = Color.White;
                    btn4.Click += new EventHandler(clicked);
                    btn4.FlatStyle = FlatStyle.Flat;
                    Controls.Add(btn4);
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

            if (Welcome.sayClick1 == true)
            {
                Qiymet4 += 5;
            }
            else if (Welcome.sayClick2 == true)
            {
                Qiymet4 += 10;
            }
            else if (Welcome.sayClick3 == true)
            {
                Qiymet4 += 15;
            }
            else if (Welcome.sayClick4 == true)
            {
                Qiymet4 += 20;
            }

            else
            {
                MessageBox.Show("Closed");
            }

            foreach (Button item in seatList)
            {
                textBox1.Text += item.Text + ",";
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReserveSeats rs = new ReserveSeats();
            rs.Show();
        }
    }
}
