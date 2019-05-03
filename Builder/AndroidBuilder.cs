using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class AndroidBuilder : ICelular
    {
        Celular celular;
        public AndroidBuilder()
        {
            celular = new Celular("Android");
        }
        public Celular Celular
        {
            get { return celular; }
        }

        public void BuildBatetia()
        {
            celular.Bateria = "MAh_1500";
        }

        public void BuildCamera()
        {
            celular.Camera = "15 MP";
        }

        public void BuildSistema()
        {
            celular.SistemaOperacional = "Android 9.0";
        }

        public void BuildTela()
        {
            celular.Tela = "9\"";
        }
    }
}
