using EfCoreAssingment02.Context;
using Microsoft.EntityFrameworkCore;

namespace EfCoreAssingment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using EventHubDbContext eventHubDbContext = new EventHubDbContext();
            try
            {
                eventHubDbContext.Database.EnsureCreated();

                Console.WriteLine("Database Created Successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
