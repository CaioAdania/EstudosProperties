using EstudosProperties.Entities;

namespace EstudosProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teste p = new Teste("TV", 500.00, 10);

            p.Nome = "TV4K";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Quantidade);
        }
    }
}
