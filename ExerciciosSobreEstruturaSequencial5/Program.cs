using System;
using System.Globalization;

namespace ExerciciosSobreEstruturaSequencial5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.*/

            Console.WriteLine("Código da primeira peça:");
            String primeiraPeca = Console.ReadLine();
            Console.WriteLine("Quantidade da primeira peça:");
            int qntPrimeiraPeca = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor da primeira peça:");
            double valorPrimeiraPeca = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Código da segunda peça:");
            String segundaPeca = Console.ReadLine();
            Console.WriteLine("Quantidade da segunda peça:");
           int qntSegundaPeca = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor da segunda peça:");
            double valorSegundaPeca = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valorTotal = qntSegundaPeca * valorSegundaPeca + qntPrimeiraPeca * valorPrimeiraPeca;

            Console.WriteLine("O valor total a ser pago é R$:" +valorTotal.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
