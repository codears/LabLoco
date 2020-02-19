namespace Fabrica
{
    abstract class AbstractRegraFactory
    {
        private readonly IRegraFactory _factory;

        protected AbstractRegraFactory(IRegraFactory regraFactory)
        {
            _factory = regraFactory;
        }

        public IRegra AplicarRegra(string nomeRegra)
        {
            IRegra regra = _factory.CriarRegra(new AcessoDados());
            return regra;
        }
    }

    class PrimeiraRegraAbstractFactory : AbstractRegraFactory
    {
        public PrimeiraRegraAbstractFactory(IRegraFactory regraFactory) : base(regraFactory)
        {
        }

        public PrimeiraRegraAbstractFactory() : this(new PrimeiraRegraFactory()) { } 
    }

    
}
