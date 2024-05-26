using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia6
{
    public class CambioAceite : servicio
    {
        public override void Rezalizarservicios()
        {
            Console.WriteLine("Realizando cambio de aceite");
          
        }
        public override double calcularcosto()
        {
            return 50.00;
        }

        public override double CalcularTiempo()
        {
            return 30.0; 
        }
    }
}
