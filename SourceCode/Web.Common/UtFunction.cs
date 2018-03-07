using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Data;
using System.Web.UI.WebControls;
//添加命名空间
using PersistenceLayer;
using System.Text.RegularExpressions;

namespace Web.Common
{
    /// <summary>
    /// 静态公共方法类，主要用于大家都能用得到的类
    /// </summary>
    public class UtFunction
    {
        #region MD5加密方法

        #region  public static string Set_32_Md5(string encrypt)
        /// <summary>
        /// 将字符串用MD5加密,返回32位加密后字符串
        /// </summary>
        /// <param name="encrypt"></param>
        /// <returns></returns>
        public static string Set_32_Md5(string encrypt)
        {
            try
            {
                return System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(encrypt, "MD5");
            }
            catch
            {
                return Names.Error;
            }

        }
        #endregion

        #region  public static string Set_16_Md5(string encrypt)
        /// <summary>
        /// 将字符串用MD5加密,返回16位加密后字符串
        /// 该结果取32位加密结果的第9位到25位
        /// </summary>
        /// <param name="encrypt"></param>
        /// <returns></returns>
        public static string Set_16_Md5(string encrypt)
        {
            try
            {
                System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
                //获取密文字节数组 
                byte[] bytResult = md5.ComputeHash(System.Text.Encoding.Default.GetBytes(encrypt));
                //转换成字符串，并取9到25位 
                string strResult = BitConverter.ToString(bytResult, 4, 8);
                //BitConverter转换出来的字符串会在每个字符中间产生一个分隔符，需要去除掉 
                strResult = strResult.Replace("-", "");
                return strResult;

            }
            catch
            {
                return Names.Error;
            }

        }
        #endregion

        #endregion

        #region GetGuid()
        /// <summary>
        /// 生成一个去除'-'的GUID字符串
        /// </summary>
        /// <returns></returns>
        public static string GetGuid()
        {
            try
            {
                //生成一个GUID值，并将值转换成字符串
                string strGuid = Guid.NewGuid().ToString();
                strGuid = strGuid.Replace("-", "");
                return strGuid;
            }
            catch
            {
                return Names.Error;
            }
        }

        #endregion

        #region GetAppSettingsByKey(string key)
        /// <summary>
        /// 获取配置文件中的appSettings值
        /// </summary>
        /// <param name="key"></param>
        public static string GetAppSettingsByKey(string key)
        {
            try
            {
                string strValue = System.Configuration.ConfigurationManager.AppSettings[key].ToString();
                return strValue;
            }
            catch
            {
                return Names.Error;
            }

        }
        #endregion

        #region public static string CutStr(string str, int len)
        /// <summary>
        /// 根据字符长度截取字符串
        /// </summary>
        /// <param name="str">被截取的字符串</param>
        /// <param name="len">需要截取的长度</param>
        /// <returns>截取后的字符串</returns>
        public static string CutStr(string str, int len)
        {
            if (str == null || str.Length == 0 || len <= 0)
            {
                return string.Empty;
            }

            int l = str.Length;

            #region 计算长度
            int clen = 0;
            while (clen < len && clen < l)
            {
                //每遇到一个中文，则将目标长度减一。
                if ((int)str[clen] > 128) { len--; }
                clen++;
            }
            #endregion

            if (clen < l)
            {
                return str.Substring(0, clen) + "...";
            }
            else
            {
                return str;
            }
        }
        #endregion

        #region public static bool IfValidDataTable(DataTable dt)
        /// <summary>
        /// 判断DataTable是否有效
        /// </summary>
        /// <param name="dt">DataTable</param>
        /// <returns>true/false</returns>
        public static bool IfValidDataTable(DataTable dt)
        {
            if (dt != null && dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region public static string GetNullString(string NullString)
        /// <summary>
        /// 处理空字符串或者NULL
        /// </summary>
        /// <param name="NullString"></param>
        /// <returns></returns>
        public static string GetNullString(string NullString)
        {
            if (string.IsNullOrEmpty(NullString))
            {
                return "";
            }
            else
            {
                return NullString;
            }
        }
        #endregion

        #region public static DateTime GetSundayDate(DateTime someDate)
        /// <summary>
        /// 根据时间，获取当前所在的周末时间
        /// </summary>
        /// <param name="someDate"></param>
        /// <returns></returns>
        public static DateTime GetSundayDate(DateTime someDate)
        {
            int i = someDate.DayOfWeek - DayOfWeek.Sunday;
            if (i != 0) i = 7 - i;// 因为枚举原因，Sunday排在最前，相减间隔要被7减。 
            TimeSpan ts = new TimeSpan(i, 0, 0, 0);
            return someDate.Add(ts);
        }
        #endregion

        #region public static DateTime GetMondayDate(DateTime someDate)
        /// <summary>
        /// 根据时间，获取当前所在的周一时间
        /// </summary>
        /// <param name="someDate"></param>
        /// <returns></returns>
        public static DateTime GetMondayDate(DateTime someDate)
        {
            int i = DayOfWeek.Monday - someDate.DayOfWeek;
            TimeSpan ts = new TimeSpan(i, 0, 0, 0);
            return someDate.Add(ts);
        }
        #endregion

        #region 身份证验证方法
        //身份证验证
        /// <summary>
        /// 根据输入的身份证号，判断其是否正确
        /// </summary>
        /// <param name="Id">身份证号</param>
        /// <returns>正确返回true,错误返回错误信息</returns>
        public static string CheckIDCard(string Id)
        {
            string check = "true";
            if (Id.Length == 18)
            {
                check = CheckIDCard18(Id);
                return check;
            }
            else if (Id.Length == 15)
            {
                check = CheckIDCard15(Id);
                return check;
            }
            else
            {
                check = "输入的身份证号长度不对";
                return check;
            }
        }

        public static string CheckIDCard1(string Id)
        {
            string check = "true";
            if (Id.Length == 18)
            {
                check = CheckIDCard181(Id);
                return check;
            }
            else if (Id.Length == 15)
            {
                check = CheckIDCard15(Id);
                return check;
            }
            else
            {
                check = "输入的身份证号长度不对";
                return check;
            }
        }

        //验证18位身份证
        public static string CheckIDCard18(string Id)
        {
            string flag = "true";
            long n = 0;
            if (long.TryParse(Id.Remove(17), out n) == false || n < Math.Pow(10, 16) || long.TryParse(Id.Replace('x', '0').Replace('X', '0'), out n) == false)
            {
                flag = "身份证号码不符合规定！15位号码应全为数字，18位号码末位可以为数字或X。";
                return flag;//数字验证
            }
            string address = "11x22x35x44x53x12x23x36x45x54x13x31x37x46x61x14x32x41x50x62x15x33x42x51x63x21x34x43x52x64x65x71x81x82x91";
            if (address.IndexOf(Id.Remove(2)) == -1)
            {
                flag = "身份证的省份代码不合法";
                return flag;//省份验证
            }
            string birth = Id.Substring(6, 8).Insert(6, "-").Insert(4, "-");
            DateTime time = new DateTime();
            if (DateTime.TryParse(birth, out time) == false)
            {
                flag = "身份证的出生年月日代码不合法";
                return flag;//生日验证
            }
            string[] arrVarifyCode = ("1,0,x,9,8,7,6,5,4,3,2").Split(',');
            string[] Wi = ("7,9,10,5,8,4,2,1,6,3,7,9,10,5,8,4,2").Split(',');
            char[] Ai = Id.Remove(17).ToCharArray();
            int sum = 0;
            for (int i = 0; i < 17; i++)
            {
                sum += int.Parse(Wi[i]) * int.Parse(Ai[i].ToString());
            }
            int y = -1;
            Math.DivRem(sum, 11, out y);
            if (arrVarifyCode[y] != Id.Substring(17, 1).ToLower())
            {
                flag = "身份证的校验码不合法，应为" + arrVarifyCode[y].ToString();
                return flag;//校验码验证
            }
            return flag;//符合GB11643-1999标准
        }

        //验证18位身份证(用在居家养老)
        public static string CheckIDCard181(string Id)
        {
            string flag = "true";
            long n = 0;
            if (long.TryParse(Id.Remove(17), out n) == false || n < Math.Pow(10, 16) || long.TryParse(Id.Replace('x', '0').Replace('X', '0'), out n) == false)
            {
                flag = "身份证号码不符合规定！15位号码应全为数字，18位号码末位可以为数字或X。";
                return flag;//数字验证
            }
            string address = "11x22x35x44x53x12x23x36x45x54x13x31x37x46x61x14x32x41x50x62x15x33x42x51x63x21x34x43x52x64x65x71x81x82x91";
            if (address.IndexOf(Id.Remove(2)) == -1)
            {
                flag = "身份证的省份代码不合法";
                return flag;//省份验证
            }
            string birth = Id.Substring(6, 8).Insert(6, "-").Insert(4, "-");
            DateTime time = new DateTime();
            if (DateTime.TryParse(birth, out time) == false)
            {
                flag = "身份证的出生年月日代码不合法";
                return flag;//生日验证
            }
            string[] arrVarifyCode = ("1,0,x,9,8,7,6,5,4,3,2").Split(',');
            string[] Wi = ("7,9,10,5,8,4,2,1,6,3,7,9,10,5,8,4,2").Split(',');
            char[] Ai = Id.Remove(17).ToCharArray();
            int sum = 0;
            for (int i = 0; i < 17; i++)
            {
                sum += int.Parse(Wi[i]) * int.Parse(Ai[i].ToString());
            }
            int y = -1;
            Math.DivRem(sum, 11, out y);
            //if (arrVarifyCode[y] != Id.Substring(17, 1).ToLower())
            //{
            //    flag = "身份证的校验码不合法，应为" + arrVarifyCode[y].ToString();
            //    return flag;//校验码验证
            //}
            return flag;//符合GB11643-1999标准
        }


        //验证15位身份证
        public static string CheckIDCard15(string Id)
        {
            string flag = "true";
            long n = 0;
            if (long.TryParse(Id, out n) == false || n < Math.Pow(10, 14))
            {
                flag = "身份证号码不符合规定！15位号码应全为数字，18位号码末位可以为数字或X。";
                return flag;//数字验证
            }
            string address = "11x22x35x44x53x12x23x36x45x54x13x31x37x46x61x14x32x41x50x62x15x33x42x51x63x21x34x43x52x64x65x71x81x82x91";
            if (address.IndexOf(Id.Remove(2)) == -1)
            {
                flag = "身份证的省份代码不合法";
                return flag;//省份验证
            }
            string birth = Id.Substring(6, 6).Insert(4, "-").Insert(2, "-");
            DateTime time = new DateTime();
            if (DateTime.TryParse(birth, out time) == false)
            {
                flag = "身份证的出生年月日代码不合法";
                return flag;//生日验证
            }
            return flag;//符合15位身份证标准
        }
        #endregion

        #region public static bool IsNum(string str)
        /// <summary>
        /// 判断字符串是否为数字(0-9)
        /// </summary>
        /// <param name="str">需要判断的数字</param>
        /// <returns>TRUE 是纯数字  FALSE 不是纯数字</returns>
        public static bool IsNum(string str)
        {
            try
            {
                for (int i = 0; i < str.Length; i++)
                {
                    char[] a = str.ToCharArray();
                    if (48 > a[i] || a[i] > 57)
                    {
                        return false;
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region public static bool IsTelnum(string str)
        /// <summary>
        /// 判断字符串是否为电话号码0-9 和‘-’
        /// </summary>
        /// <param name="str">需要判断的电话号码字符串</param>
        /// <returns>TRUE 是电话号码  FALSE 不是电话号码</returns>
        public static bool IsTelnum(string str)
        {
            try
            {
                for (int i = 0; i < str.Length; i++)
                {
                    char[] a = str.ToCharArray();
                    if ((48 > a[i] || a[i] > 57) && (a[i] != 45))
                    {
                        return false;
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region  public static bool IsChar(string str)
        /// <summary>
        /// 判断是否为纯字符，大写和小写
        /// </summary>
        /// <param name="str">需要判断的字符串</param>
        /// <returns>TRUE 是纯字符  FALSE 不是纯字符</returns>
        public static bool IsChar(string str)
        {
            try
            {
                Char[] a = str.ToCharArray();
                int len = str.Length;
                Int32 w;
                for (int i = 0; i < str.Length; i++)
                {
                    w = (Int32)a[i];
                    if ((w < 65) || (w > 122) || (90 < w && w < 97))
                    {
                        return false;
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region public static bool IsDouble(string str)
        /// <summary>
        /// 判断字符串是否为浮点数
        /// </summary>
        /// <param name="str">需要判断的字符串</param>
        /// <returns>TRUE 是浮点数  FALSE 不是浮点数</returns>
        public static bool IsDouble(string str)
        {
            try
            {
                int j = 0;
                char[] a = str.ToCharArray();
                for (int i = 0; i < str.Length; i++)
                {
                    if ((Int32)a[i] == 46)
                    {
                        j = j + 1;
                        continue;
                    }
                    if (48 > a[i] || a[i] > 57)
                        return false;

                }
                if (j > 1)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region  public static bool IsChinese(string str)
        /// <summary>
        /// 判断字符串是否为纯中文
        /// </summary>
        /// <param name="str">需要判断的字符串</param>
        /// <returns>TRUE 是纯中文  FALSE 不是纯中文</returns>
        public static bool IsChinese(string str)
        {
            try
            {
                char[] q = str.ToCharArray();
                for (int i = 0; i < str.Length; i++)
                {
                    if ((int)q[i] >= 0x4E00 && (int)q[i] <= 0x9FA5)
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }

        }

        #endregion

        #region public static int CheckStrLen(string strLine)
        /// <summary>
        /// 获取字符串的字节长度，中文占2个字节，其它占用1个字节
        /// </summary>
        /// <param name="strLine"></param>
        /// <returns></returns>
        public static int CheckStrLen(string strLine)
        {
            try
            {
                ASCIIEncoding n = new ASCIIEncoding();
                byte[] b = n.GetBytes(strLine);
                int len = 0;  // l 为字符串之实际长度
                for (int i = 0; i <= b.Length - 1; i++)
                {
                    if (b[i] == 63)  //判断是否为汉字或全脚符号
                    {
                        len++;
                    }
                    len++;
                }
                return len;
            }
            catch
            {
                return -1;
            }
        }
        #endregion

        #region public static string GetInnerSnByType(string type)
        /// <summary>
        /// 根据类型，产生一个20位内部编号
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static string GetInnerSnByType(string type)
        {
            try
            {
                string strInnerSn = "";
                string strTime = DateTime.Now.ToString("yyyyMMddHHmmss");
                Random rd = new Random();
                int intIndex = rd.Next(10000);
                string strIndex = UtFunction.SetFullByZero(intIndex, 4);
                strInnerSn = type.ToUpper() + strTime + strIndex;
                if (strInnerSn.Length == 20)
                {
                    return strInnerSn;
                }
                else
                {
                    return Names.Empty;
                }
            }
            catch
            {
                return Names.Empty;
            }
        }
        #endregion

     

        #region public static string SetFullByZero(int index, int count)
        /// <summary>
        /// 用0前补全要求的位数
        /// </summary>
        /// <param name="index">序号</param>
        /// <param name="count">位数</param>
        /// <returns></returns>
        public static string SetFullByZero(int index, int count)
        {
            try
            {
                string strValue = "";
                int len = index.ToString().Length;
                if (len < count)
                {
                    for (int i = 0; i < count - len; i++)
                    {
                        strValue += "0";
                    }
                    strValue += index.ToString();
                }
                else
                {
                    strValue += index.ToString();
                }
                return strValue;
            }
            catch
            {
                return Names.Empty;
            }

        }
        #endregion

        #region public static string CreateSnByType(string type)
        /// <summary>
        /// 根据类型，产生一个20位编号
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static string CreateSnByType(string type)
        {
            try
            {
                string strInnerSn = "";
                string strTime = DateTime.Now.ToString("yyyyMMddHHmmss");
                Random rd = new Random();
                int intIndex = rd.Next(10000);
                string strIndex = UtFunction.SetFullByZero(intIndex, 4);
                strInnerSn = type.ToUpper() + strTime + strIndex;
                if (strInnerSn.Length == 20)
                {
                    return strInnerSn;
                }
                else
                {
                    return String.Empty;
                }
            }
            catch
            {
                return String.Empty;
            }
        }
        #endregion

    

     

    
   

        /// <summary>
        /// 过滤标记
        /// </summary>
        /// <param name="NoHTML">包括HTML，脚本，数据库关键字，特殊字符的源码 </param>
        /// <returns>已经去除标记后的文字</returns>
        public static string NoHTML(string Htmlstring)
        {
            if (Htmlstring == null)
            {
                return "";
            }
            else
            {
                //删除脚本
                Htmlstring = Regex.Replace(Htmlstring, @"<script[^>]*?>.*?</script>", "", RegexOptions.IgnoreCase);
                //删除HTML
                Htmlstring = Regex.Replace(Htmlstring, @"<(.[^>]*)>", "", RegexOptions.IgnoreCase);
                Htmlstring = Regex.Replace(Htmlstring, @"([rn])[s]+", "", RegexOptions.IgnoreCase);
                Htmlstring = Regex.Replace(Htmlstring, @"-->", "", RegexOptions.IgnoreCase);
                Htmlstring = Regex.Replace(Htmlstring, @"<!--.*", "", RegexOptions.IgnoreCase);
                Htmlstring = Regex.Replace(Htmlstring, @"&(quot|#34);", "", RegexOptions.IgnoreCase);
                Htmlstring = Regex.Replace(Htmlstring, @"&(amp|#38);", "&", RegexOptions.IgnoreCase);
                Htmlstring = Regex.Replace(Htmlstring, @"&(lt|#60);", "<", RegexOptions.IgnoreCase);
                Htmlstring = Regex.Replace(Htmlstring, @"&(gt|#62);", ">", RegexOptions.IgnoreCase);
                Htmlstring = Regex.Replace(Htmlstring, @"&(nbsp|#160);", "", RegexOptions.IgnoreCase);
                Htmlstring = Regex.Replace(Htmlstring, @"&(iexcl|#161);", "xa1", RegexOptions.IgnoreCase);
                Htmlstring = Regex.Replace(Htmlstring, @"&(cent|#162);", "xa2", RegexOptions.IgnoreCase);
                Htmlstring = Regex.Replace(Htmlstring, @"&(pound|#163);", "xa3", RegexOptions.IgnoreCase);
                Htmlstring = Regex.Replace(Htmlstring, @"&(copy|#169);", "xa9", RegexOptions.IgnoreCase);
                Htmlstring = Regex.Replace(Htmlstring, @"&#(d+);", "", RegexOptions.IgnoreCase);
                Htmlstring = Regex.Replace(Htmlstring, "xp_cmdshell", "", RegexOptions.IgnoreCase);
                Htmlstring = Regex.Replace(Htmlstring, " ", "", RegexOptions.IgnoreCase);
                Htmlstring = Regex.Replace(Htmlstring, "/r", "", RegexOptions.IgnoreCase);
                Htmlstring = Regex.Replace(Htmlstring, "/n", "", RegexOptions.IgnoreCase);

                //特殊的字符
                Htmlstring = Htmlstring.Replace("<", "");
                Htmlstring = Htmlstring.Replace(">", "");
                Htmlstring = Htmlstring.Replace("*", "");
                Htmlstring = Htmlstring.Replace("-", "");
                Htmlstring = Htmlstring.Replace("?", "");
                Htmlstring = Htmlstring.Replace(",", "");
                Htmlstring = Htmlstring.Replace("/", "");
                Htmlstring = Htmlstring.Replace(";", "");
                Htmlstring = Htmlstring.Replace("*/", "");
                Htmlstring = Htmlstring.Replace("rn", "");
                Htmlstring = Htmlstring.Replace("｡", "。");
                Htmlstring = Htmlstring.Replace("､", "、");
                Htmlstring = System.Web.HttpContext.Current.Server.HtmlEncode(Htmlstring).Trim();
                return Htmlstring;
            }
        }
    }

}
