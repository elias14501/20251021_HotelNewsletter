public class NewsletterAnmeldung
{
    public string Nachname;         // Freier Text (noch ohne Überprüfung)
    public string Mail;             // Freier Text (noch ohne Überprüfung)
    public bool DurchFreunde;       // Aufmerksam? durch Freunde
    public bool DurchInternet;      // Aufmerksam? durch Internet
    public string MeistAnsprechend; // Mindestens "Ausstattung" und "Lage"
    public sbyte NextUrlaub;        // Nächster Urlaub: 1 = in 1-3Mt, 6 = in 6 Mt, -1 = undefiniert
    public string Mitteilung;       // Freier Text, kann auch leer sein

    public NewsletterAnmeldung(string nachname, string mail, bool durchFreunde, bool durchInternet, string meistAnsprechend, sbyte nextUrlaub, string mitteilung)
    {
        Nachname = nachname;
        Mail = mail;
        DurchFreunde = durchFreunde;
        DurchInternet = durchInternet;
        MeistAnsprechend = meistAnsprechend;
        NextUrlaub = nextUrlaub;
        Mitteilung = mitteilung;
    }
}

