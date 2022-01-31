using static System.Console;

namespace Aula3
{
    class Program
    {
        static void Main (string[] args)
        {

            Boolean condicao = true;
            int valor1;


            WriteLine("Exemplo utilizando while");
            while (condicao == true) //enquanto essa condição for verdadeira, os comandos abaixo serão executados
            {
                WriteLine("Digite um valor qualquer (0 para sair): ");
                valor1 = int.Parse(ReadLine());

                if (valor1 == 0)
                {
                    WriteLine("Repetição encerrada");
                    condicao = false;
                }
                else
                {
                    WriteLine($"O valor digitado é {valor1}.");
                }
            }

            int valor2;
            
            WriteLine();
            WriteLine("Exemplo utilizando do");

            //primeiro o bloco de comandos é executado (para conseguir visualizar, é necessário comentar o while)
            do{
                WriteLine("Digite um valor qualquer (0 para sair): ");
                valor2 = int.Parse(ReadLine());

                if (valor2 == 0)
                {
                    WriteLine("Repetição encerrada");
                    condicao = false;
                }
                else
                {
                    WriteLine($"O valor digitado é {valor2}.");
                }
            } while (condicao == true); //No do, a condição é passada somente no final da execução


            int valor3;

            WriteLine();
            WriteLine("Exemplo utilizando o for: ");
            WriteLine("Digite o valor desejado");
            valor3 = int.Parse(ReadLine());

            for (int i = valor3; i < 10; i++) // para cada valor digitado abaixo de 10, será somado 1 ao índice, até que chegue a 10
            {
                WriteLine(i);
            }

            WriteLine();
            WriteLine("Exemplo utilizando o foreach: ");
            int[] lista = {1, 2, 3, 4, 5};

            foreach (int numero in lista)
            {
                WriteLine(numero);
            }
        }
    }
}
