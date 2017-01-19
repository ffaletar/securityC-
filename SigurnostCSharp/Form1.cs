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
using System.Data.SqlClient;

namespace SigurnostCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registracija registracija = new Registracija();
            registracija.Show();
        }

        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            bool tocnaPrijava = false;
            
            using (var con = new sisprojektEntities())
            {
                foreach(var user in con.Korisnik)
                {
                    if(user.korisnickoIme == tbKorisniskoIme.Text)
                    {
                        tocnaPrijava = ProvjeraLozinke.ValidatePassword(tbLozinka.Text, user.lozinka);
                        break;
                    }
                    else
                    {
                        tocnaPrijava = false;
                    }
                }
            }

            if (tocnaPrijava)
            {
                this.Hide();
                Pocetna pocetna = new Pocetna();
                pocetna.Show();
            }
            else
            {
                MessageBox.Show("Netočna prijava");
            }

        }
    }
}
