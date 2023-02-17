using System;
namespace Exercice12
{
    class Program
    {
        const string excerpt = "La ou nous vivions jadis, il n’y avait ni autos, ni taxis, ni autobus : nous allions parfois, mon cousin m’accompagnait, voir Linda qui habitait dans un canton voisin.";

        public static void Main(string[] args)
        {

            // Boucle For
            // Calculer le nombre de "a"
            Console.WriteLine($"Nombre de a : {NumberOfLettersInStringFor(excerpt, 'a')}");
            // Calculer le nombre de "e"
            Console.WriteLine($"Nombre de e : {NumberOfLettersInStringFor(excerpt, 'e')}");

            // Boucle While
            // Calculer le nombre de "a"
            Console.WriteLine($"Nombre de a : {NumberOfLettersInStringWhile(excerpt, 'a')}");
            // Calculer le nombre de "e"
            Console.WriteLine($"Nombre de e : {NumberOfLettersInStringWhile(excerpt, 'e')}");

            // Fonction Encoder
            Console.WriteLine(Encode("Allo", '+'));
            Console.WriteLine(Encode("Hello World", '-'));

            // Trim complet (inclut le trim start et trim end)
            Console.WriteLine(Trim("  test   "));

            // Extraire le nom d'utilisateur
            Console.WriteLine(ExtractUsernameText("Yoda18"));
            Console.WriteLine(ExtractUsernameText("Totoro43"));
            Console.WriteLine(ExtractUsernameText("Tololo420"));
            Console.WriteLine(ExtractUsernameText("Yamato2199"));


        }

        public static int NumberOfLettersInStringFor(string input, char symbol)
        {
            int nbLetters = 0;
            input = input.ToLower();
            for (int i = 0; i < excerpt.Length; i++)
            {
                if (input[i] == symbol)
                {
                    nbLetters++;
                }
            }

            return nbLetters;
        }

        public static int NumberOfLettersInStringWhile(string input, char symbol)
        {
            int nbLetters = 0;
            int iteration = 0;
            input = input.ToLower();
            while (iteration < input.Length)
            {
                if (input[iteration] == symbol)
                {
                    nbLetters++;
                }
                iteration++;
            }

            return nbLetters;
        }

        public static string Encode(string input, char symbol)
        {
            string encoded = "";

            for (int i = 0; i < input.Length; i++)
            {
                encoded += symbol;
            }

            return encoded;
        }

        public static string Trim(string input)
        {
            return TrimEnd(TrimStart(input));
        }

        public static string TrimStart(string input)
        {
            string output = "";
            int iteration = 0;
            while (iteration < input.Length && output == "")
            {
                if (input[iteration] != ' ')
                {
                    output = input.Substring(iteration);
                }
                else
                {
                    iteration++;
                }
            }
            return output;

        }

        public static string TrimEnd(string input)
        {
            string output = "";
            int iteration = input.Length - 1;
            while (iteration > 0 && output == "")
            {
                if (input[iteration] != ' ')
                {
                    output = input.Substring(0, iteration+1);
                }
                else
                {
                    iteration--;
                }
            }
            return output;

        }

        public static string ExtractUsernameText(string input)
        {
            string output = "";
            for(int i = 0; i < input.Length; i++)
            {
                if (!char.IsNumber(input[i]))
                {
                    output += input[i];
                }
            }
            return output;
        }


    }
}