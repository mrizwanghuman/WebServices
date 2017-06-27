using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConsumingWebService
{
    public partial class SoapFarm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SoapMine.WebService1SoapClient client = new SoapMine.WebService1SoapClient();
           int totalAcc = client.Counting(Convert.ToInt32(FirstNumber.Text), Convert.ToInt32(SecondNumber.Text));
            Label1.Text = totalAcc.ToString();
           
            GridView1.DataSource = client.getCalucationList();
            GridView1.DataBind();
        }
    }
}