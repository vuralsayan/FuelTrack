using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FuelTrack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=Vural\SQLEXPRESS;Initial Catalog=DbBenzin;Integrated Security=True");


        private void Form1_Load(object sender, EventArgs e)
        {
            //Kurşunsuz 95
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM TBLBENZIN WHERE PETROLTUR='Kurşunsuz95'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblKurs95.Text = dr[3].ToString();
            }
            baglanti.Close();

            //Kurşunsuz 97
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("SELECT * FROM TBLBENZIN WHERE PETROLTUR='Kurşunsuz97'", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                LblKur97.Text = dr1[3].ToString();
            }
            baglanti.Close();

            //Euro Dizel 10
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("SELECT * FROM TBLBENZIN WHERE PETROLTUR='EuroDizel10'", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                LblDiz10.Text = dr2[3].ToString();
            }
            baglanti.Close();

            //Yeni Pro Dizel
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("SELECT * FROM TBLBENZIN WHERE PETROLTUR='YeniProDizel'", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                LblYenDiz.Text = dr3[3].ToString();
            }
            baglanti.Close();

            //Gaz
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("SELECT * FROM TBLBENZIN WHERE PETROLTUR='Gaz'", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                LblGaz.Text = dr4[3].ToString();
            }
            baglanti.Close();



        }
    }
}
