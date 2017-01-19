using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SigurnostCSharp
{
    public partial class Pocetna : Form
    {
        public Pocetna()
        {
            InitializeComponent();
        }

        private void tbPretrazivanje_TextChanged(object sender, EventArgs e)
        {
            //DataTable dt = new DataTable();
            //List<Korisnik> listaKorisnika = new List<Korisnik>();
            //using (var con = new sisprojektEntities())
            //{
            //    foreach (Korisnik user in con.Korisnik)
            //    {
            //        if (user.korisnickoIme.StartsWith(tbPretrazivanje.Text))
            //        {
            //            listaKorisnika.Add(user);
            //        }
            //    }
            //}
            //dt.Columns.Add("Korisničko ime", typeof(string));
            //dt.Columns.Add("Ime", typeof(string));
            //dt.Columns.Add("Prezime", typeof(string));
            //dt.Columns.Add("Mail", typeof(string));
            //foreach (Korisnik korisnik in listaKorisnika)
            //{
            //    dt.Rows.Add(korisnik.korisnickoIme, korisnik.ime, korisnik.prezime, korisnik.mail);
            //}
            //dataGridView1.DataSource = dt;
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Korisničko ime", typeof(string));
            dt.Columns.Add("Ime", typeof(string));
            dt.Columns.Add("Prezime", typeof(string));
            dt.Columns.Add("Mail", typeof(string));
            List<Korisnik1> listaKorisnika = new List<Korisnik1>();
            SqlConnection connection = null;
            string connectionString = "Data Source=FALE\\SQLEXPRESS;Initial Catalog=sisprojekt;Integrated Security=True;";
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT korisnickoIme, ime, prezime, mail FROM Korisnik WHERE korisnickoIme LIKE '" + textBox1.Text + "%'", connection);
                    //command.Parameters.AddWithValue("@korisnickoIme", textBox1.Text + "%");
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string korisnickoIme = reader["korisnickoIme"].ToString();
                        string ime = reader["ime"].ToString();
                        string prezime = reader["prezime"].ToString();
                        string mail = reader["mail"].ToString();

                        Korisnik1 korisnik = new Korisnik1(ime, prezime, korisnickoIme, mail);

                        listaKorisnika.Add(korisnik);
                    }
                    dataGridView2.DataSource = dt;

                }


                foreach (Korisnik1 korisnik in listaKorisnika)
                {
                    dt.Rows.Add(korisnik.korisnickoIme, korisnik.ime, korisnik.prezime, korisnik.mail);
                }


            }
            catch (Exception ex)
            {

            }

            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            List<Korisnik> listaKorisnika = new List<Korisnik>();
            using (var con = new sisprojektEntities())
            {
                foreach (Korisnik user in con.Korisnik)
                {
                    if (user.korisnickoIme.StartsWith(tbPretrazivanje.Text))
                    {
                        listaKorisnika.Add(user);
                    }
                }
            }
            dt.Columns.Add("Korisničko ime", typeof(string));
            dt.Columns.Add("Ime", typeof(string));
            dt.Columns.Add("Prezime", typeof(string));
            dt.Columns.Add("Mail", typeof(string));
            foreach (Korisnik korisnik in listaKorisnika)
            {
                dt.Rows.Add(korisnik.korisnickoIme, korisnik.ime, korisnik.prezime, korisnik.mail);
            }
            dataGridView1.DataSource = dt;
        }
    }
}
