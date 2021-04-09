using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using System;
using System.Reflection;

namespace Infrastructure.Data
{
    public class StoreContextSeed
    {
        public static async Task SeedAsync(StoreContext context, ILoggerFactory loggerFactory)
        {
            try
            {
                if (!context.Movies.Any())
                {
                    var moviesData = File.ReadAllText("../Infrastructure/Data/SeedData/movies.json");
                    var movies = JsonSerializer.Deserialize<List<Movie>>(moviesData);

                    foreach (var item in movies)
                    {
                        context.Movies.Add(item);
                    }

                    await context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSeed>();
                logger.LogError(ex.Message);
            }
        }
    }

}