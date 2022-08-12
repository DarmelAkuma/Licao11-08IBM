using System;
using System.Globalization;

namespace Licao11_08_22IBM {
    class Program {
        static void Main(string[] args) {
            CalcPreco();
        }
        static void CalcPreco() {

            double precoA, precoB;
            int codigoA, codigoB;
            Console.WriteLine("Digite o código de seu pedido:");
            string[] vetor = Console.ReadLine().Split(' ');
            codigoA = int.Parse(vetor[0]);
            codigoB = int.Parse(vetor[1]);

            precoA = RetornaPreco(codigoA);
            precoB = RetornaPreco(codigoB);

            Console.WriteLine("Total: R$ " + SomaPreco(precoA, precoB).ToString("F2", CultureInfo.InvariantCulture));
        }
        static double RetornaPreco(int codigo) {

            double resultado = 0.00;

            switch (codigo) {
                case 1:
                    resultado = 4.00;
                    return resultado;
                case 2:
                    resultado = 4.50;
                    return resultado;
                case 3:
                    resultado = 5.00;
                    return resultado;
                case 4:
                    resultado = 2.00;
                    return resultado;
                case 5:
                    resultado = 1.50;
                    return resultado;
                default:
                    return resultado;
            }
        }
        static double SomaPreco(double precoA, double precoB) {
            double resultado = precoA + precoB;
            return resultado;
        }
    }
}