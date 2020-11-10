using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso_DotNet_MVC.Models
{
    public class Context : DbContext 
    {
        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Produto> Produtos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(connectionString:@"Server=(localdb)\mssqllocaldb;Database=CursoDotNetMVC;Integrated Security=True"); 
        }
    }
}
