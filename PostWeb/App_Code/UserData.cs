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
}
