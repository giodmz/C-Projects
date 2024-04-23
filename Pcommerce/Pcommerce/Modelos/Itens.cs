using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectCinema.Banco;

namespace ProjectCinema.Modelos
{
    public class Item
    {
        public virtual ICollection<Item> Itens {  get; set; } = new List<Item>();
        public Item(string nome, string preco)
        {
            Nome = nome;
            Preco = preco;
        }


        public string Nome { get; set; }
        public string Preco { get; set; }
        public int Id { get; set; }

      
        public void AdicionarProdutoEstoque(Item item)
        {
            Itens.Add(item);
        }
        public void ExibirProdutos()
        {
            Console.WriteLine($"{Nome} (R${Preco})");            
        }

        public void ExibirPrecoItem()
        {
            Console.WriteLine($"\nEsse produto possui o valor de: R${Preco}");
        }


        

        public override string ToString()
        {
            return $@"Id: {Id}
            Nome: {Nome}
            Preço: {Preco}";
        }

    }
}
