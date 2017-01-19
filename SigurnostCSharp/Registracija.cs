using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logger;
using System.Text.RegularExpressions;

namespace SigurnostCSharp
{
    public partial class Registracija : Form
    {
        public Registracija()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidatePassword(textBox3.Text))
                {
                    using (var con = new sisprojektEntities())
                    {
                        Korisnik korisnik = new Korisnik
                        {
                            id = 100,
                            ime = textBox1.Text,
                            prezime = textBox4.Text,
                            korisnickoIme = textBox2.Text,
                            mail = textBox5.Text,
                            lozinka = ProvjeraLozinke.CreateHash(textBox3.Text),
                            tipKorisnika = 1
                        };
                        con.Korisnik.Add(korisnik);
                        con.SaveChanges();
                    }
                    MessageBox.Show("Registrirani ste!");
                    this.Close();
                }

                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Registracija nije uspjesna");
            }
        }

        private bool ValidatePassword(string password)
        {
            var input = password;
            

            if (string.IsNullOrWhiteSpace(input))
            {
                throw new Exception("Lozinka ne smije biti prazna!");
            }

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasLowerChar = new Regex(@"[a-z]+");

            if (!hasLowerChar.IsMatch(input))
            {
                MessageBox.Show("Lozinka mora sadržavati barem jedno malo slovo!");
                return false;
            }
            else if (!hasUpperChar.IsMatch(input))
            {
                MessageBox.Show("Lozinka mora sadržavati barem jedno veliko slovo!");
                return false;
            }
            else if (!hasNumber.IsMatch(input))
            {
                MessageBox.Show("Lozinka mora sadržavati barem jedan broj!");
                return false;
            }

            else
            {
                return true;
            }
        }
    }
}
