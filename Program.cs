using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1 - Inserir novo Aluno");
            Console.WriteLine("2 - Listar Alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case 1:
                        //todo add aluno
                    break;

                    case 2:
                        //todo listar alunos
                    break;

                    case 3:
                        //todo calcular media geral
                    break;

                default:
                    throw new argumentOutOfRangeException();
                }

            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1 - Inserir novo Aluno");
            Console.WriteLine("2 - Listar Alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            opcaoUsuario = Console.ReadLine();
            }

        }

    }
}
