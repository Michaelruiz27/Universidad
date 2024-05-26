using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia6
{
    public class Reparaciondefrenos : servicio
    {
        public override void Rezalizarservicios()
        {
            Console.WriteLine("Realizando cambio de Frenos");
            
        }
        public override double calcularcosto()
        {
            return 100.00;
        }
        public override double CalcularTiempo()
        {
            return 3.0; 
        }
    }
}
