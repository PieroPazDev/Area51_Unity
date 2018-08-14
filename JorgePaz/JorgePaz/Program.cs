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
            string hiddenWord = Console.ReadLine();
            string showWord = "";

            Console.Clear();

            for (int i = 0; i < hiddenWord.Length; i++)
            {
                showWord += "*";
            }
            Console.WriteLine(showWord);
        }
    }
}
