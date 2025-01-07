namespace Natale2024.Argomenti
{
    public static class Loop
    {
        public static void Parti()
        {
            Console.WriteLine("Esercizi sui loop");

            // ES - 1
            Console.WriteLine("1. Scrivere un ciclo for che stampa numeri da 1 a 10.");
            for ( int i = 1; i <= 10; i++ )
            {
                Console.WriteLine("\tNumero: {0}", i);
            }
            Console.WriteLine();

            // ES - 2
            Console.WriteLine("2. Creare un ciclo while che continua finché un valore è minore di 100.");
            int e2 = 0;
            while (e2 < 100)
            {
                Console.WriteLine("\tValore: {0}", e2);
                e2 += 10;
            }
            Console.WriteLine();

            // ES - 3
            Console.WriteLine("3. Utilizzare un ciclo do-while per chiedere all'utente di inserire un valore valido.");
            int e3;
            bool corretto = false;
            do
            {
                Console.WriteLine("\tInserisci un numero: ");
                try
                {
                    e3 = int.Parse(Console.ReadLine() ?? "");
                    Console.WriteLine("\tCorretto");
                    corretto = true;
                }
                catch
                {
                    Console.WriteLine("\tIl numero inserito non è valido");
                }
            } while (!corretto);
            Console.WriteLine();

            // ES - 4
            Console.WriteLine("4. Scrivere un ciclo for che calcola la somma di un array.");
            int[] e4 = [ 1, 2, 3, 4, 5 ];
            int sommaE4 = 0;
            for (int i = 0; i < e4.Length; i++)
            {
                sommaE4 += e4[i];
            }
            Console.WriteLine("\tSomma dell'array: {0}\n", sommaE4);

            // ES - 5
            Console.WriteLine("5. Utilizzare un ciclo foreach per iterare attraverso una lista di stringhe.");
            List<string> e5 = [ "pippo", "pippa", "pippe" ];
            foreach (string e5e in e5)
            {
                Console.WriteLine("\tStringa: {0}", e5e);
            }
            Console.WriteLine();

            // ES - 6
            Console.WriteLine("6. Creare un ciclo for che calcola il fattoriale di un numero.");
            int e6 = 5;
            int fattorialeE6 = 1;
            for (int i = 1; i <= e6; i++)
            {
                fattorialeE6 *= i;
            }
            Console.WriteLine("\tFattoriale di {0}: {1}\n", e6, fattorialeE6);

            // ES - 7
            Console.WriteLine("7. Scrivere un ciclo while che verifica se un numero è primo.");
            int e7 = 7;
            bool isPrimo = true;
            int divisore = 2;
            while (divisore <= Math.Sqrt(e7))
            {
                if (e7 % divisore == 0)
                {
                    isPrimo = false;
                    break;
                }
                divisore++;
            }
            Console.WriteLine("\tIl numero {0} è primo: {1}\n", e7, isPrimo);

            // ES - 8
            Console.WriteLine("8. Utilizzare un ciclo do-while per stampare i numeri pari fino a un massimo.");
            int maxE8 = 20;
            int pariE8 = 0;
            do
            {
                Console.WriteLine("\t{0}", pariE8);
                pariE8 += 2;
            } while (pariE8 <= maxE8);
            Console.WriteLine();

            // ES - 9
            Console.WriteLine("9. Scrivere un ciclo for che stampa i numeri in ordine inverso.");
            for (int i = e4.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("\t{0}", e4[i]);
            }
            Console.WriteLine();

            // ES - 10
            Console.WriteLine("10. Creare un ciclo while che calcola il prodotto dei numeri fino a un valore specifico.");
            int e10 = 5;
            int prodottoE10 = 1;
            int iE10 = 1;
            while (iE10 <= e10)
            {
                prodottoE10 *= e10;
                iE10++;
            }
            Console.WriteLine("\tProdotto dei numeri fino a {0}: {1}\n", e10, prodottoE10);

            // ES - 11
            Console.WriteLine("11. Utilizzare un ciclo foreach per modificare i valori in una lista.");
            List<int> e11 = [ 1, 2, 3, 4, 5 ];
            foreach (int el in e11)
            {
                // Non posso modificare un valore nel foreach
                Console.WriteLine("\tValore originale {0}, valore modificato: {1}", el, el + 1);
            }
            Console.WriteLine();

            // ES - 12
            Console.WriteLine("12. Scrivere un ciclo do-while che calcola il totale di un array.");
            int sommaE12 = 0;
            int iE12 = 0;
            do
            {
                sommaE12 += e4[iE12];
                iE12++;
            } while (iE12 < e4.Length);
            Console.WriteLine("\tTotale dell'array: {0}\n", sommaE12);

            // ES - 13
            Console.WriteLine("13. Creare un ciclo for che utilizza un'istruzione break.");
            for (int i = 0; i < e4.Length; i++)
            {
                if (e4[i] == 3)
                {
                    Console.WriteLine("\nIl for è stato interrotto all'indice: {0}", i);
                    break;
                }
            }
            Console.WriteLine("");

            // ES - 14
            Console.WriteLine("14. Utilizzare un ciclo while che termina con un'istruzione continue.");
            int e14 = 0;
            while (e14 < 10)
            {
                e14++;
                if (e14 % 2 == 0)
                    continue;
                Console.WriteLine("\tNumero dispari trovato! {0}\n", e14);
            }

            // ES - 15
            Console.WriteLine("15. Scrivere un ciclo for che utilizza una variabile dichiarata all'esterno del ciclo.");
            int e15 = 2;
            for (int i = 0; i <= e4.Length; i++)
            {
                e4[i] += e15;
            }
            Console.WriteLine("\tNuovi valori di e4: {0}\n", string.Join(", ", e4));

            // ES - 16
            Console.WriteLine("16. Creare un ciclo foreach che stampa gli indici e i valori di un array.");
            int iE16 = 0;
            foreach (int el in e4)
            {
                Console.WriteLine("\tIndice {0}, Valore {1}", iE16, el);
                iE16++;
            }
            Console.WriteLine("");

            // ES - 17
            Console.WriteLine("17. Utilizzare un ciclo do-while che verifica un valore booleano prima di continuare.");
            int e17 = 0;
            do
            {
                Console.WriteLine("\tNumero: {0}", e17);
                e17++;
            } while (!Funzioni.Divisibile(e17, 3));
            Console.WriteLine("");

            // ES - 18
            Console.WriteLine("18. Scrivere un ciclo for che calcola la somma dei numeri dispari.");
            int sommaE18 = 0;
            for (int i = 1; i <= 10; i += 2)
            {
                sommaE18 += i;
            }
            Console.WriteLine("\tSomma dei numeri dispari da 1 a 10: {0}\n", sommaE18);

            // ES - 19
            Console.WriteLine("19. Creare un ciclo while che termina quando un valore raggiunge una soglia.");
            int e19 = 0;
            int sogliaE19 = 10;
            while (e19 < sogliaE19)
            {
                Console.WriteLine("\tValore: {0}", e19);
                e19++;
            }
            Console.WriteLine();

            // ES - 20
            Console.WriteLine("20. Utilizzare un ciclo foreach per calcolare la lunghezza totale di tutte le stringhe in una lista.");
            List<string> e20 = [ "pippo", "pippa", "pippe" ];
            int totE20 = 0;
            foreach (string s in e20)
            {
                totE20 += s.Length;
            }
            Console.WriteLine("\tLunghezza totale delle stringhe nella lista: {0}\n", totE20);

            // ES - 21
            Console.WriteLine("21. Scrivere un ciclo do-while che stampa un menu fino a quando l'utente sceglie di uscire.");
            do
            {
                Console.WriteLine("\tMenu:\n\t1 - Opzione 1\n\t2 - Opzione 2\n\t3 - esci");
                if ( !int.TryParse(Console.ReadLine() ?? "", out int e21) || e21 < 1 || e21 > 3 )
                {
                    Console.WriteLine("Opzione non valida");
                }
                Console.WriteLine();
            } while( iE12 != 3 );

            // ES - 22
            Console.WriteLine("22. Creare un ciclo for che utilizza una condizione complessa.");
            // Congettura di collatz sui primi 100 numeri
            int initialE22 = new Random().Next(1,100);
            int passaggiE22 = 0;
            for (int e22 = initialE22; e22 > 1 ; e22 = e22 % 2 == 0? e22 / 2 : e22 * 3 + 1)
            {
                e22++;
            }
            Console.WriteLine("Congettura vera per il numero {0}, risolta in {1} passaggi", initialE22, passaggiE22);

            // ES - 23
            Console.WriteLine("23. Utilizzare un ciclo while per cercare un valore specifico in un array.");
            int valoreE23 = 3;
            int iE23 = 0;
            while (iE23 < e4.Length)
            {
                if (e4[iE23] == valoreE23)
                {
                    Console.WriteLine("\tValore {0} trovato all'indice {1}\n", valoreE23, iE23);
                    break;
                }
                iE23++;
            }

            // ES - 24
            Console.WriteLine("24. Scrivere un ciclo for che calcola la media di un array.");
            int sommaE24 = 0;
            for (int i = 0; i < e4.Length; i++)
            {
                sommaE24 += e4[i];
            }
            double mediaE24 = (double)sommaE24 / e4.Length;
            Console.WriteLine("\tMedia dell'array: {0}\n", mediaE24);

            // ES - 25
            Console.WriteLine("25. Creare un ciclo foreach che copia valori da un array a un altro.");
            int[] e25 = new int[e4.Length];
            int iE25 = 0;
            foreach (int valore in e4)
            {
                e25[iE25] = valore;
                iE25++;
            }
            Console.WriteLine("\tArray copiato: {0}", string.Join(", ", e25));

        }
    }
}