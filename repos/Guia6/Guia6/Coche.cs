using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia6
{
    public class Coche : Vehiculo
    {
        public override void RealizarMantenimiento()
        {

            Console.WriteLine("Realizando mantenimiento del coche: cambio de aceite y revision de frenos");
           
        }


        public override double ObtenercostodeMantenimiento()
        {
            return 150.00;
        }
        public new void Lavar()
        {
            Console.WriteLine("Lavando el coche con cera y shampoo especial");
            
        }
        public override double CalcularTiempo()
        {
            return 1.0; // Suponiendo que el mantenimiento del coche toma 1 hora
        }
    }
}
