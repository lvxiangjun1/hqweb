using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Web.Common {
    /// <summary>
    /// StringOperate的摘要说明
    /// </summary>
    public class StringOperate {
        public StringOperate() {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }

        /// <summary>
        /// 检验是否是英文、数字、下划线
        /// </summary>
        /// <param name="str">需要检验的字符串</param>
        /// <returns>是否为整数：true是整数，false非整数</returns>
        public static bool IsCheckEngNumUnderLine(string str)
        {
            Regex reg = new Regex(@"^\w+$");
            return reg.IsMatch(str);
        }

        #region 判断数字

        /// <summary>
        /// 判断数字
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsNum(string str) {
            for (int i = 0; i < str.Length; i++) {
                char[] a = str.ToCharArray();
                if (48 > a[i] || a[i] > 57) {
                    return false;
                }
            }
            return true;
        }

        #endregion

        #region 判断字符串

        /// <summary>
        /// 判断字符串
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsChar(string str) {

            Char[] a = str.ToCharArray();
            int len = str.Length;
            Int32 w;
            for (int i = 0; i < str.Length; i++) {
                w = (Int32)a[i];
                if ((w < 65) || (w > 122) || (90 < w && w < 97)) {
                    return false;
                }
            }
            return true;
        }

        #endregion

        #region 判断浮点数

        /// <summary>
        /// 判断浮点数
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsDouble(string str) {
            int j = 0;
            char[] a = str.ToCharArray();
            for (int i = 0; i < str.Length; i++) {
                if ((Int32)a[i] == 46) {
                    j = j + 1;
                    continue;
                }
                if (48 > a[i] || a[i] > 57)
                    return false;

            }
            if (j > 1) {
                return false;
            }
            else {
                return true;
            }
        }

        #endregion

        #region 判断中文

        /// <summary>
        /// 判断中文 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsChinese(string str) {
            char[] q = str.ToCharArray();
            for (int i = 0; i < str.Length; i++) {
                if ((int)q[i] >= 0x4E00 && (int)q[i] <= 0x9FA5) {
                    continue;
                }
                else {
                    return false;
                }
            }
            return true;
        }

        #endregion

        #region 裁切字符串（中文按照两个字符计算）

        /// <summary> 
        /// 裁切字符串（中文按照两个字符计算） 
        /// </summary> 
        /// <param name="str">旧字符串</param> 
        /// <param name="len">新字符串长度</param> 
        /// <param name="HtmlEnable">为 false 时过滤 Html 标签后再进行裁切，反之则保留 Html 标签。</param> 
        /// <remarks> 
        /// <para>注意：<ol> 
        /// <li>若字符串被截断则会在末尾追加“...”，反之则直接返回原始字符串。</li> 
        /// <li>参数 <paramref name="HtmlEnable"/> 为 false 时会先调用<see cref="uoLib.Common.Functions.HtmlFilter"/>过滤掉 Html 标签再进行裁切。</li> 
        /// <li>中文按照两个字符计算。若指定长度位置恰好只获取半个中文字符，则会将其补全，如下面的例子：<br/> 
        /// <code><![CDATA[ 
        /// string str = "感谢使用uoLib。"; 
        /// string A = CutStr(str,4);   // A = "感谢..." 
        /// string B = CutStr(str,5);   // B = "感谢使..." 
        /// ]]></code></li> 
        /// </ol> 
        /// </para> 
        /// </remarks> 
        public static string CutStr(string str, int len, bool HtmlEnable) {
            if (str == null || str.Length == 0 || len <= 0) { return string.Empty; }

            if (HtmlEnable == false) str = HtmlFilter(str);
            int l = str.Length;

            #region 计算长度
            int clen = 0;//当前长度  
            while (clen < len && clen < l) {
                //每遇到一个中文，则将目标长度减一。 
                if ((int)str[clen] > 128) { len--; }
                clen++;
            }
            #endregion

            if (clen < l) {
                return str.Substring(0, clen) + "...";
            }
            else {
                return str;
            }
        }

        #endregion

        #region 裁切字符串（中文按照两个字符计算，裁切前会先过滤 Html 标签）
        /// <summary> 
        /// 裁切字符串（中文按照两个字符计算，裁切前会先过滤 Html 标签） 
        /// </summary> 
        /// <param name="str">旧字符串</param> 
        /// <param name="len">新字符串长度</param> 
        /// <remarks> 
        /// <para>注意：<ol> 
        /// <li>若字符串被截断则会在末尾追加“...”，反之则直接返回原始字符串。</li> 
        /// <li>中文按照两个字符计算。若指定长度位置恰好只获取半个中文字符，则会将其补全，如下面的例子：<br/> 
        /// <code><![CDATA[ 
        /// string str = "感谢使用uoLib模块。"; 
        /// string A = CutStr(str,4);   // A = "感谢..." 
        /// string B = CutStr(str,5);   // B = "感谢使..." 
        /// ]]></code></li> 
        /// </ol> 
        /// </para> 
        /// </remarks> 
        public static string CutStr(string str, int len) {
            if (String.IsNullOrEmpty(str)) { return string.Empty; }
            else {
                return CutStr(str, len, false);
            }
        }

        #endregion

        #region 获取字符串长度（中文作 2 个字符计算）
        /// <summary> 
        /// 获取字符串长度。与string.Length不同的是，该方法将中文作 2 个字符计算。 
        /// </summary> 
        /// <param name="str">目标字符串</param> 
        /// <returns></returns> 
        public static int GetLength(string str) {
            if (str == null || str.Length == 0) { return 0; }

            int l = str.Length;
            int realLen = l;

            #region 计算长度
            int clen = 0;//当前长度  
            while (clen < l) {
                //每遇到一个中文，则将实际长度加一。 
                if ((int)str[clen] > 128) { realLen++; }
                clen++;
            }
            #endregion

            return realLen;
        }

        #endregion

        #region 过滤HTML标签
        ///   <summary>
        ///   过滤HTML，JAVASCRIPT 标记
        ///   </summary>
        ///   <param   name="Htmlstring">包括HTML的源码   </param>
        ///   <returns>已经去除后的文字</returns>
        public static string HtmlFilter(string Htmlstring) {
            Regex regex1 = new System.Text.RegularExpressions.Regex(@"<script[\s\S]+</script *>", RegexOptions.IgnoreCase);
            Regex regex2 = new System.Text.RegularExpressions.Regex(@" href *= *[\s\S]*script *:", RegexOptions.IgnoreCase);
            Regex regex3 = new System.Text.RegularExpressions.Regex(@" no[\s\S]*=", RegexOptions.IgnoreCase);
            Regex regex4 = new System.Text.RegularExpressions.Regex(@"<iframe[\s\S]+</iframe *>", RegexOptions.IgnoreCase);
            Regex regex5 = new System.Text.RegularExpressions.Regex(@"<frameset[\s\S]+</frameset *>", RegexOptions.IgnoreCase);
            Regex regex6 = new System.Text.RegularExpressions.Regex(@"\<img[^\>]+\>", RegexOptions.IgnoreCase);
            Regex regex7 = new System.Text.RegularExpressions.Regex(@"</p>", RegexOptions.IgnoreCase);
            Regex regex8 = new System.Text.RegularExpressions.Regex(@"<p>", RegexOptions.IgnoreCase);
            Regex regex9 = new System.Text.RegularExpressions.Regex(@"<[^>]*>", RegexOptions.IgnoreCase);

            Htmlstring = regex1.Replace(Htmlstring, ""); //过滤<script></script>标记 
            Htmlstring = regex2.Replace(Htmlstring, ""); //过滤href=javascript: (<A>) 属性 网管网bitsCN.com 
            Htmlstring = regex3.Replace(Htmlstring, " _disibledevent="); //过滤其它控件的on...事件 
            Htmlstring = regex4.Replace(Htmlstring, ""); //过滤iframe 
            Htmlstring = regex5.Replace(Htmlstring, ""); //过滤frameset 
            Htmlstring = regex6.Replace(Htmlstring, ""); //过滤frameset 
            Htmlstring = regex7.Replace(Htmlstring, ""); //过滤frameset 
            Htmlstring = regex8.Replace(Htmlstring, ""); //过滤frameset 
            Htmlstring = regex9.Replace(Htmlstring, "");
            Htmlstring = Htmlstring.Replace(" ", "");

            Htmlstring = Htmlstring.Replace("</strong>", "");
            Htmlstring = Htmlstring.Replace("<strong>", "");

            return Htmlstring;
        }

        #endregion

        #region 获得汉字的首字拼音
        ///   <summary>
        ///   获得汉字的首字拼音
        ///   </summary>
        ///   <param   name="strText"></param>
        ///   <returns></returns>
        public static string GetChineseSpell(string strText) {
            int len = strText.Length;
            string myStr = "";
            for (int i = 0; i < len; i++) {
                myStr += getSpell(strText.Substring(i, 1));
            }
            return myStr;
        }

        public static string getSpell(string cnChar) {
            byte[] arrCN = Encoding.Default.GetBytes(cnChar);
            if (arrCN.Length > 1) {
                int area = (short)arrCN[0];
                int pos = (short)arrCN[1];
                int code = (area << 8) + pos;
                int[] areacode = { 45217, 45253, 45761, 46318, 46826, 47010, 47297, 47614, 48119, 48119, 49062, 49324, 49896, 50371, 50614, 50622, 50906, 51387, 51446, 52218, 52698, 52698, 52698, 52980, 53689, 54481 };
                for (int i = 0; i < 26; i++) {
                    int max = 55290;
                    if (i != 25) max = areacode[i + 1];
                    if (areacode[i] <= code && code < max) {
                        return Encoding.Default.GetString(new byte[] { (byte)(65 + i) });
                    }
                }
                return "*";
            }
            else return cnChar;
        }

        #endregion

        #region 判断是否是IP格式
        /// <summary>   
        /// 判断是否是IP地址格式 0.0.0.0   
        /// </summary>   
        /// <param name="str1">待判断的IP地址</param>   
        /// <returns>true or false</returns>   
        public static bool IsIPAddress(string str1) {
            if (str1 == null || str1 == string.Empty || str1.Length < 7 || str1.Length > 15) return false;
            string regformat = @"^\d{1,3}[\.]\d{1,3}[\.]\d{1,3}[\.]\d{1,3}$";
            Regex regex = new Regex(regformat, RegexOptions.IgnoreCase);
            return regex.IsMatch(str1);
        }
        #endregion

        #region 将有SQL注入的关键字进行替换
        /// <summary>
        ///  将有SQL注入的关键字进行替换
        /// </summary>
        /// <param name="key">需要检查的字符串</param>
        /// <returns>进行替换后的字符串</returns>
        public static string ReplaceString(string key)
        {
            //构造SQL的注入关键字符
            #region 字符
            string[] strBadChar = {"and"
    ,"exec"
    ,"insert"
    ,"select"
    ,"delete"
    ,"update"
    ,"count"
    ,"or"
    //,"*"
    ,"%"
    ,":"
    ,"'"
    ,"\""
    ,"chr"
    ,"mid"
    ,"master"
    ,"truncate"
    ,"char"
    ,"declare"
    ,"SiteName"
    ,"net user"
    ,"xp_cmdshell"
    ,"/add"
    ,"exec master.dbo.xp_cmdshell"
    ,"net localgroup administrators"};
            #endregion

            //构造正则表达式
            string str_Regex = "";
            for (int i = 0; i < strBadChar.Length - 1; i++)
            {
                str_Regex += strBadChar[i] + "|";
            }
            str_Regex += strBadChar[strBadChar.Length - 1];

            //str_Regex = str_Regex.Replace("|'|", "|");

            if (key != string.Empty && key != null)
            {
                return Regex.Replace(key, str_Regex, "");
            }
            return key;
        }
        #endregion

    }
}
