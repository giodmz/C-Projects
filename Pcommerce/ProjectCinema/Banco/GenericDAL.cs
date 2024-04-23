using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ProjectCinema.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCinema.Banco
{
    internal class DAL<T> where T : class
    {
        private readonly Connection context;

        public DAL(Connection context)
        {
            this.context = context;
        }

        public IEnumerable<T> Listar()
        {
            return context.Set<T>().ToList();
        }
        public IEnumerable<T> ListarPor(Func<T, bool> condicao)
        {
            return context.Set<T>().Where(condicao);
        }


        public void Adicionar(T objeto)
        {
            context.Set<T>().Add(objeto);
            context.SaveChanges();
        }

        public void Atualizar(Item item)
        {
            var itemExistente = context.Itens.Find(item.Id);
            if (itemExistente != null) 
            {
                itemExistente.Nome = item.Nome;
                itemExistente.Preco = item.Preco;
                context.SaveChanges();
            }
        }

        public void Deletar(T objeto)
        {
            context.Set<T>().Remove(objeto);
            context.SaveChanges();
        }


        public T? RecuperarPor(Func<T, bool> condicao)
        {
            return context.Set<T>().FirstOrDefault(condicao);
        }


    }
}
