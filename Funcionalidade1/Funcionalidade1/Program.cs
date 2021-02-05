using System;
using System.Linq;


namespace Funcionalidade1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {8, 5, 6, 9, 2, 5, 10, 7, 1, 3};
            int[] sortNumbers = numbers.OrderBy(x => x).ToArray();
            String[] numberName = {"um", "dois", "tres", "quatro", "cinco", "seis", "sete", "oito", "nove", "dez"};
            for (int i = 0; i < sortNumbers.Length; i++)
            {
                Console.WriteLine(sortNumbers[i] +" - "+ numberName[i]);
            }
        }
    }
}