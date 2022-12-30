﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace YJCA.Blog.EntityFrameWorkCore.EntityFrameworkCore
{
    public class BlogDbContextFactory : IDesignTimeDbContextFactory<BlogDbContext>
    {
        public BlogDbContext CreateDbContext(string[] args)
        {
            var configuration = args.Any() ? BuildConfiguration(true) : BuildConfiguration();

            var Enable = configuration["ConnectionStrings:Enable"];

            var builder = new DbContextOptionsBuilder<BlogDbContext>();

            switch (Enable)
            {
                case "SqlServer":
                    builder.UseSqlServer(configuration.GetConnectionString(Enable));
                    break;
                case "Sqlite":
                    builder.UseSqlite(configuration.GetConnectionString(Enable));
                    break;
                case "MySql":
                    builder.UseMySql(configuration.GetConnectionString(Enable), MySqlServerVersion.LatestSupportedServerVersion);
                    break;
            }

            return new BlogDbContext(builder.Options);
        }

        /// <summary>
        /// 获取文件位置
        /// </summary>
        /// <param name="runtime">是否运行时</param>
        /// <returns></returns>
        private static IConfigurationRoot BuildConfiguration(bool runtime = false)
        {
            var builder = new ConfigurationBuilder();

            if (runtime)
                builder.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../../"));
            else
                builder.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../YJCA.Blog.DbMigrator/"));

            return builder.AddJsonFile("appsettings.json", optional: false)
                .Build();
        }
    }
}
