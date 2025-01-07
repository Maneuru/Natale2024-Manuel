namespace Natale2024.Argomenti
{
    public class Liste
    {
        public static void StampaArray<T>(IList<T> array)
        {
            foreach (T n in array)
            {
                Console.WriteLine($"\tel: {n}");
            }
            Console.WriteLine();
        }

        public static void Parti()
        {
            Console.WriteLine("Esercizi sugli array e le liste");

            // ES - 1
            Console.WriteLine("1. Creare un array di int con 5 elementi e stamparne i valori.");
            int[] e1 = [ 1, 2, 3, 4, 5 ];
            StampaArray(e1);

            // ES - 2
            Console.WriteLine("2. Dichiarare una lista di stringhe e aggiungere elementi dinamicamente.");
            List<string> e2 = [ "uno", "due", "tre" ];
            e2.Add("Quattro");
            StampaArray(e2);

            // ES - 3
            Console.WriteLine("3. Creare un array bidimensionale e popolarlo con valori. ([,])");
            int[,] e3 =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            for (int i = 0; i < e3.GetLength(0); i++)
            {
                for (int j = 0; j < e3.GetLength(1); j++)
                {
                    Console.Write($"\t{e3[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // ES - 4
            Console.WriteLine("4. Utilizzare un array per calcolare la media dei valori.");
            Console.WriteLine($"\t{e1.Average()}\n");

            // ES - 5
            Console.WriteLine("5. Dichiarare una lista di oggetti personalizzati. (classi, enum, struct, ecc)");
            List<Funzioni.Mago> e5 = [ new("Harry", 2), new("Alaric", 21) ];
            foreach (Funzioni.Mago persona in e5)
            {
                Console.WriteLine($"\tNome: {persona.Nome}, Spells: {persona.Spell}");
            }
            Console.WriteLine();

            // ES - 6
            Console.WriteLine("6. Creare un array di booleani per rappresentare lo stato di vari interruttori.");
            bool[] e6 = [ true, false, true, false, true ];
            StampaArray(e6);

            // ES - 7
            Console.WriteLine("7. Dichiarare una lista di numeri e ordinarla.");
            List<int> e7 = [ 5, 2, 8, 1, 4 ];
            e7.Sort();
            Console.WriteLine("\tArray ordinato: ");
            StampaArray(e7);

            // ES - 8
            Console.WriteLine("8. Utilizzare un array per contare la frequenza di un valore.");
            int e8 = e1.Count(n => n == 3);
            Console.WriteLine($"\tIl valore 3 viene ripetuto: {e8} volte\n");

            // ES - 9
            Console.WriteLine("9. Creare una lista di stringhe e rimuovere elementi specifici.");
            e2.Remove("due");
            Console.WriteLine("\tRimosso il valore due");
            StampaArray(e2);

            // ES - 10
            Console.WriteLine("10. Dichiarare un array e inizializzarlo con valori predefiniti.");
            int[] e10 = [10, 20, 30, 40, 50];
            StampaArray(e10);

            // ES - 11
            Console.WriteLine("11. Creare una lista che accetta solo valori univoci.");
            HashSet<int> e11 = [ 1, 2, 2, 3, 4, 4 ];
            foreach (int n in e11)
            {
                Console.WriteLine($"\tel: {n}");
            }
            Console.WriteLine();

            // ES - 12
            Console.WriteLine("12. Utilizzare un array per rappresentare una matrice di 3x3.");
            int[,] e12 = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    e12[i,j] = 3 * j + i;
                }
            }

            // ES - 13
            Console.WriteLine("13. Dichiarare una lista e cercare un elemento al suo interno.");
            bool e13b = e2.Contains("banana");
            Console.WriteLine($"\tLa lista contiene 'banana': {e13b}\n");
            
            // ES - 14
            Console.WriteLine("14. Creare un array di oggetti e iterare sui valori.");
            Funzioni.Mago[] e14 = [ new("Harry", 2), new("Alaric", 21) ];
            foreach (Funzioni.Mago p in e14)
            {
                Console.WriteLine($"\tNome: {p.Nome}, Spells: {p.Spell}");
            }
            Console.WriteLine();
            
            // ES - 15
            Console.WriteLine("15. Utilizzare una lista per memorizzare i punteggi di un gioco.");
            List<int> e15 = [ 100, 200, 150, 180 ];
            StampaArray(e15);
            Console.WriteLine();

            // ES - 16
            Console.WriteLine("16. Dichiarare un array di char per rappresentare una parola.");
            char[] e16 = ['c', 'i', 'a', 'o'];
            StampaArray(e16);
            
            // ES - 17
            Console.WriteLine("17. Creare una lista che accetta solo valori di tipo float.");
            List<float> e17 = [ 1.1f, 2.2f, 3.3f ];
            StampaArray(e17);
            
            // ES - 18
            Console.WriteLine("18. Utilizzare un array per memorizzare i giorni della settimana.");
            EnumStructCast.GiornoSettimana[] e18 = Enum.GetValues<EnumStructCast.GiornoSettimana>();
            foreach (EnumStructCast.GiornoSettimana giorno in e18)
            {
                Console.WriteLine($"\t{giorno}");
            }
            Console.WriteLine();
            
            // ES - 19
            Console.WriteLine("19. Dichiarare una lista e modificarne gli elementi in base alla loro posizione.");
            List<int> e19 = [ 10, 20, 30, 40, 50 ];
            for (int i = 0; i < e19.Count; i++)
            {
                e19[i] *= i;
            }
            StampaArray(e19);
            
            // ES - 20
            Console.WriteLine("20. Creare un array di stringhe e concatenare tutti i valori in un'unica stringa.");
            string[] e20 = ["Ciao", " ", "Bryseis", "!"];
            Console.WriteLine($"\tStringhe concatenate: {string.Join("", e20)}\n");
            
            // ES - 21
            Console.WriteLine("21. Utilizzare una lista per memorizzare dati inseriti dall'utente.");
            List<string> e21 = [];
            Console.WriteLine("\tInserisci una frase:");
            e21.Add(Console.ReadLine() ?? "");
            Console.WriteLine("\tDati inseriti dall'utente:");
            StampaArray(e21);

            // ES - 22
            Console.WriteLine("22. Dichiarare un array di numeri casuali.");
            Random random = new();
            int[] e22 = new int[5];
            for (int i = 0; i < e22.Length; i++)
            {
                e22[i] = random.Next(1, 100);
            }
            StampaArray(e22);

            // ES - 23
            Console.WriteLine("23. Creare una lista che accetta solo valori superiori a 10.");
            List<int> e23 = [ 12, 15, 8, 11, 20 ];
            e23 = e23.Where(x => x > 10).ToList();
            StampaArray(e23);

            // ES - 24
            Console.WriteLine("24. Utilizzare un array per rappresentare una tabella di moltiplicazione.");
            // Stampo tutte le tabelline da 1 a 10
            int[,] e24 = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("\t");
                for (int j = 0; j < 10; j++)
                {
                    e24[i, j] = (i + 1) * (j + 1);
                    Console.Write($"{e24[i, j]}  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // ES - 25
            Console.WriteLine("25. Dichiarare una lista e convertirla in array.");
            List<int> e25 = [1, 2, 3, 4, 5];
            int[] arrayDaLista = [.. e25];
            StampaArray(arrayDaLista);
        }
    }
}
