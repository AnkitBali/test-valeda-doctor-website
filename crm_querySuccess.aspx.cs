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
using System.Data.SqlClient;
public partial class crm_querySuccess : System.Web.UI.Page
{
    Entery obj = new Entery();
    CdateClass objCdate = new CdateClass();
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["status"] != null)
                lblMess.Text = Request.QueryString["status"].ToString();
        }
    }
}