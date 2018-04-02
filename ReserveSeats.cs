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
    public partial class ReserveSeats : Form
    {
        public static string Ad;
        public static string Soyad;
        public static int biletNo;

        public ReserveSeats()
        {
            InitializeComponent();   
        }

        private void getReserve_Click(object sender, EventArgs e)
        {
            Ad = textBox1.Text;
            Soyad = textBox2.Text;

            Order_Was_Given owg = new Order_Was_Given();
            owg.Show();
        }
    }
}
