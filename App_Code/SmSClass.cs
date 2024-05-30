using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Net;
using System.IO;


public class SmSClass
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn_string"].ConnectionString);
    SqlCommand cmd;
    SqlDataReader dr;
    
	public SmSClass()
	{
      
	}
    string getMobileNo(string userid)
    {
        if (con.State == ConnectionState.Open || con.State == ConnectionState.Broken)
        {
            con.Close();
        }
        con.Open();
        string data = "";  //SELECT CustomerID, MobileNo, CustomerName FROM CRM_TBL_Customer
        cmd = new SqlCommand("Select MobileNo from CRM_TBL_Customer where CustomerID='" + userid + "'", con);
        data= cmd.ExecuteScalar().ToString();
        con.Close();
        return data;
    }

    public void sensms(string Mobile, string msg,string sentBy)
    {
        if (Mobile.Length != 10)
            return;
        String status = "";
        try
        {
            string uid = "Valeda103274";
            string pwd = "valeda123456";
            string gsmsenderid = "VALEDA";
            string cdmasenderid = "";
            string strRequest = "username=" + uid + "&password=" + pwd + "&sender=" + gsmsenderid + "&cdmasender=" + cdmasenderid + "&to=" + Mobile + "&message=" + msg + "&priority=1&dnd=1&unicode=0";
            string url = "http://kit19.com/ComposeSMS.aspx?";//http://sms19.info/ComposeSMS.aspx? change by manoj according to Dileep sir
            string Result_FromSMS = "";
            StreamWriter myWriter = null;
            HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create(url + strRequest);
            objRequest.Method = "POST";
            objRequest.ContentLength = strRequest.Length;
            objRequest.ContentType = "application/x-www-form-urlencoded";
            myWriter = new StreamWriter(objRequest.GetRequestStream());
            myWriter.Write(strRequest);
            myWriter.Close();
            HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();
            using (StreamReader sr = new StreamReader(objResponse.GetResponseStream()))
            {
                status = sr.ReadToEnd();
                sr.Close();
            }
            SentSms_Record(Mobile, msg, status,sentBy );
        }
        catch (Exception ex)
        {
            //    status = "Not send";
        }
    }
    public void forgotPassword(string Mobile, string msg)
    {
        if (Mobile.Length != 10)
            return;
        String status = "";
        try
        {
            string uid = "Valeda103274";
            string pwd = "valeda123456";
            string gsmsenderid = "VALEDA";
            string cdmasenderid = "";
            string strRequest = "username=" + uid + "&password=" + pwd + "&sender=" + gsmsenderid + "&cdmasender=" + cdmasenderid + "&to=" + Mobile + "&message=" + msg + "&priority=1&dnd=1&unicode=0";
            string url = "http://kit19.com/ComposeSMS.aspx?";//http://sms19.info/ComposeSMS.aspx? change by manoj according to Dileep sir
            string Result_FromSMS = "";
            StreamWriter myWriter = null;
            HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create(url + strRequest);
            objRequest.Method = "POST";
            objRequest.ContentLength = strRequest.Length;
            objRequest.ContentType = "application/x-www-form-urlencoded";
            myWriter = new StreamWriter(objRequest.GetRequestStream());
            myWriter.Write(strRequest);
            myWriter.Close();
            HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();
            using (StreamReader sr = new StreamReader(objResponse.GetResponseStream()))
            {
                status = sr.ReadToEnd();
                sr.Close();
            }
            
        }
        catch (Exception ex)
        {
            //    status = "Not send";
        }
    }
     
    public void SentSms_Record(string no, string sms, string status,string sentBy)
    {
        if (con.State == ConnectionState.Open || con.State == ConnectionState.Broken)
            con.Close();
        con.Open();
        CdateClass objCdate = new CdateClass();
        DateTime dt = objCdate.getCurrentdateTimeD();
        cmd = new SqlCommand("", con);
        cmd.CommandText = "insert into Tbl_SentSmS values('" + no + "','" + sms + "','" + objCdate.ReturnDatetimeString(dt) + "','" + status + "','" + sentBy + "')";
        cmd.ExecuteNonQuery();
        con.Close();
    }
    //end
    //return the Mobilelie no of user 
    public string getMobile(string userid)
    {
        if (con.State == ConnectionState.Open || con.State == ConnectionState.Broken)
        {
            con.Close();
        }
        con.Open();
        string data = "";
        cmd = new SqlCommand("", con);
        cmd.CommandText = "SELECT MobileNo from CRM_TBL_Customer where CustomerID='" + userid + "'";
        dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            data = dr[0].ToString ();
        } dr.Close();
        con.Close();
        return data;
    
    }
//end
    public string GetNews()
    {
        if (con.State == ConnectionState.Open || con.State == ConnectionState.Broken)
        {
            con.Close();
        }
        con.Open();
        string data = "";
        cmd = new SqlCommand("", con);
        cmd.CommandText = "Select News from tbl_news ";
      data=cmd.ExecuteScalar().ToString ();
      return data;
    }
 // email  sending methods

   
}
