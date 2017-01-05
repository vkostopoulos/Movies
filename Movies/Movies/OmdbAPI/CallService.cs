using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace Movies.OmdbAPI
{
    public class CallService
    {

        public string CallServiceGetResponse(String Url)
        {
            string urlData = String.Empty;
            WebClient wc = new WebClient();
            urlData = wc.DownloadString(Url);

            return urlData;
        }
    }
}