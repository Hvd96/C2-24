using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id,marks;
            id=Int32.Parse(TextBox1.Text);
            marks=Int32.Parse(TextBox2.Text);
            String update="update Table set Marks="+marks+" where Id="+id;
            String Connection="Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\user1\Source\Repos\C2-24\C2-243\WebApplication1\WebApplication1\App_Data\student.mdf;Integrated Security=True";
            SqlConnection con=new SqlConnection(Connection);
            SqlCommand com=new SqlCommand(update,con);
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}