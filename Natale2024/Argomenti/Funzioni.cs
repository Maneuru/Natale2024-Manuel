namespace Natale2024.Argomenti
{
    public static class Funzioni
    {
        public static void Parti()
        {
            Console.WriteLine("Esercizi sulle Funzioni");

            // Es - 1
            Console.WriteLine("1. Dichiarare una funzione che restituisce un valore di tipo int e accetta due parametri.");
            Console.WriteLine("\tResto tra 6 e 5: {0}\n", Resto(6, 5));

            // Es - 2
            Console.WriteLine("2. Creare una funzione void che stampa un messaggio a console.");
            StampaMessaggio();

            // Es - 3
            Console.WriteLine("3. Scrivere una funzione che accetta un parametro string e restituisce la lunghezza della stringa.");
            Console.WriteLine("\tLunghezza della stringa \"Alberto\": {0}\n", LunghezzaStringa("Alberto"));

            // Es - 4
            Console.WriteLine("4. Dichiarare una funzione con un parametro opzionale.");
            Console.WriteLine("\tSenza parametro: {0}", Saluta());
            Console.WriteLine("\tCon parametro: {0}", Saluta("Bryseis"));

            // Es - 5
            Console.WriteLine("5. Scrivere una funzione che accetta un array come parametro.");
            int[] e5 = [ 1, 2, 3 ];
            Console.WriteLine("\tMoltiplicazione degli elementi dell'array: {0}\n", MoltiplicazioneArray(e5));

            // Es - 6
            Console.WriteLine("6. Scrivere una funzione che calcola il fattoriale di un numero.");
            Console.WriteLine("\tFattoriale di 5: {0}\n", Fattoriale(5));

            // Es - 7
            Console.WriteLine("7. Dichiarare una funzione che restituisce un valore di tipo bool basato su una condizione.");
            Console.WriteLine("\t10 è divisibile per 3? {0}\n", Divisibile(10, 3));

            // Es - 8
            Console.WriteLine("8. Creare una funzione che utilizza un'eccezione per gestire input non validi. (try - catch)");
            Console.WriteLine("\tCerca di parsare a int l'input \"12\". Risposta: {0}", TryParseInt("12"));
            Console.WriteLine("\tCerca di parsare a int l'input \"a1\". Risposta: {0}\n", TryParseInt("a1"));

            // Es - 9
            Console.WriteLine("9. Dichiarare una funzione che restituisce una lista di numeri.");
            List<int> lista = CreaLista(5);
            Console.WriteLine("\tLista di numeri: {0}\n", string.Join(", ", lista));

            // Es - 10
            Console.WriteLine("10. Scrivere una funzione che accetta e restituisce oggetti di una classe custom.");
            Mago mago = new("Gandalf", 10);
            Console.WriteLine("\tMago {0} (spell: {1})", mago.Nome, mago.Spell);
            mago = AggiungiSpell(mago);
            Console.WriteLine("\tMago {0} modificato (spell: {1})\n", mago.Nome, mago.Spell);

            // Es - 11
            Console.WriteLine("11. Scrivere una funzione che modifica una lista passata come parametro.");
            InvertiLista(lista);
            Console.WriteLine("\tLista di numeri invertita: {0}\n", string.Join(", ", lista));

            // Es - 12
            Console.WriteLine("12. Creare una funzione che utilizza un'espressione condizionale per determinare il valore restituito. (if else)");
            Console.WriteLine("\tVerifica se il numero 8 è pari o dispari: {0}\n", PariODispari(8));
        }

        public static int Resto(int a, int b)
        {
            return a % b;
        }

        public static void StampaMessaggio()
        {
            Console.WriteLine("\tMessaggio stampato dalla funzione \"StampaMessaggio\"\n");
        }

        public static int LunghezzaStringa(string stringa)
        {
            return stringa.Length;
        }

        public static string Saluta(string nome = "Mondo")
        {
            return "Ciao, " + nome + "!";
        }

        public static int MoltiplicazioneArray(int[] numeri)
        {
            int somma = 1;
            foreach ( int num in numeri )
            {
                somma *= num;
            }
            return somma;
        }

        public static int Fattoriale(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return n * Fattoriale(n - 1);
            }
        }

        public static bool Divisibile( int dividendo, int divisore )
        {
            return dividendo % divisore == 0;
        }

        public static string TryParseInt(string input)
        {
            try
            {
                int e8 = int.Parse(input);
                return "Conversione fatta!" + e8;
            }
            catch
            {
                return "L'input " + input + " non è valido";
            }
        }

        public static List<int> CreaLista(int lunghezza)
        {
            List<int> lista = [];
            for ( int i = 0; i < lunghezza; i++ )
            {
                lista.Add(i+1);
            }
            return lista;
        }

        public class Mago(string nome, int spell)
        {
            public string Nome { get; private set; } = nome;
            public int Spell { get; set; } = spell;
        }

        public static Mago AggiungiSpell(Mago mago)
        {
            mago.Spell++;
            return new(mago.Nome, mago.Spell);
        }

        public static void InvertiLista(List<int> lista)
        {
            lista.Reverse();
        }

        public static string PariODispari(int numero)
        {
            if (numero % 2 == 0)
            {
                return "Pari";
            }
            else
            {
                return "Dispari";
            }
        }
    }
}