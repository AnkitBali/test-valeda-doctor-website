using System;
using System.Data;
using System.Data.SqlClient;
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
/// Summary description for Entery
/// </summary>
public class Entery
{

    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn_string"].ConnectionString);
    SqlCommand cmd;
    SqlDataReader dr,dr1;
    SqlDataAdapter da;
    SqlConnection con1 = new SqlConnection(ConfigurationManager.ConnectionStrings["conn_string"].ConnectionString);
    public int flag = 0;
    public long id;
    string name;
    public Entery()
    {

    }


    //=============================================== some common methods for data fatching ===========================================
    public string GetNewID()
    {
        if (con.State == ConnectionState.Broken || con == null || con.State == ConnectionState.Open)
            con.Close();
        con.Open();
        int flag = 0;
        string newid = "";
        while (true)
        {
            newid = RandomNumberGenerator(8);
            SqlCommand cmd = new SqlCommand("Select * from CRM_TBL_Customer where CustomerID='" + newid + "'", con);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                flag = 1;
            } dr.Close();
            if (flag == 0)
                break;
        }
        while (newid.Length < 8)
            newid = newid + "0";
        newid = newid;
        con.Close();
        return newid;
    }
    public string CheckNewCustomer(string MobileNo)
    {
        string message = "";
        string query = "select CustomerID from CRM_TBL_Customer where MobileNo='" + MobileNo + "'";
        int flag = returnFlag(query);
        if (flag == 1)
        {
            message = "Customer Already Exists.";
        }
        return (message);
    }
    public string InsertNewCustomer(string CustomerID, string Password, string MobileNo, string AlternetMobile, string CustomerName, string Sex, string Address, string State, string City, string PinCode, string StdCode, string PhoneNo, string EmailID, string CustomerType, string Comments, string LoginID, string CurrentDate, string CurrentTime, string Media, string status, string Comm_Media, string Category, string AssignedTo, string Technician, string Country, string CustomerColor)
    {
        string message = "";
        string query = "select CustomerID from CRM_TBL_Customer where MobileNo='" + MobileNo + "'";

        int flag = returnFlag(query);
        if (flag == 1)
        {
            message = "Customer Already Exists.";
        }
        //if (con.State == ConnectionState.Open || con.State == ConnectionState.Broken)
        //    con.Close();
        //con.Open();
        //cmd = new SqlCommand("", con);
        ////SELECT CustomerID, Password, MobileNo, AlternetMobile, CustomerName, Sex, Address, State, City, PinCode, StdCode, PhoneNo, EmailID, CustomerType, Comments, LoginID, CurrentDate, CurrentTime, Media, status, id, Comm_Media, Category, AssignedTo, Technician, Country, CustomerColor FROM CRM_TBL_Customer

        //string q = "insert into CRM_TBL_Customer values('" + CustomerID + "','" + Password + "','" + MobileNo + "','" + AlternetMobile + "','" + CustomerName + "','" + Sex + "','" + Address + "','" + State + "','" + City + "','" + PinCode + "','" + StdCode + "','" + PhoneNo + "','" + EmailID + "','" + CustomerType + "','" + Comments + "','" + LoginID + "','" + CurrentDate + "','" + CurrentTime + "','" + Media + "','" + status + "','" + Comm_Media + "','" + Category + "','" + AssignedTo + "','" + Technician + "','" + Country + "','" + CustomerColor + "')";
        //cmd.CommandText = q;
        //cmd.ExecuteNonQuery();
        //con.Close();
        return (message);
    }

    private string RandomNumberGenerator(int length)
    {
        System.Security.Cryptography.RandomNumberGenerator rng = System.Security.Cryptography.RandomNumberGenerator.Create();
        char[] chars = new char[length];
        int countpassword = 1;
        //based on your requirment you can take only alphabets or number
        string validChars = "9123456789";
        string pass = "";
        for (int i = 0; i < length; i++)
        {
            byte[] bytes = new byte[1];
            rng.GetBytes(bytes);
            Random rnd = new Random(bytes[0]); chars[i] = validChars[rnd.Next(0, 10)];

        }
        pass = Convert.ToString(new string(chars));
        countpassword++;
        return pass;
    }

    public string returnTeamQuery(string doctorid, string teamBusinessQuery)
    {
        string team = "";
       
        dr = returnDataRow("SELECT TeamMember FROM CRM_TBL_Doctor where loginid='" + doctorid + "'");
        if (dr.Read())
            team = dr["TeamMember"].ToString();
        dr.Close();
        string[] TeamArray = team.Split(',');
        for (int counter = 0; counter < TeamArray.Length; counter++)
        {
            if (TeamArray[counter] != doctorid)
                teamBusinessQuery = teamBusinessQuery + " or loginid='" + TeamArray[counter] + "'";
        }
        return teamBusinessQuery;
    }


    public SqlDataReader returnDataRow(string q)
    {
        //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12; // .NET 4.5
        // ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072; // .NET 4.0
        if (con.State == ConnectionState.Open)
            con.Close();
        con.Open();
        cmd = new SqlCommand(q, con);
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        return dr;
    }
    public DataTable  returnDataTable(string q)
    {
        if (con.State == ConnectionState.Open)
            con.Close();
        con.Open();
        DataSet ds = new DataSet();
        da = new SqlDataAdapter(q, con);
        da.Fill(ds, "tab");
        con.Close();
        return ds.Tables[0];
    }

    public SqlDataReader returncommondata(string query)
    {
        if (con.State == ConnectionState.Open)
            con.Close();
        con.Open();
        cmd = new SqlCommand(query, con);
        //"Select * from CRM_TBL_Patient where id='" + id + "'"
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        return dr;
    }

    public void CommonUpdate(string query)
    {
        if (con.State == ConnectionState.Open || con.State == ConnectionState.Broken)
            con.Close();
        con.Open();
        cmd = new SqlCommand("", con);
        cmd.CommandText = query;
        cmd.ExecuteNonQuery();
        con.Close();
    }

    public void CommonInsert(string query)
    {
        if (con.State == ConnectionState.Open || con.State == ConnectionState.Broken)
            con.Close();
        con.Open();
        cmd = new SqlCommand("", con);
        cmd.CommandText = query;
        cmd.ExecuteNonQuery();
        con.Close();
    }

    public string commonname(string query)
    {
        //"select agentname from CRM_TBL_agentMaster where agentcode='" + agentcode + "'";
        if (con1.State == ConnectionState.Open || con1.State == ConnectionState.Broken)
            con1.Close();
        con1.Open();
                
        cmd = new SqlCommand("", con1);
        cmd.CommandText = query;
        dr1 = cmd.ExecuteReader();
        if (dr1.Read())
        {
            name = dr1[0].ToString();
        }
              
        return name;
        
    }

    //===============================================End of Common Methods=============================================================
    //==============================================================================Start Patient====================================
    public void InsertPatient(string loginid, string password, string pname, string gender, DateTime dob, DateTime doa, string add1, string phone, string mobile, string emailid)
    {
        if (con.State == ConnectionState.Open || con.State == ConnectionState.Broken)
            con.Close();
        con.Open();
        cmd = new SqlCommand("", con);
        string q = "insert into CRM_TBL_Patient values('" + loginid + "','" + password + "','" + pname + "','" + gender + "','" + dob + "','" + doa + "','" + add1 + "','" + phone + "','" + mobile + "','" + emailid + "','" + 0 + "')";
        cmd.CommandText = q;
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public void UpdatePatient(string pname, string gender, DateTime dob, DateTime doa, string add1, string phone, string mobile, string emailid, string id)
    {
        if (con.State == ConnectionState.Open || con.State == ConnectionState.Broken)
            con.Close();
        con.Open();
        cmd = new SqlCommand("", con);
        string q = "update CRM_TBL_Patient set pname='" + pname + "',gender='" + gender + "',dob='" + dob + "',doa='" + doa + "',add1='" + add1 + "',phone='" + phone + "',mobile='" + mobile + "',emailid='" + emailid + "' where id='" + id + "'";
        cmd.CommandText = q;
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public void RemovePatient(string id)
    {
        if (con.State == ConnectionState.Open || con.State == ConnectionState.Broken)
            con.Close();
        con.Open();
        cmd = new SqlCommand("", con);
        cmd.CommandText = "Delete from CRM_TBL_Patient where id='" + id + "'";
        cmd.ExecuteNonQuery();
        con.Close();
    }
    
    //==============================================================================Start Doctor====================================
    public void InsertDoctor(string loginid, string password, string dname, string gender, string qual, string exp, DateTime dob, DateTime doj, string add1, string phone, string mobile, string bankname, string accountno, string branchname, string ifsccode, string emailid, string TeamMember,string country,string doctorRegistrationNo,string Status)
    {
        if (con.State == ConnectionState.Open || con.State == ConnectionState.Broken)
            con.Close();
        con.Open();
        cmd = new SqlCommand("", con);
        string q = "insert into CRM_TBL_Doctor values('" + loginid + "','" + password + "','" + dname + "','" + gender + "','" + qual + "','" + exp + "','" + dob + "','" + doj + "','" + add1 + "','" + phone + "','" + mobile + "','" + bankname + "','" + accountno + "','" + branchname + "','" + ifsccode + "','" + emailid + "','" + TeamMember + "','','" + country + "','" + doctorRegistrationNo + "','"+Status+"')";
        cmd.CommandText = q;
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public void UpdateDoctor(string dname, string gender, string qual, string exp, DateTime dob, DateTime doj, string add1, string phone, string mobile, string bankname, string accountno, string branchname, string ifsccode, string emailid,string terminal,string country, string id)
    {
        if (con.State == ConnectionState.Open || con.State == ConnectionState.Broken)
            con.Close();
        con.Open();
        cmd = new SqlCommand("", con);
        string q = "update CRM_TBL_Doctor set Terminal='" + terminal + "',dname='" + dname + "',gender='" + gender + "',qual='" + qual + "',exp='" + exp + "',dob='" + dob + "',doj='" + doj + "',add1='" + add1 + "',phone='" + phone + "',mobile='" + mobile + "',bankname='" + bankname + "',accountno='" + accountno + "',branchname='" + branchname + "',ifsccode='" + ifsccode + "',emailid='" + emailid + "',country='" + country + "' where id='" + id + "'";
        cmd.CommandText = q;
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public void UpdateDoctorAdmin(string dname, string gender, string qual, string exp, DateTime dob, DateTime doj, string add1, string phone, string mobile, string bankname, string accountno, string branchname, string ifsccode, string emailid, string terminal, string country, string password,string docotrRegistrationNo,string status, string id)
    {
        if (con.State == ConnectionState.Open || con.State == ConnectionState.Broken)
            con.Close();
        con.Open();
        cmd = new SqlCommand("", con);
        string q = "update CRM_TBL_Doctor set password='" + password + "', Terminal='" + terminal + "',dname='" + dname + "',gender='" + gender + "',qual='" + qual + "',exp='" + exp + "',dob='" + dob + "',doj='" + doj + "',add1='" + add1 + "',phone='" + phone + "',mobile='" + mobile + "',bankname='" + bankname + "',accountno='" + accountno + "',branchname='" + branchname + "',ifsccode='" + ifsccode + "',emailid='" + emailid + "',country='" + country + "',doctorRegistrationNo='" + docotrRegistrationNo + "',Status='"+status+"' where id='" + id + "'";
        cmd.CommandText = q;
        cmd.ExecuteNonQuery();
        con.Close();
    }
   
    

    public void RemoveDoctor(string id)
    {
        if (con.State == ConnectionState.Open || con.State == ConnectionState.Broken)
            con.Close();
        con.Open();
        cmd = new SqlCommand("", con);
        cmd.CommandText = "Delete from CRM_TBL_Doctor where id='" + id + "'";
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public int returnFlag(string query)
    {
        flag = 0;

        con.Open();
        cmd = new SqlCommand("", con);
        cmd.CommandText = query;
        dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            flag = 1;
        }
        dr.Close();
        con.Close();
        return flag;
    }
    public void UpdatesTLRights(string empid, string DistributorRights)
    {
        con.Open();
        cmd = new SqlCommand("", con);
        string q = "Update CRM_TBL_Doctor set TeamMember='" + DistributorRights + "' where loginid='" + empid + "'";
        cmd.CommandText = q;
        cmd.ExecuteNonQuery();
        con.Close();
    }
    //--------------------------------------------------------------------Imporvements======================================================
    public void InsertCRM_TBL_Improvments(string Userid, string Remarks)
    {
        //SELECT Userid, Dated, Remarks, ID  FROM CRM_TBL_Improvments
        if (con.State == ConnectionState.Open || con.State == ConnectionState.Broken)
            con.Close();
        con.Open();
        CdateClass objCdate = new CdateClass();
        string dated= objCdate.getCurrentdateTime();
        cmd = new SqlCommand("", con);
        string q = "insert into CRM_TBL_Improvments values('" + Userid + "','" + dated + "','" + Remarks + "')";
        cmd.CommandText = q;
        cmd.ExecuteNonQuery();
        con.Close();
    }

    public string returnmaxID_CRM_TBL_Improvments()
    {
        //SELECT Userid, Dated, Remarks, ID  FROM CRM_TBL_Improvments
        if (con.State == ConnectionState.Open || con.State == ConnectionState.Broken)
            con.Close();
        con.Open();
        cmd = new SqlCommand("", con);
        cmd.CommandText = "SELECT isnull(max(id),0)+1  FROM CRM_TBL_Improvments";
        string id = cmd.ExecuteScalar().ToString();
        con.Close();
        return id;
    }
    public string returnmaxID_CRM_TBL_InvestigationReport()
    {
        //SELECT Userid, Dated, Remarks, ID  FROM CRM_TBL_Improvments
        if (con.State == ConnectionState.Open || con.State == ConnectionState.Broken)
            con.Close();
        con.Open();
        cmd = new SqlCommand("", con);
        cmd.CommandText = "SELECT isnull(max(id),0)+1  FROM CRM_TBL_InvestigationReport";
        string id = cmd.ExecuteScalar().ToString();
        con.Close();
        return id;
    }
    public void InsertCRM_TBL_InvestigationReport(string Userid, string Remarks)
    {
        //SELECT CustomerID, Comments, Dated, ID FROM CRM_TBL_InvestigationReport
        if (con.State == ConnectionState.Open || con.State == ConnectionState.Broken)
            con.Close();
        con.Open();
        CdateClass objCdate = new CdateClass();
        string dated = objCdate.getCurrentdateTime();
        cmd = new SqlCommand("", con);
        string q = "insert into CRM_TBL_InvestigationReport values('" + Userid + "','" + Remarks + "','" + dated + "')";
        cmd.CommandText = q;
        cmd.ExecuteNonQuery();
        con.Close();
    }
    //--------------------------------------------------------------------Imporvements ends ======================================================

    //--------------------------------------------------------------------Satisfaction Rate======================================================
    public void InsertCRM_SatisfactionRate(string PatientID, string PatientRate, string DoctorRate, string DoctorID, string UpdatedBY)
    {
        //SELECT     PatientID, Dated, PatientRate, DoctorRate, ID FROM TBL_PatientSatisfactionRate
        if (con.State == ConnectionState.Open || con.State == ConnectionState.Broken)
            con.Close();
        con.Open();
        CdateClass objCdate = new CdateClass();
        string dated = objCdate.getCurrentdateTime();
        cmd = new SqlCommand("", con);
        string q = "insert into TBL_PatientSatisfactionRate values('" + PatientID + "','" + dated + "','" + PatientRate + "','" + DoctorRate + "','" + DoctorID + "','" + UpdatedBY + "')";
        cmd.CommandText = q;
        cmd.ExecuteNonQuery();
        con.Close();
    }

    public void Update_SatisfactionRate(string id, string DoctorRate)
    {
        //SELECT     PatientID, Dated, PatientRate, DoctorRate, ID FROM TBL_PatientSatisfactionRate
        if (con.State == ConnectionState.Open || con.State == ConnectionState.Broken)
            con.Close();
        con.Open();
        cmd = new SqlCommand("", con);
        string q = "update TBL_PatientSatisfactionRate set DoctorRate='" + DoctorRate + "' where id='" + id + "'";
        cmd.CommandText = q;
        cmd.ExecuteNonQuery();
        con.Close();
    }
    //--------------------------------------------------------------------Imporvements ends ======================================================


}