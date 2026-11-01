using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    
    /// <summary>
    /// Classe de implementação de conversão.
    /// </summary>
    internal static class Conversoes
    {
        /// <summary>
        /// Tipo de conversão de temperatura a executar.
        /// </summary>
        public enum ConversaoTemperatura
        {
            Nulo = 0,
            CelsiusFahrenheit,
            FahrenheitCelsius
        }

        public enum ConversaoDistancia
        {
            Nulo = 0,
            MetrosMilhas,
            MilhasMetros
        }

        /// <summary>
        /// Conversâo de temperaturas.
        /// </summary>
        /// <param name="conversao"> - Conversão a efeturar.</param>
        /// <param name="temperatura"> - Temperatura a converter.</param>
        /// <returns>Retorna o resultado da conversão.</returns>
        public static double converterTemperatura(ConversaoTemperatura conversao, double temperatura)
        {
            if (conversao == ConversaoTemperatura.CelsiusFahrenheit)
            {
                return (temperatura * 1.8000 + 32);
            }
            if (conversao == ConversaoTemperatura.FahrenheitCelsius)
            {
                return ((temperatura - 32) / 1.8000);
            }
            return -1;
        }

        /// <summary>
        /// Conversão de distâncias.
        /// </summary>
        /// <param name="conversao"> - o tipo de conversão a efetuar.</param>
        /// <param name="distancia"> - a distância a converte.</param>
        /// <returns>Retorna o resultado da conversão da distância.</returns>
        /// <returns>Retorna o resultado da conversão da distância.</returns>
        public static double converterDistancia(ConversaoDistancia conversao, double distancia)
        {
            if(conversao == ConversaoDistancia.MetrosMilhas)
            {
                return distancia * 0.0006213712;
            }
            if(conversao == ConversaoDistancia.MilhasMetros)
            {
                return distancia * 1609.344;
            }
            return -1;
        }
    }
}
