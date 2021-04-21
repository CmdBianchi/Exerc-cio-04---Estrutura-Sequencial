using System;

namespace Exercício_04___Estrutura_Sequencial
{
    class Program
    {
        /// -------> START / MAIN 
        /////////////////////////////////////////////////////////////////////////////////////////////
        static void Main(string[] args)
        {
           
        }
        /// -------> FUNCTIONS
        /////////////////////////////////////////////////////////////////////////////////////////////
        static void Msg() {
            Console.WriteLine("Mostre o número e o salário do funcionário, com duas casas decimais."); 
        }
        static void Id() {
            int numero;
            Console.Write("Número de série do funcionário: ");
            numero = int.Parse(Console.ReadLine());
        }
        /////////////////////////////////////////////////////////////////////////////////////////////
        /// -------> END
    }
}
