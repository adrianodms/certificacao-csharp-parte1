using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class TiposInteiros : IAulaItem
    {
        public void Executar()
        {
            int idade = 15;

            char resposta = 'S'; // System.Char

            byte nivelDeAzul = 0xFF; // = 255 em decimal

            //nivelDeAzul = -3;

            short passageirosVoo = 230; // System.Int16

            passageirosVoo = -7;

            int populacao = 1500; // System.Int32

            populacao = -2300;

            long populacaoDoBrasil = 207_660_992; // +/- 207 milhoes

            sbyte nivelDeBrilho = -127; // System.Sbyte

            ushort passageirosNavio = 230; // System.UInt16

            uint estoque = 1500; // System.UInt132

            ulong populacaoDoMundo = 7_000_000_000; // 7 bilhoes - System.UInt64


            Console.WriteLine($"resposta: {resposta}");
            Console.WriteLine($"nivelDeAzul: {nivelDeAzul}");
            Console.WriteLine($"passageirosVoo: {passageirosVoo}");
            Console.WriteLine($"populacao: {populacao}");
            Console.WriteLine($"populacaoDoBrasil: {populacaoDoBrasil}");
            Console.WriteLine($"nivelDeBrilho: {nivelDeBrilho}");
            Console.WriteLine($"passageirosNavio: {passageirosNavio}");
            Console.WriteLine($"estoque: {estoque}");
            Console.WriteLine($"populacaoDoMundo: {populacaoDoMundo}");

            //nivelDeAzul = 0xFFFF; // = 65535 em descimal
            //passageirosVoo = 230000; // System.Int16
            //populacao = 100055505050540540; //





        }
    }
}
