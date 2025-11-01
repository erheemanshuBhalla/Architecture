using Dapper;
using Architecture_V4.Core.Entities;
using Architecture_V4.Core.Interfaces;
using System.Data;
using System.Threading.Tasks;
using System.Collections.Generic;
using App.Infrastructure.DapperRepositories;


namespace Architecture_V4.Infrastructure.DapperRepositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(IDbTransaction transaction)
            : base(transaction, "Users") { }

        public async Task<int> AddAsync(User user)
        {
            var sql = @"INSERT INTO Users (Email, Name) 
                    VALUES (@Email, @Name); 
                    SELECT CAST(SCOPE_IDENTITY() as int)";
            var id = await Connection.ExecuteScalarAsync<int>(sql, user, _transaction);
            user.Id = id;
            return id;
        }

        public async Task<int> UpdateAsync(User user)
        {
            var sql = "UPDATE Users SET Email = @Email, Name = @Name WHERE Id = @Id";
            return await Connection.ExecuteAsync(sql, user, _transaction);
        }

        public async Task<User?> GetByEmailAsync(string email)
        {
            var sql = "SELECT * FROM Users WHERE Email = @Email";
            return await Connection.QueryFirstOrDefaultAsync<User>(sql, new { Email = email }, _transaction);
        }
    }

}
