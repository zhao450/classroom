using classroomDALFactory.Factory;
using classroomIDAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classroomBLL.BussinessLogicLayer
{
    /// <summary>
    /// 用户业务逻辑
    /// </summary>
    public class ManageBLL
    {
        /// <summary>
        /// 创建用户数据访问层实例
        /// </summary>
        private readonly lManageDAL dAL = DateAccessFactory.GetManageDAL();
        /// <summary>
        /// 检测用户登录
        /// </summary>
        /// <param name="userNamme"></param>
        /// <param name="userPass"></param>
        /// <returns></returns>
        public bool CheckUserLogin(string userName, string userPass)
        {
            return true;
        }
    }
}
