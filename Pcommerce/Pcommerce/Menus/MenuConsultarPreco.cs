using ProjectCinema.Banco;
using ProjectCinema.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCinema.Menus
{
    internal class MenuConsultarPreco : Menu
    {
        public override void Executar(DAL<Item> itemDAL)
        {
            base.Executar(itemDAL);
            Console.WriteLine("Digite o nome do produto que deseja consultar: ");
            string nomeItem = Console.ReadLine()!;
            var nomeItemRec = itemDAL.RecuperarPor(a => a.Nome.Equals(nomeItem));

            if (nomeItemRec != null)
            {
                nomeItemRec.ExibirPrecoItem();
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
