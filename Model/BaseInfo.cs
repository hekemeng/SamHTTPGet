namespace SamZhengAPI.WebGet.Model
{
    using System;
    using System.Collections.Generic;

    #region Data
    public class DataConfig
    {
        public static readonly IList<APIActionData> APIActionTypeList = new List<APIActionData>()
        {
            new APIActionData(){ ActionText="验证码", ActionName="Common/VerifyCode",ActionType = 0 },
            new APIActionData(){ ActionText="短信动态码", ActionName="/Common/SMS",ActionType = 0 },
            new APIActionData(){ ActionText="会员登录", ActionName="User/Login",ActionType = 0 },
            new APIActionData(){ ActionText="会员注册", ActionName="User/Register",ActionType = 0 },
            new APIActionData(){ ActionText="会员信息", ActionName="User/Info",ActionType = 1 }
        };
    }

    public enum APIActionType
    {
        GetVerifyCode = 0,
        GetSMS = 1,
        UserLogin = 2,
        UserRegister = 3,
        GetUserInfo = 4
    }
    #endregion

    #region Model - Common
    public class APIActionData
    {
        public int ActionType { get; set; }
        public string ActionName { get; set; }
        public string ActionText { get; set; }
    }

    public class APIResult
    {
        public int StateCode { get; set; }
        public string StateMessage { get; set; }
        public DateTime APITime { get; set; }
        public object Info { get; set; }
    }


    public class VerifyCodeInfo
    {
        public int StateCode { get; set; }
        public string StateMessage { get; set; }
        public DateTime APITime { get; set; }
        public Info Info { get; set; }
    }

    public class Info
    {
        public string VerifyKey { get; set; }
        public string VerifyImage { get; set; }
    }
    #endregion

    #region Model - User-Token Result
    public class UserTokenResult
    {
        public int StateCode { get; set; }
        public string StateMessage { get; set; }
        public DateTime APITime { get; set; }
        public UserTokenSingle Info { get; set; }
    }

    public class UserTokenResultError
    {
        public int StateCode { get; set; }
        public string StateMessage { get; set; }
        public DateTime APITime { get; set; }
        public List<APIOutResultData> Info { get; set; }
    }

    public class APIOutResultData
    {
        public int Code { get; set; }
        public string Message { get; set; }
    }

    public class UserTokenSingle
    {
        public string Token { get; set; }
        public int Expire { get; set; }
    }
    #endregion



}
