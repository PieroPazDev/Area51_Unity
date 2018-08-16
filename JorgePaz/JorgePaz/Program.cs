using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JorgePaz
{
    class Program
    {
        static void Main(string[] args) {
            //Palabra a adivinar & Palabra a mostrar
            string hiddenWord = Console.ReadLine();
            string shownWord = "";
            int attemptsLeft = 5;


            //Manejo de Arrays
            int[] numbers = new int[4];
            numbers[2] = 7;
            char letter = hiddenWord[0] ;

            //Limpieza de Pantalla
            Console.Clear();

            //Llenaba palabra a mostrar con un caracter "con for"
            //Si fuese while (showWord.Length != hiddenWord.Length)
            for (int i = 0; i < hiddenWord.Length; i++) {
                shownWord += "*";
            }

            //Palabra a mostrar en consola
            Console.WriteLine(shownWord);

            //LOOP
            while (shownWord != hiddenWord && attemptsLeft >  0) {
                //UPDATE
                string attempt = Console.ReadLine();
                if (attempt.Length != 1) {
                    if(attempt == hiddenWord) {
                        shownWord = hiddenWord;
                    }
                    else {
                        if(attempt != string.Empty)
                        attemptsLeft--;
                    }
                }else {
                    if (hiddenWord.Contains(attempt)) {
                        Console.WriteLine("ACERTASTE!");
                        string tempWord = "";
                        for (int i = 0; i < hiddenWord.Length; i++) {
                            if (hiddenWord[i] == attempt[0]){
                                tempWord += hiddenWord[i];
                            } else {
                                tempWord += shownWord[i];
                            }
                            
                        }
                        shownWord = tempWord;
                    }else {
                        attemptsLeft--;
                    }
                }

                //DRAW
                Console.Clear();
                Console.WriteLine("Te quedan " + attemptsLeft + " intentos");
                Console.WriteLine(shownWord);
            }
        }
    }
}
