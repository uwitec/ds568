/**************************************************
 * ��Ȩ����: 
 * �� �� ��: JSONHelper.cs
 * �ļ�����: 
 * ����˵��: JSONHelper  JSON������
 * ��Ȩ����:
 *           ������Ϊ���������
 *           ���������������������������GPL v3��Ȩ����Ա������ٴη�����/���޸ģ�
 *           �������ǻ���ʹ��Ŀ�Ķ����Է�����Ȼ�������κε������Σ�
 *           ���޶������Ի��ض�Ŀ����������Ϊ��Ĭʾ�Ե�����
 *           ���������GNUͨ�ù�����Ȩ v3���μ�license.txt�ļ�����
 * �汾��ʷ: 
 *           v2.0.0 Sheng   2009-09-09 �޸�
System.Web.Script.Serialization�����ռ���.Net 3.5����ӵ�.
 
���Ҫ��3.5���°汾��ʹ��,��������3.5�е�System.Web.Extensions.dll ���뵽�Լ���Ӧ����.

***************************************************/

using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Script.Serialization;
using System.Data;

namespace Common
{
    /// <summary>
    /// JSON������
    /// </summary>
    public class JSONHelper
    {
        /// <summary>
        /// ����תJSON
        /// </summary>
        /// <param name="obj">����</param>
        /// <returns>JSON��ʽ���ַ���</returns>
        public static string ObjectToJSON(object obj)
        {
            JavaScriptSerializer jss = new JavaScriptSerializer();
            try
            {
                return jss.Serialize(obj);
            }
            catch (Exception ex)
            {
                
                throw new Exception("JSONHelper.ObjectToJSON(): "+ex.Message);
            }
        }

        /// <summary>
        /// ���ݱ�ת��ֵ�Լ���
        /// ��DataTableת�� List����, ��ÿһ��
        /// �����зŵ��Ǽ�ֵ���ֵ�,��ÿһ��
        /// </summary>
        /// <param name="dt">���ݱ�</param>
        /// <returns>��ϣ������</returns>
        public static List<Dictionary<string, object>> DataTableToList(DataTable dt)
        {
            List<Dictionary<string, object>> list
                 = new List<Dictionary<string, object>>();

            foreach (DataRow dr in dt.Rows)
            {
                Dictionary<string, object> dic = new Dictionary<string, object>();
                foreach (DataColumn dc in dt.Columns)
                {
                    dic.Add(dc.ColumnName, dr[dc.ColumnName]);
                }
                list.Add(dic);
            }
            return list;
        }

        /// <summary>
        /// ���ݼ�ת��ֵ�������ֵ�
        /// </summary>
        /// <param name="dataSet">���ݼ�</param>
        /// <returns>��ֵ�������ֵ�</returns>
        public static Dictionary<string, List<Dictionary<string, object>>> DataSetToDic(DataSet ds)
        {
            Dictionary<string, List<Dictionary<string, object>>> result = new Dictionary<string, List<Dictionary<string, object>>>();

            foreach (DataTable dt in ds.Tables)
                result.Add(dt.TableName, DataTableToList(dt));

            return result;
        }

        /// <summary>
        /// ���ݱ�תJSON
        /// </summary>
        /// <param name="dataTable">���ݱ�</param>
        /// <returns>JSON�ַ���</returns>
        public static string DataTableToJSON(DataTable dt)
        {
            return ObjectToJSON(DataTableToList(dt));
        }

        /// <summary>
        /// JSON�ı�ת����,���ͷ���
        /// </summary>
        /// <typeparam name="T">����</typeparam>
        /// <param name="jsonText">JSON�ı�</param>
        /// <returns>ָ�����͵Ķ���</returns>
        public static T JSONToObject<T>(string jsonText)
        {
            JavaScriptSerializer jss = new JavaScriptSerializer();
            try
            {
                return jss.Deserialize<T>(jsonText);
            }
            catch (Exception ex)
            {
                throw new Exception("JSONHelper.JSONToObject(): "+ex.Message);
            }
        }

        /// <summary>
        /// ��JSON�ı�ת��Ϊ���ݱ�����
        /// </summary>
        /// <param name="jsonText">JSON�ı�</param>
        /// <returns>���ݱ��ֵ�</returns>
        public static Dictionary<string, List<Dictionary<string, object>>> TablesDataFromJSON(string jsonText)
        {
            return JSONToObject<Dictionary<string, List<Dictionary<string, object>>>>(jsonText);
        }

        /// <summary>
        /// ��JSON�ı�ת����������
        /// </summary>
        /// <param name="jsonText">JSON�ı�</param>
        /// <returns>�����е��ֵ�</returns>
        public static Dictionary<string, object> DataRowFromJSON(string jsonText)
        {
            return JSONToObject<Dictionary<string, object>>(jsonText);
        }
    }
}
