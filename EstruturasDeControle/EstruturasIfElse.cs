using System;
using System.Xml;

namespace CursoCSharp.EstruturasDeControle
{
    public class EstruturasIfElse
    {
        public static void Executar()
        {
            Console.Write("Digite a nota: ");
            Double.TryParse(Console.ReadLine(), out double nota);

            if (nota >= 7.0)
            {
                Console.WriteLine("Aprovado!");
                Console.WriteLine("Não fez mais que sua obrigação...");
            }
            else
            {
                Console.WriteLine("Recuperação");
            }
        }
    }
}