using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Entities;
using WebApi.Models;

namespace WebApi.Data
{
    public class WebApiContext : DbContext
    {
        public WebApiContext(DbContextOptions<WebApiContext> options) : base(options)
        {
        }

        public virtual DbSet<UserEntity> Users { get; set; }
        public virtual DbSet<ProfileEntity> Profiles { get; set; }
        public virtual DbSet<OrderEntity> Orders { get; set; }
        public virtual DbSet<OrderLineEntity> OrderLines { get; set; }
        public virtual DbSet<ProductEntity> Products { get; set; }
        public DbSet<WebApi.Models.OrderModel> OrderModel { get; set; }
        public DbSet<WebApi.Models.ProductModel> ProductModel { get; set; }
        public DbSet<WebApi.Models.UserModel> UserModel { get; set; }
    }
}
