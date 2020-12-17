using System;

namespace Lista_2_exercicios02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantas eleitores tem? ");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite quantos branco foram votados");
            double vb = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite quantos nulos foram votados");
            double vn = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite quantos validos foram votados");
            double vv = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Quantidade de eleitores :  "+n1);
            Console.WriteLine("Quantidade de votos brancos : "+vb);
            Console.WriteLine("Quantidade de votos nulos : " + vn);
            Console.WriteLine("Quantidade de votos validos : " + vv);
        }
    }
}
