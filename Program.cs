using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion101_Practica01_Ejercicio03
{
    public class Program
    {
        static void Main(string[] args)
        {
           /*
            Haz un programa que pida al usuario el precio de un objeto sin IVA y la cantidad
            de IVA aplicable. 
            Luego calcula el precio final.
            */
            
            double precio;
            double alicuotaIVA;
            double precioFinal;

            double CalcularPrecioFinal()
            {
                precioFinal = precio * (1 + alicuotaIVA/100);
                return precioFinal;
            }

            Console.WriteLine("Ingrese el precio del producto...");
            precio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la alicuota de IVA...");
            alicuotaIVA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("El precio final del producto es: "+CalcularPrecioFinal());
            Console.ReadLine();

        }
    }
}
