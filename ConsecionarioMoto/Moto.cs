using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsecionarioMoto
{
    class Moto
    {
        public double valorDeFabrica = 0;
        public int añosDeUso = 0;
        public int vidaUtilEstimada = 0;

        public string Marca
        { get; private set; }

        public int Modelo
        { get; private set; }

        public double ValorFabricacion
        { get; private set; }

        public Moto(string marca, int modelo, double valorFabricacion)
        {
            Marca = marca;
            Modelo = modelo;
            ValorFabricacion = valorFabricacion;
        }

        public double CalcularDepreciacionLineal(int añoACalcular, int vidaUtil)
        {
            añosDeUso = añoACalcular - Modelo;
            double valorActualizado = (valorDeFabrica - (valorDeFabrica * (añosDeUso / vidaUtilEstimada)));
            
            return valorActualizado;
        }

        public double CalcularDepreciacionAnual(int añoACalcular, double tasaDepreciacion)
        {
            double valorActualizado = (ValorFabricacion * (Math.Pow(1 - 0.1, añoACalcular - Modelo)));
            return valorActualizado;
        }

        public string VerDescripcion()
        {
            return $"Marca: {Marca}, Valor de Fabrica: { ValorFabricacion},  Modelo:{ Modelo}";
        }



    }
}
