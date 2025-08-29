using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viaje
{
    public class CViaje
    {
        // 1 
        private static float costo_por_km;
        private static ushort km_minimo;

        private string dominio;
        private ushort distancia_recorrida;

        // 2
        public static void SetCostoPorKilometro(float num)
        {
            CViaje.costo_por_km = num;
        }

        public float GetCostoPorKilometro()
        {
            return CViaje.costo_por_km;
        }

        // 3 
        public static void SetKmMinimo(ushort num)
        {
            CViaje.km_minimo = num;
        }

        public ushort GetKmMinimo()
        {
            return CViaje.km_minimo;
        }
        // 4 
        public CViaje()
        {
            this.dominio = "XX XXX XX";
        }
        // 5 
        public CViaje(string dominio, ushort distanciaRecorrida)
        {
            this.dominio = dominio;
            this.distancia_recorrida = distanciaRecorrida;
        }
        // 6
        public void SetDominio(string dominio)
        {
            this.dominio = dominio;
        }
        public string GetDominio()
        {
            return this.dominio;
        }
        // 7     (NO SE SI LO HICE BIEN)
        public void Kilometraje()
        {
            ushort num;
            Console.WriteLine("La distancia recorrida es de : " + this.distancia_recorrida);
            Console.WriteLine("Si desea agregar kilometros a la distancia recorrida, escriba 1, caso contrario, escriba 0 : ");
            if(ushort.Parse(Console.ReadLine()) == 1)
            {
                Console.WriteLine("Cuanto desea añadir? : ");
                num = ushort.Parse(Console.ReadLine());
                this.distancia_recorrida += num;
            }
            return;
        }
        // 8 
        public float DarCosto()
        {
            if(this.distancia_recorrida < CViaje.km_minimo)
            {
                return (CViaje.costo_por_km * CViaje.km_minimo);
            }
            return (CViaje.costo_por_km * this.distancia_recorrida);
        }
        // 9
        public float DarCosto(float peajes)
        {
            if (this.distancia_recorrida < CViaje.km_minimo)
            {
                return ((CViaje.costo_por_km * (float)CViaje.km_minimo) + peajes);
            }
            return ((CViaje.costo_por_km * (float)this.distancia_recorrida) + peajes);
        }
        // 10
        public string DarDatos()
        {
            Console.WriteLine("Informacion del viaje : ");
            string datos = "Dominio : " + this.dominio;
            datos += " - Distancia recorrida : " + this.distancia_recorrida.ToString();
            datos += " - Costo por kilometro : " + CViaje.costo_por_km.ToString();
            datos += " - Costo de viaje(sin peajes) : " + DarCosto().ToString();

            return datos;
        }
        // 11
        public ushort MayorDistancia(CViaje otroViaje)
        {
            ushort diferencia_km;
            diferencia_km = (ushort)(this.distancia_recorrida - otroViaje.distancia_recorrida);
            return diferencia_km;
        }
    }
}