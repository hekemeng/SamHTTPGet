namespace SamZhengAPI.WebGet.Common
{
    #region Spaces
    using System;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;
    using System.IO;
    using System.Security.Cryptography;
    using System.Text;
    using System.Drawing;
    #endregion

    public class WinFun
    {
        #region MessageBox
        public static void ShowMessageBox(string Msg)
        {
            MessageBox.Show(Msg, "WebAPI Message");
        }
        #endregion

        #region Check URL
        public static bool CheckIsUrl(string str)
        {
            return Regex.IsMatch(str.Trim(), @"^http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&=#]*)?$");
        }
        #endregion

        #region FindControl
        /// <summary>
        /// 按名称查找控件
        /// </summary>
        /// <param name="parentControl">查找控件的父容器控件</param>
        /// <param name="findCtrlName">查找控件名称</param>
        /// <returns>若没有查找到返回NULL</returns>
        public static Control FindControl(Control parentControl, string findCtrlName)
        {
            Control _findedControl = null;
            if (!string.IsNullOrEmpty(findCtrlName) && parentControl != null)
            {
                foreach (Control ctrl in parentControl.Controls)
                {
                    if (ctrl.Name.Equals(findCtrlName))
                    {
                        _findedControl = ctrl;
                        break;
                    }
                }
            }
            return _findedControl;
        }
        #endregion

        #region Remove Space
        public static string RemoveSpace(string str)
        {
            return Regex.Replace(str, @"\s", "");
        }
        #endregion

        #region 安全操作

        #region 3DES
        /// <summary>
        /// 3DES 加/解密
        /// </summary>
        /// <param name="IsDecrypt"></param>
        /// <param name="DesKey"></param>
        /// <param name="DesData"></param>
        /// <returns></returns>
        public static string DES3EncryptDecrypt(bool IsDecrypt, string DesKey, string DesData)
        {
            TripleDESCryptoServiceProvider Des3CSP = new TripleDESCryptoServiceProvider();
            ICryptoTransform ICryptoTF;
            try
            {
                Des3CSP.Key = Convert.FromBase64String(DesKey);
                Des3CSP.Mode = CipherMode.ECB;
                Des3CSP.Padding = PaddingMode.PKCS7;
                ICryptoTF = IsDecrypt ? Des3CSP.CreateDecryptor() : Des3CSP.CreateEncryptor();
                byte[] byteBuffer = IsDecrypt ? Convert.FromBase64String(DesData) : Encoding.UTF8.GetBytes(DesData);
                MemoryStream memStream = new MemoryStream();
                CryptoStream cryptoStream = new CryptoStream(memStream, ICryptoTF, CryptoStreamMode.Write);
                cryptoStream.Write(byteBuffer, 0, byteBuffer.Length);
                cryptoStream.FlushFinalBlock();
                cryptoStream.Close();
                return IsDecrypt ?
                    Encoding.UTF8.GetString(memStream.ToArray()) :
                    Convert.ToBase64String(memStream.ToArray());
            }
            catch { }
            return "";
        }
        #endregion

        #region MD5
        /// <summary>
        /// MD5加密（32位）
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string GetMD5_32(string input)
        {
            MD5 md5 = MD5.Create();
            byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            var sb = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
                sb.Append(data[i].ToString("x2"));
            return sb.ToString().ToUpper();
        }

        public static string GetMD5_16(string input)
        {
            return GetMD5_32(input).Substring(8, 16);
        }

        public static string GetMD5_8(string input)
        {
            return GetMD5_32(input).Substring(8, 8);
        }

        public static string GetMD5_4(string input)
        {
            return GetMD5_32(input).Substring(8, 4);
        }
        #endregion

        #endregion

        #region 字符操作

        #region Get String
        /// <summary>
        /// 判断输出string
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="IsTrim"></param>
        /// <returns></returns>
        public static string GetString(object obj, bool IsTrim)
        {
            return obj != null ? (IsTrim ? obj.ToString().Trim() : obj.ToString()) : "";
        }
        #endregion

        #region Remove Special-Character
        /// <summary>
        /// 替换特殊字符
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static String RemoveSpecialCharacter(string str)
        {
            //return Regex.Replace(str, @"^[a-zA-Z0-9\u4E00-\u9FA5_@]", "");
            return Regex.Replace(str, "[ \\[ \\] \\^ *×――(^)$%~!#$…&%￥—+<>《》!！??？:：•`·、。，；,;\"‘’“”]", "");
        }
        #endregion

        #region Base64 编码/解码
        /// <summary>
        /// 字符编码
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string StringToBase64(string str)
        {
            return (GetString(str, true).Length == 0) ? "" : Convert.ToBase64String(Encoding.UTF8.GetBytes(str));
        }

        /// <summary>
        /// 字符解码
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string Base64ToString(string str)
        {
            return (GetString(str, true).Length == 0) ? "" : Encoding.UTF8.GetString(Convert.FromBase64String(str));
        }

        /// <summary>
        /// 图片编码 Image
        /// </summary>
        /// <param name="Data"></param>
        /// <returns></returns>
        public static string ImageToBase64(Image Data)
        {
            try
            {
                Bitmap bmp = new Bitmap(Data);
                MemoryStream ms = new MemoryStream();
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] arr = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(arr, 0, (int)ms.Length);
                ms.Close();
                return Convert.ToBase64String(arr);
            }
            catch { }

            return "";
        }

        /// <summary>
        /// 图片编码 byte[]
        /// </summary>
        /// <param name="Data"></param>
        /// <returns></returns>
        public static string ImageToBase64(byte[] Data)
        {
            return Convert.ToBase64String(Data);
        }

        /// <summary>
        /// 图片解码
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static Image Base64ToImage(string str)
        {
            try
            {
                byte[] arr = Convert.FromBase64String(str);
                MemoryStream ms = new MemoryStream(arr);
                Bitmap bmp = new Bitmap(ms);
                ms.Close();
                return bmp;
            }
            catch { }

            return null;
        }
        #endregion

        public static string RegexResplace(string SourceData, string SourceText, string ObjectText)
        {
            return Regex.Replace(SourceData, new Uri(SourceText).Host, ObjectText, RegexOptions.IgnoreCase);
        }
        #endregion

        #region 数值操作

        #region Get Int
        /// <summary>
        /// Sbyte:代表有符号的8位整数，数值范围从-128 ～ 127
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static sbyte GetInt8(object obj)
        {
            sbyte.TryParse(GetString(obj, true), out sbyte Result);
            return Result;
        }

        /// <summary>
        /// Short:代表有符号的16位整数，范围从-32768 ～ 32767
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static short GetInt16(object obj)
        {
            short.TryParse(GetString(obj, true), out short Result);
            return Result;
        }

        /// <summary>
        /// Int:代表有符号的32位整数，范围从-2147483648 ～ 2147483648
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static int GetInt32(object obj)
        {
            int.TryParse(GetString(obj, true), out int Result);
            return Result;
        }

        /// <summary>
        /// Long:代表有符号的64位整数，范围从-9223372036854775808 ～ 9223372036854775808
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static long GetInt64(object obj)
        {
            long.TryParse(GetString(obj, true), out long Result);
            return Result;
        }
        #endregion

        #region Get Double/Float
        /// <summary>
        /// Double
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static double GetDouble(object obj)
        {
            double.TryParse(GetString(obj, true), out double Result);
            return Result;
        }
        #endregion

        #endregion

        #region 文本操作
        /// <summary>
        /// 写入文本文件 (追加)
        /// </summary>
        /// <param name="txtPath"></param>
        /// <param name="txtContent"></param>
        /// <returns></returns>
        public static bool AppendWriteToFile(string txtPath, string txtContent)
        {
            try
            {
                if (File.Exists(txtPath))
                {
                    using (StreamWriter sw = File.AppendText(txtPath))
                    {
                        sw.WriteLine(txtContent);
                        sw.Flush();
                        sw.Close();
                    }
                }
                else
                {
                    using (StreamWriter sw = File.CreateText(txtPath))
                    {
                        sw.WriteLine(txtContent);
                        sw.Flush();
                        sw.Close();
                    }
                }
                return true;
            }
            catch { }

            return false;
        }

        /// <summary>
        /// 写入日志（文本）
        /// </summary>
        /// <param name="LogType"></param>
        /// <param name="LogTitle"></param>
        /// <param name="LogContent"></param>
        public static void WriteAppendLogs(string LogType, string LogTitle, string LogContent)
        {
            AppendWriteToFile(
                Application.StartupPath+"/Logs/" + LogType + ".txt",
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "：" + LogTitle + "：" + LogContent
                );
        }
        #endregion
    }
}
