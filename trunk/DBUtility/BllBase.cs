
namespace DBUtility
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Reflection;
    public class BllBase
    {

        /// <summary>
        /// 调用分页存储过程
        /// </summary>
        /// <param name="tblName">表名</param>
        /// <param name="strGetFields">返回的列名</param>
        /// <param name="fldName">排序字段,必填</param>
        /// <param name="PageSize">分页大小</param>
        /// <param name="PageIndex">当前页索引</param>
        /// <param name="doCount">是否返回总记录数，如果为0则返回记录，否则返回总记录数</param>
        /// <param name="OrderType">排序类型,0为升序,否则为降序</param>
        /// <param name="strWhere">条件语句，不包含where</param>
        /// <returns></returns>
        public System.Data.DataSet ExcePagination(string tblName, string strGetFields, string fldName, int PageSize, int PageIndex, int? doCount, int? OrderType, string strWhere)
        {
              return DbHelperSQL.Query(tblName, strGetFields, fldName, PageSize, PageIndex, doCount, OrderType, strWhere);
        }

        
    }
}
