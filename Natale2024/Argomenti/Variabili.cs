namespace Natale2024.Argomenti
{
    public static class Variabili
    {
        public static void Parti()
        {
            Console.WriteLine("Esercizi sulle Variabili");

            // Es - 1
            Console.WriteLine("1. Dichiarare una variabile di tipo int e assegnarle un valore, quindi modificarlo.");
            int e1 = 10;
            Console.WriteLine("\tVariabile intera e1: {0}", e1);
            e1 = 420;
            Console.WriteLine("\tVariabile e1 modificata: {0}\n", e1);

            // Es - 2
            Console.WriteLine("2. Creare una variabile di tipo string, assegnarle un valore e concatenarla con un'altra stringa.");
            string e2 = "Ciao";
            string e2c = e2 + " mondo!";
            Console.WriteLine("\tVariabile stringa e2: {0}\n", e2c);

            // Es - 3
            Console.WriteLine("3. Dichiarare una variabile di tipo bool e cambiarne il valore.");
            bool e3 = true;
            Console.WriteLine("\tVariabile bool e3: {0}", e3);
            e3 = false;
            Console.WriteLine("\tVariabile e3 modificata: {0}\n", e3);

            // Es - 4
            Console.WriteLine("4. Utilizzare una variabile di tipo double per rappresentare un numero con decimali.");
            double e4 = 4.20;
            Console.WriteLine("\tVariabile double e4: {0}\n", e4);

            // Es - 5
            Console.WriteLine("5. Dichiarare una variabile char e assegnarle un carattere.");
            char e5 = 'A';
            Console.WriteLine("\tVariabile char e5: {0}\n", e5);

            // Es - 6
            Console.WriteLine("6. Usare una variabile di tipo decimal per rappresentare una quantità monetaria.");
            decimal e6 = 99.99m;
            Console.WriteLine("\tVariabile decimal e6: {0}\n", e6.ToString("C"));

            // Es - 7
            Console.WriteLine("7. Dichiarare una variabile float e assegnarle un valore, verificandone la precisione rispetto a double.");
            float e7 = 1 / 3f;
            double e7d = 1 / 3f;
            Console.WriteLine("\tVariabile float e7: {0}", e7);
            Console.WriteLine("\tVariabile double e7Double: {0}\n", e7d);

            // Es - 8
            Console.WriteLine("8. Dichiarare una variabile long per rappresentare un numero molto grande.");
            long e8 = 123456789012345L;
            Console.WriteLine("\tVariabile long e8: {0}\n", e8);

            // Es - 9
            Console.WriteLine("9. Creare una variabile short e verificarne il suo range di valori.");
            short e9a = short.MinValue;
            short e9b = short.MaxValue;
            Console.WriteLine("\tLa vairabile e9 va da: {0} a {1}\n", e9a, e9b);

            // Es - 10
            Console.WriteLine("10. Usare una variabile byte per rappresentare un numero tra 0 e 255.");
            byte e10 = 210;
            Console.WriteLine("\tVariabile byte e10: {0}\n", e10);

            // Es - 11
            Console.WriteLine("11. Dichiarare una variabile const e provare a modificarne il valore.");
            const int e11 = 100;
            Console.WriteLine("\tVariabile costante intera e11: {0}", e11);
            Console.WriteLine("\tUn'eventuale tentativo di modificazione darebbe errore\n");
            // e11 = 200; // Questa linea da errore perché le variabili const non possono essere modificate.

            // Es - 12
            Console.WriteLine("12. Dichiarare più variabili in una sola riga e assegnare loro valori diversi.");
            int e12a = 1, e12b = 2, e12c = 3;
            Console.WriteLine("\tVariabili intere: e12a = {0}, e12b = {1}, e12c = {2}\n", e12a, e12b, e12c);

            // Es - 13
            Console.WriteLine("13. Dichiarare una variabile di tipo var e verificare come il compilatore determina il tipo.");
            var e13 = "stringa";
            Console.WriteLine("\tVariabile var e13: {0} (Tipo: {1})\n", e13, e13.GetType());

            // Es - 14
            Console.WriteLine("Dichiarare e usare variabili con valori predefiniti.");
            int e14a = default;
            bool e14b = default;
            Console.WriteLine("\tVariabile intera predefinita e14: {0}", e14a);
            Console.WriteLine("\tVariabile bool predefinita e14Bool: {0}\n", e14b);

            // Es - 15
            Console.WriteLine("15. Cambiare il tipo di una variabile usando il casting esplicito.");
            double e15 = 7.89;
            Console.WriteLine("\tVariabile double e15: {0}", e15);
            Console.WriteLine("\tVariabile double e15 (dopo il casting a intero): {0}\n", (int)e15);

            // Es - 16
            Console.WriteLine("16. Dichiarare una variabile costante di tipo string.");
            const string e16 = "Constante";
            Console.WriteLine("\tVariabile costante string e16: {0}\n", e16);

            // Es - 17
            Console.WriteLine("17. Utilizzare una variabile per rappresentare una data usando il tipo DateTime.");
            DateTime e17 = DateTime.Now;
            Console.WriteLine("\tVariabile DateTime e17: {0}\n", e17.ToString("dd-MM-yyyy"));

            // Es - 18
            Console.WriteLine("18. Dichiarare una variabile e utilizzarla in un'espressione matematica.");
            int e18 = 5;
            int e18Risultato = e18 * 2 + 10;
            Console.WriteLine("\tVariabile intera e18: {0}", e18);
            Console.WriteLine("\tRisultato dell'espressione matematica 2x + 10 con x = e18: {0}\n", e18Risultato);

        }
    }
}