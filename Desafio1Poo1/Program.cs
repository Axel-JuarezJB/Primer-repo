using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1Poo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Telefono celu1 = new Telefono("Samsung","J7");
            //Console.WriteLine("Escriba el numero telefonico:");
            //celu1.NumeroTelefonico = Console.ReadLine();
            //Console.WriteLine("Escriba el codigo de operador");
            //celu1.CodigoOperador = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Estado del telefono uno: {celu1.Marca}, {celu1.Modelo}, {celu1.NumeroTelefonico}, {celu1.CodigoOperador} "  );

            //Telefono celu2 = new Telefono("Iphone", "13");
            //celu2.NumeroTelefonico = "1123456789";
            //celu2.CodigoOperador = 2;
            //Console.WriteLine($"Estado segundo telefono: {celu2.Marca}, {celu2.Modelo}," +
            //    $" {celu2.NumeroTelefonico}, {celu2.CodigoOperador} "  );

            //Console.WriteLine(celu1.Llamar());
            //Console.WriteLine(celu2.Llamar("Pepe"));
            //Console.WriteLine(celu1.Llamar(1123456789));

            Television tele1 = new Television("LG", "Smart TV", true);
            tele1.volumen = 56;
            Console.WriteLine(tele1.volumen);

            Television tele2 = new Television("Samsung", "Smart TV", false);
            tele2.canal = 924;
            tele2.volumen = 20;
            Console.WriteLine($"Estado tele: {tele2.prender}, {tele2.marca}, " +
                $"{tele2.modelo}, {tele2.canal}, {tele2.volumen}");
            tele2.SubirVolumen(40);
            tele2.Cambiar(856);
            Console.WriteLine($"nuevo estado: {tele2.volumen}, {tele2.canal}");
           
        }
    }
}
