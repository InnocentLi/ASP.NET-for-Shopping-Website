using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    private SqlConnection conn = null;
    private SqlCommand cmd = null;
    //private SqlDataAdapter adapter = null;  

    private string sql = null;
    public string strHTML = string.Empty;

   

  
    public void openDatabase()
    {
        conn = new SqlConnection();

        conn.ConnectionString = " Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Phone;Data Source=INNOCENCE\\MSSQLSERVER01";
        if (conn.State == ConnectionState.Closed)
        {
            conn.Open();
            //Response.Write("<script>alert('Connected!');</script>");  
        }
    }
    public void load()
    {
        string s1, s2, s4,s5,s6,s7;
        openDatabase();
        cmd = new SqlCommand("select * from buy where money=(select max(money) from buy)", conn);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            s1 = (String)dr[1].ToString().Trim();
            s2 = (String)dr[2].ToString().Trim();
            s4 = (String)dr[4].ToString().Trim();
            s5 = (String)dr[5].ToString().Trim();
            s6 = (String)dr[6].ToString().Trim();
            s7 = (String)dr[7].ToString().Trim();
           // Page.ClientScript.RegisterClientScriptBlock(GetType(), "", "<div style='display:inline-block;'><img src=" + s4 + "><h3>" + s6 + "</h3><p>" + s7 + "</p><h5>" + s2 + "</h5></div>");
         //  Response.Write("<div style='display:inline-block;'><img src=" + s4+"><h3>"+s6+"</h3><p>"+s7+"</p><h5>"+s2+ "</h5></div>");
         strHTML = "<div style='display:inline-block;'><img style='width:230px' src=" + s4 + "><h3>" + s6 + "</h3><p>" + s7 + "</p><h5>" + s2 + "</h5></div>";
          
        }
        conn.Close();

    }



    public void load(String sql)
    {
        string s1, s2, s4, s5, s6, s7;
        int s3;
        openDatabase();
        cmd = new SqlCommand(sql, conn);
        SqlDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            s1 = (String)dr[1].ToString().Trim();
            s2 = (String)dr[2].ToString().Trim();
            s4 = (String)dr[4].ToString().Trim();
            s5 = (String)dr[5].ToString().Trim();
            s6 = (String)dr[6].ToString().Trim();
            s7 = (String)dr[7].ToString().Trim();
            s3 = (Int32)dr[3];
           
            strHTML += "<div style='display:inline-block; '><img style='width:230px' src=" + s4 + "><h3>" + s6 + "</h3><p>" + s7 + "</p><h5>" + s2 + "</h5>   <button><a href ='Show.aspx'>立即购买</a></div></button>";
            Session["phone"] = s1;
            Session["purl"] = s4;
            Session["money"] = s6;
            Session["in"] = s7;
            // a = (Int32)dr[3] + 1;
            //  sql = " UPDATE buy SET vc = " + a + " WHERE name =" + s1 + "";
        }
        
  
        conn.Close();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["phone"] = null;
        Session["purl"] = null;
        Session["money"] = null;
        Session["in"] = null;
        strHTML = null;
        if (!IsPostBack) { load();
             
}
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)//查找
    {


        sql = "select * from buy where name LIKE'%" + TextBox1.Text.ToString().Trim() + "%'";

        load(sql);
    }


    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        sql = "select * from buy where name LIKE'%iPhone%'";
        load(sql);
    }

    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        sql = "select * from buy where name LIKE'%三星%'";
        load(sql);
    }

    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        sql = "select * from buy where name LIKE'%小米%'";
        load(sql);
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        
    }
}