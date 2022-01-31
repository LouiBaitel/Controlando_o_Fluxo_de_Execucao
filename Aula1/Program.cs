using static System.Console; // inserindo esta biblioteca, podemos deixar o código mais limpo

namespace Aula01
{
    class Program
    {
        static void Main (string[] args)
        {
            WriteLine("Digite o primeiro valor: "); // como insterimos a biblioteca inicialmente, podemos fazer uso somente do WriteLine
                                                     // Este comando possibilita printar uma informação na tela para o usuário
            
            int valor1;    // Definimos inicialmente quais as variáveis desejamos capturar do usuário
            int valor2;
            int total;   

            valor1 = int.Parse(ReadLine());  // Com o comando ReadLine, associado a variável definida anteriormente, podemos capturar a informação e gravá-la em valor1
                                             // O comando int.Parse converte a informação recebida(que estará na forma de string) em inteiro, para que seja possível armazená-la

            WriteLine($"O primeiro valor é {valor1}!"); // Utilizando o $ antes das aspas, podemos concatenar as informações dentro do que será printado, com o uso de {variável}

            WriteLine("Digite o segundo valor: ");
            valor2 = int.Parse(ReadLine());
            WriteLine($"O segundo valor é {valor2}!");

            total = (valor1 + valor2);

            WriteLine($"A soma dos valores informados é {total}!");
            
        }
    }
}