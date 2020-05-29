using Microsoft.AspNetCore.Mvc;
using WebApiCoreTest.Common;
using WebApiCoreTest.Entity;

namespace WebApiCoreTest.Controllers
{
    /// <summary>
    /// ��½�û���
    /// </summary>
    [Route("[controller]")]
    [ApiController]
    public class LogInController : ControllerBase
    {
        /// <summary>
        /// Getע����һ��
        /// </summary>
        /// <param name="n">����</param>
        /// <param name="p">�����</param>
        /// <returns></returns>
        [HttpGet("{n}-{p}")]
        public Users Get(string n, string p)
        {
            return new UsersDal().GetUsersByLogin("1", "2");
        }
    }
}