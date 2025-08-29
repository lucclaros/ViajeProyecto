using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viaje
{
    public class CViaje
    {
        private static float costo_por_km;
        private static ushort km_minimo;
        
        public static void SetCostoPorKilometro(float num) => costo_por_km = num;
        public static void SetKmMinimo(ushort num) => km_minimo = num;

        public static float GetCostoPorKilometro() => costo_por_km;
        public static ushort GetKmMinimo() => km_minimo;

        
        public CViaje() => dominio = "XX XXX XX";

        public CViaje(string dominio, ushort distanciaRecorrida)
        {
            this.dominio = dominio;
            this.distancia_recorrida = distanciaRecorrida;
        }

        public void SetDominio(string dominio) => this.dominio = dominio;
        public string GetDominio() => dominio;

        public void AgregarKilometraje(ushort km)
        {
            distancia_recorrida += km;
        }

        public float DarCosto()
        {
            return (distancia_recorrida < km_minimo) ? costo_por_km * km_minimo : costo_por_km * distancia_recorrida;
        }

        public float DarCosto(float peajes)
        {
            return DarCosto() + peajes;
        }

        public string DarDatos()
        {
            return $"Dominio: {dominio} - Distancia recorrida: {distancia_recorrida} km - Costo por km: {costo_por_km} - Costo total: {DarCosto()}";
        }

        public int MayorDistancia(CViaje otroViaje)
        {
            return distancia_recorrida - otroViaje.distancia_recorrida;
        }
    }
}
