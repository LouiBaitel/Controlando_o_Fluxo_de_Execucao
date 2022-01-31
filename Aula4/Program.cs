using static System.Console;

namespace Aula4
{
    class Program
    {
        static void Main (string [] args)
        {
            Boolean condicao = true;
            int valor1;

            while (condicao == true) 
            {
                WriteLine("Digite um valor qualquer (0 para sair): ");
                valor1 = int.Parse(ReadLine());

                if (valor1 == 0)
                {
                    WriteLine("Repetição encerrada");
                    break; //encerra a aplicação
                }
                else
                {
                    WriteLine($"O valor digitado é {valor1}.");
                    continue; //continuar a aplicação
                }
            }
        }
    }
}
