using System;
using System.Collections.Generic;
using System.Linq;

namespace YatzyBibliotek
{
    public class PoengBibliotek
    {
        // Offentlig liste som viser alle mulige kategorier
        private List<string> kategorier = new List<string>()
        {
                "enere","toere","treere","firere","femmere",
                "seksere","par","to par","tre like","fire like",
                "liten straight","stor straight","fullt hus","sjanse","yatzy"
        };

        // Metode som vil skrive i konsollen alle mulige valg av kategorier
        public void getKategorier()
        {
            Console.WriteLine(string.Format("Her er liste over alle mulige kategorier: {0}.", string.Join(",", kategorier)));
        }

        // Hoved metode som vil starte kalkulasjonen med gitt terningsøyne of kategori
        public int kalkulerPoengsum(string terninger, string kategori)
        {
            // Her initialiseres poengsum og terningsøynene konverteres til int array
            List<int> terningListe = new List<int>(konverterTerninger(terninger));

            int poengSum = 0;

            // Her gjør vi kategori strengen om til små bokstaver så det passer sammenligning av kategori listen
            kategori = kategori.ToLower();

            // Liste med alle kategoriene som er gyldig


            // Her valideres en oppgitte kategorien for å sjekke om den er gyldig
            if (!kategorier.Contains(kategori))
            {
                throw new ArgumentException("Ugyldig kategori oppgitt!");
            }

            // Her er switchen som sjekker gitt kategori og utfører kalkulasjon for den kategorien 
            switch (kategori)
            {
                case "enere":
                    poengSum = beregnLike(terningListe, kategori);
                    break;
                case "toere":
                    poengSum = beregnLike(terningListe, kategori);
                    break;
                case "treere":
                    poengSum = beregnLike(terningListe, kategori);
                    break;
                case "firere":
                    poengSum = beregnLike(terningListe, kategori);
                    break;
                case "femmere":
                    poengSum = beregnLike(terningListe, kategori);
                    break;
                case "seksere":
                    poengSum = beregnLike(terningListe, kategori);
                    break;
                case "par":
                    poengSum = beregnPar(terningListe);
                    break;
                case "to par":
                    poengSum = beregnToPar(terningListe);
                    break;
                case "tre like":
                    poengSum = beregnTreLike(terningListe);
                    break;
                case "fire like":
                    poengSum = beregnFireLike(terningListe);
                    break;
                case "liten straight":
                    poengSum = beregnLitenStraight(terningListe);
                    break;
                case "stor straight":
                    poengSum = beregnStorStraight(terningListe);
                    break;
                case "fullt hus":
                    poengSum = beregnFulltHus(terningListe);
                    break;
                case "sjanse":
                    poengSum = beregnSjanse(terningListe);
                    break;
                case "yatzy":
                    poengSum = beregnYatzy(terningListe);
                    break;
                default:
                    break;
            }

            return poengSum;
        }

        // METODE FOR Å FINNE KATEGORI MED HØYEST POENGSUM
        public string[] finnBesteKategori(string terninger)
        {
            string[] resultat = new string[2];
            int høyestePoengSum = 0;
            string høyesteKategori = "Ingen kategori";

            // Går gjennom alle kategorier og kalkulerer poengsummen for hver kategori
            foreach (string kategori in kategorier)
            {
                int midlertidigResultat = kalkulerPoengsum(terninger, kategori);
                // Hvis vi finner en kategori med høyere resultat lagres denne
                if (midlertidigResultat > høyestePoengSum)
                {
                    høyestePoengSum = midlertidigResultat;
                    høyesteKategori = kategori;
                }
            }
            // Putter inn de kalkularte variablene inn i resultat 
            resultat[0] = høyesteKategori;
            resultat[1] = høyestePoengSum.ToString();

            Console.WriteLine("Her er kategori: " + resultat[0] + " denne ga poengsummen: " + resultat[1]);
            // Returnerer streng array med kategorien og poengsummen
            return resultat;
        }

        // METODER FOR BEREGNING AV POENGSUMMER

        // Kategorier: enere,toere,treere,firere,femmere,seksere
        private int beregnLike(List<int> terningListe, string kategori)
        {
            int poengSum = 0;
            switch (kategori)
            {
                case "enere":
                    foreach (int terning in terningListe)
                    {
                        if (terning == 1)
                        {
                            poengSum += terning;
                        }
                    }
                    break;
                case "toere":
                    foreach (int terning in terningListe)
                    {
                        if (terning == 2)
                        {
                            poengSum += terning;
                        }
                    }
                    break;
                case "treere":
                    foreach (int terning in terningListe)
                    {
                        if (terning == 3)
                        {
                            poengSum += terning;
                        }
                    }
                    break;
                case "firere":
                    foreach (int terning in terningListe)
                    {
                        if (terning == 4)
                        {
                            poengSum += terning;
                        }
                    }
                    break;
                case "femmere":
                    foreach (int terning in terningListe)
                    {
                        if (terning == 5)
                        {
                            poengSum += terning;
                        }
                    }
                    break;
                case "seksere":
                    foreach (int terning in terningListe)
                    {
                        if (terning == 6)
                        {
                            poengSum += terning;
                        }
                    }
                    break;
                default:
                    break;
            }

            return poengSum;
        }

        // KATEGORI PAR
        private int beregnPar(List<int> terningListe)
        {
            int resultat = 0;

            // Løkke som blar gjennom alle terningene
            for (int i = 0; i < terningListe.Count; i++)
            {
                // Løkke som blar gjennom alle terningene et hakk etter forrige løkke
                for (int j = i + 1; j < terningListe.Count; j++)
                {
                    // Sjekker om nåværende terning er lik neste
                    if (terningListe[i] == terningListe[j])
                    {
                        // Legger til terningen i resultat så lenge den er større en nåværende resultat
                        if (terningListe[i] > resultat)
                        {
                            resultat = terningListe[i];
                        }
                    }
                }
            }

            return resultat * 2;
        }

        // KATEGORI TO PAR
        private int beregnToPar(List<int> terningListe)
        {
            int poengSum = 0;
            // Her lager vi en liste som vil lagrer parene
            List<int> par = new List<int>();

            // Denne løkken sjekker hvor mange ganger den finner tallene 1 til 6
            for (int i = 1; i <= 6; i++)
            {
                int teller = 0;

                // Denne løkken sjekker med alle terningene i listen og finner vi lik terning til tallet øker vi teller
                foreach (int terning in terningListe)
                {
                    if (terning == i)
                    {
                        teller++;
                    }
                }

                // Hvis vi finner 4 like tall da har vi 2 par, finner vi 2 eller 3, da har vi 1 par av dette tallet
                if (teller == 4)
                {
                    par.Add(i);
                    par.Add(i);
                }
                else if (teller >= 2)
                {
                    par.Add(i);
                }
            }

            // Hvis vi har funnet 2 par da kan vi kalkulere poengsummen
            if (par.Count == 2)
            {
                foreach (int terning in par)
                {
                    poengSum += (terning * 2);
                }
            }

            return poengSum;
        }

        // KATEGORI TRE LIKE
        private int beregnTreLike(List<int> terningListe)
        {
            int resultat = 0;
            // Løkke som blar gjennom tallet 1 til 6 som representerer øynene
            for (int i = 1; i <= 6; i++)
            {
                int teller = 0;
                // Løkke som blar gjennom terningene
                foreach (int terning in terningListe)
                {
                    // Hvis vi finner en terning som er like det nåværende tallet så øker vi teller
                    if (terning == i)
                    {
                        teller++;
                    }
                }
                // Hvis telleren er større eller lik 3 så har vi funnet 3 like
                if (teller >= 3)
                {
                    resultat = i;
                }
            }

            return resultat * 3;
        }

        // KATEGORI FIRE LIKE
        private int beregnFireLike(List<int> terningListe)
        {
            int poengSum = 0;
            for (int i = 1; i <= 6; i++)
            {
                int teller = 0;
                foreach (int terning in terningListe)
                {
                    if (terning == i)
                    {
                        teller++;
                    }
                }

                // Hvis det blir funnet 4 like eller mer så legger vi tallet multiplisert med 4 til i summen
                if (teller >= 4)
                {
                    poengSum += (i * 4);
                }
            }

            return poengSum;
        }

        // KATEGORI LITEN STRAIGHT
        private int beregnLitenStraight(List<int> terningListe)
        {
            int poengSum = 0;
            // Her lager vi en ny liste som tar unike verdier fra original listen
            List<int> litenStraightListe = terningListe.Distinct().ToList();
            // Deretter sorterer vi listen stigende
            litenStraightListe.Sort();

            // Sjekker om listen har 5 terninger,siste terning er 5 og første terning er 1
            if (litenStraightListe.Count == 5 && litenStraightListe[0] == 1 && litenStraightListe[4] == 5)
            {
                poengSum = 15;
            }

            return poengSum;
        }

        // KATEGORI STOR STRAIGHT
        private int beregnStorStraight(List<int> terningListe)
        {
            int poengSum = 0;
            // Her lager vi en ny liste som tar unike verdier fra original listen
            List<int> storStraightListe = terningListe.Distinct().ToList();
            // Deretter sorterer vi listen stigende
            storStraightListe.Sort();

            // Sjekker om listen har 5 terninger,siste terning er 6 og første terning er 2
            if (storStraightListe.Count == 5 && storStraightListe[0] == 2 && storStraightListe[4] == 6)
            {
                poengSum = 20;
            }

            return poengSum;
        }

        // KATEGORI FULLT HUS
        private int beregnFulltHus(List<int> terningListe)
        {
            int poengSum = 0;
            int toLike = 0;
            int treLike = 0;

            // Løkke som går gjennom tallene 1 til 6 og teller hvor mange like som finnes
            for (int i = 1; i <= 6; i++)
            {
                int teller = 0;
                foreach (int terning in terningListe)
                {
                    if (terning == i)
                    {
                        teller++;
                    }
                }
                // Ender vi opp med to like har vi et par
                if (teller == 2)
                {
                    toLike = 2 * i;
                    // Ender vi opp med tre like har vi en trio
                }
                else if (teller == 3)
                {
                    treLike = 3 * i;
                }
            }

            // Hvis vi har et par og en trio så har vi fullt hus og kan kalkulere resultat
            if (treLike > 0 && toLike > 0)
            {
                poengSum = treLike + toLike;
            }

            return poengSum;
        }

        // KATEGORI SJANSE
        private int beregnSjanse(List<int> terningListe)
        {
            int poengSum = 0;
            // Her adderes hver terning inn i poengsummen
            foreach (int terning in terningListe)
            {
                poengSum += terning;
            }

            return poengSum;
        }

        // KATEGORI YATZY
        private int beregnYatzy(List<int> terningListe)
        {
            int poengSum = 0;
            // Løkke som løper gjennom tallet 1 til 6 og teller hvor mange ganger vi finner duplikater av et tall
            for (int i = 1; i <= 6; i++)
            {
                int teller = 0;
                foreach (int terning in terningListe)
                {
                    if (terning == i)
                    {
                        teller++;
                    }
                }

                // Har vi 5 like tall har vi nådd yatzy
                if (teller == 5)
                {
                    poengSum = 50;
                }
            }

            return poengSum;
        }

        // VALIDERING AV TERNINGER

        // Denne metoden validerer og konverterer strengen med terningsøyne til integer array
        private int[] konverterTerninger(string terningsØyne)
        {
            int[] resultat = { };
            // Hvis vi ikke mottar noen terninger får vi error
            if (terningsØyne.Length <= 0)
            {
                throw new ArgumentException("Ingen terningsøyne oppgitt!");
            }

            // Hvis det er feil format på terningene får vi error
            // Eksempel: 1.2.3.4.5
            try
            {
                resultat = Array.ConvertAll(terningsØyne.Split(','), int.Parse);
            }
            catch (FormatException)
            {
                throw new FormatException("Feil format på terningene som ble oppgitt!");
            }

            validerTerninger(resultat);

            return resultat;

        }

        // Metode for validering av terningsøynene 
        private void validerTerninger(int[] terningsØyne)
        {
            // Hvis vi ikke blir gitt 5 terninger får vi error
            if (terningsØyne.Length != 5)
            {
                throw new ArgumentException("Kalkulasjonen trenger 5 terninger, du oppga " + terningsØyne.Length + " !");
            }

            // Hvis noen av terningene er større enn 6 eller mindre enn 1 får vi error
            foreach (int terning in terningsØyne)
            {
                if (terning < 1)
                {
                    throw new ArgumentException("Terningene kan ikke ha mindre enn 1 øye, du oppga " + terning + " !");

                }
                else if (terning > 6)
                {
                    throw new ArgumentException("Terningene kan ikke ha flere øyer enn 6, du oppga " + terning + " !");
                }
            }

        }
    }
}
