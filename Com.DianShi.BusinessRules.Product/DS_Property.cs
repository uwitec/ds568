using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Common;
using System.Linq.Dynamic;
using Com.DianShi.Model.Product;
using DBUtility;
namespace Com.DianShi.BusinessRules.Product
{
    public class DS_Property_Br : BllBase
    {
        public void Add(DS_Property Property)
        {
            using (var ct = new DS_PropertyDataContext(DbHelperSQL.Connection))
            {
                ct.DS_Property.InsertOnSubmit(Property);
                ct.SubmitChanges();
            }
        }

        public void Update(DS_Property Property)
        {
            using (var ct = new DS_PropertyDataContext(DbHelperSQL.Connection))
            {
                ct.DS_Property.Attach(Property, true);
                ct.SubmitChanges();
            }
        }

        public void Delete(int ID)
        {
            using (var ct = new DS_PropertyDataContext(DbHelperSQL.Connection))
            {
                var st = ct.DS_Property.Single(a => a.ID == ID);
                ct.DS_Property.DeleteOnSubmit(st);
                ct.SubmitChanges();
            }
        }

        public void Delete(string Ids)
        {
            using (var ct = new DS_PropertyDataContext(DbHelperSQL.Connection))
            {
                string[] idarray = Ids.Split(',');
                var list = ct.DS_Property.Where(a=>idarray.Contains(a.ID.ToString()));
                ct.DS_Property.DeleteAllOnSubmit(list);
                ct.SubmitChanges();
            }
        }

        public DS_Property GetSingle(int ID)
        {
            using (var ct = new DS_PropertyDataContext(DbHelperSQL.Connection))
            {
                return ct.DS_Property.Single(a => a.ID == ID);
            }
        }

        public List<T> Query<T>(string sql, params object[] parameterValues)
        {
            using (var ct = new DS_PropertyDataContext(DbHelperSQL.Connection))
            {
                return ct.ExecuteQuery<T>(sql, parameterValues).ToList();//ct.DS_Property.Where(c=>System.Data.Linq.SqlClient.SqlMethods.Like(字段,"%A%"))
            }
        }

        public List<DS_Property> Query(string condition, string orderby, int startIndex, int pageSize, ref int pageCount, params object[] param)
        {
            using (var ct = new DS_PropertyDataContext(DbHelperSQL.Connection))
            {
                IQueryable<DS_Property> PropertyList = ct.DS_Property;
                if (!string.IsNullOrEmpty(condition))
                    PropertyList = PropertyList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    PropertyList = PropertyList.OrderBy(orderby);
                pageCount = PropertyList.Count();
                return PropertyList.Skip(startIndex).Take(pageSize).ToList();
            }
        }

        public List<DS_Property> Query(string condition, string orderby, params object[] param)
        {
            using (var ct = new DS_PropertyDataContext(DbHelperSQL.Connection))
            {
                IQueryable<DS_Property> PropertyList = ct.DS_Property;
                if (!string.IsNullOrEmpty(condition))
                    PropertyList = PropertyList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    PropertyList = PropertyList.OrderBy(orderby);
                return PropertyList.ToList();
            }
        }

        public Com.DianShi.Model.Product.DS_Property CreateModel() {
            return new Com.DianShi.Model.Product.DS_Property();
        }

        /// <summary>
        /// 排序
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="IsUp"></param>
        public void Sort(int ID, bool IsUp)
        {
            using (var ct = new DS_PropertyDataContext(DbHelperSQL.Connection))
            {
                var md = ct.DS_Property.Single(a => a.ID == ID);
                ct.ExecuteCommand("update DS_Property  set px=(select RowNumber from (select (ROW_NUMBER() OVER (ORDER BY px)) AS RowNumber,id from DS_Property where  SysCatID={0}) as p2 where id=DS_Property.id) where SysCatID={0}", md.SysCatID);
                if (IsUp)
                {
                    DS_Property p = ct.DS_Property.Single(a => a.ID == ID);
                    DS_Property p1;
                    if (p.Px > 1)
                    {
                        p1 = ct.DS_Property.Single(a => a.Px == (p.Px - 1) && a.SysCatID == md.SysCatID);
                        p.Px--;
                        p1.Px++;
                    }

                }
                else
                {
                    DS_Property p = ct.DS_Property.Single(a => a.ID == ID);
                    DS_Property p1;
                    if (p.Px < ct.DS_Property.Where(a => a.SysCatID == md.SysCatID).Count())
                    {
                        p1 = ct.DS_Property.Single(a => a.Px == (p.Px + 1) && a.SysCatID == md.SysCatID);
                        p.Px++;
                        p1.Px--;
                    }
                }
                ct.SubmitChanges();
            }
        }

        /// <summary>
        /// 获取属性控件字符串
        /// </summary>
        /// <param name="CatID">产品分类ID</param>
        /// <returns></returns>
        public string GetControlList(int CatID) {
            var prtvbl = new DS_PropertyValue_Br();
            var prtlist = Query("SysCatID=@0", "px",CatID);
            var sb =new System.Text.StringBuilder();
            int i=0;
            foreach (var item in prtlist.Where(a => a.Request == true).OrderBy(a => a.Px))
            {
                GetControl(sb,item,prtvbl);
            }
            foreach (var item in prtlist.Where(a => a.Request == false).OrderBy(a => a.Px))
            {
                GetControl(sb, item, prtvbl);
            }
            return sb.ToString();
        }

        private void GetControl(System.Text.StringBuilder sb, DS_Property item,DS_PropertyValue_Br prtvbl)
        {
            string temstr = "";
            string itemstr = "<div class=\"prtctn overflowAuto\"><div class=\"prtn floatL\">{0}：</div><div class=\"floatL\">{1}</div></div>";
            switch (item.ControlType) { 
                case (byte)ControlType.文本框:
                    sb.Append(string.Format(itemstr, (item.Request ? "<span class='red'>*</span>" : "") + item.ProName, "<input name=\"txt_"+item.ID+"\" class=\"txtbox" + (item.Request ? " required" : "") + " Property"+item.MapID+"\" type=\"text\" />" + item.Unit));
                    break;
                case (byte)ControlType.下拉框:
                    var prtvlist = prtvbl.Query("PropertyID=@0", "px", item.ID);
                    temstr = "<select name=\"sl_" + item.ID + "\" " + "class='Property" + item.MapID + (item.Request ? " required" : "") + "'" + ">";
                    foreach (var vitem in prtvlist)
                    {
                        temstr+="<option value=\"" + vitem.PropertyValue + "\">" + vitem.PropertyValue + "</option>";
                    }
                    temstr += "</select>" + item.Unit;
                    sb.Append(string.Format(itemstr, (item.Request ? "<span class='red'>*</span>" : "") + item.ProName, temstr));
                    break;
                case (byte)ControlType.多选框:
                    
                    var prtvlist2 = prtvbl.Query("PropertyID=@0", "px", item.ID);
                    foreach (var vitem in prtvlist2)
                    {
                        temstr += "<input type=\"checkbox\" " + "class=\"Property" + item.MapID +(item.Request ? " required" : "") + "\" value=\"" + vitem.PropertyValue + "\" name=\"cb_" + item.ID + "\" id=\"cb_" + vitem.ID + "\" /><label for=\"cb_" + vitem.ID + "\">" + vitem.PropertyValue + "</label> ";
                    }
                    sb.Append(string.Format(itemstr, (item.Request ? "<span class='red'>*</span>" : "") + item.ProName, temstr+item.Unit));
                    break;
                case (byte)ControlType.单选框:
                    var prtvlist3 = prtvbl.Query("PropertyID=@0", "px", item.ID);
                    foreach (var vitem in prtvlist3)
                    {
                        temstr += "<input type=\"radio\" " + "class=\"Property" + item.MapID + (item.Request ? " required" : "") + "\" value=\"" + vitem.PropertyValue + "\" name=\"rd_" + item.ID + "\" id=\"rd_" + vitem.ID + "\" /><label for=\"rd_" + vitem.ID + "\">" + vitem.PropertyValue + "</label> ";
                    }
                    sb.Append(string.Format(itemstr, (item.Request ? "<span class='red'>*</span>" : "") + item.ProName, temstr + item.Unit)); 
                    break;
            }
        }


        public enum ControlType : byte { 
            文本框,
            下拉框,
            多选框,
            单选框
        }
    }
}
