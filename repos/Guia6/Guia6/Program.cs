using Guia6;
using System;

public  class Program
{
    static void Main(string[] args)
    {
        Vehiculo micoche = new Coche();
        micoche.RealizarMantenimiento();
        Console.WriteLine("Costo del mantenimiento del coche:$"+ micoche.ObtenercostodeMantenimiento());
        Console.WriteLine("Tiempo del mantenimiento del coche: " + micoche.CalcularTiempo() + " hora");

        Vehiculo miMoto = new Moto();
        miMoto.RealizarMantenimiento();
        Console.WriteLine("costo del mantenimiento de la moto:$" + miMoto.ObtenercostodeMantenimiento());
        Console.WriteLine("Tiempo del mantenimiento de la moto: " + miMoto.CalcularTiempo() + " hora");


        micoche.Lavar();
        Coche micochereal = new Coche();
        micochereal.Lavar(); 
        
        servicio servicioAceite=new CambioAceite();
        servicioAceite.Rezalizarservicios();
        Console.WriteLine("costo del cambio de aceite:$" + servicioAceite.calcularcosto());
        Console.WriteLine("Tiempo del cambio de aceite: " + servicioAceite.CalcularTiempo() + " Minutos");

        servicio serviciofrenos=new Reparaciondefrenos();
        serviciofrenos.Rezalizarservicios();
        Console.WriteLine("costo de reparacion de frenos:$" + serviciofrenos.calcularcosto());
        Console.WriteLine("Tiempo de reparación de frenos: " + serviciofrenos.CalcularTiempo() + " hora");
    }
}

   
