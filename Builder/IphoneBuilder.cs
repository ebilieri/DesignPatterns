using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class IphoneBuilder : ICelular
    {
        Celular celular;
        public IphoneBuilder()
        {
            celular = new Celular("Iphone");
        }
        public Celular Celular
        {
            get { return celular; }
        }

        public void BuildBatetia()
        {
            celular.Bateria = "MAh_3500";
        }

        public void BuildCamera()
        {
            celular.Camera = "25 MP";
        }

        public void BuildSistema()
        {
            celular.SistemaOperacional = "iOS 11";
        }

        public void BuildTela()
        {
            celular.Tela = "7\"";
        }
    }
}
