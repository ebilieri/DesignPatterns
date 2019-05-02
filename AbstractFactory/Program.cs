using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = ExecutaAbstractFactory.MontarCarro("luxo");
            Console.WriteLine(c1.Roda);
            Carro c2 = ExecutaAbstractFactory.MontarCarro("popular");
            Console.WriteLine(c2.Roda);

            Console.ReadKey();
        }
    }
}
