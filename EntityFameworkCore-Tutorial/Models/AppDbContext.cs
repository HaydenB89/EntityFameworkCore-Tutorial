using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFameworkCore_Tutorial.Models {                         //This will not be a SQL table, EF will use this as refernce
    public class AppDbContext : DbContext {                            // DbContext is part of the EF package we downloaded
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Item> Items { get; set; }


        public AppDbContext() { }                                                           //Default Constructor
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }      //Parent Constructor
                                                 
        
        protected override void OnConfiguring(DbContextOptionsBuilder builder) {   //overroding the messge when using OnConfig
                                                                                      //Protected ONLY allows from specified class
            if(!builder.IsConfigured) {
                builder.UseSqlServer("server=localhost\\sqlexpress;database=SalesDb1;trusted_connection=true;");       //this will create and rename a new 'using database'
                                                                                                                        // '\\' means one'\' will appear in the message
            }
        }

        protected override void OnModelCreating(ModelBuilder builder) {            //this method also overides something in DbConext
             builder.Entity<Item>
                (e => e.HasIndex(x => x.Code)
                    .IsUnique(true));                                              // this makes Item.Code unique
        }
    }
}
