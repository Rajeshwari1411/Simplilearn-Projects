using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using bal;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB_schoolmanagement
{
    public partial class showclasses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            schooldetails b = new schooldetails();
            List<classes> products = new List<classes>();
            products = b.GetProducts();

            GridView1.DataSource = products;
            GridView1.DataBind();

        }
    }
}