using System;

namespace primeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! \n Projeto 2 \n Variáveis");

            int idade = 16;
            int pessoas = 2;
            Console.WriteLine("minha idade é " + idade + " anos\n São " + pessoas + " para entrar");

            if (idade >= 18 || pessoas >= 2)
            {
                Console.WriteLine("Pode entrar. \n Idade maior que 18 e/ou está acompanhado");
            } 
            else
            {
                Console.WriteLine("Não pode entrar. \n Idade menor que 18 e/ou não está acompanhado");
            }

            int mes = 1;
            double ingresso = 25;
            while (mes <= 12)
            {
                ingresso = ingresso + ingresso * 0.005;
                Console.WriteLine("O ingresso custa " + ingresso);
                mes++;
            }

            mes = 0;
            do
            {
                ingresso = ingresso + ingresso * 0.005;
                Console.WriteLine("O ingresso custa " + ingresso);
                mes++;
            } while (mes <= 12);

            for (mes = 1; mes <=12; mes++)
            {
                ingresso = ingresso + ingresso * 0.005;
                Console.WriteLine("O ingresso custa " + ingresso);
            }

            switch (mes)
            {
                case 1: 
                    Console.WriteLine("Janeiro");
                    break;
                case 2:
                    Console.WriteLine("Fevereiro");
                    break;
                case 3:
                    Console.WriteLine("Março");
                    break;
                case 4:
                    Console.WriteLine("Abril");
                    break;
                default: 
                    Console.WriteLine("Mês inválido");
                    break;
            }
        }
    }
}
