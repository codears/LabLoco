
using System;

namespace Fabrica
{
    public class RegraFactory<T>
    {
        private RegraFactory() { }

        public static T Create<T>(IAcessoDados acessoDados) where T : IRegra
        {
            return (T)Activator.CreateInstance(typeof(T), acessoDados);
        }
    }
}