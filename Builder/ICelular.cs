namespace Builder
{
    public interface ICelular
    {
        void BuildTela();
        void BuildBatetia();
        void BuildSistema();
        void BuildCamera();

        Celular Celular { get; }
    }
}
