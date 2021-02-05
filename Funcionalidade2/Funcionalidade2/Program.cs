using System;

namespace Funcionalidade2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne, numberTwo, result = 0;
            string operation;
            
            Console.WriteLine("Digite o operador: ");
            operation = Console.ReadLine();
            
            Console.WriteLine("Digite o primeiro numero: ");
            numberOne = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o segundo numero: ");
            numberTwo = int.Parse(Console.ReadLine());
            
            switch (operation)
            {
                case "+":
                   result = numberOne + numberTwo;
                    break;
                case "-":
                    result = numberOne - numberTwo;
                    break;
                case "/":
                    result = numberOne / numberTwo;
                    break;
                case "*":
                    result = numberOne * numberTwo;
                    break;
                default:
                    Console.WriteLine("operaçao invalida");
                    break;
            }
            Console.WriteLine("{0} {1} {2} = {3} " , numberOne, operation, numberTwo, result);
        }
    }
}