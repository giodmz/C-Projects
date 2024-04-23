using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCinema.Modelos
{
    internal class Precos
    {


        public int Id { get; set; }
        public string Preco {  get; set; }
        public virtual Item? Item { get; set; }
        public Precos(string preco) 
        {
            Preco = preco;
        }

   

        public override string ToString()
        {
            return $@"Id: {Id}
            Preço: {Preco}";
        }

    }
}
