using System;

namespace DigitalInnovationOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Adicionar um aluno");
            Console.WriteLine("2- Remover um aluno");
            Console.WriteLine("3- Calcular média");
            Console.WriteLine("X - Sair");

            string opcaoUsuario = Console.ReadLine(); 

            while(opcaoUsuario.ToUpper() != "X"){
                
                switch(opcaoUsuario){

                    case "1":
                    break;

                    case "2":
                    break;

                    case "3":
                    break;

                    default:
                    throw new ArgumentOutOfRangeException();
                }

            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Adicionar um aluno");
            Console.WriteLine("2- Remover um aluno");
            Console.WriteLine("3- Calcular média");
            Console.WriteLine("X - Sair");

            opcaoUsuario = Console.ReadLine(); 
            }
        }
    }
}
