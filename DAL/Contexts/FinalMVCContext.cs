
using EcommerceGame.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Contexts
{
    public class FinalMVCContext : DbContext
    {
        public FinalMVCContext(DbContextOptions<FinalMVCContext> options) : base(options)
        {

        }

        public DbSet<User> users { get; set; }
        public DbSet<Game> games { get; set; }
        public DbSet<UserRole> userRoles { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<AddToCart> addToCarts { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<Order_Item> order_Items { get; set; }
        public DbSet<Platform> platforms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // dol el composit pk
            modelBuilder.Entity<Platform>()
                .HasKey(p => new { p.Game_ID, p.Name });

            modelBuilder.Entity<UserRole>()
               .HasKey(u => new { u.Role_ID, u.User_Id });

            modelBuilder.Entity<AddToCart>()
               .HasKey(A => new { A.User_ID, A.Game_ID });

            modelBuilder.Entity<Order_Item>()
               .HasKey(O => new { O.Order_ID, O.Game_ID });

            // w dol el relation
            modelBuilder.Entity<AddToCart>()
         .HasOne(b => b.user)
         .WithMany(a => a.addToCarts)
         .HasForeignKey(b => b.User_ID);

            modelBuilder.Entity<AddToCart>()
     .HasOne(b => b.game)
     .WithMany(a => a.addToCarts)
     .HasForeignKey(b => b.Game_ID);
            modelBuilder.Entity<Order>()
 .HasOne(b => b.user)
 .WithMany(a => a.orders)
 .HasForeignKey(b => b.User_ID);

            modelBuilder.Entity<Order_Item>()
 .HasOne(b => b.order)
 .WithMany(a => a.order_Items)
 .HasForeignKey(b => b.Order_ID);
            modelBuilder.Entity<Order_Item>()
 .HasOne(b => b.game)
 .WithMany(a => a.order_Items)
 .HasForeignKey(b => b.Game_ID);

            modelBuilder.Entity<Platform>()
.HasOne(b => b.game)
.WithMany(a => a.platforms)
.HasForeignKey(b => b.Game_ID);

            modelBuilder.Entity<UserRole>()
.HasOne(b => b.user)
.WithMany(a => a.userRoles)
.HasForeignKey(b => b.User_Id);


            modelBuilder.Entity<UserRole>()
.HasOne(b => b.role)
.WithMany(a => a.userRoles)
.HasForeignKey(b => b.Role_ID);







        }

    }
}
