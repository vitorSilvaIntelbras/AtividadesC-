using System; //Trabalhar com o console
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq; //trabalhar com conjuntos grandes de dados
using System.Net.Mime;
using System.Security.AccessControl;
using System.Text; //manipulção de textos
using System.Threading.Tasks; //Opicional, criar programa que rode em vários núcleos 


namespace Calculos //POO
{
    class Algoritmo //POO
    {
        public static int Adicao (int numero1, int numero2){
            int result = numero1 + numero2;
            return result;
            //static faz com que a classe precise estar antes di metodo
        }

         public static int Substracao (int numero1, int numero2){
            int result = numero1  - numero2;
            return result;
            //static faz com que a classe precise estar antes di metodo
        }

         public static int Divisao (int numero1, int numero2){
            int result = numero1 / numero2;
            return result;
            //static faz com que a classe precise estar antes di metodo
        }
         public static int Multiplicacao (int numero1, int numero2){
            int result = numero1 * numero2;
            return result;
            //static faz com que a classe precise estar antes di metodo
        }
    }      
    
}
