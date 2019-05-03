namespace Builder
{
    public class Fabricante
    {

        public void Construtor(ICelular celularBuilder)
        {
            celularBuilder.BuildBatetia();
            celularBuilder.BuildSistema();
            celularBuilder.BuildTela();
            celularBuilder.BuildCamera();
        }
    }
}
