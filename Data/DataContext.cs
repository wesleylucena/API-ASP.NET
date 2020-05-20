using APIrest.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIrest.Data
{
    public class DataContext : DbContext
    {
        //acessar tabela do banco de dados 

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Cadastro> Cadastros { get; set; }
    }
}

