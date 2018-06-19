namespace SamZhengAPI.WebGet.Common.UC
{
    #region Spaces
    using System;
    using System.Net;
    #endregion

    public class UCWebClient : WebClient
    {
        /// <summary>
        /// 超时时间(毫秒)
        /// </summary>
        public int _Timeout { get; set; }

        public UCWebClient()
        {
            _Timeout = 60000;
        }

        public UCWebClient(int timeout)
        {
            _Timeout = timeout;
        }

        protected override WebRequest GetWebRequest(Uri address)
        {
            var result = base.GetWebRequest(address);
            result.Timeout = _Timeout;
            return result;
        }
    }
}
