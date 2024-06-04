using System; //Trabalhar com o console
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq; //trabalhar com conjuntos grandes de dados
using System.Net.Mime;
using System.Security.AccessControl;
using System.Text; //manipulção de textos
using System.Threading.Tasks; //Opicional, criar programa que rode em vários núcleos 


namespace Calculadora //POO
{
    class Entrada //POO
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual operação deseja fazer? \n1-Adição\n2-Subtração\n3-Divisão\n4-Multiplicação");
            int operacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro número: ");
            int num_1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int num_2 = int.Parse(Console.ReadLine());

            int resultado = 0; // Inicializa o resultado

            switch (operacao)
            {
                case 1:
                    resultado = Calculos.Algoritmo.Adicao(num_1, num_2);
                    break;
                case 2:
                    resultado = Calculos.Algoritmo.Substracao(num_1, num_2);
                    break;
                case 3:
                    resultado = Calculos.Algoritmo.Divisao(num_1, num_2);
                    break;
                case 4:
                    resultado = Calculos.Algoritmo.Multiplicacao(num_1, num_2);
                    break;
                default:
                    Console.WriteLine("Operação inválida");
                    break;
            }

            Console.WriteLine("Resultado: " + resultado);
        }
    }
}
