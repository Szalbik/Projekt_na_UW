using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace statystyka
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
        public double srednia(double[] arr)
        {
            if (arr.Length == 0)
            {
                return 0;
            }
            double suma = 0.0;
            for (int i = 0; i < arr.Length; i++)
            {
                suma += arr[i];
            }
            return suma / arr.Length;
        }

        [WebMethod]
        public double mediana(double[] arr)
        {
            Array.Sort(arr);

            if (arr.Length == 0)
            {
                return 0;
            }
            if (arr.Length % 2 == 1)
            {
                return arr[arr.Length / 2];
            }
            else
            {
                return (arr[arr.Length / 2] + arr[arr.Length / 2 - 1]) / 2;
            }
        }

        [WebMethod]
        public double wariancja(double[] arr)
        {
            double mean = srednia(arr);
            double suma = 0.0;

            for (int i = 0; i < arr.Length; i++)
            {
                suma += Math.Pow(arr[i] - mean, 2);
            }

            return suma / arr.Length;
        }

        [WebMethod]
        public double std_odchylenie(double[] arr)
        {
            return Math.Sqrt(wariancja(arr));
        }
    }
}
