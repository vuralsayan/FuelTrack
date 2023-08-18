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
                progressBar1.Value = int.Parse(dr[4].ToString());
                LblKur95Litre.Text = dr[4].ToString();
            }
            baglanti.Close();

            //Kurşunsuz 97
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("SELECT * FROM TBLBENZIN WHERE PETROLTUR='Kurşunsuz97'", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                LblKur97.Text = dr1[3].ToString();
                progressBar2.Value = int.Parse(dr1[4].ToString());
                LblKur97Litre.Text = dr1[4].ToString();
            }
            baglanti.Close();

            //Euro Dizel 10
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("SELECT * FROM TBLBENZIN WHERE PETROLTUR='EuroDizel10'", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                LblDiz10.Text = dr2[3].ToString();
                progressBar3.Value = int.Parse(dr2[4].ToString());
                LblEuroLitre.Text = dr2[4].ToString();
            }
            baglanti.Close();

            //Yeni Pro Dizel
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("SELECT * FROM TBLBENZIN WHERE PETROLTUR='YeniProDizel'", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                LblYenDiz.Text = dr3[3].ToString();
                progressBar4.Value = int.Parse(dr3[4].ToString());
                LblProLitre.Text = dr3[4].ToString();
            }
            baglanti.Close();

            //Gaz
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("SELECT * FROM TBLBENZIN WHERE PETROLTUR='Gaz'", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                LblGaz.Text = dr4[3].ToString();
                progressBar5.Value = int.Parse(dr4[4].ToString());
                LblGazLitre.Text = dr4[4].ToString();
            }
            baglanti.Close();



        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            double kursunsuz95, litre, tutar;
            kursunsuz95 = Convert.ToDouble(LblKurs95.Text);
            litre = Convert.ToDouble(numericUpDown1.Value);
            tutar = kursunsuz95 * litre;
            TxtKursunsuz95Fiyat.Text = tutar.ToString();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            double kursunsuz97, litre, tutar;
            kursunsuz97 = Convert.ToDouble(LblKur97.Text);
            litre = Convert.ToDouble(numericUpDown2.Value);
            tutar = kursunsuz97 * litre;
            TxtKursunsuz97Fiyat.Text = tutar.ToString();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            double eurodizel10, litre, tutar;
            eurodizel10 = Convert.ToDouble(LblDiz10.Text);
            litre = Convert.ToDouble(numericUpDown4.Value);
            tutar = eurodizel10 * litre;
            TxtEuroDizelFiyat.Text = tutar.ToString();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            double yenipro, litre, tutar;
            yenipro = Convert.ToDouble(LblYenDiz.Text);
            litre = Convert.ToDouble(numericUpDown3.Value);
            tutar = yenipro * litre;
            TxtProDizelFiyat.Text = tutar.ToString();
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            double gaz, litre, tutar;
            gaz = Convert.ToDouble(LblGaz.Text);
            litre = Convert.ToDouble(numericUpDown5.Value);
            tutar = gaz * litre;
            TxtGazFiyat.Text = tutar.ToString();
        }
    }

}
