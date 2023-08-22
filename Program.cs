using System.Runtime.Serialization;
using System.Globalization;
using System.Collections;

namespace Treinamento_Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
            
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("CALCULADORA");
            Console.WriteLine();
            Console.WriteLine(" 1- Adição:\n 2- Subtração:\n 3- Divisão:\n 4-Multiplicação:\n 5- Sair do programa:");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Digite uma das opções acima:");
            short opc = short.Parse(Console.ReadLine());

            switch(opc){
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Console.WriteLine("Opção inválida");break;
            }

        }
        static void Soma() 
        {
            Console.Clear();
            float resultado;
            Console.Write("Digite o primeiro valor: ");
            float a = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Digite o segundo valor: ");
            float b = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine();
            resultado = a + b;
            Console.WriteLine("O resultado da soma: "+ resultado.ToString("F2",CultureInfo.InvariantCulture));
            Console.ReadKey();
            Menu();
        }
        static void Subtracao()
        {
            Console.Clear();
            float resultado;
            Console.Write("Digite o primeiro valor: ");
            float a = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o segundo valor: ");
            float b = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            resultado = a - b;
            Console.WriteLine("O resultado da subtração: " + resultado.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();
            Menu();
        }

        static void Divisao()

        {
            
            Console.Clear();
            float resultado;
            Console.Write("Digite o primeiro valor: ");
            float a = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o segundo valor: ");
            float b = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if(b <= 0)
            {
                Console.WriteLine("Divisão invalida, digite um número positivo e diferente de zero!");
            }
            Console.WriteLine();
            resultado = a / b;
            Console.WriteLine("O resultado da divisão: " + resultado.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();
            Menu();
        }
        static void Multiplicacao()
        {
            Console.Clear();
            float resultado;
            Console.Write("Digite o primeiro valor: ");
            float a = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o segundo valor: ");
            float b = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            resultado = a * b;
            Console.WriteLine("O resultado da multiplicação: "+ resultado.ToString("F2",CultureInfo.InvariantCulture));
            Console.ReadKey();
            Menu();

        }
    }
}