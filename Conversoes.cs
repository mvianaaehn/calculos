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
    }
}
