using classroomIDAL.Interface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace classroomDALFactory.Factory
{
    /// <summary>
    /// 共产类负责加个DAL和IDAL之间的传递
    /// </summary>
    public class DateAccessFactory
    {
        private static object GetInstance(string className)
        {
            string configName = ConfigurationManager.AppSettings["DataAccessLayer"];
            //如果没有获取到程序集名称则抛出异常
            if (string.IsNullOrEmpty(configName))
            {
                throw new InvalidOperationException();
            }
            Assembly assembly = Assembly.Load(configName);
            string assName = string.Format("{0}.{1}.{2}", configName, "DataAccessLayer", className);
            return assembly.CreateInstance(assName);
        }
        /// <summary>
        /// 创建用户数据访问层实例
        /// </summary>
        /// <returns></returns>
        public static lManageDAL GetManageDAL()
        {

            lManageDAL dAL = GetInstance("ManagerDAL") as lManageDAL;
            return dAL;
        }
    }
}
