using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ServiceIO
{
   public class ClassDollar
    {
        public ClassDollar()
        {

        }
        public string GetValutaFromOpenExchangeRates()
        {
            WebRequest request = WebRequest.Create("https://openexchangerates.org/api/latest.json?app_id=05d1e2e07e6245b1aba05f9717f8f364");

            request.Credentials = CredentialCache.DefaultCredentials;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Stream datastream = response.GetResponseStream();

            StreamReader reader = new StreamReader(datastream);

            string responseFromServer = reader.ReadToEnd();

            reader.Close();
            datastream.Close();
            return responseFromServer;
        }
    }
}
