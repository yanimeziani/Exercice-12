using System;
namespace Exercice12
{
    class Program
    {
        const string excerpt = "       La ou nous vivions jadis, il n’y avait ni autos, ni taxis, ni autobus : nous allions parfois, mon cousin m’accompagnait, voir Linda qui habitait dans un canton voisin.  ";

        public static void Main(string[] args)
        {

            // Boucle For
            // Calculer le nombre de "a"
            Console.WriteLine($"Nombre de A : {NumberOfLettersInStringFor(excerpt, 'a')}");
            // Calculer le nombre de "e"
            Console.WriteLine($"Nombre de E : {NumberOfLettersInStringFor(excerpt, 'e')}");

            // Boucle While
            // Calculer le nombre de "a"
            Console.WriteLine($"Nombre de A : {NumberOfLettersInStringWhile(excerpt, 'a')}");
            // Calculer le nombre de "e"
            Console.WriteLine($"Nombre de E : {NumberOfLettersInStringWhile(excerpt, 'e')}");

            // Fonction Encode
            Console.WriteLine(Encode(excerpt, '-'));

            // Trim
            Console.WriteLine(Trim("  test  "));


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
            int i = 0;
            while (i < input.Length)
            {
                if (input[i] != ' ')
                {
                    output = input.Substring(i);
                    break;
                } else
                {
                    i++;
                }
            }
            return output;

        }

        public static string TrimEnd(string input)
        {
            string output = "";
            for (int i = input.Length - 1; i > 0; i--)
            {
                if (input[i] != ' ')
                {
                    output = input.Substring(0, i+1);
                    break;
                }
            }
            return output;

        }

    }
}