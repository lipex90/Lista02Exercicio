using System;

namespace Lista_2_exercícios
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculoDia nome = new CalculoDia();
            CalculoDia idade = new CalculoDia();
            CalculoDia ano = new CalculoDia();

            Console.WriteLine("Digite seu primeiro nome");
            nome.Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade você tem");
            idade.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine(nome.Nome+" VOCÊ JÁ VIVEU "+ano.Ano+" DIAS");
        }
    }
}
