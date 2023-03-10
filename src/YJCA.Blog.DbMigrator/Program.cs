// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using YJCA.Blog.EntityFrameWorkCore.EntityFrameworkCore;

Console.WriteLine("Entity Framework Core Migrate Start!\nGet Pending Migrations...");

string[] runtime = new[] { "y" };

using (BlogDbContext dbContextFactory = new BlogDbContextFactory().CreateDbContext(runtime))
{
    var dbContext = dbContextFactory.Database;
    // 是否存在待迁移
    if (!dbContext.GetPendingMigrations().Any())
        Console.WriteLine("No to be migrated");
    else
    {
        Console.WriteLine($"Pending Migrations：\n{string.Join("\n", await dbContext.GetPendingMigrationsAsync())}");

        Console.WriteLine("Do you want to continue?(Y/N)");

        if (Console.ReadLine().Trim().Equals("y", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Migrating...");
            try
            {
                await dbContext.MigrateAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
    }

    Console.WriteLine("Entity Framework Core Migrate Complete!");

    Console.WriteLine("Whether to initialize the database?(Y/N)");
    if (Console.ReadLine().Trim().Equals("y", StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine(await DbInitializer.Initialize(dbContextFactory));
    }
}

Console.WriteLine("Press any key to exit!");
Console.ReadKey();