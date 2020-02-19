using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica
{
    class Program
    {
        static void Main(string[] args)
        {
            var acessoDados = new AcessoDados();
            var primeiraRegra = RegraFactory<IRegra>.Create<PrimeiraRegra>(acessoDados);
            var segundaRegra = RegraFactory<IRegra>.Create<SegundaRegra>(acessoDados);
            primeiraRegra.Escrever();
            segundaRegra.Escrever();
            Console.ReadLine();
        }
    }    
}