

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using System.Xml;
using System.Xml.Linq;

//*************************************************************************************
//
//          https://toshi.io/docs/#introduction  
//          http://json2csharp.com/#    , and paste in https://bitcoin.toshi.io/api/v0/blocks to get poco 
//
//
//         source location :  https://github.com/maxcli/share
//
//*************************************************************************************

namespace CliftCons.POC
{
    class Program
    {
        const string uri = @"https://bitcoin.toshi.io/api/v0/blocks";

        static void Main(string[] args)
        {


            HttpStatusCode statusCode;
            HttpWebRequest request;
            HttpWebResponse response;
            //Document responseBody;

            request = GetRequest(uri);
            try
            {
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (WebException ex)
            {
                response = (HttpWebResponse)ex.Response;
            }
            statusCode = response.StatusCode;

            if (statusCode.Equals(HttpStatusCode.OK))
            {



                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    JavaScriptSerializer js = new JavaScriptSerializer();
                    js.MaxJsonLength = Int32.MaxValue; // Whatever max length you want here
                    var objText = reader.ReadToEnd();


                    List<RootObject> rootObjects = js.Deserialize<List<RootObject>>(objText);

                    int i = 0;
                }

            }
            response.Close();

        }

        //
        //		ContentType	"application/json" 
        //      Not  "application/xml"
        public static HttpWebRequest GetRequest(string url)
        {

            Uri uri = new Uri(url);
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(uri);
            request.Method = "GET";
            return request;

        }
    }
}
