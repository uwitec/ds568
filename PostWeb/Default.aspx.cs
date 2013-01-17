using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using Com.DianShi.BusinessRules.Album;
namespace Com.ItOnline.Web
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            var anony = new { a = 1, b = "2",c=0.1,d=new[]{1,2,3} };
            
            var jsonserialize = new System.Web.Script.Serialization.JavaScriptSerializer();
            
            var obj=jsonserialize.DeserializeObject(jsonserialize.Serialize(anony));
            
            Response.Write((obj as IDictionary)["c"]);
        }
        
    }

}
