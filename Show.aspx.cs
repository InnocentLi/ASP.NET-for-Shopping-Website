using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Show: System.Web.UI.Page
{
    private SqlConnection conn = null;
    private SqlCommand cmd = null;
    //private SqlDataAdapter adapter = null;  

    private string sql = null;
    public string strrHTML = string.Empty;

  /*  public void openDatabase()
    {
        conn = new SqlConnection();

        conn.ConnectionString = " Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Phone;Data Source=INNOCENCE\\MSSQLSERVER01";
        if (conn.State == ConnectionState.Closed)
        {
            conn.Open();
          
        }
    }
    public void load()
    {
        openDatabase();
        cmd = new SqlCommand(" update buy set num = num + 1 where name ="+"'"+Session["phone"].ToString()+"'", conn);
        Response.Write("<script>alert('Connected!');</script>");
        conn.Close();
    }*/



    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Phone;Data Source=INNOCENCE\\MSSQLSERVER01");
        conn.Open();
        string sqladd = " update buy set vc = vc + 1 where name =" + "'" + Session["phone"].ToString() + "'";
        SqlCommand commd = new SqlCommand(sqladd, conn);
        commd.ExecuteReader();
        conn.Close();
        strrHTML = "<div style='display:inline-block; '><img style='width:230px' src=" + Session["purl"].ToString() + "><h3>" + Session["money"].ToString() + "</h3><p>" + Session["in"].ToString() + "</p> ";
    }





    protected void Button1_Click(object sender, EventArgs e)
    {

        //    load();
        SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Phone;Data Source=INNOCENCE\\MSSQLSERVER01");
        conn.Open();
        string sqladd = " update buy set num = num + 1 where name =" + "'" + Session["phone"].ToString() + "'";
        SqlCommand commd = new SqlCommand(sqladd, conn);
        commd.ExecuteReader();
        conn.Close();
        Response.Write("<script>alert('添加购物车成功')</script >");
    }
}
