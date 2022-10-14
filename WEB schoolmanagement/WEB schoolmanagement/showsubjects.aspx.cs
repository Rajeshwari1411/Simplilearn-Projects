using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using bal;

namespace WEB_schoolmanagement
{
    public partial class showsubjects : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            schooldetails b = new schooldetails();
            List<subjectcs> products = new List<subjectcs>();
            products = b.GetProducts1();

            GridView1.DataSource = products;
            GridView1.DataBind();
        }
    }
}