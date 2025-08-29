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
            float costoporkm;
            ushort kmMinimo;
            // 1

            Console.WriteLine("Ingresar el valor del costo por kilometro : ");
            costoporkm = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar el kilometraje minimo : ");
            kmMinimo = ushort.Parse(Console.ReadLine());
          

            CViaje.SetCostoPorKilometro(costoporkm);
            CViaje.SetKmMinimo(kmMinimo);

            Console.WriteLine("Costo por kilometro : {0}  Kilometraje minimo : {1} ", costoporkm, kmMinimo);

            // 2

            CViaje Viaje1, ViajeMayorRecorrido;
            string dom = "";
            ushort distancia_recorrida;
            Console.WriteLine("Ingresar dominio : ");
            dom = Console.ReadLine();
            ViajeMayorRecorrido = new CViaje();

            if(dom != "Fin")
            {
                while(dom != "Fin")
                {
                    Console.WriteLine("Ingresar distancia recorrida : ");
                    distancia_recorrida = ushort.Parse(Console.ReadLine());
                    Viaje1 = new CViaje(dom, distancia_recorrida);
                    if(Viaje1.MayorDistancia(ViajeMayorRecorrido) > 0)
                    {
                        ViajeMayorRecorrido = Viaje1;
                    }
                    Console.WriteLine("Ingresar dominio : (para finalizar, escriba 'Fin')");
                    dom = Console.ReadLine();
                }
                // 3
                Console.WriteLine("VIAJE CON MAYOR RECORRIDO : ");
                Console.WriteLine(ViajeMayorRecorrido.DarDatos());
            } 
            // 4
            else
            {
                Console.WriteLine("No se ingresaron viajes validos.");
            }

            Console.Write("Fin del programa. Presione <ENTER> para finalizar");
            Console.ReadLine();

        }
    }
}
