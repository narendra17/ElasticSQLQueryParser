using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.IO;

namespace ElasticSQLQueryParser.Controllers
{
    public static class Util
    {
        public static string ElasticCall(string url, string method, string query)
        {
            HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create(url);
            myReq.Method = method;
            if (method == "POST")
            {
                using (var streamWriter = new StreamWriter(myReq.GetRequestStream()))
                {
                    string json = query ;

                    streamWriter.Write(json);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
            }
            HttpWebResponse myResp = (HttpWebResponse)myReq.GetResponse();
            System.IO.StreamReader respStreamReader = new System.IO.StreamReader(myResp.GetResponseStream());
            string responseString = respStreamReader.ReadToEnd();
            respStreamReader.Close();
            myResp.Close();
            return responseString;
        }
    }
}