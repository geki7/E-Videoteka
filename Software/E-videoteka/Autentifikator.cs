namespace E_videoteka
{
    public class Autentifikator
    {
        public RepozitorijKorisnika repozitorij = new RepozitorijKorisnika();

        public void Registracija(string ime, string prezime, string email, string username, string password, string passwordrep)
        {
            ProvjeriLozinku(password, passwordrep);
            VerificirajRegistraciju(ime, prezime, email, username, password, passwordrep);
            string adresa = "Adresa nije potrebna";
            string uloga = "Korisnik";
            repozitorij.DodajKorisnika(ime, prezime, email, username, password, adresa, uloga);
        }

        public void ProvjeriLozinku(string password, string passwordrep)
        {
            if (password != passwordrep)
            {
                throw new PasswordMissMatchException("Lozinke nisu iste");
            }
        }

        public void VerificirajRegistraciju(string ime, string prezime, string email, string username, string password, string passwordrep)
        {
            if (ime == "")
            {
                throw new InvalidInputException("Polje Ime ne može biti prazno");
            }
            if (prezime == "")
            {
                throw new InvalidInputException("Polje Prezime ne može biti prazno");
            }
            if (email == "")
            {
                throw new InvalidInputException("Polje E-mail ne može biti prazno");
            }
            if (username == "")
            {
                throw new InvalidInputException("Polje Username ne može biti prazno");
            }
            if (password == "")
            {
                throw new InvalidInputException("Polje Lozinka ne može biti prazno");
            }
            if (passwordrep == "")
            {
                throw new InvalidInputException("Polje Ponovljena lozinka ne može biti prazno");
            }
        }
    }
}
