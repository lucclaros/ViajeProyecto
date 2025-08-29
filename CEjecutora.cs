using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viaje
{
    public class CEjecutora
    {
        public static void Main()
        {
            float costoPorKm = LeerFloat("Ingresar el valor del costo por kilometro: ");
            ushort kmMinimo = LeerUShort("Ingresar el kilometraje minimo: ");

            CViaje.SetCostoPorKilometro(costoPorKm);
            CViaje.SetKmMinimo(kmMinimo);

            Console.WriteLine($"Costo por kilometro: {costoPorKm}, Kilometraje minimo: {kmMinimo}");

            CViaje viajeActual, viajeMayorRecorrido = new CViaje();
            string dominio;
            
            Console.WriteLine("Ingresar dominio (para finalizar, escriba 'Fin'):");
            dominio = Console.ReadLine();

            if (dominio != "Fin")
            {
                while (dominio != "Fin")
                {
                    ushort distancia = LeerUShort("Ingresar distancia recorrida: ");
                    viajeActual = new CViaje(dominio, distancia);

                    if (viajeActual.MayorDistancia(viajeMayorRecorrido) > 0)
                        viajeMayorRecorrido = viajeActual;

                    Console.WriteLine("Ingresar dominio (para finalizar, escriba 'Fin'):");
                    dominio = Console.ReadLine();
                }

                Console.WriteLine("\nVIAJE CON MAYOR RECORRIDO:");
                Console.WriteLine(viajeMayorRecorrido.DarDatos());
            }
            else
            {
                Console.WriteLine("No se ingresaron viajes válidos.");
            }

            Console.WriteLine("\nFin del programa. Presione <ENTER> para finalizar.");
            Console.ReadLine();
        }

        private static float LeerFloat(string mensaje)
        {
            float valor;
            do
            {
                Console.Write(mensaje);
            } while (!float.TryParse(Console.ReadLine(), out valor));
            return valor;
        }

        private static ushort LeerUShort(string mensaje)
        {
            ushort valor;
            do
            {
                Console.Write(mensaje);
            } while (!ushort.TryParse(Console.ReadLine(), out valor));
            return valor;
        }
    }
}
