using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            FactotyMethod fm = new FactotyMethod();

            Console.WriteLine("Liu Kang | SubZero | Scopion");
            Console.WriteLine();

            Console.WriteLine("Escolha seu personagem");
            string escolha = Console.ReadLine();

            IPersonagem personagem = fm.EscolherPersonagem(escolha);
            Console.WriteLine();
            Console.Write("Você vai jogar com: ");

            if (personagem != null)
                personagem.Escolhido();
            else
                Console.WriteLine("Personagem invalido");

            Console.ReadKey();
        }
    }
}
