using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class over: System.Web.UI.Page
{
    private SqlConnection conn = null;
    private SqlCommand cmd = null;
    //private SqlDataAdapter adapter = null;  

    private string sql = null;
    public string strrrHTML = string.Empty;
    public string strrrrHTML = string.Empty;




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
    public void load(String sql)
    {
        string s1,s4;
        int s5,s6;
        int sum = 0;
        openDatabase(); 
        cmd = new SqlCommand(sql, conn);
     //   SqlDataReader dr = cmd.ExecuteReader();
        SqlDataReader dr = cmd.ExecuteReader();
        while  (dr.Read())
        {
            s1 = dr[1].ToString().Trim();
            s5 = (Int32)dr[5];
            s4 = dr[4].ToString().Trim();
            s6 = (Int32)dr[6];
            sum += s5 * s6;
            strrrHTML += "<div style=';display:block;text-align:center;width:1000px;height:300px;'><img style='width:230px' src=" + s4 + "><span>名称" + s1 + "</span><span>数量" + s5 + "</span><span>单价" + s6 + "</span></div> ";
        }
           strrrrHTML = "<div style='float:left;display:inline;'>最后价格" + sum+"</div>";
        conn.Close();

    }
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
        
          load("select * from buy where num > 0 ");
        }
    }




}