using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Text.RegularExpressions;

namespace Web.Common
{
    /// <summary>
    /// SQL语句验证
    /// </summary>
    public class SQLToolAction
    {
        #region  public static bool ValidateQuery(string[] keyword)
        /// <summary>
        /// 验证输入的字符数组是否含有注入SQL语句，true为不含，false为包含
        /// </summary>
        /// <param name="keyword"></param>
        /// <returns></returns>
        public static bool ValidateQuery(string[] keyword)
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
            string str_Regex = ".*(";
            for (int i = 0; i < strBadChar.Length - 1; i++)
            {
                str_Regex += strBadChar[i] + "|";
            }
            str_Regex += strBadChar[strBadChar.Length - 1] + ").*";

            foreach (string str in keyword)
            {
                //去掉单引号检验

                //str_Regex = str_Regex.Replace("|'|", "|");

                if (str != "")
                {
                    if (Regex.Matches(str, str_Regex).Count > 0)
                    {
                        //有SQL注入字符
                        return false;
                    }
                }

            }
            return true;
        }
        #endregion

        #region public static string ReplaceString(string key)
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

            if (key !=string.Empty&&key!=null)
            {
                return Regex.Replace(key, str_Regex, "");
            }
            return key;
        }
        #endregion

        #region SQL注入检测
        /// <summary>
        ///SQL注入过滤
        /// </summary>
        /// <param name="InText">要过滤的字符串</param>
        /// <returns>如果参数存在不安全字符，则返回true</returns>
        public static bool SQLValidateCheck(string InText)
        {
            string word = "and|exec|insert|select|delete|update|chr|mid|master|or|truncate|char|declare|join|count|*|%|'|SiteName|net user|xp_cmdshell|/add|exec master.dbo.xp_cmdshell|net localgroup administrators'";
            if (InText == null)
                return false;
            foreach (string str_t in word.Split('|'))
            {
                if ((InText.ToLower().IndexOf(str_t + " ") > -1) || (InText.ToLower().IndexOf(" " + str_t) > -1) || (InText.ToLower().IndexOf(str_t) > -1))
                {
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region 检测字符串是否全为正整数
        /// <summary>
        /// 检测字符串是否全为正整数
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsNum(string str)
        {
            bool blResult = true;//默认状态下是数字

            if (str == "")
                blResult = false;
            else
            {
                foreach (char Char in str)
                {
                    if (!char.IsNumber(Char))
                    {
                        blResult = false;
                        break;
                    }
                }
                if (blResult)
                {
                    if (int.Parse(str) == 0)
                        blResult = false;
                }
            }
            return blResult;
        }
        #endregion

    }
}
