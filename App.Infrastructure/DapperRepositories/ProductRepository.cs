using Architecture_V4.Core.Entities;
using Architecture_V4.Core.Interfaces;
using Dapper;
using System.Data;

namespace Architecture_V4.Infrastructure.DapperRepositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDbTransaction _transaction;
        private IDbConnection Connection => _transaction.Connection;

        public ProductRepository(IDbTransaction transaction)
        {
            _transaction = transaction;
        }

        public async Task<Product?> GetByIdAsync(int id)
        {
            var sql = "SELECT * FROM Products WHERE Id = @Id";
            return await Connection.QueryFirstOrDefaultAsync<Product>(sql, new { Id = id }, _transaction);
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            var sql = "SELECT * FROM Products";
            return await Connection.QueryAsync<Product>(sql, transaction: _transaction);
        }

        public async Task<int> AddAsync(Product product)
        {
            var sql = @"
                INSERT INTO Products (Name, Price, Stock)
                VALUES (@Name, @Price, @Stock);
                SELECT CAST(SCOPE_IDENTITY() as int)";
            var id = await Connection.ExecuteScalarAsync<int>(sql, product, _transaction);
            product.Id = id;
            return id;
        }

        public async Task<int> UpdateAsync(Product product)
        {
            var sql = "UPDATE Products SET Name = @Name, Price = @Price, Stock = @Stock WHERE Id = @Id";
            return await Connection.ExecuteAsync(sql, product, _transaction);
        }

        public async Task<int> DeleteAsync(int id)
        {
            var sql = "DELETE FROM Products WHERE Id = @Id";
            return await Connection.ExecuteAsync(sql, new { Id = id }, _transaction);
        }

        public async Task<IEnumerable<Product>> GetProductsInStockAsync()
        {
            var sql = "SELECT * FROM Products WHERE Stock > 0";
            return await Connection.QueryAsync<Product>(sql, transaction: _transaction);
        }
    }

}
