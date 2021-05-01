using System;
using System.Collections.Generic;

namespace YatzyBibliotek
{
    public class PoengBibliotek
    {
        // Hoved metode som vil starte kalkulasjonen med gitt terningsøyne of kategori
        public int kalkulerPoengsum(string terninger, string kategori)
        {
            // Her initialiseres poengsum og terningsøynene konverteres til int array
            int [] konvertertTerninger = konverterTerninger(terninger);
            List<int> terningListe = new List<int>(konvertertTerninger);
           
            int poengSum = 0;

            // Her gjør vi kategori strengen om til små bokstaver så det passer sammenligning av kategori listen
            kategori = kategori.ToLower();
            
            // Liste med alle kategoriene som er gyldig
            List<string> kategorier = new List<string>(){
                "enere","toere","treere","firere","femmere",
                "seksere","par","to par","tre like","fire like",
                "liten straight","stor straight","fullt hus","sjanse","yatzy"
            };
            
            // Her valideres en oppgitte kategorien for å sjekke om den er gyldig
            if (!kategorier.Contains(kategori))
            {
                throw new ArgumentException("Ugyldig kategori oppgitt!");
            }
            
            switch (kategori)
            {
                case "enere":
                    foreach (int terning in terningListe)
                    {
                        if(terning == 1)
                        {
                            poengSum += terning;
                        }
                    }
                    break;
                case "toere":
                    foreach (int terning in terningListe)
                    {
                        if(terning == 2)
                        {
                            poengSum += terning;
                        }
                    }
                    break;
                case "treere":
                    foreach (int terning in terningListe)
                    {
                        if(terning == 3)
                        {
                            poengSum += terning;
                        }
                    }
                    break;
                case "firere":
                    foreach (int terning in terningListe)
                    {
                        if(terning == 4)
                        {
                            poengSum += terning;
                        }
                    }
                    break;
                case "femmere":
                    foreach (int terning in terningListe)
                    {
                        if(terning == 5)
                        {
                            poengSum += terning;
                        }
                    }
                    break;
                case "seksere":
                    foreach (int terning in terningListe)
                    {
                        if(terning == 6)
                        {
                            poengSum += terning;
                        }
                    }
                    break;
                case "par":
                    int resultat = 0;
                    for (int i = 0; i < terningListe.Count; i++)
                    {
                        for (int j = i + 1; j < terningListe.Count; j++)
                        {
                            if(terningListe[i] == terningListe[j])
                            {
                                if (terningListe[i] > resultat)
                                {
                                    resultat = terningListe[i];
                                }
                            }
                        }
                    }
                    poengSum += (resultat*2);
                    break;
                case "to par":
                    // Her lager vi en liste som vil lagrer parene
                    List<int> par = new List<int>();

                    // Denne løkken sjekker hvor mange ganger den finner tallene 1 til 6
                    for (int i = 0; i <= 6; i++)
                    {
                        int teller = 0;
                        foreach (int terning in terningListe)
                        {
                            if (terning == i)
                            {
                                teller++;
                            }
                        }

                        // Hvis den har funnet et tall 4 ganger så har vi 2 par på det tallet
                        if (teller == 4)
                        {
                            par.Add(i);
                            par.Add(i);
                        
                        // Hvis den har funnet et tall 2 eller 3 ganger da har vi bare 1 par funnet på det tallet
                        } else if (teller >= 2)
                        {
                            par.Add(i);
                        }
                    }

                    // Så lenge det er funnet to par kan vi kalkulere poengsummen
                    if (par.Count == 2)
                    {
                        foreach (int terning in par)
                        {
                            poengSum += (terning*2);
                        }
                    }


                    break;
                case "tre like":
                    break;
                case "fire like":
                    break;
                case "liten straight":
                    break;
                case "stor straight":
                    break;
                case "fullt hus":
                    break;
                case "sjanse":
                    break;
                case "yatzy":
                    break;
                default:
                break;
            }

            return poengSum;
        }
    
        // Denne metoden validerer og konverterer strengen med terningsøyne til integer array
        private int [] konverterTerninger(string terningsØyne)
        {
            int [] resultat = {};
            if(terningsØyne.Length <= 0) 
            {
                throw new ArgumentException("Ingen terningsøyne oppgitt!");
            }

            try
            {
                resultat = System.Array.ConvertAll(terningsØyne.Split(','), int.Parse);
            }
            catch (System.FormatException)
            {
                throw new FormatException("Feil format på terningsøynene, husk å ha de kommaseparert!");
            }

            validerTerninger(resultat);

            return resultat;

        }

        // Metode for validering av terningsøynene 
        private void validerTerninger (int [] terningsØyne)
        {
            if (terningsØyne.Length != 5)
            {
                throw new ArgumentException("Kalkulasjonen trenger 5 terninger, du oppga "+terningsØyne.Length+" !");
            }

            foreach (int terning in terningsØyne)
            {
                if(terning < 1 )
                {
                    throw new ArgumentException("Terningene kan ikke ha mindre enn 1 øye, du oppga "+terning+" !");

                } else if (terning > 6) 
                {
                    throw new ArgumentException("Terningene kan ikke ha flere øyer enn 6, du oppga "+terning+" !");
                }
            }

        }
    }
}
