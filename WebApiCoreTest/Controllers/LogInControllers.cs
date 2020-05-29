using Microsoft.AspNetCore.Mvc;
using WebApiCoreTest.Common;
using WebApiCoreTest.Entity;

namespace WebApiCoreTest.Controllers
{
    /// <summary>
    /// 登陆用户啊
    /// </summary>
    [Route("[controller]")]
    [ApiController]
    public class LogInController : ControllerBase
    {
        /// <summary>
        /// Get注释走一波
        /// </summary>
        /// <param name="n">名字</param>
        /// <param name="p">密码表</param>
        /// <returns></returns>
        [HttpGet("{n}-{p}")]
        public Users Get(string n, string p)
        {
            return new UsersDal().GetUsersByLogin("1", "2");
        }
    }
}