using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication1
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
 
        [WebMethod]
        public float kwadrat(float a)
        {
            return a*a;
        }

        [WebMethod]
        public float trojkat(float a, float h)
        {
            return a * h / 2;
        }

        [WebMethod]
        public float prostakat(float a, float b)
        {
            return a * b;
        }

        [WebMethod]
        public float rownoleglobok(float a, float h)
        {
            return a * h;
        }

        [WebMethod]
        public float trapez(float a, float b, float h)
        {
            return (a + b) * h / 2;
        }

    }
}
