using System;

namespace Exercício_04___Estrutura_Sequencial
{
    class Program
    {
        /// -------> START / MAIN 
        /////////////////////////////////////////////////////////////////////////////////////////////
        static void Main(string[] args)
        {
            Msg();
            Id();
        }
        /// -------> FUNCTIONS
        /////////////////////////////////////////////////////////////////////////////////////////////
        static void Msg() {
            Console.WriteLine("Mostre o número e o salário do funcionário, com duas casas decimais."); 
        }
        /*------------------------------------------------------------------------------------------*/
        static int Id() {
            int numero;
            Console.Write("Número de série do funcionário: ");
            numero = int.Parse(Console.ReadLine());
            return numero;
        }
        /*------------------------------------------------------------------------------------------*/
        static void Salary() {
            double hours, salary;

            Console.Write("Difite a quantede de horas trabalhadas: ");
            hours = double.Parse(Console.ReadLine());
            



        }


        /////////////////////////////////////////////////////////////////////////////////////////////
        /// -------> END
    }
}
