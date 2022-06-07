using System;

namespace primeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! \n Projeto 2 \n Variáveis");

            int idade;
            idade = 21;
            Console.WriteLine("minha idade é " + idade + " anos\n");

            double salario;
            salario = 1900.00;
            Console.WriteLine("meu salário é "+ salario + " reais\n");

            salario = idade; //int < double
            //idade = salario; //inválido: double > int
            idade = (int)salario; //casting válido

            char letra = 'a';
            int num = (int)letra; //casting válido:caractere -> inteiro
            num = (int)(letra+5); //casting + representação da tabela ascii
            letra = (char)num; //casting + conversão da tabela ascii

            //bool, byte < short, char < int, float < long, double - ordem por tamanhos

        }
    }
}
