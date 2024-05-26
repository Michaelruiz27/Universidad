using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia6
{
    public class Moto : Vehiculo
    {
        public override void RealizarMantenimiento()
        {
            Console.WriteLine(" Realizando mantenimiento de la moto: Lubricacion de la cadena y revision de neumaticos.");
        }
        public override double ObtenercostodeMantenimiento()
        {
            return 100.00;
        }
        public override double CalcularTiempo()
        {
            return 1; // Suponiendo que el mantenimiento de la moto toma 30 minutos
        }
    }
}
