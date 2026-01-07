

using Microsoft.EntityFrameworkCore;
using System.Data;
using System;
using sport.Models;

namespace sport.Models;

public class HubDbContext : DbContext
{
    public HubDbContext(DbContextOptions<HubDbContext> options) : base(options)
    {}
    public DbSet<Product>Products = Set<Product>();
    
}