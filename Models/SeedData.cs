using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using CLAMP_Assignment1.Models;

namespace CLAMP_Assignment1.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ClampContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ClampContext>>()))
            {
                // Look for any clamps.
                if (context.Clamps.Any())
                {
                    return;   // DB has been seeded
                }

                context.Clamps.AddRange(
                    new Clamp
                    {
                        Material = "metal",
                        Size = "small",
                        Type = "C-clamp",
                        MaximumOpeningWidth = 2, // in inches
                        LoadCapacity = 20, // in lbs
                        Price = 5.99m,
                        CustomerReview = 4
                    },
                    new Clamp
                    {
                        Material = "plastic",
                        Size = "medium",
                        Type = "bar clamp",
                        MaximumOpeningWidth = 4,
                        LoadCapacity = 30,
                        Price = 7.99m,
                        CustomerReview = 3
                    },
                    new Clamp
                    {
                        Material = "metal",
                        Size = "large",
                        Type = "spring clamp",
                        MaximumOpeningWidth = 6,
                        LoadCapacity = 50,
                        Price = 12.99m,
                        CustomerReview = 5
                    },
                    new Clamp
                    {
                        Material = "metal",
                        Size = "small",
                        Type = "bar clamp",
                        MaximumOpeningWidth = 2.5,
                        LoadCapacity = 25,
                        Price = 6.49m,
                        CustomerReview = 3
                    },
                    new Clamp
                    {
                        Material = "plastic",
                        Size = "small",
                        Type = "spring clamp",
                        MaximumOpeningWidth = 3,
                        LoadCapacity = 15,
                        Price = 3.99m,
                        CustomerReview = 2
                    },
                    new Clamp
                    {
                        Material = "metal",
                        Size = "medium",
                        Type = "C-clamp",
                        MaximumOpeningWidth = 5,
                        LoadCapacity = 40,
                        Price = 10.49m,
                        CustomerReview = 4
                    },
                    new Clamp
                    {
                        Material = "metal",
                        Size = "large",
                        Type = "bar clamp",
                        MaximumOpeningWidth = 7,
                        LoadCapacity = 60,
                        Price = 15.99m,
                        CustomerReview = 5
                    },
                    new Clamp
                    {
                        Material = "plastic",
                        Size = "medium",
                        Type = "spring clamp",
                        MaximumOpeningWidth = 4.5,
                        LoadCapacity = 35,
                        Price = 8.49m,
                        CustomerReview = 4
                    },
                    new Clamp
                    {
                        Material = "wood",
                        Size = "medium",
                        Type = "hand screw clamp",
                        MaximumOpeningWidth = 3.5,
                        LoadCapacity = 30,
                        Price = 9.49m,
                        CustomerReview = 4
                    },
                    new Clamp
                    {
                        Material = "metal",
                        Size = "extra large",
                        Type = "pipe clamp",
                        MaximumOpeningWidth = 8,
                        LoadCapacity = 70,
                        Price = 17.99m,
                        CustomerReview = 5
                    }
                );

                context.SaveChanges();
            }
        }

        internal static void Initialize(ClampContext dbContext)
        {
            throw new NotImplementedException();
        }
    }
}
