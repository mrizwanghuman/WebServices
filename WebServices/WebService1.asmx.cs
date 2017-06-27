using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServices
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod(EnableSession = true, Description = "Great thing happens")]
        public int Counting(int firstNumber, int secondNumber)
        {
            List<string> storedList;
            if (Session["Accounting"] == null)
            {
                storedList = new List<string>();
            }
            else
            {
                storedList = (List<string>)Session["Accounting"];
            }
            string listCalculations = firstNumber.ToString() + " + " + secondNumber.ToString() + " = " + (firstNumber + secondNumber).ToString();
            storedList.Add(listCalculations);
            Session["Accounting"] = storedList;
            return firstNumber + secondNumber;
        }
        [WebMethod(EnableSession =true)]
        public List<string> getCalucationList()
        {
            if (Session["Accounting"] == null)
            {
                List<string> storedList = new List<string>();
                storedList.Add("No calculations");
                return storedList;
            }
            else
            {
                return (List<string>)Session["Accounting"];
            }
            
        }
    }
}
