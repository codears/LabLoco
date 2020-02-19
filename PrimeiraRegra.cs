using System;

namespace Fabrica
{
    class PrimeiraRegra : BaseRegra
    {
        IAcessoDados _acessoDados;
        public PrimeiraRegra(AcessoDados acessoDados)
        {
            _acessoDados = acessoDados;
        }

        public void Escrever()
        {
            Console.WriteLine("eu sou a primeira regra criada");
        }

        public void AutoValidar()
        {
            throw new NotImplementedException();
        }
    }

    class SegundaRegra : BaseRegra
    {
        IAcessoDados _acessoDados;
        public SegundaRegra(AcessoDados acessoDados)
        {
            _acessoDados = acessoDados;
        }

        public void Escrever()
        {
            Console.WriteLine("eu sou a segunda regra criada");
        }

        public void AutoValidar()
        {
            throw new NotImplementedException();
        }
    }

    class BaseRegra : IRegra
    {
        public void AutoValidar()
        {
            throw new NotImplementedException();
        }

        protected void Escrever(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
