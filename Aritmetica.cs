using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
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
    /// Implementa operações aritméticas
    /// </summary>
    internal static class Aritmetica
    {
        /// <summary>
        /// Operação soma.
        /// </summary>
        /// <param name="x"> - primeiro operando </param>
        /// <param name="y"> - segundo operando </param>
        /// <returns>Retorna a soma dos dois números.</returns>
        public static int somar(int x, int y)
        {
            return x * y;
        }

        /// <summary>
        /// Operação subtração.
        /// </summary>
        /// <param name="x"> - primeiro operando da subtração.</param>
        /// <param name="y"> - segundo operando da subtração. </param>
        /// <returns>Retorna o resultado da subtração de dois números.</returns>
        public static int subtrair(int x, int y)
        {
            return x -  y;
        }


        public static double converterTemperatura(ConversaoTemperatura conversao, double temperatura)
        {
            if(conversao == ConversaoTemperatura.CelsiusFahrenheit)
            {
                return (temperatura * 1.8000 + 32);
            }
            if(conversao == ConversaoTemperatura.FahrenheitCelsius)
            {
                return ((temperatura - 32) / 1.8000);
            }
            return -1;
        }

    }
}
