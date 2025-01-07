namespace Natale2024.Argomenti
{
    public static class EnumStructCast
    {
        public static void StampaEnum<T>() where T : Enum
        {
            Console.WriteLine("Valori di {0}:", nameof(T));
            foreach (T e in Enum.GetValues(typeof(T)))
            {
                Console.WriteLine("\tId: {0}", e);
            }
            Console.WriteLine();
        }
        public static void Parti()
        {
            Console.WriteLine("Esercizi sugli enum, struct e cast");

            // ES - 1
            Console.WriteLine("1. Creare un enum per rappresentare i giorni della settimana e iterare sui valori.");
            StampaEnum<GiornoSettimana>();

            // ES - 2
            Console.WriteLine("2. Dichiarare un enum per rappresentare i livelli di priorità di un task.");
            StampaEnum<LivelloPriorita>();

            // ES - 3
            Console.WriteLine("3. Usare un enum per selezionare un'opzione in uno switch-case.");
            Opzione selezione = Opzione.OPZIONE_A;
            switch (selezione)
            {
                case Opzione.OPZIONE_A:
                    Console.WriteLine("\tHai scelto Opzione A");
                    break;
                case Opzione.OPZIONE_B:
                    Console.WriteLine("\tHai scelto Opzione B");
                    break;
                case Opzione.OPZIONE_C:
                    Console.WriteLine("\tHai scelto Opzione C");
                    break;
            }
            Console.WriteLine();

            // ES - 4
            Console.WriteLine("4. Dichiarare una struct per rappresentare un punto 2D e calcolare la distanza tra due punti.");
            Punto2D punto1 = new(3, 4);
            Punto2D punto2 = new(0, 0);
            Console.WriteLine("\tLa distanza tra i due punti è: {0}\n", punto1.DistanzaDa(punto2));

            // ES - 5
            Console.WriteLine("5. Creare una struct per rappresentare un rettangolo e calcolarne l'area.");
            Rettangolo rettangolo = new(5, 10);
            Console.WriteLine("\tL'area del rettangolo è: {0}\n", rettangolo.Area());

            // ES - 6
            Console.WriteLine("6. Utilizzare un enum per rappresentare i tipi di un veicolo in un programma.");
            StampaEnum<Veicolo>();

            // ES - 7
            Console.WriteLine("7. Dichiarare una struct con un costruttore e un metodo.");
            Console.WriteLine("\tStruct \"Punto\" creata con parametri (x,y) e motodo \"DistanzaDa\"\n");

            // ES - 8
            Console.WriteLine("8. Scrivere un programma che converte un valore int in un enum usando il casting.");
            int e8 = 0;
            Console.WriteLine("\tIl numero {0} equivale a {1} nell'enum giornoSettimana\n", e8, (GiornoSettimana)e8);

            // ES - 10
            Console.WriteLine("10. Creare una struct per rappresentare un colore in formato RGB.");
            ColoreRgb colore = new(255, 0, 0);
            Console.WriteLine("\tIl colore è: {0}\n", colore.ToString());

            // ES - 12
            Console.WriteLine("12. Dichiarare una struct con proprietà readonly.");
            Console.WriteLine("\tStruct \"Punto\" creata con parametri (x,y) e motodo \"DistanzaDa\" readonly\n");

            // ES - 13
            Console.WriteLine("13. Creare un enum per rappresentare i mesi dell'anno.");
            StampaEnum<MeseAnno>();

            // ES - 14
            Console.WriteLine("14. Dichiarare una struct per rappresentare una persona con nome e età.");
            Persona persona = new("Mario", 30);
            Console.WriteLine("\tNome: {0}, Età: {1}\n", persona.Nome, persona.Eta);

            // ES - 15
            Console.WriteLine("15. Scrivere un programma che utilizza il casting esplicito tra tipi numerici.");
            double e15 = 5.75;
            Console.WriteLine("\tIl valore castato a float è: {0}", (float)e15);

            // ES - 16
            Console.WriteLine("16. Dichiarare un enum per rappresentare i tipi di errore di un'app.");
            StampaEnum<TipoErroreApp>();

            // ES - 17
            Console.WriteLine("17. Creare una struct per rappresentare una posizione 3D e calcolarne la distanza.");
            Punto3D p1 = new(1, 2, 3);
            Punto3D p2 = new(4, 5, 6);
            Console.WriteLine("\tLa distanza tra i due punti: {0}", p1.DistanzaDa(p2));

            // ES - 18
            Console.WriteLine("18. Utilizzare un enum per definire i tipi di permesso di un'app.");
            StampaEnum<PermessoApp>();

            // ES - 19
            Console.WriteLine("19. Dichiarare una struct per rappresentare una data personalizzata.");
            Data data = new (21, 1, 2030);
            Console.WriteLine("\tLa data è: {0}\n", data.ToString());

            // ES - 20
            Console.WriteLine("20. Creare una struct per rappresentare una carta da gioco (valore e seme).");
            CartaDaGioco carta = new("Asso", "Cuori");
            Console.WriteLine("\tLa carta è: {0}\n", carta.ToString());

            // ES - 21
            Console.WriteLine("21. Utilizzare un enum in un'istruzione condizionale.");
            Opzione opzione = Opzione.OPZIONE_A;
            if (opzione == Opzione.OPZIONE_A)
            {
                Console.WriteLine("\tCondizione vera\n");
            }
            else
            {
                Console.WriteLine("\tCondizione false\n");
            }

            // ES - 22
            Console.WriteLine("22. Dichiarare una struct che contiene un array come proprietà.");
            Vettore10 vettoreE22 = new();
            Console.WriteLine("\tStruct creato: {0}\n", vettoreE22.ToString());

            // ES - 23
            Console.WriteLine("23. Scrivere un programma che converte un valore double in float usando il casting esplicito.");
            double e23 = 7.25;
            Console.WriteLine("\tIl valore castato a float è: {0}\n", (float)e23);

            // ES - 24
            Console.WriteLine("24. Utilizzare un enum per rappresentare i tipi di file supportati da un'app.");
            StampaEnum<TipoFile>();

            // ES - 25
            Console.WriteLine("25. Creare una struct per rappresentare un vettore e calcolare il prodotto scalare.");
            Vettore10 vettoreE25 = new();
            Console.WriteLine("\tIl prodotto scalare è: {0}\n", vettoreE25.ProdottoScalare(vettoreE22));
        }

        public enum GiornoSettimana { LUNEDI, MARTEDI, MERCOLEDI, GIOVEDI, VENERDI, SABATO, DOMENICA }
        public enum LivelloPriorita { BASSA, MEDIA, ALTA }
        public enum Opzione { OPZIONE_A, OPZIONE_B, OPZIONE_C }
        public enum Veicolo { SENZA_MOTORE, CICLOMOTORI, MOTOVEICOLI, AUTOVEICOLI }
        public enum MeseAnno
        { 
            GENNAIO = 1,
            FEBBRAIO = 2,
            MARZO = 3,
            APRILE = 4,
            MAGGIO = 5,
            GIUGNO = 6, 
            LUGLIO = 7,
            AGOSTO = 8,
            SETTEMBRE = 9,
            OTTOBRE = 10,
            NOVEMBRE = 11,
            DICEMBRE = 12
        }
        public enum TipoErroreApp { ERRORE1, ERRORE2, ERRORE3 }
        public enum PermessoApp { LETTURA, SCRITTURA, ESECUZIONE }
        public enum TipoFile { PDF, DOCX, JPEG, PNG }
        public struct Punto2D (double x, double y)
        {
            public double X { get; set; } = x;
            public double Y { get; set; } = y;
            public readonly double DistanzaDa(Punto2D altro)
            {
                return Math.Sqrt( Math.Pow(X - altro.X, 2) + Math.Pow(Y - altro.Y, 2) );
            }
        }

        public struct Rettangolo ( double larghezza, double altezza )
        {
            public double Larghezza { get; set; } = larghezza;
            public double Altezza{ get; set; } = altezza;

            public readonly double Area()
            {
                return Larghezza * Altezza;
            }
        }

        public struct ColoreRgb ( byte red, byte green, byte blue )
        {
            public byte Red { get; set; } = red;
            public byte Green { get; set; } = green;
            public byte Blue { get; set; } = blue;

            public override readonly string ToString()
            {
                return "#" + Red.ToString("X") + Green.ToString("X") + Blue.ToString("X");
            }
        }

        public struct Persona ( string nome, int eta )
        {
            public string Nome { get; set; } = nome;
            public int Eta { get; set; } = eta;
        }
        public struct Punto3D (double x, double y, double z)
        {
            public double X { get; set; } = x;
            public double Y { get; set; } = y;
            public double Z  { get; set; } = z;
            public readonly double DistanzaDa(Punto3D altro)
            {
                return Math.Sqrt(Math.Pow(X - altro.X, 2) + Math.Pow(Y - altro.Y, 2) + Math.Pow(Z - altro.Z, 2));
            }
        }
        public struct Data (int giorno, int mese, int anno)
        {
            public int Giorno { get; set; } = giorno;
            public int Mese { get; set; } = mese;
            public int Anno { get; set; } = anno;

            public override readonly string ToString()
            {
                return $"{Giorno:DD}/{Mese:DD}/{Anno:DDDD}";
            }
        }
        public struct CartaDaGioco (string valore, string seme)
        {
            public string Valore { get; set; } = valore;
            public string Seme { get; set; } = seme;
            public override readonly string ToString()
            {
                return Valore + " di " + Seme;
            }
        }
        public readonly struct Vettore10 ()
        {
            private readonly int[] vettore = [ 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 ];
            public readonly int[] Vettore => vettore;

            public readonly int ProdottoScalare(Vettore10 altro)
            {
                int somma = 0;
                for ( int i = 0; i < vettore.Length; i++ )
                {
                    somma += vettore[i] * altro.Vettore[i];
                }
                return somma;
            }

            public override readonly string ToString()
            {
                return $"[{string.Join(", ", vettore)}]";
            }
        }

    }
}