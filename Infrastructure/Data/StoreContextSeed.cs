using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using System.Text.Json;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Data
{
    public class StoreContextSeed
    {
        public static async Task SeedAsync (StoreContext context, ILoggerFactory loggerFactory)
        {
            try
            {
                if(!context.Foods.Any())
                {
                    var foodsData = File.ReadAllText("../Infrastructure/Data/SeedData/Foods.json");

                    var foods = JsonSerializer.Deserialize<List<Food>>(foodsData);

                    foreach (var item in foods)
                    {
                        context.Foods.Add(item);
                        
                    }
                    await context.SaveChangesAsync();
                }


                if(!context.SeatTypes.Any())
                {
                    var seatTypesData = File.ReadAllText("../Infrastructure/Data/SeedData/SeatTypes.json");

                    var seatTypes = JsonSerializer.Deserialize<List<SeatType>>(seatTypesData);

                    foreach (var item in seatTypes)
                    {
                        context.SeatTypes.Add(item);
                        
                    }
                    await context.SaveChangesAsync();
                }

                if(!context.Seats.Any())
                {
                    var seatsData = File.ReadAllText("../Infrastructure/Data/SeedData/Seats.json");

                    var seats = JsonSerializer.Deserialize<List<Seat>>(seatsData);

                    foreach (var item in seats)
                    {
                        context.Seats.Add(item);
                        
                    }
                    await context.SaveChangesAsync();
                }
            }
            catch(Exception ex)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSeed>();
                logger.LogError(ex.Message);
            }
        }
    }
}