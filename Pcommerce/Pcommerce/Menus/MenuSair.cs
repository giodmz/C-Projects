using ProjectCinema.Banco;
using ProjectCinema.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCinema.Menus
{
    internal class MenuSair : Menu
    {
        public override void Executar(DAL<Item> itemDAL)
        {
            Console.WriteLine("\nAté logo! :D");
        }
    }
}
