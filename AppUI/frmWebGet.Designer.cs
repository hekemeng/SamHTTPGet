namespace SamZhengAPI.WebGet.AppUI
{
    partial class frmWebGet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWebGet));
            this.gbBaseInfo = new System.Windows.Forms.GroupBox();
            this.txtUserAgent = new System.Windows.Forms.TextBox();
            this.lblUserAgent = new System.Windows.Forms.Label();
            this.txtHttpTimeOut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHttpURL = new System.Windows.Forms.Label();
            this.lblEncoding = new System.Windows.Forms.Label();
            this.cmbEncoding = new System.Windows.Forms.ComboBox();
            this.lblHttpType = new System.Windows.Forms.Label();
            this.cmbHttpType = new System.Windows.Forms.ComboBox();
            this.ssStatusBar = new System.Windows.Forms.StatusStrip();
            this.ssStatusBar_Info = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbParameters = new System.Windows.Forms.GroupBox();
            this.txtParamV4 = new System.Windows.Forms.TextBox();
            this.txtParamN4 = new System.Windows.Forms.TextBox();
            this.txtParamV3 = new System.Windows.Forms.TextBox();
            this.txtParamN3 = new System.Windows.Forms.TextBox();
            this.txtParamV2 = new System.Windows.Forms.TextBox();
            this.txtParamN2 = new System.Windows.Forms.TextBox();
            this.txtParamV1 = new System.Windows.Forms.TextBox();
            this.lblParamValue = new System.Windows.Forms.Label();
            this.txtParamN1 = new System.Windows.Forms.TextBox();
            this.lblParamName = new System.Windows.Forms.Label();
            this.gbHeaders = new System.Windows.Forms.GroupBox();
            this.txtHeaderV4 = new System.Windows.Forms.TextBox();
            this.txtHeaderN4 = new System.Windows.Forms.TextBox();
            this.txtHeaderV3 = new System.Windows.Forms.TextBox();
            this.txtHeaderN3 = new System.Windows.Forms.TextBox();
            this.txtHeaderV2 = new System.Windows.Forms.TextBox();
            this.txtHeaderN2 = new System.Windows.Forms.TextBox();
            this.txtHeaderV1 = new System.Windows.Forms.TextBox();
            this.lblHeaderValue = new System.Windows.Forms.Label();
            this.txtHeaderN1 = new System.Windows.Forms.TextBox();
            this.lblHeaderName = new System.Windows.Forms.Label();
            this.btnHtppSend = new System.Windows.Forms.Button();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.txtOptionTips = new System.Windows.Forms.TextBox();
            this.lblHtmlSource = new System.Windows.Forms.Label();
            this.lblResultHeaders = new System.Windows.Forms.Label();
            this.txtHtmlSource = new System.Windows.Forms.TextBox();
            this.txtResultHeaders = new System.Windows.Forms.TextBox();
            this.gbLoginRegister = new System.Windows.Forms.GroupBox();
            this.btnGetLoginSMS = new System.Windows.Forms.Button();
            this.picVerifyCode = new System.Windows.Forms.PictureBox();
            this.btnUserRegister = new System.Windows.Forms.Button();
            this.cmbLoginType = new System.Windows.Forms.ComboBox();
            this.lblLoginType = new System.Windows.Forms.Label();
            this.lblLoginMobileCode = new System.Windows.Forms.Label();
            this.txtLoginMobileCode = new System.Windows.Forms.TextBox();
            this.lblLoginVerifyCode = new System.Windows.Forms.Label();
            this.txtLoginVerifyCode = new System.Windows.Forms.TextBox();
            this.btnUserLogin = new System.Windows.Forms.Button();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.lblLoginPassword = new System.Windows.Forms.Label();
            this.lbLoginUser = new System.Windows.Forms.Label();
            this.txtLoginUser = new System.Windows.Forms.TextBox();
            this.txtOnlineHost = new System.Windows.Forms.TextBox();
            this.gbSetting = new System.Windows.Forms.GroupBox();
            this.lblTestHost = new System.Windows.Forms.Label();
            this.lblOnlineHost = new System.Windows.Forms.Label();
            this.txtTestHost = new System.Windows.Forms.TextBox();
            this.btnSwapHost = new System.Windows.Forms.Button();
            this.btnGetRegisterSMS = new System.Windows.Forms.Button();
            this.cmbAPIAction = new System.Windows.Forms.ComboBox();
            this.txtVerifyKey = new System.Windows.Forms.TextBox();
            this.gbBaseInfo.SuspendLayout();
            this.ssStatusBar.SuspendLayout();
            this.gbParameters.SuspendLayout();
            this.gbHeaders.SuspendLayout();
            this.gbResult.SuspendLayout();
            this.gbLoginRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVerifyCode)).BeginInit();
            this.gbSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBaseInfo
            // 
            this.gbBaseInfo.Controls.Add(this.cmbAPIAction);
            this.gbBaseInfo.Controls.Add(this.txtUserAgent);
            this.gbBaseInfo.Controls.Add(this.lblUserAgent);
            this.gbBaseInfo.Controls.Add(this.txtHttpTimeOut);
            this.gbBaseInfo.Controls.Add(this.label1);
            this.gbBaseInfo.Controls.Add(this.lblHttpURL);
            this.gbBaseInfo.Controls.Add(this.lblEncoding);
            this.gbBaseInfo.Controls.Add(this.cmbEncoding);
            this.gbBaseInfo.Controls.Add(this.lblHttpType);
            this.gbBaseInfo.Controls.Add(this.cmbHttpType);
            this.gbBaseInfo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.gbBaseInfo.Location = new System.Drawing.Point(12, 12);
            this.gbBaseInfo.Name = "gbBaseInfo";
            this.gbBaseInfo.Size = new System.Drawing.Size(753, 88);
            this.gbBaseInfo.TabIndex = 0;
            this.gbBaseInfo.TabStop = false;
            this.gbBaseInfo.Text = "基本信息 Info";
            // 
            // txtUserAgent
            // 
            this.txtUserAgent.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUserAgent.Location = new System.Drawing.Point(194, 54);
            this.txtUserAgent.Name = "txtUserAgent";
            this.txtUserAgent.Size = new System.Drawing.Size(553, 23);
            this.txtUserAgent.TabIndex = 10;
            this.txtUserAgent.Text = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) " +
    "Chrome/64.0.3282.140 Safari/537.36 Edge/17.17134";
            // 
            // lblUserAgent
            // 
            this.lblUserAgent.AutoSize = true;
            this.lblUserAgent.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUserAgent.Location = new System.Drawing.Point(158, 59);
            this.lblUserAgent.Name = "lblUserAgent";
            this.lblUserAgent.Size = new System.Drawing.Size(37, 17);
            this.lblUserAgent.TabIndex = 9;
            this.lblUserAgent.Text = "UA：";
            // 
            // txtHttpTimeOut
            // 
            this.txtHttpTimeOut.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtHttpTimeOut.Location = new System.Drawing.Point(194, 24);
            this.txtHttpTimeOut.Name = "txtHttpTimeOut";
            this.txtHttpTimeOut.Size = new System.Drawing.Size(72, 23);
            this.txtHttpTimeOut.TabIndex = 8;
            this.txtHttpTimeOut.Text = "6000毫秒";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(153, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "超时：";
            // 
            // lblHttpURL
            // 
            this.lblHttpURL.AutoSize = true;
            this.lblHttpURL.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblHttpURL.Location = new System.Drawing.Point(278, 28);
            this.lblHttpURL.Name = "lblHttpURL";
            this.lblHttpURL.Size = new System.Drawing.Size(44, 17);
            this.lblHttpURL.TabIndex = 5;
            this.lblHttpURL.Text = "接口：";
            // 
            // lblEncoding
            // 
            this.lblEncoding.AutoSize = true;
            this.lblEncoding.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEncoding.Location = new System.Drawing.Point(7, 54);
            this.lblEncoding.Name = "lblEncoding";
            this.lblEncoding.Size = new System.Drawing.Size(44, 17);
            this.lblEncoding.TabIndex = 4;
            this.lblEncoding.Text = "编码：";
            // 
            // cmbEncoding
            // 
            this.cmbEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEncoding.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEncoding.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbEncoding.FormattingEnabled = true;
            this.cmbEncoding.Items.AddRange(new object[] {
            "UTF-8",
            "GBK",
            "GB2312",
            "GB18030"});
            this.cmbEncoding.Location = new System.Drawing.Point(51, 51);
            this.cmbEncoding.Name = "cmbEncoding";
            this.cmbEncoding.Size = new System.Drawing.Size(93, 25);
            this.cmbEncoding.TabIndex = 3;
            // 
            // lblHttpType
            // 
            this.lblHttpType.AutoSize = true;
            this.lblHttpType.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblHttpType.Location = new System.Drawing.Point(7, 27);
            this.lblHttpType.Name = "lblHttpType";
            this.lblHttpType.Size = new System.Drawing.Size(44, 17);
            this.lblHttpType.TabIndex = 2;
            this.lblHttpType.Text = "协议：";
            // 
            // cmbHttpType
            // 
            this.cmbHttpType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHttpType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbHttpType.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbHttpType.FormattingEnabled = true;
            this.cmbHttpType.Items.AddRange(new object[] {
            "GET",
            "POST"});
            this.cmbHttpType.Location = new System.Drawing.Point(51, 24);
            this.cmbHttpType.Name = "cmbHttpType";
            this.cmbHttpType.Size = new System.Drawing.Size(93, 25);
            this.cmbHttpType.TabIndex = 0;
            // 
            // ssStatusBar
            // 
            this.ssStatusBar.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ssStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssStatusBar_Info});
            this.ssStatusBar.Location = new System.Drawing.Point(0, 649);
            this.ssStatusBar.Name = "ssStatusBar";
            this.ssStatusBar.Size = new System.Drawing.Size(1148, 22);
            this.ssStatusBar.TabIndex = 1;
            this.ssStatusBar.Text = "statusStrip1";
            // 
            // ssStatusBar_Info
            // 
            this.ssStatusBar_Info.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ssStatusBar_Info.Name = "ssStatusBar_Info";
            this.ssStatusBar_Info.Size = new System.Drawing.Size(56, 17);
            this.ssStatusBar_Info.Text = "准备就绪";
            // 
            // gbParameters
            // 
            this.gbParameters.Controls.Add(this.txtParamV4);
            this.gbParameters.Controls.Add(this.txtParamN4);
            this.gbParameters.Controls.Add(this.txtParamV3);
            this.gbParameters.Controls.Add(this.txtParamN3);
            this.gbParameters.Controls.Add(this.txtParamV2);
            this.gbParameters.Controls.Add(this.txtParamN2);
            this.gbParameters.Controls.Add(this.txtParamV1);
            this.gbParameters.Controls.Add(this.lblParamValue);
            this.gbParameters.Controls.Add(this.txtParamN1);
            this.gbParameters.Controls.Add(this.lblParamName);
            this.gbParameters.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.gbParameters.Location = new System.Drawing.Point(12, 111);
            this.gbParameters.Name = "gbParameters";
            this.gbParameters.Size = new System.Drawing.Size(429, 161);
            this.gbParameters.TabIndex = 2;
            this.gbParameters.TabStop = false;
            this.gbParameters.Text = "请求参数 Parameters";
            // 
            // txtParamV4
            // 
            this.txtParamV4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtParamV4.Location = new System.Drawing.Point(82, 128);
            this.txtParamV4.Name = "txtParamV4";
            this.txtParamV4.Size = new System.Drawing.Size(335, 23);
            this.txtParamV4.TabIndex = 15;
            // 
            // txtParamN4
            // 
            this.txtParamN4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtParamN4.Location = new System.Drawing.Point(11, 128);
            this.txtParamN4.Name = "txtParamN4";
            this.txtParamN4.Size = new System.Drawing.Size(65, 23);
            this.txtParamN4.TabIndex = 14;
            // 
            // txtParamV3
            // 
            this.txtParamV3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtParamV3.Location = new System.Drawing.Point(82, 99);
            this.txtParamV3.Name = "txtParamV3";
            this.txtParamV3.Size = new System.Drawing.Size(335, 23);
            this.txtParamV3.TabIndex = 13;
            // 
            // txtParamN3
            // 
            this.txtParamN3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtParamN3.Location = new System.Drawing.Point(11, 99);
            this.txtParamN3.Name = "txtParamN3";
            this.txtParamN3.Size = new System.Drawing.Size(65, 23);
            this.txtParamN3.TabIndex = 12;
            // 
            // txtParamV2
            // 
            this.txtParamV2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtParamV2.Location = new System.Drawing.Point(82, 70);
            this.txtParamV2.Name = "txtParamV2";
            this.txtParamV2.Size = new System.Drawing.Size(335, 23);
            this.txtParamV2.TabIndex = 11;
            // 
            // txtParamN2
            // 
            this.txtParamN2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtParamN2.Location = new System.Drawing.Point(11, 70);
            this.txtParamN2.Name = "txtParamN2";
            this.txtParamN2.Size = new System.Drawing.Size(65, 23);
            this.txtParamN2.TabIndex = 10;
            // 
            // txtParamV1
            // 
            this.txtParamV1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtParamV1.Location = new System.Drawing.Point(82, 42);
            this.txtParamV1.Name = "txtParamV1";
            this.txtParamV1.Size = new System.Drawing.Size(335, 23);
            this.txtParamV1.TabIndex = 9;
            this.txtParamV1.Text = "a1f6798a-b3e3-4c91-ab88-3a5c0597834b";
            // 
            // lblParamValue
            // 
            this.lblParamValue.AutoSize = true;
            this.lblParamValue.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblParamValue.Location = new System.Drawing.Point(126, 25);
            this.lblParamValue.Name = "lblParamValue";
            this.lblParamValue.Size = new System.Drawing.Size(44, 17);
            this.lblParamValue.TabIndex = 8;
            this.lblParamValue.Text = "参数值";
            // 
            // txtParamN1
            // 
            this.txtParamN1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtParamN1.Location = new System.Drawing.Point(11, 42);
            this.txtParamN1.Name = "txtParamN1";
            this.txtParamN1.Size = new System.Drawing.Size(65, 23);
            this.txtParamN1.TabIndex = 7;
            this.txtParamN1.Text = "token";
            // 
            // lblParamName
            // 
            this.lblParamName.AutoSize = true;
            this.lblParamName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblParamName.Location = new System.Drawing.Point(9, 25);
            this.lblParamName.Name = "lblParamName";
            this.lblParamName.Size = new System.Drawing.Size(56, 17);
            this.lblParamName.TabIndex = 0;
            this.lblParamName.Text = "参数名称";
            // 
            // gbHeaders
            // 
            this.gbHeaders.Controls.Add(this.txtHeaderV4);
            this.gbHeaders.Controls.Add(this.txtHeaderN4);
            this.gbHeaders.Controls.Add(this.txtHeaderV3);
            this.gbHeaders.Controls.Add(this.txtHeaderN3);
            this.gbHeaders.Controls.Add(this.txtHeaderV2);
            this.gbHeaders.Controls.Add(this.txtHeaderN2);
            this.gbHeaders.Controls.Add(this.txtHeaderV1);
            this.gbHeaders.Controls.Add(this.lblHeaderValue);
            this.gbHeaders.Controls.Add(this.txtHeaderN1);
            this.gbHeaders.Controls.Add(this.lblHeaderName);
            this.gbHeaders.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.gbHeaders.Location = new System.Drawing.Point(454, 111);
            this.gbHeaders.Name = "gbHeaders";
            this.gbHeaders.Size = new System.Drawing.Size(430, 161);
            this.gbHeaders.TabIndex = 14;
            this.gbHeaders.TabStop = false;
            this.gbHeaders.Text = "请求Headers";
            // 
            // txtHeaderV4
            // 
            this.txtHeaderV4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtHeaderV4.Location = new System.Drawing.Point(84, 127);
            this.txtHeaderV4.Name = "txtHeaderV4";
            this.txtHeaderV4.Size = new System.Drawing.Size(335, 23);
            this.txtHeaderV4.TabIndex = 15;
            // 
            // txtHeaderN4
            // 
            this.txtHeaderN4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtHeaderN4.Location = new System.Drawing.Point(13, 127);
            this.txtHeaderN4.Name = "txtHeaderN4";
            this.txtHeaderN4.Size = new System.Drawing.Size(65, 23);
            this.txtHeaderN4.TabIndex = 14;
            // 
            // txtHeaderV3
            // 
            this.txtHeaderV3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtHeaderV3.Location = new System.Drawing.Point(84, 99);
            this.txtHeaderV3.Name = "txtHeaderV3";
            this.txtHeaderV3.Size = new System.Drawing.Size(335, 23);
            this.txtHeaderV3.TabIndex = 13;
            // 
            // txtHeaderN3
            // 
            this.txtHeaderN3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtHeaderN3.Location = new System.Drawing.Point(13, 99);
            this.txtHeaderN3.Name = "txtHeaderN3";
            this.txtHeaderN3.Size = new System.Drawing.Size(65, 23);
            this.txtHeaderN3.TabIndex = 12;
            // 
            // txtHeaderV2
            // 
            this.txtHeaderV2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtHeaderV2.Location = new System.Drawing.Point(84, 70);
            this.txtHeaderV2.Name = "txtHeaderV2";
            this.txtHeaderV2.Size = new System.Drawing.Size(335, 23);
            this.txtHeaderV2.TabIndex = 11;
            // 
            // txtHeaderN2
            // 
            this.txtHeaderN2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtHeaderN2.Location = new System.Drawing.Point(13, 70);
            this.txtHeaderN2.Name = "txtHeaderN2";
            this.txtHeaderN2.Size = new System.Drawing.Size(65, 23);
            this.txtHeaderN2.TabIndex = 10;
            // 
            // txtHeaderV1
            // 
            this.txtHeaderV1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtHeaderV1.Location = new System.Drawing.Point(83, 42);
            this.txtHeaderV1.Name = "txtHeaderV1";
            this.txtHeaderV1.Size = new System.Drawing.Size(335, 23);
            this.txtHeaderV1.TabIndex = 9;
            this.txtHeaderV1.Text = "a1f6798a-b3e3-4c91-ab88-3a5c0597834b";
            // 
            // lblHeaderValue
            // 
            this.lblHeaderValue.AutoSize = true;
            this.lblHeaderValue.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblHeaderValue.Location = new System.Drawing.Point(126, 25);
            this.lblHeaderValue.Name = "lblHeaderValue";
            this.lblHeaderValue.Size = new System.Drawing.Size(63, 17);
            this.lblHeaderValue.TabIndex = 8;
            this.lblHeaderValue.Text = "Header值";
            // 
            // txtHeaderN1
            // 
            this.txtHeaderN1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtHeaderN1.Location = new System.Drawing.Point(12, 42);
            this.txtHeaderN1.Name = "txtHeaderN1";
            this.txtHeaderN1.Size = new System.Drawing.Size(65, 23);
            this.txtHeaderN1.TabIndex = 7;
            this.txtHeaderN1.Text = "token";
            // 
            // lblHeaderName
            // 
            this.lblHeaderName.AutoSize = true;
            this.lblHeaderName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblHeaderName.Location = new System.Drawing.Point(10, 25);
            this.lblHeaderName.Name = "lblHeaderName";
            this.lblHeaderName.Size = new System.Drawing.Size(75, 17);
            this.lblHeaderName.TabIndex = 0;
            this.lblHeaderName.Text = "Header名称";
            // 
            // btnHtppSend
            // 
            this.btnHtppSend.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnHtppSend.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnHtppSend.Location = new System.Drawing.Point(771, 25);
            this.btnHtppSend.Name = "btnHtppSend";
            this.btnHtppSend.Size = new System.Drawing.Size(102, 75);
            this.btnHtppSend.TabIndex = 15;
            this.btnHtppSend.Text = "发送请求(F8)";
            this.btnHtppSend.UseVisualStyleBackColor = true;
            this.btnHtppSend.Click += new System.EventHandler(this.btnHtppSend_Click);
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.txtOptionTips);
            this.gbResult.Controls.Add(this.lblHtmlSource);
            this.gbResult.Controls.Add(this.lblResultHeaders);
            this.gbResult.Controls.Add(this.txtHtmlSource);
            this.gbResult.Controls.Add(this.txtResultHeaders);
            this.gbResult.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.gbResult.Location = new System.Drawing.Point(12, 283);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(872, 355);
            this.gbResult.TabIndex = 16;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "结果 Result";
            // 
            // txtOptionTips
            // 
            this.txtOptionTips.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtOptionTips.Location = new System.Drawing.Point(8, 220);
            this.txtOptionTips.Multiline = true;
            this.txtOptionTips.Name = "txtOptionTips";
            this.txtOptionTips.ReadOnly = true;
            this.txtOptionTips.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOptionTips.Size = new System.Drawing.Size(421, 126);
            this.txtOptionTips.TabIndex = 16;
            // 
            // lblHtmlSource
            // 
            this.lblHtmlSource.AutoSize = true;
            this.lblHtmlSource.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblHtmlSource.Location = new System.Drawing.Point(444, 19);
            this.lblHtmlSource.Name = "lblHtmlSource";
            this.lblHtmlSource.Size = new System.Drawing.Size(111, 17);
            this.lblHtmlSource.TabIndex = 15;
            this.lblHtmlSource.Text = "Response Body：";
            // 
            // lblResultHeaders
            // 
            this.lblResultHeaders.AutoSize = true;
            this.lblResultHeaders.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblResultHeaders.Location = new System.Drawing.Point(7, 19);
            this.lblResultHeaders.Name = "lblResultHeaders";
            this.lblResultHeaders.Size = new System.Drawing.Size(69, 17);
            this.lblResultHeaders.TabIndex = 14;
            this.lblResultHeaders.Text = "Headers：";
            // 
            // txtHtmlSource
            // 
            this.txtHtmlSource.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtHtmlSource.Location = new System.Drawing.Point(442, 39);
            this.txtHtmlSource.Multiline = true;
            this.txtHtmlSource.Name = "txtHtmlSource";
            this.txtHtmlSource.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHtmlSource.Size = new System.Drawing.Size(418, 307);
            this.txtHtmlSource.TabIndex = 1;
            // 
            // txtResultHeaders
            // 
            this.txtResultHeaders.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtResultHeaders.Location = new System.Drawing.Point(8, 39);
            this.txtResultHeaders.Multiline = true;
            this.txtResultHeaders.Name = "txtResultHeaders";
            this.txtResultHeaders.ReadOnly = true;
            this.txtResultHeaders.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultHeaders.Size = new System.Drawing.Size(421, 166);
            this.txtResultHeaders.TabIndex = 0;
            // 
            // gbLoginRegister
            // 
            this.gbLoginRegister.Controls.Add(this.txtVerifyKey);
            this.gbLoginRegister.Controls.Add(this.btnGetRegisterSMS);
            this.gbLoginRegister.Controls.Add(this.btnGetLoginSMS);
            this.gbLoginRegister.Controls.Add(this.picVerifyCode);
            this.gbLoginRegister.Controls.Add(this.btnUserRegister);
            this.gbLoginRegister.Controls.Add(this.cmbLoginType);
            this.gbLoginRegister.Controls.Add(this.lblLoginType);
            this.gbLoginRegister.Controls.Add(this.lblLoginMobileCode);
            this.gbLoginRegister.Controls.Add(this.txtLoginMobileCode);
            this.gbLoginRegister.Controls.Add(this.lblLoginVerifyCode);
            this.gbLoginRegister.Controls.Add(this.txtLoginVerifyCode);
            this.gbLoginRegister.Controls.Add(this.btnUserLogin);
            this.gbLoginRegister.Controls.Add(this.txtLoginPassword);
            this.gbLoginRegister.Controls.Add(this.lblLoginPassword);
            this.gbLoginRegister.Controls.Add(this.lbLoginUser);
            this.gbLoginRegister.Controls.Add(this.txtLoginUser);
            this.gbLoginRegister.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.gbLoginRegister.Location = new System.Drawing.Point(898, 283);
            this.gbLoginRegister.Name = "gbLoginRegister";
            this.gbLoginRegister.Size = new System.Drawing.Size(238, 355);
            this.gbLoginRegister.TabIndex = 17;
            this.gbLoginRegister.TabStop = false;
            this.gbLoginRegister.Text = "登录/注册 Login/Register";
            // 
            // btnGetLoginSMS
            // 
            this.btnGetLoginSMS.ForeColor = System.Drawing.Color.Blue;
            this.btnGetLoginSMS.Location = new System.Drawing.Point(56, 260);
            this.btnGetLoginSMS.Name = "btnGetLoginSMS";
            this.btnGetLoginSMS.Size = new System.Drawing.Size(82, 31);
            this.btnGetLoginSMS.TabIndex = 28;
            this.btnGetLoginSMS.Text = "获取登录码";
            this.btnGetLoginSMS.UseVisualStyleBackColor = true;
            this.btnGetLoginSMS.Click += new System.EventHandler(this.btnGetLoginSMS_Click);
            // 
            // picVerifyCode
            // 
            this.picVerifyCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picVerifyCode.Location = new System.Drawing.Point(140, 127);
            this.picVerifyCode.Name = "picVerifyCode";
            this.picVerifyCode.Size = new System.Drawing.Size(85, 35);
            this.picVerifyCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picVerifyCode.TabIndex = 27;
            this.picVerifyCode.TabStop = false;
            // 
            // btnUserRegister
            // 
            this.btnUserRegister.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUserRegister.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUserRegister.Location = new System.Drawing.Point(140, 312);
            this.btnUserRegister.Name = "btnUserRegister";
            this.btnUserRegister.Size = new System.Drawing.Size(82, 31);
            this.btnUserRegister.TabIndex = 26;
            this.btnUserRegister.Text = "注册(&R)";
            this.btnUserRegister.UseVisualStyleBackColor = true;
            this.btnUserRegister.Click += new System.EventHandler(this.btnUserRegister_Click);
            // 
            // cmbLoginType
            // 
            this.cmbLoginType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoginType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLoginType.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbLoginType.FormattingEnabled = true;
            this.cmbLoginType.Items.AddRange(new object[] {
            "普通登录",
            "手机登录"});
            this.cmbLoginType.Location = new System.Drawing.Point(53, 60);
            this.cmbLoginType.Name = "cmbLoginType";
            this.cmbLoginType.Size = new System.Drawing.Size(169, 25);
            this.cmbLoginType.TabIndex = 11;
            // 
            // lblLoginType
            // 
            this.lblLoginType.AutoSize = true;
            this.lblLoginType.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLoginType.Location = new System.Drawing.Point(10, 62);
            this.lblLoginType.Name = "lblLoginType";
            this.lblLoginType.Size = new System.Drawing.Size(44, 17);
            this.lblLoginType.TabIndex = 25;
            this.lblLoginType.Text = "方式：";
            // 
            // lblLoginMobileCode
            // 
            this.lblLoginMobileCode.AutoSize = true;
            this.lblLoginMobileCode.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLoginMobileCode.Location = new System.Drawing.Point(9, 228);
            this.lblLoginMobileCode.Name = "lblLoginMobileCode";
            this.lblLoginMobileCode.Size = new System.Drawing.Size(56, 17);
            this.lblLoginMobileCode.TabIndex = 24;
            this.lblLoginMobileCode.Text = "动态码：";
            // 
            // txtLoginMobileCode
            // 
            this.txtLoginMobileCode.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtLoginMobileCode.Location = new System.Drawing.Point(66, 225);
            this.txtLoginMobileCode.Name = "txtLoginMobileCode";
            this.txtLoginMobileCode.Size = new System.Drawing.Size(65, 29);
            this.txtLoginMobileCode.TabIndex = 23;
            // 
            // lblLoginVerifyCode
            // 
            this.lblLoginVerifyCode.AutoSize = true;
            this.lblLoginVerifyCode.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLoginVerifyCode.Location = new System.Drawing.Point(9, 132);
            this.lblLoginVerifyCode.Name = "lblLoginVerifyCode";
            this.lblLoginVerifyCode.Size = new System.Drawing.Size(56, 17);
            this.lblLoginVerifyCode.TabIndex = 22;
            this.lblLoginVerifyCode.Text = "验证码：";
            // 
            // txtLoginVerifyCode
            // 
            this.txtLoginVerifyCode.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtLoginVerifyCode.Location = new System.Drawing.Point(66, 129);
            this.txtLoginVerifyCode.Name = "txtLoginVerifyCode";
            this.txtLoginVerifyCode.Size = new System.Drawing.Size(65, 29);
            this.txtLoginVerifyCode.TabIndex = 21;
            // 
            // btnUserLogin
            // 
            this.btnUserLogin.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUserLogin.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUserLogin.Location = new System.Drawing.Point(52, 312);
            this.btnUserLogin.Name = "btnUserLogin";
            this.btnUserLogin.Size = new System.Drawing.Size(82, 31);
            this.btnUserLogin.TabIndex = 18;
            this.btnUserLogin.Text = "登录(&L)";
            this.btnUserLogin.UseVisualStyleBackColor = true;
            this.btnUserLogin.Click += new System.EventHandler(this.btnUserLogin_Click);
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Location = new System.Drawing.Point(53, 95);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.PasswordChar = '*';
            this.txtLoginPassword.Size = new System.Drawing.Size(169, 23);
            this.txtLoginPassword.TabIndex = 13;
            this.txtLoginPassword.Text = "123321";
            // 
            // lblLoginPassword
            // 
            this.lblLoginPassword.AutoSize = true;
            this.lblLoginPassword.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLoginPassword.Location = new System.Drawing.Point(9, 93);
            this.lblLoginPassword.Name = "lblLoginPassword";
            this.lblLoginPassword.Size = new System.Drawing.Size(44, 17);
            this.lblLoginPassword.TabIndex = 12;
            this.lblLoginPassword.Text = "密码：";
            // 
            // lbLoginUser
            // 
            this.lbLoginUser.AutoSize = true;
            this.lbLoginUser.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbLoginUser.Location = new System.Drawing.Point(9, 30);
            this.lbLoginUser.Name = "lbLoginUser";
            this.lbLoginUser.Size = new System.Drawing.Size(44, 17);
            this.lbLoginUser.TabIndex = 11;
            this.lbLoginUser.Text = "账号：";
            // 
            // txtLoginUser
            // 
            this.txtLoginUser.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.txtLoginUser.Location = new System.Drawing.Point(53, 29);
            this.txtLoginUser.Name = "txtLoginUser";
            this.txtLoginUser.Size = new System.Drawing.Size(169, 25);
            this.txtLoginUser.TabIndex = 0;
            this.txtLoginUser.Text = "test1805";
            // 
            // txtOnlineHost
            // 
            this.txtOnlineHost.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtOnlineHost.Location = new System.Drawing.Point(76, 23);
            this.txtOnlineHost.Name = "txtOnlineHost";
            this.txtOnlineHost.Size = new System.Drawing.Size(146, 25);
            this.txtOnlineHost.TabIndex = 16;
            this.txtOnlineHost.Text = "v1.300830.com";
            // 
            // gbSetting
            // 
            this.gbSetting.Controls.Add(this.btnSwapHost);
            this.gbSetting.Controls.Add(this.txtTestHost);
            this.gbSetting.Controls.Add(this.lblTestHost);
            this.gbSetting.Controls.Add(this.txtOnlineHost);
            this.gbSetting.Controls.Add(this.lblOnlineHost);
            this.gbSetting.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbSetting.Location = new System.Drawing.Point(898, 12);
            this.gbSetting.Name = "gbSetting";
            this.gbSetting.Size = new System.Drawing.Size(238, 260);
            this.gbSetting.TabIndex = 18;
            this.gbSetting.TabStop = false;
            this.gbSetting.Text = "设置 Setting";
            // 
            // lblTestHost
            // 
            this.lblTestHost.AutoSize = true;
            this.lblTestHost.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTestHost.Location = new System.Drawing.Point(10, 59);
            this.lblTestHost.Name = "lblTestHost";
            this.lblTestHost.Size = new System.Drawing.Size(68, 17);
            this.lblTestHost.TabIndex = 32;
            this.lblTestHost.Text = "测试域名：";
            // 
            // lblOnlineHost
            // 
            this.lblOnlineHost.AutoSize = true;
            this.lblOnlineHost.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOnlineHost.Location = new System.Drawing.Point(10, 27);
            this.lblOnlineHost.Name = "lblOnlineHost";
            this.lblOnlineHost.Size = new System.Drawing.Size(68, 17);
            this.lblOnlineHost.TabIndex = 31;
            this.lblOnlineHost.Text = "正式域名：";
            // 
            // txtTestHost
            // 
            this.txtTestHost.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTestHost.Location = new System.Drawing.Point(76, 54);
            this.txtTestHost.Name = "txtTestHost";
            this.txtTestHost.Size = new System.Drawing.Size(146, 25);
            this.txtTestHost.TabIndex = 33;
            this.txtTestHost.Text = "192.168.45.19";
            // 
            // btnSwapHost
            // 
            this.btnSwapHost.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSwapHost.Location = new System.Drawing.Point(76, 86);
            this.btnSwapHost.Name = "btnSwapHost";
            this.btnSwapHost.Size = new System.Drawing.Size(146, 30);
            this.btnSwapHost.TabIndex = 34;
            this.btnSwapHost.Text = "转测试域名";
            this.btnSwapHost.UseVisualStyleBackColor = true;
            this.btnSwapHost.Click += new System.EventHandler(this.btnSwapHost_Click);
            // 
            // btnGetRegisterSMS
            // 
            this.btnGetRegisterSMS.ForeColor = System.Drawing.Color.Blue;
            this.btnGetRegisterSMS.Location = new System.Drawing.Point(143, 260);
            this.btnGetRegisterSMS.Name = "btnGetRegisterSMS";
            this.btnGetRegisterSMS.Size = new System.Drawing.Size(82, 31);
            this.btnGetRegisterSMS.TabIndex = 31;
            this.btnGetRegisterSMS.Text = "获取注册码";
            this.btnGetRegisterSMS.UseVisualStyleBackColor = true;
            this.btnGetRegisterSMS.Click += new System.EventHandler(this.btnGetRegisterSMS_Click);
            // 
            // cmbAPIAction
            // 
            this.cmbAPIAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAPIAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAPIAction.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbAPIAction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbAPIAction.FormattingEnabled = true;
            this.cmbAPIAction.Location = new System.Drawing.Point(318, 21);
            this.cmbAPIAction.Name = "cmbAPIAction";
            this.cmbAPIAction.Size = new System.Drawing.Size(429, 25);
            this.cmbAPIAction.TabIndex = 32;
            this.cmbAPIAction.SelectedIndexChanged += new System.EventHandler(this.cmbAPIAction_SelectedIndexChanged);
            // 
            // txtVerifyKey
            // 
            this.txtVerifyKey.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtVerifyKey.Location = new System.Drawing.Point(12, 182);
            this.txtVerifyKey.Name = "txtVerifyKey";
            this.txtVerifyKey.Size = new System.Drawing.Size(210, 23);
            this.txtVerifyKey.TabIndex = 16;
            // 
            // frmWebGet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 671);
            this.Controls.Add(this.gbSetting);
            this.Controls.Add(this.gbLoginRegister);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.btnHtppSend);
            this.Controls.Add(this.gbHeaders);
            this.Controls.Add(this.gbParameters);
            this.Controls.Add(this.ssStatusBar);
            this.Controls.Add(this.gbBaseInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmWebGet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sam.Zheng - HTTP Get/Post";
            this.Load += new System.EventHandler(this.frmWebGet_Load);
            this.gbBaseInfo.ResumeLayout(false);
            this.gbBaseInfo.PerformLayout();
            this.ssStatusBar.ResumeLayout(false);
            this.ssStatusBar.PerformLayout();
            this.gbParameters.ResumeLayout(false);
            this.gbParameters.PerformLayout();
            this.gbHeaders.ResumeLayout(false);
            this.gbHeaders.PerformLayout();
            this.gbResult.ResumeLayout(false);
            this.gbResult.PerformLayout();
            this.gbLoginRegister.ResumeLayout(false);
            this.gbLoginRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVerifyCode)).EndInit();
            this.gbSetting.ResumeLayout(false);
            this.gbSetting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBaseInfo;
        private System.Windows.Forms.StatusStrip ssStatusBar;
        private System.Windows.Forms.ComboBox cmbHttpType;
        private System.Windows.Forms.Label lblHttpType;
        private System.Windows.Forms.ComboBox cmbEncoding;
        private System.Windows.Forms.Label lblEncoding;
        private System.Windows.Forms.Label lblHttpURL;
        private System.Windows.Forms.GroupBox gbParameters;
        private System.Windows.Forms.Label lblParamName;
        private System.Windows.Forms.TextBox txtParamN1;
        private System.Windows.Forms.TextBox txtParamV1;
        private System.Windows.Forms.Label lblParamValue;
        private System.Windows.Forms.TextBox txtParamV3;
        private System.Windows.Forms.TextBox txtParamN3;
        private System.Windows.Forms.TextBox txtParamV2;
        private System.Windows.Forms.TextBox txtParamN2;
        private System.Windows.Forms.GroupBox gbHeaders;
        private System.Windows.Forms.TextBox txtHeaderV3;
        private System.Windows.Forms.TextBox txtHeaderN3;
        private System.Windows.Forms.TextBox txtHeaderV2;
        private System.Windows.Forms.TextBox txtHeaderN2;
        private System.Windows.Forms.TextBox txtHeaderV1;
        private System.Windows.Forms.Label lblHeaderValue;
        private System.Windows.Forms.TextBox txtHeaderN1;
        private System.Windows.Forms.Label lblHeaderName;
        private System.Windows.Forms.Button btnHtppSend;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.TextBox txtResultHeaders;
        private System.Windows.Forms.TextBox txtHtmlSource;
        private System.Windows.Forms.Label lblResultHeaders;
        private System.Windows.Forms.Label lblHtmlSource;
        private System.Windows.Forms.ToolStripStatusLabel ssStatusBar_Info;
        private System.Windows.Forms.TextBox txtOptionTips;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHttpTimeOut;
        private System.Windows.Forms.TextBox txtUserAgent;
        private System.Windows.Forms.Label lblUserAgent;
        private System.Windows.Forms.GroupBox gbLoginRegister;
        private System.Windows.Forms.TextBox txtLoginUser;
        private System.Windows.Forms.Label lbLoginUser;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.Label lblLoginPassword;
        private System.Windows.Forms.Button btnUserLogin;
        private System.Windows.Forms.Label lblLoginMobileCode;
        private System.Windows.Forms.TextBox txtLoginMobileCode;
        private System.Windows.Forms.Label lblLoginVerifyCode;
        private System.Windows.Forms.TextBox txtLoginVerifyCode;
        private System.Windows.Forms.ComboBox cmbLoginType;
        private System.Windows.Forms.Label lblLoginType;
        private System.Windows.Forms.TextBox txtParamV4;
        private System.Windows.Forms.TextBox txtParamN4;
        private System.Windows.Forms.TextBox txtHeaderV4;
        private System.Windows.Forms.TextBox txtHeaderN4;
        private System.Windows.Forms.Button btnUserRegister;
        private System.Windows.Forms.PictureBox picVerifyCode;
        private System.Windows.Forms.Button btnGetLoginSMS;
        private System.Windows.Forms.TextBox txtOnlineHost;
        private System.Windows.Forms.GroupBox gbSetting;
        private System.Windows.Forms.Label lblTestHost;
        private System.Windows.Forms.Label lblOnlineHost;
        private System.Windows.Forms.TextBox txtTestHost;
        private System.Windows.Forms.Button btnSwapHost;
        private System.Windows.Forms.Button btnGetRegisterSMS;
        private System.Windows.Forms.ComboBox cmbAPIAction;
        private System.Windows.Forms.TextBox txtVerifyKey;
    }
}