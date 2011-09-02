using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Linq.Expressions;
namespace DBUtility
{
    public class DbHelperSQL
    {

        public static DbConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["TodexOAConnectionString"].ToString());
            con.Open();
            return con;
        }

        public static DbConnection GetConnection(string conString)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            return con;
        }


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
        public static DataSet Query(string tblName, string strGetFields, string fldName, int PageSize, int PageIndex, int? doCount, int? OrderType, string strWhere)
        {
            using (DbConnection con = GetConnection())
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con as SqlConnection;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Pager2005";
                SqlParameter[] pm = new SqlParameter[8];
                pm[0] = new SqlParameter("@tblName", tblName);
                pm[1] = new SqlParameter("@strGetFields", strGetFields);
                pm[2] = new SqlParameter("@fldName", fldName);
                pm[3] = new SqlParameter("@PageSize", PageSize);
                pm[4] = new SqlParameter("@PageIndex", PageIndex);
                pm[5] = new SqlParameter("@doCount", doCount);
                pm[6] = new SqlParameter("@OrderType", OrderType);
                pm[7] = new SqlParameter("@strWhere", strWhere);
                cmd.Parameters.AddRange(pm);
                sda.SelectCommand = cmd;
                sda.Fill(ds);
                return ds;
            }
        }
    }

}