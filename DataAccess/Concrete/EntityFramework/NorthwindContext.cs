using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //context : Db tablosu ile proje classlarını bağlamak
    public class NorthwindContext:DbContext    
    {
        //hangi veritabaniyla ilişkilendirildiği yer
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //db adı ; hangi database'i kullanacaksın onun ismi ; KUllanıcı adı şifreyle bağlanma
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");//sql server kullanacagız
        }
        public DbSet<Product> Products { get; set; } //product'ı products tablosuna bagla
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
