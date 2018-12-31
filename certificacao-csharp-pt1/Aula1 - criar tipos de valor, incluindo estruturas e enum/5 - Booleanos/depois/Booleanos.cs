using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Booleanos : IAulaItem
    {
        public void Executar()
        {
            //bool possuiSaldo = 1;

            bool possuiSaldo = true;

            Console.WriteLine($"Possui saldo: {possuiSaldo}");

            int dias = DateTime.Now.Day;

            Console.WriteLine($"Dias: {dias}");

            bool diasPar = (dias % 2 == 0);

            if (diasPar)
            {
                Console.WriteLine("dias é um numero par");
            }
            else
            {
                Console.WriteLine("dias é um numero impar");
            }
        }
    }
}
