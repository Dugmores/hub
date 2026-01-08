

using System;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore;

namespace stores.sport.Models;

public static class SeedData
{
    public static void EnsurePopulated(IApplicationBuilder app)
    {
        HubContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<HubContext>();

        //check for pending migrations
        if (context.Database.GetPendingMigrations().Any())
        {
            context.Database.Migrate();
        }

        //check for existing data and add if none exists
        if (!context.Products.Any())
        {
            context.Products.AddRange(
                new Product
                {
                    Name = "Kayak",
                    Description = "A boat for one person",
                    Category = "Watersports",
                    Price = 275
                },
                new Product
                {
                    Name = "Lifejacket",
                    Description = "Protective and fashionable",
                    Category = "Watersports",
                    Price = 48.95m
                },
                new Product
                {
                    Name = "Soccer Ball",
                    Description = "FIFA-approved size and weight",
                    Category = "Soccer",
                    Price = 19.50m
                },
                new Product
                {
                    Name = "Corner Flags",
                    Description = "Give your playing field a professional touch",
                    Category = "Soccer",
                    Price = 34.95m
                }
            );
            context.SaveChanges();
        }
    }
}