using System.Collections.Generic;
using WebApiCoreTest.Entity;

namespace WebApiCoreTest.Common
{
    public class UsersDal
    {
        DapperHelper _db = new DapperHelper();
        public Users GetUsersByLogin(string userName, string passWord)
        {
            string sql = "select * from Users where username=@username and password=@password";
            // var user = _db.Find<Users>(sql, new { userName, passWord });
            //     var user = new List<Users>
            //    {
            //        new Users{UserName = "111name",PassWord="1111pwd",Age=11,Sex="111sex"},
            //        new Users{UserName = "111name",PassWord="1111pwd",Age=11,Sex="111sex"},
            //        new Users{UserName = "111name",PassWord="1111pwd",Age=11,Sex="111sex"}S
            //    };
            // return user == null ? default : user;
            return new Users{UserName = "111name",PassWord="1111pwd",Age=11,Sex="111sex"};
        }
    }
}