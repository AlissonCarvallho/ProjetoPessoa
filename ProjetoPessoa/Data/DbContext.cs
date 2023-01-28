using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using ProjetoPessoa.Data;

namespace ProjetoPessoa.Data
{
    public class MyDbContext : DbContext
    {
        private Action<SqlServerDbContextOptionsBuilder>? _DefaultConnection;

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_DefaultConnection);
        }
    }
}
 


