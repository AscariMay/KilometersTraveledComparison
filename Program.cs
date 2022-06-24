using System;
using System.Collections.Generic;
using System.Globalization;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verificação de Quilometragens rodadas dos veiculos\n");

            List<Carros> lista = new List<Carros>();
            Console.Write("Quantidade de veículos a serem verificados: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(',');
                double kmInicial = double.Parse(vect[1], CultureInfo.InvariantCulture);
                double kmFinal = double.Parse(vect[2], CultureInfo.InvariantCulture);
                lista.Add(new Carros(vect[0], kmInicial, kmFinal));
            }

            CalculationService calculation = new CalculationService();
            Carros quilometragem = calculation.Max(lista);
            Console.WriteLine("\nVeículo com mais quilômetros rodados: ");
            Console.WriteLine(quilometragem);
        
        }
    }
}
