using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1909correcao
{
    class Program
    {
        static void Main(string[] args)
        {
            String nomeProduto;
            int precoProduto;
            int quantidadeProduto;
            int valorTotal; 

            Console.Write("Digite o nome do Produto: ");
            nomeProduto = Console.ReadLine();

            Console.Write("Digite o Preço do Produto: ");
            precoProduto = Convert.ToInt32(Console.ReadLine());

            Console.Write("DIgite a QUantidade de Produto: ");
            quantidadeProduto = Convert.ToInt32(Console.ReadLine());

            valorTotal = quantidadeProduto * precoProduto;

            Console.Clear();
            Console.WriteLine(" *********** Venda do Produto ***********");
            Console.WriteLine(" Produto: " + nomeProduto);
            Console.WriteLine(" Quantidade: " + quantidadeProduto + " x Valor unitario: " + precoProduto);
            //.toString() -> Converte o numero para o texto. o "C" -> formata para moeda
            Console.WriteLine(" Total de Venda: " + valorTotal.ToString("C"));

            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Digita numero seu Animal");
            }
           
             Console.ReadKey();

        }
    }
}
