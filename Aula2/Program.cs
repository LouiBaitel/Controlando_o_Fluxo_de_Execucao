using static System.Console;

namespace Aula2
{
    class Program
    {
        static void Main (string [] args)
        {
            
            int idade;

            WriteLine("Qual a sua idade?");
            idade = int.Parse(ReadLine());

            if (idade >= 18) //Se esta condição for verdadeira, o comando abaixo será executado
            {
               WriteLine($"O usuário possui {idade} anos, portanto é maior.");
            }
            else // Caso a condição seja falsa, o comando abaixo será executado
            {
                WriteLine($"O usuário possui {idade} anos, logo, é menor.");
            }


            int mes;
            WriteLine(@"
            Digite o número do mês, conforme abaixo:
            1 - Janeiro
            2 - Fevereiro
            3 - Março
            4 - Abril
            5 - Maio
            6 - Junho
            7 - Julho
            8 - Agosto
            9 - Setembro
            10 - Outubro
            11 - Novembro
            12 - Dezembro
            ");
            mes = int.Parse(ReadLine());

            WriteLine();
            WriteLine("Método com if"); 
            if(mes == 1)
            {
                WriteLine("Janeiro possui 31 dias");
            }
            else if(mes == 2) //Podem ser incluídos quantos else if desejar dentro da estrutura de condição
            {
                WriteLine("Fevereiro possui 28 dias");
            }
            else if(mes == 3)
            {
                WriteLine("Março possui 31 dias");
            }
             else if(mes == 4)
            {
                WriteLine("Abril possui 30 dias");
            }
             else if(mes == 5)
            {
                WriteLine("Maio possui 31 dias");
            }
             else if(mes == 6)
            {
                WriteLine("Junho possui 30 dias");
            }
             else if(mes == 7)
            {
                WriteLine("Julho possui 31 dias");
            }
             else if(mes == 8)
            {
                WriteLine("Agosto possui 31 dias");
            }
             else if(mes == 9)
            {
                WriteLine("Setembro possui 30 dias");
            }
             else if(mes == 10)
            {
                WriteLine("Outubro possui 31 dias");
            }
             else if(mes == 11)
            {
                WriteLine("Novembro possui 30 dias");
            }
            else if(mes == 12)
            {
                WriteLine("Dezembro possui 31 dias");
            }
            else // Aqui não foi incluida nenhuma opção pois todos  os meses válidos foram incluidos anteriormente
            {
                WriteLine($"O mês {mes} não é um mês válido.");
            }


            //Outra forma de fazer o que isso é utilizando o switch
            WriteLine();
            WriteLine("Método com switch"); 
            switch(mes)
            {
                case 1:
                WriteLine("Janeiro possui 31 dias");
                break; // Necessário incluir o break para que não entre em loop
                case 2:
                WriteLine("Fevereiro possui 28 dias");
                break;
                case 3:
                WriteLine("Março possui 31 dias");
                break;
                case 4:
                WriteLine("Abril possui 30 dias");
                break;
                case 5:
                WriteLine("Maio possui 31 dias");
                break;
                case 6:
                WriteLine("Junho possui 30 dias");
                break;
                case 7:
                WriteLine("Julho possui 31 dias");
                break;
                case 8:
                WriteLine("Agosto possui 31 dias");
                break;
                case 9:
                WriteLine("Setembro possui 30 dias");
                break;
                case 10:
                WriteLine("Outubro possui 31 dias");
                break;
                case 11:
                WriteLine("Novembro possui 30 dias");
                break;
                case 12:
                WriteLine("Dezembro possui 31 dias");
                break;
                default:
                WriteLine("O mês digitado não é válido :/");
                break;


            }

        }
    }
}
