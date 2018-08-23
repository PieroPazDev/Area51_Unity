using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JorgePaz
{
    class Game
    {

        bool isDone;
        SingleWordSystem currentWordSystem;
        string message;

        public void Run()
        {
            Initialize();
            while (!isDone)
            {
                Update();
                Draw();
            }
        }

        bool Retry()
        {
            Console.WriteLine("Has terminado! Deseas volver a jugar? y/n");
            string compare = Console.ReadLine();
            return compare == "y";
        }

        void Initialize()
        {
            Console.Clear();
            currentWordSystem = new SingleWordSystem();
            Console.Clear();
            currentWordSystem.ShowFieldValues();
            Console.Write("\nPresione cualquier tecla para iniciar...");
            Console.ReadKey();
            Draw();
        }

        void Update()
        {
            bool attemptSuccess = currentWordSystem.EvaluateAttempt(Console.ReadLine());
            if (attemptSuccess)
            {
                message = "ACERTASTE!";
            }
            else
            {
                message = "VUELVE A INTENTAR!";
            }
            if (currentWordSystem.isDone)
            {
                isDone = !Retry();
                if (!isDone)
                {
                    Initialize();
                }
            }
        }

        void Draw()
        {
            Console.Clear();
            Console.WriteLine("Tienes " + currentWordSystem.attemptsNumber + " intentos");
            Console.WriteLine(currentWordSystem.word);
        }
    }
}
