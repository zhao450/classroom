using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classroomIDAL.Interface
{
    public interface lManageDAL
    {
        /// <summary>
        /// 检测用户登录的接口（只是一个方法，但是没有实现）
        /// </summary>
        /// <param name="userNamme"></param>
        /// <param name="userPass"></param>
        /// <returns></returns>
        bool CheckUserLogin(string userNamme, string userPass);
    }
}
