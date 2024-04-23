using ProjectCinema.Banco;
using ProjectCinema.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCinema.Menus
{
    internal class Menu
    {
       

        public virtual void Executar(DAL<Item> itemDAL)
        {
            Console.Clear();
        }


    }
}
