using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WishListApp.Models;

namespace WishListApp.Services
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<WishItem> WishListDb { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //     => optionsBuilder.UseNpgsql(
    //         "Host=ec2-176-34-105-15.eu-west-1.compute.amazonaws.com;" +
    //         "Database=deqjhelpbfqp9o;" +
    //         "Username=gefknzzeeyhdqt;" +
    //         "Password=fb65f7fb451f8a8478586b3111589647d5e44ea5b7cafb3f14f27a36355941ac");
            
        
    //    "DefaultConnection": "Server=DESKTOP-AU95730\\SQLEXPRESS;Database=WhishList;Trusted_Connection=True;MultipleActiveResultSets=True"

    }
}
