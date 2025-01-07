namespace Natale2024.Argomenti 
{
    public class Classi
    {
        public static void Parti()
        {
            Console.WriteLine("Esercizi sulle classi.");

            List<Persona> persone =
            [
                new("Alice", 25),
                new("Bob", 30),
                new("Charlie", 35)
            ];

            List<Lavoro> lavori =
            [
                new Lavoro("Ingegnere", "Progetta e costruisce"),
                new Lavoro("Medico", "Cura i pazienti"),
                new Lavoro("Insegnante", "Insegna agli studenti")
            ];

            Random random = new();
            foreach (Persona persona in persone)
            {
                persona.Lavoro = lavori[random.Next(0, lavori.Count - 1)];
            }

            foreach (Persona persona in persone)
            {
                persona.Saluta();
                persona.AnnunciaEta();
                persona.AnnunciaLavoro();
                Console.WriteLine();
            }
        }
    }

    // ES - 6, 7
    public class Rubrica
    {
        public List<Persona> Contatti { get; set; } = [];

        public Persona this[int i]
        {
            get => Contatti[i];
            set => Contatti[i] = value;
        }
    }

    // ES - 1, 2, 5
    public class Persona ( string nome, int eta, Lavoro? lavoro = null )
    {
        public string Nome { get; set; } = nome;
        public int Eta { get; set; } = eta;
        public Lavoro? Lavoro { get; set; } = lavoro;

        public void Saluta()
        {
            Console.WriteLine($"Ciao, mi chiamo {Nome}.");
        }

        public void AnnunciaEta()
        {
            Console.WriteLine($"Ho {Eta} anni.");
        }

        public void AnnunciaLavoro()
        {
            if (Lavoro != null)
            {
                Console.WriteLine($"Lavoro come {Lavoro.Nome}. {Lavoro.Descrizione}");
            }
            else
            {
                Console.WriteLine("Non ho ancora un lavoro.");
            }
        }
    }

    public class Lavoro (string nome, string descrizione)
    {
        public string Nome { get; set; } = nome;
        public string Descrizione { get; set; } = descrizione;
    }

    // ES - 3
    public class Punto (double x, double y)
    {
        public double X { get; set; } = x;
        public double Y { get; set; } = y;

        public double CalcolaDistanza(Punto altro)
        {
            return Math.Sqrt(Math.Pow(X - altro.X, 2) + Math.Pow(Y - altro.Y, 2));
        }
    }

    // ES - 4
    public class PuntoColorato(double x, double y, EnumStructCast.ColoreRgb colore) : Punto(x, y)
    {
        public EnumStructCast.ColoreRgb Colore { get; set; } = colore;
    }

    // Creare una classe con proprietà indicizzate.
    public class ArchivioDocumenti
    {
        private Dictionary<int, string> documenti = new Dictionary<int, string>();

        public string this[int id]
        {
            get { return documenti.ContainsKey(id) ? documenti[id] : null; }
            set { documenti[id] = value; }
        }
    }
}
