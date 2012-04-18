using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Xml.Linq;
using Com.DianShi.Model.Member;
/// <summary>
///UserData 的摘要说明
/// </summary>
public class UserData
{
    public UserData()
    {
        //
        //TODO: 在此处添加构造函数逻辑
        //
       
    }
    public DS_Members Member{ get; set; }

    public string ValiCode { get; set; }

    public Com.DianShi.BusinessRules.Transaction.DS_Cart ShoppingCart { get; set; }
   
    /// <summary>
    /// 检查对象是否为空,验证中如果发现Session["UserData"]为空则创建Session["UserData"],若为空则返回false，否则还回true
    /// </summary>
    /// <param name="ot"></param>
    /// <returns></returns>
    public static bool ChkObjNull(ObjType ot) {
        bool b = false;
        var ud = HttpContext.Current.Session["UserData"] as UserData;
        if (ud == null)
        {
            HttpContext.Current.Session["UserData"]=ud = new UserData();
            return b;
        }
        
        switch (ot) {
            case ObjType.会员信息:
                b = !object.Equals(ud.Member,null);
                break;
            case ObjType.购物车:
                b = !object.Equals(ud.ShoppingCart, null);
                break;
        }

        return b;
    }

    public enum ObjType { 
        会员信息,
        购物车
    }
}
