using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcuradoraRanked
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidadeVitorias = 100;
            int quantidadeDerrotas = 15;

            CalculadorRanked(quantidadeVitorias, quantidadeDerrotas);
        }
        public static void CalculadorRanked(int vitorias, int derrotas)
        {
            int saldoRanked = vitorias - derrotas;

            string nivel = "";

            if (saldoRanked <= 10)
            {
                nivel = "Ferro";
            }
            else if (saldoRanked <= 20)
            {
                nivel = "Bronze";
            }
            else if (saldoRanked <= 50)
            {
                nivel = "Prata";
            }
            else if (saldoRanked <= 80)
            {
                nivel = "Ouro";
            }
            else if (saldoRanked <= 90)
            {
                nivel = "Diamante";
            }
            else if (saldoRanked <= 100)
            {
                nivel = "Lendário";
            }
            else if (saldoRanked >= 101)
            {
                nivel = "Imortal";
            }

            Console.WriteLine("O Herói tem de saldo de {0} está no nível de {1}", saldoRanked, nivel);
        }
    }
}
