using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
   public class FactotyMethod
    {
        public IPersonagem EscolherPersonagem(string personagem)
        {
            switch (personagem.ToUpper())
            {
                case "LIU KANG": return new LiuKang();
                case "SCORPION": return new Scorpion();
                case "SUBZERO": return new SubZero();
                default:return null;
            }
        }
    }
}
