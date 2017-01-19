using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigurnostCSharp
{
    public class Korisnik1
    {
        
        public string ime { get; set; }
        public string prezime { get; set; }
        public string korisnickoIme { get; set; }
        public string mail { get; set; }

        public virtual TipKorisnika TipKorisnika1 { get; set; }

        public Korisnik1(string ime, string prezime, string korisnickoIme,string mail)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.korisnickoIme = korisnickoIme;
            this.mail = mail;
        }


    }
}
