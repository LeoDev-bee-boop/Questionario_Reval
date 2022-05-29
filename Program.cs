using Questionário_Reval.Classes;
using System;

//Código desenvolvido por Leonardo Bratfisch Sevalhos para um questionário da empresa Reval

namespace Questionário_Reval
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instânciado Classe
            var calculo = new Calculo();

            //Variáveis Globais
            int varA = 0;
            int varB = 0;
            int resultado = 0;
            int seletor = 0;
            int aux;
            bool continuar;

            do
            {
                //Inciando Seletor de Operação
                Console.WriteLine("=====Digite abaixo qual será a operação realizada!===== \n");
                Console.WriteLine("\n 1 - Adição");
                Console.WriteLine("\n 2 - Subtração");
                Console.WriteLine("\n 3 - Multiplicação");
                Console.WriteLine("\n 4 - Divisão");

                //Atribuindo valor da operação escolhida
                seletor = Convert.ToInt32(Console.ReadLine());

                //Atribuindo primeiro valor da operação
                Console.WriteLine("\n Digite o primeiro número da operação: \n");
                varA = Convert.ToInt32(Console.ReadLine());

                //Atribuindo segubndo valor da operação
                Console.WriteLine("\n Digite o segundo número da operação: \n");
                varB = Convert.ToInt32(Console.ReadLine());

                switch (seletor)
                {
                    case 1:
                        resultado = calculo.Somar(varA, varB); break;
                    case 2:
                        resultado = calculo.Subtrair(varA, varB); break;
                    case 3:
                        resultado = calculo.Multiplicar(varA, varB); break;
                    case 4:
                        resultado = calculo.Dividir(varA, varB); break;
                }

                Console.WriteLine("O resultado da operação foi: " + resultado);

                Console.WriteLine("\n Deseja continar? Digite 1 para SIM e qualquer outro número para NÃO \n");
                aux = Convert.ToInt32(Console.ReadLine());

                //Valida retorno
                if (aux == 1)
                    continuar = true;
                else
                    continuar = false;

            } while (continuar == true);
        }
    }
}