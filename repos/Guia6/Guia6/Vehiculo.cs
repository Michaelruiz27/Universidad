using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia6
{
    public  class Vehiculo
    {
        public virtual void RealizarMantenimiento()
        {
            Console.WriteLine("Realizando mantenimiento general del vehiculo");
        }

        public virtual double ObtenercostodeMantenimiento()
        {
            return 50.00;
        }
        public void Lavar()
        {
            Console.WriteLine("Lavar vehiculo");
            
        }

        public virtual double CalcularTiempo()
        {
            return 0;
        }
    }
}
