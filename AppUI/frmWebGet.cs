namespace SamZhengAPI.WebGet.AppUI
{
    #region Spaces
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Threading;
    using System.Windows.Forms;
    using Common;
    using Newtonsoft.Json;
    using Model;
    using System.Text.RegularExpressions;
    #endregion

    public partial class frmWebGet : Form
    {
        #region Variables
        private readonly string[] _Array_EncodingList = new string[] { "UTF-8", "GBK", "GB2312", "GB18030" };

        private Thread _Thread_WebGetting;        
        private Thread _Thread_GetVerifyCode;
        private Thread _Thread_GetSMS;
        private Thread _Thread_UserLogin;
        private Thread _Thread_UserRegister;        

        private bool _IsOnlineHost = true;
        private string _ObjectHost = "";
        private const string _Format_URL = "http://{0}/api/{1}/";
        #endregion

        #region Init
        public frmWebGet()
        {
            InitializeComponent();
        }
        #endregion

        #region Load
        private void frmWebGet_Load(object sender, EventArgs e)
        {
            //Thead
            CheckForIllegalCrossThreadCalls = false;

            //Event
            Activated += frmWebGet_Activated;
            KeyDown += frmWebGet_KeyDown;
            picVerifyCode.Click += picVerifyCode_Click;

            //Double-Click
            txtHeaderV1.DoubleClick += txtHeaderV1_DoubleClick;

            //Setting
            cmbHttpType.SelectedIndex = 0;
            cmbEncoding.SelectedIndex = 0;
            cmbLoginType.SelectedIndex = 0;
            txtHtmlSource.MaxLength = int.MaxValue;

            //Load APIs List
            foreach (var item in DataConfig.APIActionTypeList)
                cmbAPIAction.Items.Add(item.ActionText + " " + item.ActionName + " " + (item.ActionType == 1 ? "POST" : "GET"));
            cmbAPIAction.SelectedIndex = 0;

            //picVerifyCode_Click(new object(), new EventArgs());
        }

        private string GetHTTPSendURL(int Index)
        {
            return string.Format(_Format_URL, (_IsOnlineHost ? txtOnlineHost.Text : txtTestHost.Text), DataConfig.APIActionTypeList[Index].ActionName);
        }
        #endregion

        #region Events Process
        private void txtHeaderV1_DoubleClick(object sender, EventArgs e)
        {
            txtHeaderV1.SelectAll();
        }

        private void frmWebGet_Activated(object sender, EventArgs e)
        {
            cmbAPIAction.Focus();
        }

        //Key
        private void frmWebGet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F8)
                btnHtppSend_Click(new object(), new EventArgs());
        }
        #endregion

        #region Button - Verify Code
        private void picVerifyCode_Click(object sender, EventArgs e)
        {
            _Thread_GetVerifyCode = new Thread(() =>
            {
                #region Parameters/Headers
                IDictionary<string, string> SendParams = new Dictionary<string, string>() { };
                IDictionary<string, string> SendHeaders = ProcessSendHeaders();
                #endregion

                string GetURL = GetHTTPSendURL((int)APIActionType.GetVerifyCode);

                #region Process & Results
                bool IsSucceed = ProcessHTTPSend(GetURL, SendParams, SendHeaders, out string OutMessages, out string OutHtmlSource);
                if (IsSucceed && OutHtmlSource.Length > 0)
                {
                    var VerifyCode = JsonConvert.DeserializeObject<VerifyCodeInfo>(OutHtmlSource);
                    if (VerifyCode.StateCode.Equals(1) && VerifyCode.Info.VerifyImage.Length > 0)
                    {
                        txtVerifyKey.Text = VerifyCode.Info.VerifyKey;
                        picVerifyCode.Image = WinFun.Base64ToImage(VerifyCode.Info.VerifyImage);
                    }
                    else
                        WinFun.ShowMessageBox("获取验证码失败：" + VerifyCode.StateMessage);
                }
                #endregion

            });
            _Thread_GetVerifyCode.Start();
        }
        #endregion

        #region Button : Http Send
        private void btnHtppSend_Click(object sender, EventArgs e)
        {
            _Thread_WebGetting = new Thread(() =>
            {
                btnHtppSend.Enabled = false;

                #region Parameters/Headers
                IDictionary<string, string> SendParams = new Dictionary<string, string>() { };
                IDictionary<string, string> SendHeaders = ProcessSendHeaders();

                int Row = 1;
                foreach (Control item in gbParameters.Controls)
                {
                    if (item is TextBox && item.Name.IndexOf("txtParamN") > -1)
                    {
                        if (WinFun.FindControl(gbParameters, "txtParamN" + Row.ToString()) is TextBox CtTbKey && CtTbKey.Text.Trim().Length > 0 &&
                            WinFun.FindControl(gbParameters, "txtParamV" + Row.ToString()) is TextBox CtTbValue && CtTbValue.Text.Trim().Length > 0)
                            SendParams.Add(CtTbKey.Text.Trim(), CtTbValue.Text.Trim());
                        Row++;
                    }
                }
                #endregion

                #region Process & Results
                switch (cmbAPIAction.SelectedIndex)
                {
                    case (int)APIActionType.GetVerifyCode: picVerifyCode_Click(new object(), new EventArgs());break;
                    case (int)APIActionType.GetSMS: btnGetLoginSMS_Click(new object(), new EventArgs()); break;
                    case (int)APIActionType.UserLogin: btnUserLogin_Click(new object(), new EventArgs()); break;
                    case (int)APIActionType.UserRegister: btnGetRegisterSMS_Click(new object(), new EventArgs()); break;
                    default:
                        ProcessHTTPSend(GetHTTPSendURL(cmbAPIAction.SelectedIndex), SendParams, SendHeaders, out string OutMessages, out string OutHtmlSource);
                        break;
                }
                #endregion

                btnHtppSend.Enabled = true;
            });
            _Thread_WebGetting.Start();
        }
        #endregion

        #region Process HTTP Send / Result
        private bool ProcessHTTPSend(string GetURL,
            IDictionary<string, string> SendParams,
            IDictionary<string, string> SendHeaders,
            out string OutMessages,
            out string OutHtmlSource)
        {
            txtOptionTips.Text = "";
            txtHtmlSource.Text = "";
            txtResultHeaders.Text = "";

            bool IsSucceed = false;
            bool IsPost = cmbHttpType.SelectedIndex == 1 ? true : false;
            OutMessages = "";
            OutHtmlSource = "";

            IDictionary<string, string> OutSendHeaders = new Dictionary<string, string>() { };
            IDictionary<string, string> OutResultHeaders = new Dictionary<string, string>() { };

            if (WinFun.CheckIsUrl(GetURL))
            {
                txtOptionTips.AppendText(FormatResultData("请求：" + GetURL + "\r\n"));
                if (IsPost)
                {
                    IsSucceed = HttpFun.DoWebPost(
                            GetURL,
                            "",
                            FormatGetTimeout(),
                            _Array_EncodingList[cmbEncoding.SelectedIndex],
                            SendParams,
                            SendHeaders,
                            out OutSendHeaders,
                            out OutResultHeaders,
                            out OutHtmlSource,
                            out OutMessages
                        );
                }
                else
                {
                    IsSucceed = HttpFun.DoWebGet(
                        GetURL,
                            FormatGetTimeout(),
                            _Array_EncodingList[cmbEncoding.SelectedIndex],
                            SendParams,
                            SendHeaders,
                            out OutSendHeaders,
                            out OutResultHeaders,
                            out OutHtmlSource,
                            out OutMessages
                        );
                }

                txtOptionTips.AppendText(FormatResultData("URL：" + OutMessages + "\r\n"));
                if (IsSucceed)
                {
                    txtOptionTips.AppendText(FormatResultData("结果：成功。\r\n"));
                    txtOptionTips.AppendText(FormatResultData("字数：" + OutHtmlSource.Length.ToString() + "\r\n"));
                    txtHtmlSource.Text = OutHtmlSource;
                }
                else
                    txtOptionTips.AppendText("结果：失败。" + OutMessages + "\r\n");

                #region Headers Show
                txtResultHeaders.AppendText("请求Headers：\r\n");
                foreach (var item in OutSendHeaders)
                    txtResultHeaders.AppendText(item.Key + ": " + item.Value + "\r\n");

                txtResultHeaders.AppendText("\r\n返回Headers：\r\n");

                foreach (var item in OutResultHeaders)
                    txtResultHeaders.AppendText(item.Key + ": " + item.Value + "\r\n");
                #endregion

            }
            else WinFun.ShowMessageBox("请求URL无效。");

            return IsSucceed;
        }
        #endregion

        #region Process Params
        private string FormatResultData(string str)
        {
            return DateTime.Now.ToString("HH:mm:ss") + " " + str;
        }

        private int FormatGetTimeout()
        {
            txtHttpTimeOut.Text = WinFun.RemoveSpace(txtHttpTimeOut.Text).Trim();
            return WinFun.GetInt32(txtHttpTimeOut.Text.Replace("毫秒", ""));
        }
        #endregion

        #region Process Send-Headers
        private IDictionary<string, string> ProcessSendHeaders()
        {
            int Row = 1;
            IDictionary<string, string> SendHeaders = new Dictionary<string, string>() { };
            foreach (Control item in gbHeaders.Controls)
            {
                if (item is TextBox && item.Name.IndexOf("txtHeaderN") > -1)
                {
                    if (WinFun.FindControl(gbHeaders, "txtHeaderN" + Row.ToString()) is TextBox CtTbKey && CtTbKey.Text.Trim().Length > 0 &&
                        WinFun.FindControl(gbHeaders, "txtHeaderV" + Row.ToString()) is TextBox CtTbValue && CtTbValue.Text.Trim().Length > 0)
                        SendHeaders.Add(CtTbKey.Text.Trim(), CtTbValue.Text.Trim());
                    Row++;
                }
            }
            if (txtUserAgent.Text.Trim().Length > 0)
                SendHeaders.Add("User-Agent", txtUserAgent.Text.Trim());

            return SendHeaders;
        }
        #endregion

        #region Button : Login
        private void btnUserLogin_Click(object sender, EventArgs e)
        {
            _Thread_UserLogin = new Thread(() =>
            {
                btnUserLogin.Enabled = false;

                #region Parameters/Headers
                IDictionary<string, string> SendParams = new Dictionary<string, string>() { };
                IDictionary<string, string> SendHeaders = ProcessSendHeaders();

                SendParams.Add("UserName", txtLoginUser.Text.Trim());
                SendParams.Add("Type", cmbLoginType.SelectedIndex == 1 ? "1" : "0");
                SendParams.Add("Password", WinFun.StringToBase64(txtLoginPassword.Text.Trim()));
                SendParams.Add("MobileCode", txtLoginMobileCode.Text.Trim());
                SendParams.Add("VerifyKey", txtVerifyKey.Text.Trim());
                SendParams.Add("VerifyCode", txtLoginVerifyCode.Text.Trim());
                #endregion

                #region Process & Results
                bool IsSucceed = ProcessHTTPSend(GetHTTPSendURL((int)APIActionType.UserLogin), SendParams, SendHeaders, out string OutMessages, out string OutHtmlSource);
                if (IsSucceed && OutHtmlSource.Length > 0)
                {
                    UserTokenResult ResultInfo = null;
                    UserTokenResultError ResultInfoError = null;

                    try { ResultInfo = JsonConvert.DeserializeObject<UserTokenResult>(OutHtmlSource); }
                    catch { }

                    try { ResultInfoError = JsonConvert.DeserializeObject<UserTokenResultError>(OutHtmlSource); }
                    catch { }

                    if (ResultInfo != null)
                        if (ResultInfo.StateCode.Equals(1))
                        {
                            txtParamV1.Text = ResultInfo.Info.Token;
                            txtHeaderV1.Text = ResultInfo.Info.Token;
                            WinFun.ShowMessageBox("登录成功");
                        }
                        else WinFun.ShowMessageBox("登录失败，" + ResultInfo.StateMessage);
                    else
                    {
                        if (ResultInfoError != null)
                        {
                            StringBuilder SbResults = new StringBuilder();
                            foreach (var item in ResultInfoError.Info)
                                SbResults.Append(item.Code.ToString() + "：" + item.Message + "\r");

                            WinFun.ShowMessageBox("登录失败，\r" + SbResults.ToString());
                        }
                        else
                            WinFun.ShowMessageBox("登录失败，远程返回状态不正确");
                    }
                }
                else WinFun.ShowMessageBox(OutMessages);
                #endregion

                btnUserLogin.Enabled = true;
            });
            _Thread_UserLogin.Start();
        }
        #endregion

        #region Button : Register
        private void btnUserRegister_Click(object sender, EventArgs e)
        {
            _Thread_UserRegister = new Thread(() =>
            {
                btnUserRegister.Enabled = false;

                #region Parameters/Headers
                IDictionary<string, string> SendParams = new Dictionary<string, string>() { };
                IDictionary<string, string> SendHeaders = ProcessSendHeaders();

                SendParams.Add("UserName", txtLoginUser.Text.Trim());
                SendParams.Add("Password", WinFun.StringToBase64(txtLoginPassword.Text.Trim()));
                SendParams.Add("MobileCode", txtLoginMobileCode.Text.Trim());
                SendParams.Add("VerifyKey", txtVerifyKey.Text.Trim());
                SendParams.Add("VerifyCode", txtLoginVerifyCode.Text.Trim());
                #endregion

                #region Process & Results
                bool IsSucceed = ProcessHTTPSend(GetHTTPSendURL((int)APIActionType.UserRegister), SendParams, SendHeaders, out string OutMessages, out string OutHtmlSource);
                if (IsSucceed && OutHtmlSource.Length > 0)
                {
                    UserTokenResult ResultInfo = null;
                    UserTokenResultError ResultInfoError = null;

                    try { ResultInfo = JsonConvert.DeserializeObject<UserTokenResult>(OutHtmlSource); }
                    catch { }

                    try { ResultInfoError = JsonConvert.DeserializeObject<UserTokenResultError>(OutHtmlSource); }
                    catch { }

                    if (ResultInfo != null)
                        if (ResultInfo.StateCode.Equals(1))
                        {
                            //txtParamV1.Text = ResultInfo.Info.Token;
                            //txtHeaderV1.Text = ResultInfo.Info.Token;
                            WinFun.ShowMessageBox("注册成功");
                        }
                        else WinFun.ShowMessageBox("注册失败，" + ResultInfo.StateMessage);
                    else
                    {
                        if (ResultInfoError != null)
                        {
                            StringBuilder SbResults = new StringBuilder();
                            foreach (var item in ResultInfoError.Info)
                                SbResults.Append(item.Code.ToString() + "：" + item.Message + "\r");

                            WinFun.ShowMessageBox("注册失败，\r" + SbResults.ToString());
                        }
                        else
                            WinFun.ShowMessageBox("注册失败，远程返回状态不正确");
                    }
                }
                else WinFun.ShowMessageBox(OutMessages);
                #endregion

                btnUserRegister.Enabled = true;
            });
            _Thread_UserRegister.Start();
        }
        #endregion

        #region Button - Swap Host
        private void btnSwapHost_Click(object sender, EventArgs e)
        {
            if (_IsOnlineHost)
            {
                _ObjectHost = txtTestHost.Text.Trim();
                btnSwapHost.Text = "转正式域名";
                _IsOnlineHost = false;
            }
            else
            {
                _ObjectHost = txtOnlineHost.Text.Trim();
                btnSwapHost.Text = "转测试域名";
                _IsOnlineHost = true;
            }
        }
        #endregion

        #region Button : SMS
        private void btnGetLoginSMS_Click(object sender, EventArgs e)
        {
            GetSMSend("UserLogin", btnGetLoginSMS);
        }

        private void GetSMSend(string GetType, Button ObjButton)
        {
            ObjButton.Enabled = false;
            _Thread_GetSMS = new Thread(() =>
            {
                #region Parameters/Headers
                IDictionary<string, string> SendParams = new Dictionary<string, string>() { };
                IDictionary<string, string> SendHeaders = ProcessSendHeaders();

                SendParams.Add("Type", GetType);
                SendParams.Add("Mobile", txtLoginUser.Text.Trim());
                SendParams.Add("VerifyKey", txtVerifyKey.Text.Trim());
                SendParams.Add("VerifyCode", txtLoginVerifyCode.Text.Trim());
                #endregion

                bool IsSucceed = ProcessHTTPSend(GetHTTPSendURL((int)APIActionType.GetSMS), SendParams, SendHeaders, out string OutMessages, out string OutHtmlSource);
                if (IsSucceed && OutHtmlSource.Length > 0)
                {

                }
            });
            _Thread_GetSMS.Start();
            ObjButton.Enabled = true;
        }

        private void btnGetRegisterSMS_Click(object sender, EventArgs e)
        {
            GetSMSend("UserRegister", btnGetRegisterSMS);
        }
        #endregion

        #region Action Changed
        private void cmbAPIAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            APIActionData ActionInfo = DataConfig.APIActionTypeList[cmbAPIAction.SelectedIndex];
            cmbHttpType.SelectedIndex = ActionInfo.ActionType;
        }
        #endregion
    }
}
