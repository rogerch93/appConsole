using System;

namespace Retrospectiva
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcaoUsuario = obterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        //Adc aluno
                        break;
                    case "2":
                        // listar alunos
                        break;
                    case "3":
                        //calcular média geral 
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();

                }

                opcaoUsuario = obterOpcaoUsuario();
            }

        }

        private static string obterOpcaoUsuario()
        {
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            return opcaoUsuario;
        }
    }
}
