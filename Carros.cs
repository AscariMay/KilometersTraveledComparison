using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class Carros : IComparable
    {
        public string PlacaDoModelo { get; set; }
        private double KmInicial { get; set; }
        private double KmFinal { get; set; }

        public Carros(string placaDoModelo)
        {
            PlacaDoModelo = placaDoModelo;
        }

        public Carros(string placaDoModelo, double kmInicial, double kmFinal) : this(placaDoModelo)
        {
            KmInicial = kmInicial;
            KmFinal = kmFinal;
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Carros))
            {
                throw new ArgumentException("Comparing error: argument is not an Product");
            }

            KmFinal -= KmInicial;
            Carros other = obj as Carros;
            return KmFinal.CompareTo(other.KmFinal);
        }

        public override string ToString()
        {
            return PlacaDoModelo
                + ", "
                + KmFinal.ToString();
        }

    }
}

