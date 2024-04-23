using ProjectCinema.Banco;
using ProjectCinema.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCinema.Menus
{
    internal class MenuRemoverItem : Menu
    {
        public override void Executar(DAL<Item> itemDAL)
        {
            base.Executar(itemDAL);
            Console.WriteLine("Digite o nome do produto que deseja remover do estoque: ");
            string nomeItem = Console.ReadLine()!;
            var nomeItemRec = itemDAL.RecuperarPor(item => item.Nome.Equals(nomeItem));
            if (nomeItemRec != null) 
            { 
                itemDAL.Deletar(nomeItemRec);
                Console.WriteLine($"\nO item {nomeItem} foi removido do estoque com sucesso. Retornando ao menu...");
                Thread.Sleep(2000);
            }
            else
            {
                Console.WriteLine("O produto não foi encontrado no estoque.");
            }
        }
    }
}
