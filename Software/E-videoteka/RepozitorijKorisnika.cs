using System.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace E_videoteka
{
    public class RepozitorijKorisnika
    {   
        public void DodajKorisnika(string ime, string prezime, string email, string username, string password, string adresa, string uloga)
        {
            using (var context = new PI2247_DBEntities1())
            {
                Korisnik korisnik = new Korisnik
                {
                    Ime = ime,
                    Prezime = prezime,
                    Email = email,
                    Username = username,
                    Password = password,
                    Uloga = uloga,
                    Adresa = adresa
                };
                context.Korisniks.Add(korisnik);
                context.SaveChanges();
            }
        }
        public bool ProvjeriPrijavu(string username, string password)
        {
            using (var context = new PI2247_DBEntities1())
            {
                var query = from p in context.Korisniks
                            where p.Username == username && p.Password == password
                            select p;

                if (query.Any())
                {
                    MessageBox.Show("Uspješno ste ulogirani.");
                    return true;
                }
                else
                {
                    MessageBox.Show("Krivo korisničko ime ili lozinka.");
                    return false;
                }
            }
        }
        
        public Korisnik DohvatiKorisnika(string username, string password)
        {
            Korisnik odabrani = new Korisnik();
            List<Korisnik> listaKorisnika = new List<Korisnik>();
            using (var context = new PI2247_DBEntities1())
            {
                var query = from p in context.Korisniks
                            select p;
                listaKorisnika = query.ToList();
            }
            foreach (Korisnik item in listaKorisnika)
            {
                if(item.Password == password && username == item.Username)
                {
                    odabrani = item;
                    break;
                }
            }
            return odabrani;
        }

        public Korisnik DohvatiKorisnikaPoAdresi(string adresa)
        {
            Korisnik odabrani = new Korisnik();
            List<Korisnik> listaKorisnika = new List<Korisnik>();
            using (var context = new PI2247_DBEntities1())
            {
                var query = from p in context.Korisniks
                            select p;
                listaKorisnika = query.ToList();
            }
            foreach (Korisnik item in listaKorisnika)
            {
                if (item.Adresa == adresa)
                {
                    odabrani = item;
                    break;
                }
            }
            return odabrani;
        }
    }
}
