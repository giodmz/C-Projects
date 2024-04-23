using Microsoft.EntityFrameworkCore;
using ProjectCinema.Banco;
using ProjectCinema.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCinema.Menus
{
    internal class MenuRegistrarProduto : Menu
    {
        public override void Executar(DAL<Item> itemDAL)
        {
           base.Executar(itemDAL);
           Console.WriteLine("Registro de produtos");
           Console.WriteLine("Digite o nome do produto deseja registrar: ");
           string nomeItem = Console.ReadLine()!;
           Console.WriteLine("Agora digite o preço do produto:");
           string precoItem = Console.ReadLine()!;

            if (itemDAL.Listar().Any(item => item.Nome == nomeItem))
            {
                Console.WriteLine($"\nO produto {nomeItem} já está em nosso estoque.");
            }
            else
            {
                Item item = new Item(nomeItem, precoItem);
                itemDAL.Adicionar(item);

                Console.WriteLine($"O produto {nomeItem} (R$:{precoItem}) foi registrado com sucesso");
            }

            Thread.Sleep(2000);

        }

    }
}
