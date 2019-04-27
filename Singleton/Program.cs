using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonMethod();

            Console.WriteLine("#######################");

            NoSingletonMethod();

            Console.ReadKey();
        }

        private static void NoSingletonMethod()
        {
            Console.WriteLine("No Singleton Method");
            NoSingleton jogador1 = new NoSingleton();
            jogador1.Mensagem("Jogador 1: A bola esta comigo!");

            NoSingleton jogador2 = new NoSingleton();
            jogador2.Mensagem("Jogador 2: Recebi a bola");

            NoSingleton jogador3 = new NoSingleton();
            jogador3.Mensagem("Jogador 3: Recebi o lançamento na linha de frente");
        }

        private static void SingletonMethod()
        {
            Console.WriteLine("Singleton Method");
            Singleton jogador1 = Singleton.GetInstancia;
            jogador1.Mensagem("Jogador 1: A bola esta comigo!");

            Singleton jogador2 = Singleton.GetInstancia;
            jogador2.Mensagem("Jogador 2: Recebi a bola");

            Singleton jogador3 = Singleton.GetInstancia;
            jogador3.Mensagem("Jogador 3: Recebi o lançamento na linha de frente");
        }
    }
}
