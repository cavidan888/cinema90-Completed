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
    public partial class Salon_One : Form
    {
        public static List<Button> seatList = new List<Button>();

        public Button btn;
        public int top = 0;
        public int left = 0;
        public int count = 10;
        public int seatNumber = 1;
        public static double Qiymet;
        public static bool birdir = false;


        public Salon_One()
        {
            InitializeComponent();
            birdir = true;
        }




        private void Salon_One_Load(object sender, EventArgs e)
        {

            CreateOnix();




            //List<Button> buttons = new List<Button>();
            //for (int i = 0; i < 10; i++)
            //{
            //    Button newButton = new Button();
            //    buttons.Add(newButton);
            //    this.Controls.Add(newButton);
            //}
            Welcome wlc = new Welcome();
            

        }

        public void CreateOnix()
        {

            for (int i = 0; i < count * 2; i++)
            {
                count -= 2;
                left = (50 * i);
                for (int j = 0; j < count; j++)
                {
                    btn = new Button();
                    btn.Height = 50;
                    btn.Width = 50;
                    btn.Left = left;
                    btn.Top = top;

                    btn.Text = seatNumber.ToString();
                    btn.ForeColor = Color.FromArgb(235, 244, 66);
                    btn.BackColor = Color.Black;
                    btn.FlatAppearance.BorderSize = 5;
                    btn.FlatAppearance.BorderColor = Color.White;
                    btn.Click  +=  new EventHandler(clicked);
                    btn.FlatStyle = FlatStyle.Flat;
                    Controls.Add(btn);
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
                Qiymet += 5;
            }
            else if(Welcome.sayClick2 == true)
            {
                Qiymet += 10;
            }
            else if (Welcome.sayClick3 == true)
            {
                Qiymet += 15;
            }
            else if (Welcome.sayClick4 == true)
            {
                Qiymet += 20;
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

        private void reserveButton_Click(object sender, EventArgs e)
        {
            ReserveSeats rs = new ReserveSeats();
            rs.Show();
        }
    }

}