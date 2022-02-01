using DataAccess.DBAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data //git commit 2nd time test
{
    public class UserData : IUserData
    {
        private readonly ISQLDataAccess _db;
        public UserData(ISQLDataAccess db)
        {
            _db = db;
        }

        public Task<IEnumerable<UserModel>> GetUsers() =>
            _db.LoadData<UserModel, dynamic>("dbo.spUser_GetAll", new { });

        public async Task<UserModel?> GetUser(int id)
        {
            var results = await _db.LoadData<UserModel, dynamic>("dbo.spUser_Get", new { Id = id });

            return results.FirstOrDefault();
        }

        public Task InsertUser(UserModel user) =>
            _db.SaveData("dbo.spUser_Insert", new { user.FirstName, user.LastName });

        public Task UpdateUser(UserModel user) =>
            _db.SaveData("dbo.spUser_Update", user);

        public Task DeleteUser(int id) =>
            _db.SaveData("dbo.spUser_Delete", new { Id = id });
    }
}
