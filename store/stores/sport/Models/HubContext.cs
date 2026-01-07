

using Microsoft.EntityFrameworkCore;
using System.Data;
using System;
using stores.sport.Models;

namespace stores.sport.Models;

public class HubContext : DbContext
{
    public HubContext(DbContextOptions<HubContext> options) : base(options)
    {}
    public DbSet<Product>Products => Set<Product>();
    
}