using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace password.UI
{
    public class HttpHelper
    {
        public static void SendGet(string uri)
        {
            string serviceAddress = uri;
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(serviceAddress);
            request.Method = "GET";
            //request.ContentType = "application/json";
            //string strContent = @"{ ""value"": ""test""}";
            //using (StreamWriter dataStream = new StreamWriter(request.GetRequestStream()))
            //{
            //    dataStream.Write(strContent);
            //    dataStream.Close();
            //}
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (StreamReader dataStream = new StreamReader(response.GetResponseStream()))
            {
                var result = dataStream.ReadToEnd();                
            }
        }
    }
}