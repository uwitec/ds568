<%@ Page Language="C#" AutoEventWireup="True" %>
<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="System.Net" %>
<%@ Import Namespace="System.IO" %>
<script runat="server">
  string proxy = "http://searchbox.mapbar.com/publish";
  private void Pipe(string url) {
		try {
			WebRequest request = WebRequest.Create(url);
			HttpWebResponse response = (HttpWebResponse)request.GetResponse(); 
			Response.ContentType = response.ContentType;
			
			if (response.StatusCode==HttpStatusCode.OK) {
				string characterSet = response.CharacterSet;
				Encoding encode;
				if (characterSet!=""){
					encode = Encoding.GetEncoding(characterSet);
				} else {
					encode = Encoding.GetEncoding("utf-8");
				}
				System.IO.Stream stream = response.GetResponseStream();
				System.IO.StreamReader reader = new System.IO.StreamReader(stream, encode);
				char [] chars = new char[516];
				int count = reader.Read(chars, 0, 516);
				while(count > 0) {
				  string str = new String(chars, 0, count);
				  str = str.Replace("%25u", "%u");
				  str = str.Replace("proxy.jsp?api=poiUpdate", "proxy.aspx?api=poiUpdate");
					//Response.Write(chars, 0, count);
					Response.Write(str);
					count = reader.Read(chars, 0, 516);
				}
				reader.Close();
				stream.Close();
			}	
			response.Close();
		}catch(Exception exp) {
			Response.StatusCode = 404;
			Response.Write("error read:" + exp.Message);
		}
	}
	
 	private String getTarget() {
  	string url = "";
    string qry = HttpUtility.UrlDecode(Request.QueryString.ToString());
    string api = Request.QueryString["api"];
    if (api == "keyword") {
    	url = proxy + "/common/proxy.jsp?" + qry;
    } else if (api == "getCityByName") {
      url = proxy + "/common/proxy.jsp?" + qry;
    } else if (api == "template1000") { 
      url = proxy + "/template/template1000/?" + qry.Substring(qry.IndexOf("&") + 1);
    } else if(api == "poiUpdate") {
      url = proxy + "/common/proxy.jsp?" + qry;
    }
    //Response.Write(url);
    return url;
  }	
</script>
<%
 	try {
    Pipe(getTarget());
  } catch (Exception ex) {
  	Response.StatusCode = 404;
   	Response.Write(ex);
  }	
%>