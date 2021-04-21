using System;

namespace Exercício_04___Estrutura_Sequencial
{
    class Program
    {
        /// -------> START / MAIN 
        /////////////////////////////////////////////////////////////////////////////////////////////
        static void Main(string[] args){
            Msg();
            LineBreaker();
            Id();
            Salary();
            LineBreaker();
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
        static double Salary() {
            double hours, hourvalue, salary;

            Console.Write("Define a quantidade de horas trabalhadas: ");
            hours = double.Parse(Console.ReadLine());
            Console.Write("Valor por hora: ");
            hourvalue = double.Parse(Console.ReadLine());
            salary = hourvalue * hours;
            Console.Write("O Valor da hoa é:" +salary);
            Console.WriteLine(" ");
            return salary; 
        }
        /*------------------------------------------------------------------------------------------*/
        static void LineBreaker() {  
            Console.WriteLine("----------------------");               
        }
        /////////////////////////////////////////////////////////////////////////////////////////////
        /// -------> END
    }
}
