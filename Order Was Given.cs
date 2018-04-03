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
   
    public partial class Order_Was_Given : Form
    {
       

        public string seats;
        public Order_Was_Given()
        {
            InitializeComponent();
            showInfo();
            
        }

        public void showInfo()
        {
            AName.Text = ReserveSeats.Ad;
            ASurName.Text = ReserveSeats.Soyad;


            AMovieName.Text = Movies.moviesName[Welcome.SelectedMovieNum];








            



            foreach (Button item1 in Salon_One.seatList)
            {
                seats += item1.Text + ",";
                ABiletNo.Text = seats;
                APrice.Text = "Total Price " + Salon_One.Qiymet.ToString() + "Azn";
                ShowToUser.Text = "Salam " + ReserveSeats.Ad + " " + ReserveSeats.Soyad + " Sizin " + Movies.moviesName[Welcome.SelectedMovieNum] + " Filmine Sifariwleriniz Verildi";
            }



            foreach (Button item2 in Salon_Two.seatList)
            {
                seats += item2.Text + ",";
                ABiletNo.Text = seats;
                APrice.Text = "Total Price " + Salon_Two.Qiymet2.ToString() + "Azn";
                ShowToUser.Text = "Salam " + ReserveSeats.Ad + " " + ReserveSeats.Soyad + " Sizin " + Movies.moviesName[Welcome.SelectedMovieNum] + " Filmine Sifariwleriniz Verildi";
            }


            foreach (Button item3 in Salon_Three.seatList)
            {
                seats += item3.Text + ",";
                ABiletNo.Text = seats;
                APrice.Text = "Total Price " + Salon_Three.Qiymet3.ToString() + "Azn";
                ShowToUser.Text = "Salam " + ReserveSeats.Ad + " " + ReserveSeats.Soyad + " Sizin " + Movies.moviesName[Welcome.SelectedMovieNum] + " Filmine Sifariwleriniz Verildi";
            }


            foreach (Button item4 in Salon_Four.seatList)
            {
                seats += item4.Text + ",";
                ABiletNo.Text = seats;
                APrice.Text = "Total Price " + Salon_Four.Qiymet4.ToString() + "Azn";
                ShowToUser.Text = "Salam " + ReserveSeats.Ad + " " + ReserveSeats.Soyad + " Sizin " + Movies.moviesName[Welcome.SelectedMovieNum] + " Filmine Sifariwleriniz Verildi";
            }

          

            if (Welcome.sayClick1 == true)
            {
                ASalonName.Text = Welcome.secilmis_Salon1;
                ASeansName.Text = Welcome.secilmis_Seans1;
                
            }
            else if (Welcome.sayClick2 == true)
            {
                ASalonName.Text = Welcome.secilmis_Salon2;
                ASeansName.Text = Welcome.secilmis_Seans2;
            }
            else if (Welcome.sayClick3 == true)
            {
                ASalonName.Text = Welcome.secilmis_Salon3;
                ASeansName.Text = Welcome.secilmis_Seans3;
            }
            else if (Welcome.sayClick4 == true)
            {
                ASalonName.Text = Welcome.secilmis_Salon4;
                ASeansName.Text = Welcome.secilmis_Seans4;
            }
            else
            {
                MessageBox.Show("err");
            }



           

        }


      
    }
}
