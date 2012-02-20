using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Dynamic;
using Com.DianShi.Model.Member;
using DBUtility;
namespace Com.DianShi.BusinessRules.Member
{
    public class DS_Employees_Br:BllBase
    {
        public void Add(DS_Employees Employees)
        {
            using (var ct = new DS_EmployeesDataContext(DbHelperSQL.Connection))
            {
                ct.DS_Employees.InsertOnSubmit(Employees);
                ct.SubmitChanges();
            }
        }

        public void Update(DS_Employees Employees)
        {
            using (var ct = new DS_EmployeesDataContext(DbHelperSQL.Connection))
            {
                ct.DS_Employees.Attach(Employees, true);
                ct.SubmitChanges();
            }
        }

        public void Delete(int ID)
        {
            using (var ct = new DS_EmployeesDataContext(DbHelperSQL.Connection))
            {
                DS_Employees st = ct.DS_Employees.Single(a => a.ID == ID);
                ct.DS_Employees.DeleteOnSubmit(st);
                ct.SubmitChanges();
            }
        }

        public DS_Employees GetSingle(int ID)
        {
            using (var ct = new DS_EmployeesDataContext(DbHelperSQL.Connection))
            {
                return ct.DS_Employees.Single(a => a.ID == ID);
            }
        }

        public List<T> Query<T>(string sql, params object[] parameterValues)
        {
            using (var ct = new DS_EmployeesDataContext(DbHelperSQL.Connection))
            {
                return ct.ExecuteQuery<T>(sql, parameterValues).ToList();
            }
        }

        public List<DS_Employees> Query(string condition, string orderby, int startIndex, int pageSize, ref int pageCount, params object[] param)
        {
            using (var ct = new DS_EmployeesDataContext(DbHelperSQL.Connection))
            {
                IQueryable<DS_Employees> EmployeesList = ct.DS_Employees;
                if (!string.IsNullOrEmpty(condition))
                    EmployeesList = EmployeesList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    EmployeesList = EmployeesList.OrderBy(orderby);
                pageCount = EmployeesList.Count();
                return EmployeesList.Skip(startIndex).Take(pageSize).ToList();
            }
        }

        public List<DS_Employees> Query(string condition, string orderby, params object[] param)
        {
            using (var ct = new DS_EmployeesDataContext(DbHelperSQL.Connection))
            {
                IQueryable<DS_Employees> EmployeesList = ct.DS_Employees;
                if (!string.IsNullOrEmpty(condition))
                    EmployeesList = EmployeesList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    EmployeesList = EmployeesList.OrderBy(orderby);
                return EmployeesList.ToList();
            }
        }

        public Com.DianShi.Model.Member.DS_Employees CreateModel() {
            return new Com.DianShi.Model.Member.DS_Employees();
        }

       
    }
}
