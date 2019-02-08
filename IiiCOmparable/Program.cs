using System;
using System.Collections.Generic;
using System.IO;

namespace IiiCOmparable
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminho = @"C:\Projetos\in.txt";
            try
            {
                using (StreamReader sr = File.OpenText(caminho))
                {

                    List<Funcionario> f = new List<Funcionario>();
                    
                    while (!sr.EndOfStream)
                    {
                        f.Add(new Funcionario(sr.ReadLine()));
                    }

                    f.Sort();
                    
                    foreach (var str in f)
                    {
                        Console.WriteLine(str);
                    }
                }
            

            }catch(IOException e)
            {
                Console.WriteLine("Houve um erro");
                Console.WriteLine(e.Message);
            }
        }
    }
}
