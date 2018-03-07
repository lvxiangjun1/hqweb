using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data;
using PersistenceLayer; 
using Web.Common;
using System.IO;
using System.Xml.Xsl;
using System.Text.RegularExpressions;
namespace Web.BaseWeb
{
    /// <summary>
    /// HtmlCreate 的摘要说明。
    /// </summary>
    public class ContentsList
    {
        public ContentsList()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }

        #region 形成新闻列表HTML
        /// <summary>
        /// 形成新闻列表HTML
        /// </summary>
        /// <param name="NodeId"></param>
        /// <param name="outputQty"></param>
        /// <param name="TitleLength"></param>
        /// <returns></returns>
        public static StringWriter GetContentList(string NodeId, string outputQty, string TitleLength, bool outputType, string DateTimeFormat, string OrderString, string UpDown)
        {
            string strSql = "SELECT WEB_TB_COMMONMODEL.GENERALID,WEB_TB_COMMONMODEL.TITLE FROM WEB_TB_COMMONMODEL ORDER BY " + OrderString + " " + UpDown;
            strSql = "SELECT * FROM (SELECT ROWNUM AS RN,T1.* FROM (" + strSql + ")  T1 WHERE ROWNUM <= " + outputType + ") WHERE RN >= 0";
            DataTable DT = PersistenceLayer.Query.ProcessSql(strSql, Names.DBName);
            string xslPath = BaseClass.GetListLabel() + "通用信息列表.config";
            XsltArgumentList argsList = new XsltArgumentList();
            argsList.AddParam("titleLength", "", TitleLength);
            StringWriter str = new StringWriter();
            str = LabelManage.GetOutPrint(DT, xslPath, argsList);
            return str;
        }

        #endregion

        #region 图片新闻FLASH展示
        /// <summary>
        /// 图片新闻FLASH展示
        /// </summary>
        /// <param name="NodeID"></param>
        /// <param name="outputType"></param>
        /// <param name="titleLength"></param>
        /// <param name="contentLength"></param>
        /// <param name="imageClass"></param>
        /// <param name="titleClass"></param>
        /// <param name="imageWidth"></param>
        /// <param name="imageHeight"></param>
        /// <param name="OrderString"></param>
        /// <param name="UpDown"></param>
        /// <returns>AddLinks</returns>

        public static StringWriter GetPicShow(string NodeId, string outputType, int titleLength, string imageWidth, string imageHeight, string OrderString, string UpDown)
        {
            try
            {
                string strsql = "SELECT T_PRODUCT.ID,T_PRODUCTPIC.PICURL,T_PRODUCT.PRONAME"
                    + " FROM T_PRODUCT,T_PRODUCTPIC WHERE PICURL <> 'NULL' AND T_PRODUCT.PROID=T_PRODUCTPIC.PROID AND T_PRODUCTPIC.ISTOP=1 ORDER BY " + OrderString + " " + UpDown;
                strsql = "SELECT * FROM (SELECT ROWNUM AS RN,T1.* FROM (" + strsql + ")  T1 WHERE ROWNUM <= " + outputType + ") WHERE RN >= 0";
                DataTable DT = PersistenceLayer.Query.ProcessSql(strsql, Names.DBName);
                string xslPath = BaseClass.GetListLabel() + "WEB_首页图片新闻滚动列表.config";
                XsltArgumentList argsList = new XsltArgumentList();
                argsList.AddParam("titleLength", "", titleLength);
                argsList.AddParam("focusWidth", "", imageWidth);
                argsList.AddParam("focusHeight", "", imageHeight);
                StringWriter str = new StringWriter();
                str = LabelManage.GetOutPrint(DT, xslPath, argsList);
                return str;
            }
            catch (Exception ex)
            {
                StringWriter str1 = new StringWriter();
                return str1;
            }
        }
        public static StringWriter GetSqPicShow(string NodeId, string outputType, int titleLength, string imageWidth, string imageHeight, string OrderString, string UpDown,string orgCode)
        {
            try
            {
                string strsql = "SELECT ID,ORGCODE,COM_TB_SQXW_0001.PICURL,TITLE"
                    + " FROM COM_TB_SQXW_0001 WHERE PICURL <> 'NULL' AND COM_TB_SQXW_0001.STATUS=1 and COM_TB_SQXW_0001.ORGCODE=" + orgCode + " ORDER BY " + OrderString + " " + UpDown;
                strsql = "SELECT * FROM (SELECT ROWNUM AS RN,T1.* FROM (" + strsql + ")  T1 WHERE ROWNUM <= " + outputType + ") WHERE RN >= 0";
                DataTable DT = PersistenceLayer.Query.ProcessSql(strsql, Names.DBName);
                string xslPath = BaseClass.GetListLabel() + "WEB_首页图片新闻滚动列表.config";
                XsltArgumentList argsList = new XsltArgumentList();
                argsList.AddParam("titleLength", "", titleLength);
                argsList.AddParam("focusWidth", "", imageWidth);
                argsList.AddParam("focusHeight", "", imageHeight);
                StringWriter str = new StringWriter();
                str = LabelManage.GetOutPrint(DT, xslPath, argsList);
                return str;
            }
            catch (Exception ex)
            {
                StringWriter str1 = new StringWriter();
                return str1;
            }
        }
        public static StringWriter GetPicNewsShow(string NodeId, string outputType, int titleLength, string imageWidth, string imageHeight, string OrderString, string UpDown)
        {
            string strsql = "SELECT WEB_TB_COMMONMODEL.GENERALID,WEB_TB_COMMONMODEL.DEFAULTPICURL,WEB_TB_COMMONMODEL.TITLE"
                + " FROM WEB_TB_COMMONMODEL WHERE DEFAULTPICURL <> 'NULL' AND WEB_TB_COMMONMODEL.STATUS=99 AND NODEID =" + NodeId + " ORDER BY " + OrderString + " " + UpDown;
            strsql = "SELECT * FROM (SELECT ROWNUM AS RN,T1.* FROM (" + strsql + ")  T1 WHERE ROWNUM <= " + outputType + ") WHERE RN >= 0";
            DataTable DT = PersistenceLayer.Query.ProcessSql(strsql, Names.DBName);
            string xslPath = BaseClass.GetListLabel() + "WEB_首页新闻图片列表.config";
            XsltArgumentList argsList = new XsltArgumentList();
            argsList.AddParam("titleLength", "", titleLength);
            argsList.AddParam("focusWidth", "", imageWidth);
            argsList.AddParam("focusHeight", "", imageHeight);
            StringWriter str = new StringWriter();
            str = LabelManage.GetOutPrint(DT, xslPath, argsList);
            return str;
        }

        #endregion

    
         

        #region  截取字符串
        private static Regex RegNumber = new Regex("^\\d+$");
        private static Regex RegNumberSign = new Regex("^-?\\d+$");
        private static Regex RegDecimal = new Regex("^\\d+(\\.\\d+)?$");
        private static Regex RegDecimalSign = new Regex("^(-?\\d+)(\\.\\d+)?$"); //等价于^[+-]?\d+[.]?\d+$

        public static string CutString(string inputString, int len, bool withbit)
        {
            ASCIIEncoding ascii = new ASCIIEncoding();
            int tempLen = 0;
            string tempString = "";
            byte[] s = ascii.GetBytes(inputString);
            for (int i = 0; i < s.Length; i++)
            {
                if ((int)s[i] == 63)
                {
                    tempLen += 2;
                }
                else
                {
                    tempLen += 1;
                }

                try
                {
                    tempString += inputString.Substring(i, 1);
                }
                catch
                {
                    break;
                }

                if (tempLen > len) break;
            }

            //如果截过则加上半个省略号
            if (tempString != inputString)
            {
                withbit = true;
                byte[] mybyte = System.Text.Encoding.Default.GetBytes(inputString);
                if (mybyte.Length > len) tempString += "...";
            }
            return tempString;
        }
        #endregion
         

    }

}
