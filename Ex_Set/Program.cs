using Ex_Set.Entities;
using System;
using System.Collections.Generic;

namespace Ex_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Estudantes> set = new HashSet<Estudantes>();

            Console.Write("Quantos estudantes há no curso A: ");
            int n1 = int.Parse(Console.ReadLine());
            for (int i = 1; i<= n1; i++)
            {
                int codigoA=int.Parse(Console.ReadLine());
                set.Add(new Estudantes { Codigo = codigoA });
            }
            Console.Write("Quantos estudantes há no curso B: ");
            int n2 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n2; i++)
            {
                int codigoB = int.Parse(Console.ReadLine());
                set.Add(new Estudantes { Codigo = codigoB });
            }
            Console.Write("Quantos estudantes há no curso C: ");
            int n3 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n3; i++)
            {
                int codigoC = int.Parse(Console.ReadLine());
                set.Add(new Estudantes { Codigo = codigoC });
            }

            Console.Write("Total de Estudantes: " + set.Count);
        }
    }
}
