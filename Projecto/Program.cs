using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto
{
    class Program
    {

        /*
            * Funcão Calculo de Preço de Custo 
            * 
        */

        private static void PrecoCusto() {
            double valorProduto, dispesas, lucro;
            Console.Clear();
            Console.WriteLine("Digite o valor do produto : ");
            valorProduto = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor das Dispesas : ");
            dispesas = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do lucro ( Ex: 10 => 10% ) : ");
            lucro = (double.Parse(Console.ReadLine()) / 100) * valorProduto;
            Console.WriteLine("O preço de custo é igual "+ ( valorProduto + dispesas + lucro));
            Console.WriteLine();
            Console.Write("\r\nPressione enter para volta no menu Inicial : ");
            Console.ReadLine();
        }

        /*
            * Funcão  Salario
            * 
        */
        private static double DescontoINSS(double salario) {
            return salario * 0.08;
        }
        private static double DescontoIR(double salario)
        {
            return salario * 0.05;
        }
        private static double DescontoSeguroSaude(double salario)
        {
            return salario * 0.02;
        }
        private static void Salario()
        {
            double salarioHora, salarioBasico;
            int nrHora;
            double salarioLiquido;
            Console.Clear();
            Console.WriteLine("Digite o valor do salario por Hora : ");
            salarioHora = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da hora de trabalho : ");
            nrHora = int.Parse(Console.ReadLine());
            salarioBasico = salarioHora * nrHora;
            Console.WriteLine("Salario basico - " + salarioBasico);
            salarioLiquido = salarioBasico - (DescontoINSS(salarioBasico) - DescontoIR(salarioBasico) - DescontoSeguroSaude(salarioBasico));
            Console.WriteLine();
            Console.WriteLine("Salario com discontos de INSS - " +  DescontoINSS(salarioBasico));
            Console.WriteLine("Salario com discontos de IR - " + DescontoIR(salarioBasico));
            Console.WriteLine("Salario com discontos de seguro de saúde - "+ DescontoSeguroSaude(salarioBasico));
            Console.WriteLine("Salario Liquido : " + salarioLiquido);
            Console.Write("\r\nPressione enter para volta no menu Inicial : ");
            Console.ReadLine();
        }

        /*
            * Funcão Conversor Temperatura 
            * 
        */ 

        private static void ConversorTemperatura() {
            double fahrenheit, celsius;
            string op;
            Console.Clear();
            Console.Write("\r\n1 - Para calcular celcius ");
            Console.Write("\r\n2 - Para calcular fahrenheit  ");
            Console.WriteLine("\r\n Selecionar (1/2) : ");
            op = Console.ReadLine();
            if (op == "1")
            {
                Console.WriteLine("Digite o valor em celcius : ");
                fahrenheit = double.Parse(Console.ReadLine());
                celsius = ((fahrenheit - 32) * 5)/ 9;
                Console.WriteLine("O valor em celsius : " + celsius);
            }
            else {
                Console.WriteLine("Digite o valor em fahrenheit : ");
                celsius = double.Parse(Console.ReadLine());

                fahrenheit = (celsius * 9) / 5 + 32;
                Console.WriteLine("O valor em Fahrenheit: " + fahrenheit);
            }
            Console.Write("\r\nPressione enter para volta no menu Inicial : ");
            Console.ReadLine();
        }

        
        /*
             * Funcão Conversor de moeda 
             * 
         */

        private static void ConversorDeMoeda() {
            float dollars, conversion_rate, euros;
            conversion_rate = 1.12f;
            Console.Clear();
            Console.WriteLine("Enter in Dollars:");
            dollars = float.Parse(Console.ReadLine());
            euros = dollars * conversion_rate;
            Console.WriteLine("Dollars:" + euros);
            Console.Write("\r\nPressione enter para volta no menu Inicial : ");
            Console.ReadLine();
        }

        /*
            * Funcão Menu Inicial 
            * 
        */

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Menu Pricipal :");
            Console.WriteLine("1) Cálculo do Salário ");
            Console.WriteLine("2) Preço de Custo ");
            Console.WriteLine("3) Conversor de Temperatura ");
            Console.WriteLine("4) Conversor de Moeda ");
            Console.WriteLine("5) Sair");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Salario();
                    return true;
                case "2":
                    PrecoCusto();
                    return true;
                case "3":
                    ConversorTemperatura();
                    return true;
                case "4":
                    ConversorDeMoeda();
                    return true;
                case "5":
                    return false;
                default:
                    return true;
            }
        }

        /*
       * Funcão Inicial 
       * 
       */
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
    }
}
