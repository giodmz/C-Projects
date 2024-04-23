using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ProjectCinema.Modelos;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProjectCinema.Banco
{
    internal class Connection : DbContext
    {

        public DbSet<Item> Itens {  get; set; }
        public DbSet<Precos> Precos { get; set; }

        ///  Rede de conexão para o banco de dados
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;" +
            "Initial Catalog=Itens;" +
            "Integrated Security=True;" +
            "Encrypt=False;" +
            "Trust Server Certificate=False;" +
            "Application Intent=ReadWrite;" +
            "Multi Subnet Failover=False";


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString).UseLazyLoadingProxies();
        }



    }
}
