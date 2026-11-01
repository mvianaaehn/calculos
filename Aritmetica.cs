using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    
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

        /// <summary>
        /// Operação de multiplicação.
        /// </summary>
        /// <param name="x"> - valor do primeiro operando.</param>
        /// <param name="y"> - valor do segundo operando.</param>
        /// <returns>Retorna o resutado da multiplicação de dois números.</returns>
        public static int multiplicar(int x, int y)
        {
            return x * y;
        }

    }
}
