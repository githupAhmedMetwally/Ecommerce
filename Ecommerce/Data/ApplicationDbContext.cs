﻿using Ecommerce.Models;
using FinalProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Ecommerce.ViewModels;

namespace Ecommerce.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
         
        public DbSet<Product> Products { get; set; }
        public DbSet<Categoty> Categoties { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<WishList> wishLists { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Payment> payments { get; set; }
        public DbSet<Ecommerce.ViewModels.ProductVM> ProductVM { get; set; } = default!;
        public DbSet<Ecommerce.ViewModels.PaymentVM> PaymentVM { get; set; } = default!;


    }
}
