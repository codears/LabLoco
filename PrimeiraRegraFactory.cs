namespace Fabrica
{
    class PrimeiraRegraFactory : IRegraFactory
    {
        public IRegra CriarRegra(AcessoDados acessoDados)
        {
            return new PrimeiraRegra(acessoDados);
        }
    }

    class SegundaRegraFactory : IRegraFactory
    {
        public IRegra CriarRegra(AcessoDados acessoDados)
        {
            return new SegundaRegra(acessoDados);
        }
    }
}
