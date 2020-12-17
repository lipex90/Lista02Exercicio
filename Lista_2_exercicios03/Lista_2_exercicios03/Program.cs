using System;

namespace Lista_2_exercicios03
{
    class Program
    {
        static void Main(string[] args)
        {
          
            AjusteSalario salario = new AjusteSalario();
            AjusteSalario funcionario = new AjusteSalario();
            AjusteSalario reajuste = new AjusteSalario();

            Console.WriteLine("Digite o nome do funcionário");
            funcionario.Funcionario = Console.ReadLine();
            Console.WriteLine("Digite quantidade do salário");
            salario.Salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantos por cento para reajustar o salario");
            reajuste.Reajuste = double.Parse(Console.ReadLine());

            Console.WriteLine("Nome : "+funcionario.Funcionario);
            Console.WriteLine("Salario : "+salario.Salario);
            Console.WriteLine("Reajuse : "+reajuste.Reajuste);
        }
    }
}
