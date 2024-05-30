using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

/// <summary>
/// Summary description for CdateClass
/// </summary>
public class CdateClass
{
	public CdateClass()
	{
		//
		// TODO: Add constructor logic here
		//
	}
  public string getCurrentdateTime()
    {
        DateTime cDate = DateTime.Now;
        cDate = cDate.AddHours(12); cDate = cDate.AddMinutes(30);
        string cDatemmddyyyy = cDate.ToString("MM/dd/yyyy hh:mm:ss tt");
        return cDatemmddyyyy;

    }

  public DateTime getCurrentdateTimeD()
  {
      DateTime cDate = DateTime.Now;
      cDate = cDate.AddHours(12); cDate = cDate.AddMinutes(30);
      return cDate;
  }
  public string getCurrentdateTimeString()
  {
      //System.Globalization.CultureInfo.CurrentCulture.ClearCachedData();
      DateTime cDate = DateTime.Now;
      cDate = cDate.AddHours(12); cDate = cDate.AddMinutes(30);
      string cDatemmddyyyy = cDate.ToString("MM/dd/yyyy hh:mm:ss tt");
      return cDatemmddyyyy;

  }

  public string getCurrentdateTimeStringWithoutTime()
  {
      //System.Globalization.CultureInfo.CurrentCulture.ClearCachedData();
      DateTime cDate = DateTime.Now;
      cDate = cDate.AddHours(12); cDate = cDate.AddMinutes(30);
      string cDatemmddyyyy = cDate.ToString("MM/dd/yyyy");
      return cDatemmddyyyy;
  }
  public string ReturnDatetimeString(DateTime cDate)
  {
      //System.Globalization.CultureInfo.CurrentCulture.ClearCachedData();
      string cDatemmddyyyy = cDate.ToString("MM/dd/yyyy hh:mm:ss tt");
      return cDatemmddyyyy;
  }
}
