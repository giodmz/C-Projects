using ProjectCinema.Banco;
using ProjectCinema.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ProjectCinema.Menus
{
    internal class MenuMostrarProdutosRegistrados : Menu
    {
        public override void Executar(DAL<Item> itemDAL)
        {
            base.Executar(itemDAL);
            Console.WriteLine("Produtos no estoque: ");
            foreach (var produto in itemDAL.Listar())
            {
                produto.ExibirProdutos();
            }
            

            Console.WriteLine("\nDigite qualquer tecla para voltar ao menu");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
