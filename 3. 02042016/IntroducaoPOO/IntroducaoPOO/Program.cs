using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroducaoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exemplo de uso 1: Usando o construtor padrão

            Produto p1 = new Produto();

            Console.WriteLine(p1.GetDetalhes());
            Console.WriteLine();
            //-----------------------------------------------------------

            //Exemplo de uso 2: Usando o construtor com argumentos
            Produto p2 = new Produto("111", "Notebook Dell i5 8GB 1TB", 2400);

            Console.WriteLine(p2.GetDetalhes());
            Console.WriteLine();
            //-----------------------------------------------------------

            //Exemplo de uso 3: Usando Object Initializer
            Produto p3 = new Produto
            {
                Codigo = "222",
                Descricao = "Adaptador HDMI/VGA Multilaser",
                PrecoVenda = 68.99
            };

            Console.WriteLine(p3.GetDetalhes());
            Console.WriteLine();
            //-----------------------------------------------------------

            //Exemplo de uso 4: Usando métodos da classe (considerando o objeto p3 criado acima)
            p3.AplicarDesconto(10);

            Console.WriteLine(p3.GetDetalhes());
            Console.WriteLine();
            //-----------------------------------------------------------

            //Exemplo de uso 5: Atribuindo um valor inválido ao preço do objeto p2 (será validado no encapsulamento do atributo)
            p2.PrecoVenda = -1;
            p2.Descricao = "";
            Console.WriteLine(p2.GetDetalhes());
            Console.WriteLine();
        }
    }
}
