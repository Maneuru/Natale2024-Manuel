namespace Natale2024.Argomenti
{
    public static class AlgebraBool
    {
        public static void Parti()
        {
            Console.WriteLine("Esercizi sull'algebra di bool");

            // ES - 1
            Console.WriteLine("1. Utilizzare un if-else per verificare se un numero è pari o dispari");
            int e1 = 7;
            Console.WriteLine("\tIl numero {0} è: {1}\n", e1, Funzioni.PariODispari(e1));

            // Es - 2
            Console.WriteLine("2. Scrivere un programma che utilizza una serie di if-else per categorizzare un'età.");
            Console.WriteLine("\tL'età 25 è categorizzata come: {0}\n", CategorizzaEta(25));

            // Es - 3
            Console.WriteLine("3. Creare un'espressione logica che combina più condizioni con &&.");
            int e3 = 7;
            Console.WriteLine("\tIl numero e3 = {0} è compreso tra 5 e 10: {1}\n", e3, e3 >= 5 && e3 <= 10);

            // Es - 4
            Console.WriteLine("4. Utilizzare un'espressione logica con || per verificare se un numero è compreso in un intervallo.");
            int e4 = 1;
            Console.WriteLine("\tIl numero e3 = {0} è compreso tra 5 e 10: {1}\n", e4, !(e4 < 5 || e4 > 10));

            // Es - 5
            Console.WriteLine("5. Scrivere un if-else che utilizza l'operatore ! per invertire una condizione.");
            int e5 = 10;
            Console.WriteLine("\tIl numero e5 = {0} non è minore di 5 né maggiore di 15: {1}\n", e5, !(e5 < 5 || e5 > 15) );

            // Es - 6
            Console.WriteLine("6. Dichiarare una variabile booleana e usarla in un'istruzione if.");
            bool e6 = true;
            if ( e6 )
            {
                Console.WriteLine("\tSe vedi questo messaggio e6 = true\n");
            } else 
            {
                Console.WriteLine("\tSe vedi questo messaggio e6 = false\n");
            }

            // Es - 7
            Console.WriteLine("7. Creare un programma che utilizza if-else nidificati.");
            int e7 = -15;
            Console.WriteLine("\tIl numero e7 = {0} è: {1}\n", e7, IfElseNidificati(e7));

            // Es - 8
            Console.WriteLine("8. Utilizzare un'espressione switch per valutare un valore booleano.");
            bool e8 = false;
            Console.WriteLine("\tSwitch sul valore booleano e8 = {0}: {1}\n", e8, SwitchBooleano(true));

            // Es - 9
            Console.WriteLine("9. Creare un'istruzione if-else che utilizza un'espressione con operatori di confronto.");
            int e9 = 7;
            Console.WriteLine("\tIl numero e9 = {0} è maggio di 5 e 10: {1}\n", e9, e9 > 5);

            // Es - 10
            Console.WriteLine("10. Utilizzare un operatore ternario per assegnare un valore a una variabile.");
            string e10 = 3 % 2 == 0? "Pari" : "Dispari";
            Console.WriteLine("\tLa viaribile stringa e10 è: {0}\n", e10);

            // Es - 11
            Console.WriteLine("11. Scrivere una serie di if-else per verificare più condizioni.");
            Console.WriteLine("\tL'età 10 è categorizzata come: {0}\n", CategorizzaEta(25));

            // Es - 12
            Console.WriteLine("12. Creare un programma che utilizza un if-else per determinare il maggiore tra due numeri.");
            int e12a = 8; int e12b = 12;
            Console.WriteLine("\tIl maggiore tra 8 e 12 è: {0}\n", e12a > e12b? e12a : e12b);

            // Es - 13
            Console.WriteLine("13. Utilizzare un'istruzione if per verificare se una stringa è vuota o nulla.");
            Console.WriteLine("\tLa stringa \"\" è vuota o null: {0}\n", "" == string.Empty || "" == null );

            // Es - 14
            Console.WriteLine("14. Creare un programma che utilizza if-else per verificare se un anno è bisestile.");
            Console.WriteLine("\tL'anno 2024 è bisestile: {0}\n", AnnoBisestile(2024));

            // Es - 15
            Console.WriteLine("15. Scrivere un'espressione logica che verifica se una stringa contiene una sottostringa specifica.");
            Console.WriteLine("\tLa stringa \"Hello World\" contiene \"World\": {0}\n", "Hello World".Contains("World"));

            // Es - 16
            Console.WriteLine("16. Utilizzare un if-else per verificare se un array contiene un elemento specifico.");
            int[] e16 = [1, 2, 3, 4, 5];
            Console.WriteLine("\tL'atrray contiene il numero 3: {0}\n", e16.Contains(3));

            // Es - 17
            Console.WriteLine("17. Creare una funzione che utilizza if-else per determinare se un numero è positivo, negativo o zero.");
            int e17 = -15;
            Console.WriteLine("\tLa variabile e17 = {0} è: {1}\n", e17, DeterminaSegno(e17));

            // Es - 18
            Console.WriteLine("18. Creare un programma che utilizza un switch per determinare il giorno della settimana.");
            Console.WriteLine("\tIl giorno 3 è: {0}\n", GiornoDellaSettimana(3));

            // Es - 19
            Console.WriteLine("19. Utilizzare un'istruzione if per verificare se un numero è divisibile per 3 e 5.");
            Console.WriteLine("\tIl numero 15 è divisibile per 3 e 5: {0}\n", 15 % 3 == 0 && 15 % 5 == 0);

            // Es - 20
            Console.WriteLine("20. Scrivere un'istruzione if per verificare se un valore booleano è true.");
            bool e20 = true;
            if ( e20 )
            {
                Console.WriteLine("\tSì, è proprio true\n");
            }

            // Es - 21
            Console.WriteLine("21. Utilizzare un switch per valutare una variabile stringa.");
            Console.WriteLine("\tVerifica della parola \"ATTIVO\"': {0}\n", ValutaStringa("ATTIVO"));

            // Es - 22
            Console.WriteLine("22. Creare un programma che utilizza un if per verificare se un array è vuoto.");
            int[] e22 = [];
            Console.WriteLine("\tL'array è vuoto: {0}\n", e22.Length == 0);

            // Es - 23
            Console.WriteLine("23. Utilizzare un if per verificare se un valore è un numero primo.");
            Console.WriteLine("\tIl numero 7 è primo: {0}\n", NumeroPrimo(7));

            // Es - 24
            Console.WriteLine("24. Scrivere un programma che utilizza un'istruzione if-else per verificare se una parola è palindroma.");
            Console.WriteLine("\tLa parola 'radar' è palindroma: {0}\n", Palindroma("radar"));
        }
        public static string CategorizzaEta(int eta)
        {
            if (eta < 13)
            {
                return "bambino";
            }
            else if (eta < 20)
            {
                return "adolescente";
            }
            else if (eta < 65)
            {
                return "adulto";
            }
            else
            {
                return "anziano";
            }
        }

        public static string IfElseNidificati(int num)
        {
            if ( num % 2 == 0 )
            {
                if( num >= 0 )
                {
                    return "multiplo di 2 positivo";
                }
                else
                {
                    return "multiplo di 2 negativo";
                }
            }
            else 
            {
                return "non multiplo di 2";
            }
        }

        public static string SwitchBooleano(bool condizione)
        {
            switch (condizione)
            {
                case true:
                    return "Caso true";
                case false:
                    return "Caso false";
            }
        }
        
        public static bool AnnoBisestile(int anno)
        {
            // Se l'anno è divisibile per 4 AND non è divisibile per 100 OR è divisibile per 400
            return anno % 4 == 0 && ( anno % 100 != 0 || anno % 400 == 0 );

            // O return DateTime.IsLeapYear(anno);
        }

        public static string DeterminaSegno(int num)
        {
            if (num > 0)
            {
                return "positivio";
            }
            else if (num < 0 )
            {
                return "negativo";
            }
            else
            {
                return "zero";
            }
        }
        public static string GiornoDellaSettimana(int giorno)
        {
            string risultato = "";
            switch(giorno)
            {
                case 0:
                    risultato = "Lunedì";
					break;
                case 1:
                    risultato = "Martedì";
					break;
                case 2:
                    risultato = "Mercoledì";
					break;
                case 3:
                    risultato = "Giovedì";
					break;
                case 4:
                    risultato = "Venerdì";
					break;
                case 5:
                    risultato = "Sabato";
					break;
                case 6:
                    risultato = "Domenica";
					break;
                default:
                    risultato = "Bad Request";
                    break;
            }
            return risultato;
            // O return ((DayOfWeek)giorno).ToString();
        }

        public static int ValutaStringa(string stringa)
        {
            int risultato;
            switch (stringa)
            {
                case "ATTIVO":
                    risultato = 1;
                    break;
                case "INATTIVO":
                    risultato = 0;
                    break;
                default:
                    risultato = -1;
                    break;
            }
            return risultato;
        }
        public static bool NumeroPrimo(int numero)
        {
            if ( numero > 2 )
            {
                bool numeroPrimo = true;
                for (int i = 2; i < numero; i++)
                {
                    if ( numero % i == 0 )
                    {
                        numeroPrimo = false;
                    }
                }
                return numeroPrimo;
            }
            else if ( numero == 2 )
            {
                return true;
            }
            
            return false;
        }
        public static bool Palindroma(string parola)
        {
            int lunghezza = parola.Length;
            int mezzoArray = (int)MathF.Floor(lunghezza / 2f);

            for (int i = 0; i <= mezzoArray; i++)
            {
                if ( parola[i] != parola[lunghezza - i - 1] )
                {
                    return false;
                }
            }
            
            return true;
        }
    }
}