using Microsoft.EntityFrameworkCore.Update.Internal;
using ProjectCinema.Banco;
using ProjectCinema.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProjectCinema.Menus.MenuAlterarPreco;

namespace ProjectCinema.Menus
{
    internal class MenuAlterarPreco: Menu
    {
        public override void Executar(DAL<Item> itemDAL)
        {
            base.Executar(itemDAL);
            Console.WriteLine("Digite o nome do produto que deseja alterar a precificação: ");
            string nomeItem = Console.ReadLine()!;
            var nomeItemRec = itemDAL.RecuperarPor(item => item.Nome.Equals(nomeItem));

            if (nomeItemRec != null)
            {
                Console.WriteLine($"\nDigite a nova precificação do produto: {nomeItem}");
                string precoItem = Console.ReadLine()!;
                if(!string.IsNullOrEmpty(precoItem))
                {
                    nomeItemRec.Preco = precoItem;
                    itemDAL.Atualizar(nomeItemRec);
                    Console.WriteLine("Preço do produto atualizado com sucesso!");
                }
               
                
            }
           
            else
            {
                Console.WriteLine($"O produto {nomeItem} não foi no nosso encontrado no sistema.");
            }

            Console.WriteLine("\nDigite qualquer tecla para voltar ao menu");
            Console.ReadKey();
            Console.Clear();
        }

       

    }


}

