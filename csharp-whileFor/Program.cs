/*
     1. Creare un metodo che, a partire da 4 variabili che contengono la lunghezza dei lati di un
    quadrilatero, stampi a schermo se la figura geometrica in questione è un quadrato, oppure no.

    2. Creare un metodo che, a partire da 3 variabili che contengono la lunghezza dei lati di un
    triangolo, stampi a schermo se il triangolo in questione è equilatero, isoscele o scaleno.

    3. Creare un programma che, con l’aiuto di una variabile numerica, stampi il numero se il numero è
    compreso tra -10 e 10, oppure stampi “errore”.

    4. Creare un programma che controlli un carattere. Stampare a schermo se si tratta di una vocale o di una consonante.

    5. Creare un metodo che stampi a schermo i numeri da 1 a 10. Utilizzare sia un ciclo while, sia un ciclo for.

    6. Creare un metodo che stampi a schermo i numeri da 10 a 0. Utilizzare sia un while che un ciclo for.

    7. Creare un metodo che stampi a schermo i numeri pari da 0 a -10. Utilizzare sia un while che un ciclo for.

    8. Creare un metodo che stampi a schermo i numeri dispari da -1 a 20. Utilizzare sia un ciclo while, sia un ciclo for.

    9. Creare un metodo che stampi a schermo la tabellina di un numero a piacere da 1 a 10.
*/

namespace csharp_whileFor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // ESERCIZIO 1
            Console.WriteLine("---------------------------------------------------\n");
            Console.WriteLine("ESERCIZIO 1\n");

            ChekQuadrato();

            // ESERCIZIO 2
            Console.WriteLine("---------------------------------------------------\n");
            Console.WriteLine("ESERCIZIO 2\n");

            ChekTriangoloType();

            // ESERCIZIO 3
            Console.WriteLine("---------------------------------------------------\n");
            Console.WriteLine("ESERCIZIO 3\n");

            ChekVariableBetween();

            // ESERCIZIO 4
            Console.WriteLine("---------------------------------------------------\n");
            Console.WriteLine("ESERCIZIO 4\n");

            CheckVariableChar();

            // ESERCIZIO 5
            Console.WriteLine("---------------------------------------------------\n");
            Console.WriteLine("ESERCIZIO 5\n");

            LoopNumbers();

            // ESERCIZIO 6
            Console.WriteLine("---------------------------------------------------\n");
            Console.WriteLine("ESERCIZIO 6\n");

            LoopNumbers2();

            // ESERCIZIO 7
            Console.WriteLine("---------------------------------------------------\n");
            Console.WriteLine("ESERCIZIO 7\n");

            LoopNumbers3();

            // ESERCIZIO 8
            Console.WriteLine("---------------------------------------------------\n");
            Console.WriteLine("ESERCIZIO 8\n");

            LoopNumbers4();

            // ESERCIZIO 9
            Console.WriteLine("---------------------------------------------------\n");
            Console.WriteLine("ESERCIZIO 9\n");

            RandomNum();

        }

        static void ChekQuadrato()
        {
            int num1, num2, num3, num4;

            Console.WriteLine("\nDigitare il primo numero:\n");

            //Controllo
            while (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Sintassi errata. Inserisci un numero");
            }

            Console.WriteLine("\nDigitare il secondo numero:\n");

            //Controllo
            while (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Sintassi errata. Inserisci un numero");
            }

            Console.WriteLine("\nDigitare il terzo numero:\n");

            //Controllo
            while (!int.TryParse(Console.ReadLine(), out num3))
            {
                Console.WriteLine("Sintassi errata. Inserisci un numero");
            }

            Console.WriteLine("\nDigitare il quarto numero:\n");

            //Controllo
            while (!int.TryParse(Console.ReadLine(), out num4))
            {
                Console.WriteLine("Sintassi errata. Inserisci un numero");
            }




            if (num1 == num2 && num2 == num3 && num3 == num4)
            {
                Console.WriteLine($"\nI valori ({num1},{num2},{num3},{num4}) formano un quadrato\n");
            }
            else
            {
                Console.WriteLine($"\nI valori ({num1},{num2},{num3},{num4}) non costituiscono un quadrato\n");
            }
        }

        static void ChekTriangoloType()
        {
            int num1, num2, num3;

            Console.WriteLine("\nDigitare il primo numero:\n");

            //Controllo
            while (!int.TryParse(Console.ReadLine(), out num1) || num1 <= 0)
            {
                Console.WriteLine("Sintassi errata. Inserisci un numero valido (maggiore di 0).");
            }

            Console.WriteLine("\nDigitare il secondo numero:\n");

            //Controllo
            while (!int.TryParse(Console.ReadLine(), out num2) || num2 <= 0)
            {
                Console.WriteLine("Sintassi errata. Inserisci un numero valido (maggiore di 0).");
            }

            Console.WriteLine("\nDigitare il terzo numero:\n");

            //Controllo
            while (!int.TryParse(Console.ReadLine(), out num3) || num3 <= 0)
            {
                Console.WriteLine("Sintassi errata. Inserisci un numero valido (maggiore di 0).");
            }

            // Verifica se i lati possono formare un triangolo (disuguaglianza triangolare)
            if (num1 + num2 > num3 && num1 + num3 > num2 && num2 + num3 > num1)
            {
                // Classificazione con operatore ternario
                Console.WriteLine((num1 == num2 && num2 == num3) ? "Abbiamo un triangolo equilatero" : (num1 == num2 || num2 == num3 || num1 == num3) ? "Abbiamo un triangolo isoscele" : "Abbiamo un triangolo scaleno");
            }
            else
            {
                Console.WriteLine("I lati forniti non possono formare un triangolo valido.");
            }

        }

        static void ChekVariableBetween()
        {

            int variable;

            Console.WriteLine("\nDigitare il numero:\n");

            //Controllo
            while (!int.TryParse(Console.ReadLine(), out variable))
            {
                Console.WriteLine("Sintassi errata. Inserisci un numero valido.");
            }

            // Verifica se il numero è compreso tra -10 e 10
            if (variable >= -10 && variable <= 10)
            {
                Console.WriteLine($"Il numero è: {variable}");
            }
            else
            {
                Console.WriteLine("Errore: il numero non è compreso tra -10 e 10.");
            }

        }

        static void CheckVariableChar()
        {
            char carattere;

            Console.WriteLine("Inserisci un carattere:");

            //Controllo
            while (!char.TryParse(Console.ReadLine(), out carattere))
            {
                Console.WriteLine("Input non valido. Inserisci un singolo carattere:");
            }

            // Controllo se è una lettera
            if (char.IsLetter(carattere))
            {
                // Converte il carattere in minuscolo per semplificare il controllo
                char lowerChar = char.ToLower(carattere);

                // Controllo se è una vocale
                if (lowerChar == 'a' || lowerChar == 'e' || lowerChar == 'i' || lowerChar == 'o' || lowerChar == 'u')
                {
                    Console.WriteLine($"{carattere} è una vocale.");
                }
                else
                {
                    Console.WriteLine($"{carattere} è una consonante.");
                }
            }
            else
            {
                Console.WriteLine("Errore: il carattere inserito non è una lettera.");
            }
        }

        static void LoopNumbers()
        {
            Console.WriteLine("Ciclo for:\n");

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"Numero: {i}\n");
            }

            Console.WriteLine("Ciclo while:\n");

            int indice = 1;

            while (true)
            {
                if (indice == 11)
                {
                    break;
                }

                Console.WriteLine($"Numero: {indice}\n");

                indice++;

            }

        }

        static void LoopNumbers2()
        {
            Console.WriteLine("Ciclo for:\n");

            for (int i = 10; i > -1; i--)
            {
                Console.WriteLine($"Numero: {i}\n");
            }

            Console.WriteLine("Ciclo while:\n");

            int indice = 10;

            while (true)
            {
                if (indice == -1)
                {
                    break;
                }

                Console.WriteLine($"Numero: {indice}\n");

                indice--;

            }

        }

        static void LoopNumbers3()
        {
            Console.WriteLine("Ciclo for:\n");

            for (int i = 0; i > -10; i--)
            {
                if (i % 2 != 0)
                {
                    continue;
                }

                Console.WriteLine($"Numero: {i}\n");
            }

            Console.WriteLine("Ciclo while:\n");

            int indice = 0;

            while (true)
            {
                if (indice  == -10)
                {
                    break;
                }

                else if (indice % 2 == 0)
                {
                    Console.WriteLine($"Numero: {indice}\n");
                }

                indice--;

            }
        }

        static void LoopNumbers4()
        {
            Console.WriteLine("Ciclo for:\n");

            for (int i = -1; i < 20; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }

                Console.WriteLine($"Numero: {i}\n");
            }

            Console.WriteLine("Ciclo while:\n");

            int indice = -1;

            while (true)
            {
                if (indice == 21)
                {
                    break;
                }

                else if (indice % 2 != 0)
                {
                    Console.WriteLine($"Numero: {indice}\n");
                }

                indice++;

            }

        }

        static void RandomNum()
        {

            int numero;

            Console.WriteLine("Inserisci un numero per vedere la sua tabellina da 1 a 10:");

            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Inserisci un numero valido.");
            }

            Console.WriteLine($"\nTabellina del {numero}:");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }

        }
    }
}
