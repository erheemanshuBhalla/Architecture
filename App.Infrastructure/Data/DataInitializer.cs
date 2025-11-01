using App.Core.Interfaces;
using Architecture_V4.Core.Entities;
using Architecture_V4.Infrastructure.DapperRepositories;
using Dapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructure.Data
{
    public static class DataInitializer
    {
        public static async Task SeedAsync(IServiceProvider services)
        {
            using var scope = services.CreateScope();
            var connectionFactory = scope.ServiceProvider.GetRequiredService<IDbConnectionFactory>();

            using var connection = connectionFactory.CreateConnection();
            using var transaction = connection.BeginTransaction();
            var userRepo = new UserRepository(transaction);

            try
            {
                // Ensure table exists
                var createTableSql = @"
                    IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Users' AND xtype='U')
                    CREATE TABLE Users (
                        Id INT IDENTITY(1,1) PRIMARY KEY,
                        Name NVARCHAR(100) NOT NULL,
                        Email NVARCHAR(100) NOT NULL
                    );";
                await connection.ExecuteAsync(createTableSql, transaction: transaction);

                var count = await connection.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM Users", transaction: transaction);
                if (count == 0)
                {
                    await userRepo.AddAsync(new User { Name = "Alice", Email = "alice@demo.com" });
                    await userRepo.AddAsync(new User { Name = "Bob", Email = "bob@demo.com" });
                    await userRepo.AddAsync(new User { Name = "Charlie", Email = "charlie@demo.com" });
                }

                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }
    }
}
