using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        var daniRamazana = new ArrayList();

        dan prvi = new dan(new DateTime(2023, 03, 23), new TimeOnly(4, 01), new TimeOnly(5, 39), new TimeOnly(11, 54), new TimeOnly(15, 20), new TimeOnly(18, 08), new TimeOnly(19, 34));
        dan drugi = new dan(new DateTime(2023, 03, 24), new TimeOnly(4, 00), new TimeOnly(5, 37), new TimeOnly(11, 54), new TimeOnly(15, 21), new TimeOnly(18, 09), new TimeOnly(19, 35));
        dan treci = new dan(new DateTime(2023, 03, 25), new TimeOnly(3, 58), new TimeOnly(5, 36), new TimeOnly(11, 53), new TimeOnly(15, 21), new TimeOnly(18, 10), new TimeOnly(19, 36));
        dan cetvrti = new dan(new DateTime(2023, 03, 26), new TimeOnly(4, 56), new TimeOnly(6, 34), new TimeOnly(11, 53), new TimeOnly(15, 22), new TimeOnly(18, 11), new TimeOnly(19, 38));
        dan peti = new dan(new DateTime(2023, 03, 27), new TimeOnly(4, 53), new TimeOnly(6, 34), new TimeOnly(12, 53), new TimeOnly(16, 22), new TimeOnly(19, 11), new TimeOnly(20, 38));
        dan sesti = new dan(new DateTime(2023, 03, 28), new TimeOnly(4, 51), new TimeOnly(6, 32), new TimeOnly(12, 53), new TimeOnly(16, 22), new TimeOnly(19, 13), new TimeOnly(20, 40));
        dan sedmi = new dan(new DateTime(2023, 03, 29), new TimeOnly(4, 48), new TimeOnly(6, 29), new TimeOnly(12, 52), new TimeOnly(16, 23), new TimeOnly(19, 15), new TimeOnly(20, 42));
        dan osmi = new dan(new DateTime(2023, 03, 30), new TimeOnly(4, 47), new TimeOnly(6, 27), new TimeOnly(12, 52), new TimeOnly(16, 24), new TimeOnly(19, 16), new TimeOnly(20, 43));
        dan deveti = new dan(new DateTime(2023, 03, 31), new TimeOnly(4, 45), new TimeOnly(6, 25), new TimeOnly(12, 52), new TimeOnly(16, 24), new TimeOnly(19, 18), new TimeOnly(20, 45));
        dan deseti = new dan(new DateTime(2023, 04, 01), new TimeOnly(4, 43), new TimeOnly(6, 23), new TimeOnly(12, 51), new TimeOnly(16, 25), new TimeOnly(19, 19), new TimeOnly(20, 47));
        dan jedanaesti = new dan(new DateTime(2023, 04, 02), new TimeOnly(4, 40), new TimeOnly(6, 21), new TimeOnly(12, 51), new TimeOnly(16, 25), new TimeOnly(19, 20), new TimeOnly(20, 48));
        dan dvanaesti = new dan(new DateTime(2023, 04, 03), new TimeOnly(4, 38), new TimeOnly(6, 19), new TimeOnly(12, 51), new TimeOnly(16, 25), new TimeOnly(19, 21), new TimeOnly(20, 49));
        dan trinaesti = new dan(new DateTime(2023, 04, 04), new TimeOnly(4, 35), new TimeOnly(6, 17), new TimeOnly(12, 50), new TimeOnly(16, 25), new TimeOnly(19, 22), new TimeOnly(20, 50));
        dan cetrnaesti = new dan(new DateTime(2023, 04, 05), new TimeOnly(4, 33), new TimeOnly(6, 15), new TimeOnly(12, 50), new TimeOnly(16, 26), new TimeOnly(19, 23), new TimeOnly(20, 52));
        dan petnaesti = new dan(new DateTime(2023, 04, 06), new TimeOnly(4, 31), new TimeOnly(6, 14), new TimeOnly(12, 50), new TimeOnly(16, 27), new TimeOnly(19, 24), new TimeOnly(20, 53));
        dan sesnaesti = new dan(new DateTime(2023, 04, 07), new TimeOnly(4, 29), new TimeOnly(6, 12), new TimeOnly(12, 50), new TimeOnly(16, 28), new TimeOnly(19, 25), new TimeOnly(20, 55));
        dan sedamnaesti = new dan(new DateTime(2023, 04, 08), new TimeOnly(4, 27), new TimeOnly(6, 10), new TimeOnly(12, 49), new TimeOnly(16, 28), new TimeOnly(19, 27), new TimeOnly(20, 57));
        dan osamnaesti = new dan(new DateTime(2023, 04, 09), new TimeOnly(4, 25), new TimeOnly(6, 08), new TimeOnly(12, 49), new TimeOnly(16, 29), new TimeOnly(19, 28), new TimeOnly(20, 58));
        dan devetnaesti = new dan(new DateTime(2023, 04, 10), new TimeOnly(4, 23), new TimeOnly(6, 06), new TimeOnly(12, 49), new TimeOnly(16, 30), new TimeOnly(19, 29), new TimeOnly(21, 00));
        dan dvadesti = new dan(new DateTime(2023, 04, 11), new TimeOnly(4, 21), new TimeOnly(6, 05), new TimeOnly(12, 48), new TimeOnly(16, 30), new TimeOnly(19, 31), new TimeOnly(21, 02));
        dan dvadesetprvi = new dan(new DateTime(2023, 04, 12), new TimeOnly(4, 18), new TimeOnly(6, 04), new TimeOnly(12, 48), new TimeOnly(16, 31), new TimeOnly(19, 32), new TimeOnly(21, 03));
        dan dvadesetdrugi = new dan(new DateTime(2023, 04, 13), new TimeOnly(4, 16), new TimeOnly(6, 02), new TimeOnly(12, 48), new TimeOnly(16, 31), new TimeOnly(19, 33), new TimeOnly(21, 05));
        dan dvadesettreci = new dan(new DateTime(2023, 04, 14), new TimeOnly(4, 14), new TimeOnly(6, 00), new TimeOnly(12, 48), new TimeOnly(16, 31), new TimeOnly(19, 34), new TimeOnly(21, 06));
        dan dvadesetcetvrti = new dan(new DateTime(2023, 04, 15), new TimeOnly(4, 12), new TimeOnly(5, 58), new TimeOnly(12, 47), new TimeOnly(16, 31), new TimeOnly(19, 36), new TimeOnly(21, 08));
        dan dvadesetpeti = new dan(new DateTime(2023, 04, 16), new TimeOnly(4, 09), new TimeOnly(5, 57), new TimeOnly(12, 47), new TimeOnly(16, 32), new TimeOnly(19, 37), new TimeOnly(21, 09));
        dan dvadesetsesti = new dan(new DateTime(2023, 04, 17), new TimeOnly(4, 07), new TimeOnly(5, 55), new TimeOnly(12, 47), new TimeOnly(16, 32), new TimeOnly(19, 38), new TimeOnly(21, 11));
        dan dvadesetsedmi = new dan(new DateTime(2023, 04, 18), new TimeOnly(4, 05), new TimeOnly(5, 53), new TimeOnly(12, 47), new TimeOnly(16, 32), new TimeOnly(19, 39), new TimeOnly(21, 13));
        dan dvadesetosmi = new dan(new DateTime(2023, 04, 19), new TimeOnly(4, 03), new TimeOnly(5, 52), new TimeOnly(12, 46), new TimeOnly(16, 33), new TimeOnly(19, 40), new TimeOnly(21, 15));
        dan dvadesetdeveti = new dan(new DateTime(2023, 04, 20), new TimeOnly(4, 01), new TimeOnly(5, 50), new TimeOnly(12, 46), new TimeOnly(16, 33), new TimeOnly(19, 41), new TimeOnly(21, 16));

        daniRamazana.Add(prvi);
        daniRamazana.Add(drugi);
        daniRamazana.Add(treci);
        daniRamazana.Add(cetvrti);
        daniRamazana.Add(peti);
        daniRamazana.Add(sesti);
        daniRamazana.Add(sedmi);
        daniRamazana.Add(osmi);
        daniRamazana.Add(deveti);
        daniRamazana.Add(deseti);
        daniRamazana.Add(jedanaesti);
        daniRamazana.Add(dvanaesti);
        daniRamazana.Add(trinaesti);
        daniRamazana.Add(cetrnaesti);
        daniRamazana.Add(petnaesti);
        daniRamazana.Add(sesnaesti);
        daniRamazana.Add(sedamnaesti);
        daniRamazana.Add(osamnaesti);
        daniRamazana.Add(devetnaesti);
        daniRamazana.Add(dvadesti);
        daniRamazana.Add(dvadesetprvi);
        daniRamazana.Add(dvadesetdrugi);
        daniRamazana.Add(dvadesettreci);
        daniRamazana.Add(dvadesetcetvrti);
        daniRamazana.Add(dvadesetpeti);
        daniRamazana.Add(dvadesetsesti);
        daniRamazana.Add(dvadesetsedmi);
        daniRamazana.Add(dvadesetosmi);
        daniRamazana.Add(dvadesetdeveti);
        //ponavljanje petlje sve dok se ne unese ispravan datum
        bool repeat = true;
        while (repeat) { 
        Console.WriteLine("Unesite dan ramazana kao dd/mm/yy: ");

        try { 
        string userInput = Console.ReadLine();
        DateTime usersDate = DateTime.Parse(userInput);

        foreach (dan d in daniRamazana)
        {
            if (d.date == usersDate)
            {
                Console.WriteLine("Datum: " + d.date.ToString("dd/MM/yyyy"));
                Console.WriteLine("Zora: " + d.zora.ToString("HH:mm"));
                Console.WriteLine("Izlazak sunca: " + d.izlazakSunca.ToString("HH:mm"));
                Console.WriteLine("Podne: " + d.podne.ToString("HH:mm"));
                Console.WriteLine("Ikindija: " + d.ikindija.ToString("HH:mm"));
                Console.WriteLine("Aksam: " + d.aksam.ToString("HH:mm"));
                Console.WriteLine("Jacija: " + d.jacija.ToString("HH:mm"));

                Console.WriteLine("Preostalo vrijeme posta: " + d.preostaloVrijemePosta());
                Console.WriteLine("Ukupan broj sati posta za taj dan: " + d.getTrajanje());
                Console.WriteLine("Broj preostalih dana do Bajrama: " + d.Bajram());
                repeat = false;
                break;
            }
        }
    }
            //u slučaju da smo pogriješili format datuma
             catch (Exception ex)
            {
                Console.WriteLine("Unesite ispravne podatke!");
            }

        }
    }

    public class dan
    {
        public DateTime date;
        public TimeOnly zora;
        public TimeOnly izlazakSunca;
        public TimeOnly podne;
        public TimeOnly ikindija;
        public TimeOnly jacija;
        public TimeOnly aksam;


        //konstruktor koji prima sve atribute
        public dan(DateTime date, TimeOnly zora, TimeOnly izlazakSunca, TimeOnly podne, TimeOnly ikindija, TimeOnly aksam, TimeOnly jacija)
        {
            this.date = date;
            this.zora = zora;
            this.izlazakSunca = izlazakSunca;
            this.podne = podne;
            this.ikindija = ikindija;
            this.aksam = aksam;
            this.jacija = jacija;
        }
        //getteri
        public DateTime GetDate()
        {
            return date;
        }
        public TimeOnly GetZora()
        {
            return zora;
        }
        public TimeOnly GetIzlazakSunca()
        {
            return izlazakSunca;
        }
        public TimeOnly GetPodne()
        {
            return podne;
        }

        public TimeOnly GetIkindija()
        {
            return ikindija;
        }
        public TimeOnly GetJacija()
        {
            return jacija;
        }
        public TimeOnly GetAksam()
        {
            return aksam;
        }
        //funkcija koja racuna trajanje posta 
        public TimeSpan getTrajanje()
        {
            TimeSpan trajanje = aksam - zora;
            return trajanje;
        }

        //funkcija koja racuna preostalo vrijeme posta
        public TimeSpan preostaloVrijemePosta()
        {
            TimeOnly trenutno = TimeOnly.FromDateTime(DateTime.Now);
            TimeSpan preostalo = aksam - trenutno;
            return preostalo;
        }
        public TimeSpan Bajram()
        {
            DateTime bajram = new DateTime(2023, 04, 21);
            DateTime trenutno = DateTime.Now;
            TimeSpan razlika = bajram - trenutno;
            return razlika;
        }

    }
}