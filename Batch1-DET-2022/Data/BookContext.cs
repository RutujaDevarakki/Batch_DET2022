using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022.Models.Data
{
    public class BookContext:DbContext
    {
        private object optionsBuilder;

        public BookContext() 
        {

        }
        public BookContext(DbContextOptions<BookContext> options)
                : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        public virtual DbSet<Book> Book { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=FNXWSF2-SHEL;Database=learning;Trusted_Connection=True;");
            }
        }
        
        protected override void OnModelCreating(ModelBuilder modeBuilder)
        {

            modeBuilder.Entity<Book>()
                .Property(b => b.price)
                .IsRequired()
                .HasColumnName("BKprice")
                .HasDefaultValue(200);
        }
    }
}

