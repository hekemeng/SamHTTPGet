namespace SamZhengAPI.WebGet.Common
{
    #region Spaces
    using System;
    using System.Net;
    using System.Collections.Generic;
    using UC;
    using System.Text;
    #endregion

    public class HttpFun
    {
        public static bool DoWebGet(
            string GetUrl, 
            int TimeOut, 
            string GetEncoding, 
            IDictionary<string,string> Parameters, 
            IDictionary<string, string> Headers,
            out IDictionary<string, string> OutSendHeaders,
            out IDictionary<string, string> OutResultHeaders,
            out string HtmlSource,
            out string OutMessages)
        {
            return DoWebAction(GetUrl, false, "", TimeOut, GetEncoding, Parameters, Headers, out OutSendHeaders, out OutResultHeaders, out HtmlSource, out OutMessages);
        }

        public static bool DoWebPost(
            string GetUrl, 
            string PostData, 
            int TimeOut, 
            string GetEncoding, 
            IDictionary<string, string> Parameters,
            IDictionary<string, string> Headers,
            out IDictionary<string, string> OutSendHeaders,
            out IDictionary<string, string> OutResultHeaders,
            out string HtmlSource,
            out string OutMessages)
        {
            return DoWebAction(GetUrl, true, PostData, TimeOut, GetEncoding, Parameters, Headers, out OutSendHeaders, out OutResultHeaders, out HtmlSource, out OutMessages);
        }

        private static bool DoWebAction(
            string GetUrl, 
            bool IsPost, 
            string PostData, 
            int TimeOut, 
            string GetEncoding, 
            IDictionary<string, string> Parameters, 
            IDictionary<string, string> Headers,
            out IDictionary<string, string> OutSendHeaders,
            out IDictionary<string, string> OutResultHeaders,
            out string HtmlSource,
            out string OutMessages
            )
        {
            HtmlSource = "";
            OutMessages = "";
            OutSendHeaders = new Dictionary<string, string>() { };
            OutResultHeaders = new Dictionary<string, string>() { };

            using (UCWebClient HttpGet = TimeOut > 0 ? new UCWebClient(TimeOut) : new UCWebClient())
            {
                string GetPostURL = GetUrl.Substring(GetUrl.Length - 1, 1) == "/" ? GetUrl : GetUrl.IndexOf("?") < 0 ? GetUrl + "/" : GetUrl;
                GetPostURL = GetPostURL.IndexOf("?") < 0 ? GetPostURL + "?" : GetPostURL;
                string ParamDatas = "";

                //Parameters
                if (Parameters != null)
                    foreach (var item in Parameters)
                        ParamDatas += string.Format("{0}={1}&", item.Key, item.Value);
                ParamDatas = ParamDatas.TrimEnd('&');

                try
                {
                    //Headers
                    if (Headers != null)
                        foreach (var item in Headers)
                            HttpGet.Headers.Add(item.Key, item.Value);

                    //Common-Headers
                    HttpGet.Headers.Add("Accept", "*/*");
                    HttpGet.Headers.Add("Accept-Language", "en-US, en; q=0.8, zh-Hans-CN; q=0.5, zh-Hans; q=0.3");
                    HttpGet.Headers.Add("Cache-Control", "max-age=0");
                    HttpGet.Headers.Add("Host", new Uri(GetUrl).Host);

                    //Send-Headers
                    for (int i = 0; i < HttpGet.Headers.Count; i++)
                        OutSendHeaders.Add(HttpGet.Headers.GetKey(i), HttpGet.Headers.Get(i));

                    //Request
                    OutMessages = GetPostURL + ParamDatas;
                    byte[] ResponseDataBytes = new byte[] { };
                    if (IsPost)
                    {
                        HttpGet.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                        byte[] PostDataBytes = Encoding.GetEncoding(GetEncoding).GetBytes(IsPost ? ParamDatas : "");
                        ResponseDataBytes = HttpGet.UploadData(GetPostURL, "POST", PostDataBytes);
                    }
                    else
                        ResponseDataBytes = HttpGet.DownloadData(GetPostURL + ParamDatas);

                    HtmlSource = Encoding.GetEncoding(GetEncoding).GetString(ResponseDataBytes);

                    //Return-Headers
                    WebHeaderCollection HeadersCollection = HttpGet.ResponseHeaders;
                    for (int i = 0; i < HeadersCollection.Count; i++)
                        OutResultHeaders.Add(HeadersCollection.GetKey(i), HeadersCollection.Get(i));

                    return true;
                }
                catch (Exception ex) { OutMessages = GetPostURL + "^" + ParamDatas + "^" + ex.Message.ToString(); }
            }          

            return false;
        }
    }
}
