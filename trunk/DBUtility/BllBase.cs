
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
        /// 将一个Model实例的值复赋值给另一个具有相同类型的Model实例
        /// </summary>
        /// <typeparam name="T1">原实例类型</typeparam>
        /// <typeparam name="T2">被赋值的实例类型</typeparam>
        /// <param name="t1">原实例</param>
        /// <param name="t2">被赋值的实例</param>
        public void CopyModel<T1, T2>(T1 t1,ref T2 t2)
        {
            foreach (PropertyInfo pInfo in t1.GetType().GetProperties())
            {
                object val = pInfo.GetValue(t1, null);
                PropertyInfo info2 = getPropertyInfo<T2>(t2, pInfo.Name);
                info2.SetValue(t2, val, null);
            }
        }

        /// <summary>
        /// 根据属性名称查找一个属性
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        private PropertyInfo getPropertyInfo<T>(T t,string name)
        {
            foreach (PropertyInfo pInfo in t.GetType().GetProperties())
            {
                if (pInfo.Name == name)
                {
                    return pInfo;
                }
            }
            return null;
        }

        public object CopyEntity(object source,object target)
        {
            try
            {
                if (source == null || target == null)
                {
                    throw new ApplicationException("传入的实体不应为null!");
                }
                //取目标对象所有字段 
                PropertyInfo[] pf = target.GetType().GetProperties();
                foreach (PropertyInfo f in pf)
                {
                    //取原对象，与目标对象属性相同的字段属性 
                    PropertyInfo ff = source.GetType().GetProperty(f.Name);
                    //将原对象的对应属性的值取出 
                    //ff.GetValue(source, null); 

                    //赋值 
                    try
                    {
                        if (ff != null)
                            f.SetValue(target, ff.GetValue(source, null), null);
                    }
                    catch (Exception ex)
                    {
                        throw new ApplicationException("给[" + f.Name + "]属性赋值发生错误！" + ex.Message);
                    }
                }

                return target;
            }
            catch (Exception ex)
            {
                return null;
                throw (ex);
            }
        }

        public static void CopyObjectProperty<T>(T tSource, T tDestination) where T : class
        {
            //获得所有property的信息
            PropertyInfo[] properties = tSource.GetType().GetProperties();
            foreach (PropertyInfo p in properties)
            {
                p.SetValue(tDestination, p.GetValue(tSource, null), null);
            }
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
        public System.Data.DataSet ExcePagination(string tblName, string strGetFields, string fldName, int PageSize, int PageIndex, int? doCount, int? OrderType, string strWhere)
        {
              return DbHelperSQL.Query(tblName, strGetFields, fldName, PageSize, PageIndex, doCount, OrderType, strWhere);
        }

    }
}
