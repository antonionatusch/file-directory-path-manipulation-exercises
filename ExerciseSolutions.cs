using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace FileAndFileInfo_13_12_udemy
{
    public class ExerciseSolutions
    {
        public static void Exercise1()
        {
            var textPath = @"C:\Users\Usuario\Desktop\xd.txt";
            Console.WriteLine("Cantidad de palabras del archivo: " +  GetNumberOfWords(textPath));
        }

        public static void Exercise2()
        {
            var textPath = @"C:\Users\Usuario\Desktop\xd.txt";
            Console.WriteLine("Palabra más larga del archivo de texto: " + GetLongestWord(textPath));
        }



        public static int GetNumberOfWords(string textPath)
        {
            var wordsInText =
                File
                .ReadAllText(textPath) // Lee el texto
                .ToString() // Lo almacena en un arreglo de strings
                .Split(' '); // Cuyos elementos serán aquellos que están espaciados por un espacio en blanco.

            int wordCounter = 0;

            foreach (var word in wordsInText)
            {
                wordCounter++;
            }

            return wordCounter;
        }

        public static String GetLongestWord(string textPath)
        {
            var wordsInText =
                File
                .ReadAllText(textPath)
                .ToString()
                .Split(' ');

            var longestWord = wordsInText[0];

            foreach (var word in wordsInText)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }

            return longestWord;
        }

       


    }
}
