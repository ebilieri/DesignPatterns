using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
   public class NoSingleton
    {
        public NoSingleton()
        {
            Console.WriteLine("Bola em Jogo!");
        }

        public void Mensagem(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }

    
}
