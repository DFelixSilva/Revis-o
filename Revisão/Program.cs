using System;

namespace Revisão
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1- Insrir novo aluno");
            Console.WriteLine("2- Listar Alunos");
            Console.WriteLine("3- Calcular média geral");
            Console.WriteLine("x- Sair");
            Console.WriteLine();


            String OpcaoUsuario = Console.ReadLine();

            while (OpcaoUsuario. ToUpper() != "x")
            {
                switch (OpcaoUsuario)
                {
                    case "1":
                        //TODO: adicionar aluno;
                        break;
                    case "2":
                        //TODO: listar alunos;
                        break;

                    case "3":
                        //TODO: calcular média geral;
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }



             Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1- Insrir novo aluno");
            Console.WriteLine("2- Listar Alunos");
            Console.WriteLine("3- Calcular média geral");
            Console.WriteLine("x- Sair");
            Console.WriteLine();


             OpcaoUsuario = Console.ReadLine();
            }
         
        }
    }
}
