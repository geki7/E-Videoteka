# e-Videoteka
Aplikacija koja funkcionira kao Netflix na LAN razini. Omogućuje registriranje korisnika, prijavu, dodavanje filma, izmjenu korisnika, prilikom registracije u pozadini se automatski u Windows servirs dodaje servis koji će kasnije provjeravati je li pokrenut ili ne kako bi se moglo utvrditi želi li korisnik omogućiti gledanje filmova korisnicima.
Nalazi se posebna klasa "WorkerService" koja omogućuje kreiranje servisa na računalo sa Windows operacijskim sustavom. Instalirani su dodatci VLC kako bi se mogao pokretati određeni film. 
