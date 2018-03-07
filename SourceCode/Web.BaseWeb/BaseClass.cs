using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Web;
using PersistenceLayer;
using System.Globalization;
using System.IO;
using System.Xml.Xsl;
using System.Xml.Linq;
using System.Xml;
using System.Xml.XPath;
using System.Text.RegularExpressions;
using Web.Common;

namespace Web.BaseWeb
{
    /// <summary>
    /// BaseClass 的摘要说明。
    /// 网站基础类管理
    /// </summary>
    public class BaseClass
    {
        public BaseClass()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }

        #region 截断字符串
        /// <summary>
        /// 截断字符串
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string CutText(string str, int len, string morestr)
        {
            if (str.Length > len)
            {
                str = str.Substring(0, len) + morestr;
            }
            return str;
        }

        #endregion

        #region 去除HTML代码
        /// <summary>
        /// 去除HTML代码
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string RemoveHtml(string str)
        {
            return CheckStr.HtmlFilter(str);
        }

        #endregion

        #region 得到上传图片基本地址
        /// <summary>
        /// 得到上传图片基本地址
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public static string UpLoadDir()
        {
            return SiteInfo.VirtualPath() + "/uploadfile";
        }

        #endregion

        #region 时间格式化
        /// <summary>
        /// 时间格式化
        /// </summary>
        /// <param name="StrDateTime"></param>
        /// <param name="FormatDatetime"></param>
        /// <returns></returns>
        public static string GetDateTime(DateTime StrDateTime, string FormatDatetime)
        {
            try
            {
                return StrDateTime.ToString(FormatDatetime, DateTimeFormatInfo.InvariantInfo);
            }
            catch
            {
                return DateTime.Now.ToShortDateString();
            }
        }

        #endregion


        #region 时间格式化
        /// <summary>
        /// 时间格式化
        /// </summary>
        /// <param name="StrDateTime"></param>
        /// <param name="FormatDatetime"></param>
        /// <returns></returns>
        public static string GetyearTime(DateTime StrDateTime, string FormatDatetime)
        {
            try
            {
                string year= StrDateTime.ToString(FormatDatetime, DateTimeFormatInfo.InvariantInfo);
                return year.Substring(0, 4);
            }
            catch
            {
                return DateTime.Now.ToString("yyyy");
            }
        }

        public static string GetmonthTime(DateTime StrDateTime, string FormatDatetime)
        {
            try
            {
                string month = StrDateTime.ToString(FormatDatetime, DateTimeFormatInfo.InvariantInfo);
                string monthnew= month.Substring(5, 2);
                string result="";
                switch (monthnew)
                {
                    case "01":
                        result = "一月";
                        break;
                    case "02":
                        result = "二月";
                        break;
                    case "03":
                        result = "三月";
                        break;
                    case "04":
                        result = "四月";
                        break;
                    case "05":
                        result = "五月";
                        break;
                    case "06":
                        result = "六月";
                        break;
                    case "07":
                        result = "七月";
                        break;
                    case "08":
                        result = "八月";
                        break;
                    case "09":
                        result = "九月";
                        break;
                    case "10":
                        result = "十月";
                        break;
                    case "11":
                        result = "十一月";
                        break;
                    case "12":
                        result = "十二月";
                        break;
                    default:
                        break;
                }
                return result;
            }
            catch
            {
                return DateTime.Now.ToString("MM");
            }
        }
        public static string GetdayTime(DateTime StrDateTime, string FormatDatetime)
        {
            try
            {
                string day = StrDateTime.ToString(FormatDatetime, DateTimeFormatInfo.InvariantInfo);
                return day.Substring(8, 2);
            }
            catch
            {
                return DateTime.Now.ToString("dd");
            }
        }
        #endregion

        #region 得到列表类标签库地址
        /// <summary>
        /// 得到列表类标签库地址
        /// </summary>
        /// <returns></returns>
        public static string GetListLabel()
        {
            return System.Web.HttpContext.Current.Server.MapPath(SiteInfo.VirtualPath() + "/Template/标签库/列表类/");
        }

        #endregion

        #region 得到内容类标签库地址
        /// <summary>
        /// 得到内容类标签库地址
        /// </summary>
        /// <returns></returns>
        public static string GetContentLabel()
        {
            return System.Web.HttpContext.Current.Server.MapPath(SiteInfo.VirtualPath() + "/Template/标签库/内容类/");
        }

        #endregion

        #region 得到静态类标签库地址
        /// <summary>
        /// 得到静态类标签库地址
        /// </summary>
        /// <returns></returns>
        public static string GetStaticLabel()
        {
            return System.Web.HttpContext.Current.Server.MapPath(SiteInfo.VirtualPath() + "/Template/标签库/静态类/");
        }

        #endregion

        #region 网站虚拟路径
        /// <summary>
        /// 网站虚拟路径
        /// </summary>
        /// <returns></returns>
        public static string VirtualPath()
        {
            return SiteInfo.VirtualPath() + "/";
        }

        #endregion

        #region 网站虚拟路径
        /// <summary>
        /// 网站虚拟路径
        /// </summary>
        /// <returns></returns>
        public static string VirtualPath1()
        {
            return SiteInfo.VirtualPath();
        }

        #endregion

        #region 根据列表类样式展现HTML 有分页
        /// <summary>
        /// 根据列表类样式展现HTML 有分页
        /// </summary>
        /// <returns></returns>
        public static StringWriter ShowListLabel(out Int32 reacordCount, params string[] strString)
        {
            StringWriter output = new StringWriter();
            try
            {
                string LableName = "";
                XsltArgumentList argsList = new XsltArgumentList();
                argsList.AddExtensionObject("WP:BaseClass", new BaseClass());
                LableName = strString[0].Split('=')[1];
                string XMLPath = BaseClass.GetListLabel() + LableName + ".config";
                string LableSqlString = XMLExplainer.GetXMLValue("root", "LabelSqlString", XMLPath);
                string LabelSqlCount = XMLExplainer.GetXMLValue("root", "LabelSqlCount", XMLPath);
                string XsltString = XMLExplainer.GetXMLValue("root", "LabelTemplate", XMLPath);
                for (int i = 1; i < strString.Length; i++)
                {
                    string strObject = strString[i];
                    string[] strObjects = strObject.Split('=');
                    LableSqlString = LableSqlString.Replace("@" + strObjects[0], strObjects[1]);
                    LabelSqlCount = LabelSqlCount.Replace("@" + strObjects[0], strObjects[1]);
                    argsList.AddParam(strObjects[0], "", strObjects[1]);
                }
                DataTable DT = XMLExplainer.GetXMLValues("attributes", XMLPath);
                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    LableSqlString = LableSqlString.Replace("@" + DT.Rows[i]["name"].ToString(), DT.Rows[i]["default"].ToString());
                    LabelSqlCount = LabelSqlCount.Replace("@" + DT.Rows[i]["name"].ToString(), DT.Rows[i]["default"].ToString());
                    string tempstring = (string)argsList.GetParam(DT.Rows[i]["name"].ToString(), "");
                    try
                    {
                        argsList.AddParam(DT.Rows[i]["name"].ToString(), "", DT.Rows[i]["default"].ToString());
                    }
                    catch
                    {
                        continue;
                    }
                }
                XDocument source = new XDocument();
                XDocument newTree = new XDocument();
                using (XmlWriter writer = newTree.CreateWriter())
                {
                    XslCompiledTransform xslt = new XslCompiledTransform();
                    xslt.Load(XmlReader.Create(new StringReader(XsltString)));
                    DataTable DTT = PersistenceLayer.Query.ProcessSql(LableSqlString, Names.DBName);
                    DataSet DS = new DataSet();
                    DS.Tables.Add(DTT);
                    string XmlStr = "<?xml version=\"1.0\" encoding=\"utf-8\" ?>";
                    XmlStr = XmlStr + DS.GetXml().ToString();
                    XmlDocument XmlDoc = new XmlDocument();
                    XmlDoc.LoadXml(XmlStr);
                    XPathNavigator navgator = XmlDoc.CreateNavigator();
                    xslt.Transform(navgator, argsList, output);
                    reacordCount = 0;
                    if (!"".Equals(LabelSqlCount))
                    {
                        DataTable DTCount = PersistenceLayer.Query.ProcessSql(LabelSqlCount, Names.DBName);
                        reacordCount = Convert.ToInt32(DTCount.Rows[0][0].ToString());
                    }
                    return output;
                }
            }
            catch (Exception ex)
            {
                output.Write(ex.Message.ToString());
                reacordCount = 0;
                return output;
            }

        }

        #endregion

        #region 根据列表类样式展现HTML 无分页
        /// <summary>
        /// 根据列表类样式展现HTML 无分页
        /// </summary>
        /// <returns></returns>
        public static StringWriter ShowListLabelNoPage(string strString)
        {
            string[] strList = strString.Split(',');
            string tempstr = "";
            for (int i = 0; i < strList.Length; i++)
            {
                if (i == strList.Length - 1)
                    tempstr = tempstr + strList[i];
                else
                    tempstr = tempstr + strList[i] + ",";
            }
            return ShowListLabelNoPageIn(tempstr);
        }

        public static StringWriter ShowListLabelNoPageIn(params string[] strString)
        {
            StringWriter output = new StringWriter();
            try
            {
                string LableName = "";
                XsltArgumentList argsList = new XsltArgumentList();
                argsList.AddExtensionObject("WP:BaseClass", new BaseClass());
                LableName = strString[0].Split('=')[1];
                string XMLPath = BaseClass.GetListLabel() + LableName + ".config";
                string LableSqlString = XMLExplainer.GetXMLValue("root", "LabelSqlString", XMLPath);
                string LabelSqlCount = XMLExplainer.GetXMLValue("root", "LabelSqlCount", XMLPath);
                string XsltString = XMLExplainer.GetXMLValue("root", "LabelTemplate", XMLPath);
                for (int i = 1; i < strString.Length; i++)
                {
                    string strObject = strString[i];
                    string[] strObjects = strObject.Split('=');
                    LableSqlString = LableSqlString.Replace("@" + strObjects[0], strObjects[1]);
                    argsList.AddParam(strObjects[0], "", strObjects[1]);
                }
                DataTable DT = XMLExplainer.GetXMLValues("attributes", XMLPath);
                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    LableSqlString = LableSqlString.Replace("@" + DT.Rows[i]["name"].ToString(), DT.Rows[i]["default"].ToString());
                    string tempstring = (string)argsList.GetParam(DT.Rows[i]["name"].ToString(), "");
                    try
                    {
                        argsList.AddParam(DT.Rows[i]["name"].ToString(), "", DT.Rows[i]["default"].ToString());
                    }
                    catch
                    {
                        continue;
                    }
                }
                XDocument source = new XDocument();
                XDocument newTree = new XDocument();
                using (XmlWriter writer = newTree.CreateWriter())
                {
                    XslCompiledTransform xslt = new XslCompiledTransform();
                    xslt.Load(XmlReader.Create(new StringReader(XsltString)));
                    DataTable DTT = PersistenceLayer.Query.ProcessSql(LableSqlString, Names.DBName);
                    DataSet DS = new DataSet();
                    DS.Tables.Add(DTT);
                    string XmlStr = "<?xml version=\"1.0\" encoding=\"utf-8\" ?>";
                    XmlStr = XmlStr + DS.GetXml().ToString();
                    XmlDocument XmlDoc = new XmlDocument();
                    XmlDoc.LoadXml(XmlStr);
                    XPathNavigator navgator = XmlDoc.CreateNavigator();
                    xslt.Transform(navgator, argsList, output);
                    return output;
                }
            }
            catch (Exception ex)
            {
                output.Write(ex.Message.ToString());
                return output;
            }

        }

        #endregion

        #region 根据列表类样式展现HTML 有分页
        /// <summary>
        /// 根据列表类样式展现HTML 有分页
        /// </summary>
        /// <returns></returns>
        public static StringWriter ShowListLabel81890(out Int32 reacordCount, params string[] strString)
        {
            StringWriter output = new StringWriter();
            try
            {
                string LableName = "";
                XsltArgumentList argsList = new XsltArgumentList();
                argsList.AddExtensionObject("WP:BaseClass", new BaseClass());
                LableName = strString[0].Split('=')[1];
                string XMLPath = BaseClass.GetListLabel() + LableName + ".config";
                string LableSqlString = XMLExplainer.GetXMLValue("root", "LabelSqlString", XMLPath);
                string LabelSqlCount = XMLExplainer.GetXMLValue("root", "LabelSqlCount", XMLPath);
                string XsltString = XMLExplainer.GetXMLValue("root", "LabelTemplate", XMLPath);
                for (int i = 1; i < strString.Length; i++)
                {
                    string strObject = strString[i];
                    string[] strObjects = strObject.Split('=');
                    LableSqlString = LableSqlString.Replace("@" + strObjects[0], strObjects[1]);
                    LabelSqlCount = LabelSqlCount.Replace("@" + strObjects[0], strObjects[1]);
                    argsList.AddParam(strObjects[0], "", strObjects[1]);
                }
                DataTable DT = XMLExplainer.GetXMLValues("attributes", XMLPath);
                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    LableSqlString = LableSqlString.Replace("@" + DT.Rows[i]["name"].ToString(), DT.Rows[i]["default"].ToString());
                    LabelSqlCount = LabelSqlCount.Replace("@" + DT.Rows[i]["name"].ToString(), DT.Rows[i]["default"].ToString());
                    string tempstring = (string)argsList.GetParam(DT.Rows[i]["name"].ToString(), "");
                    try
                    {
                        argsList.AddParam(DT.Rows[i]["name"].ToString(), "", DT.Rows[i]["default"].ToString());
                    }
                    catch
                    {
                        continue;
                    }
                }
                XDocument source = new XDocument();
                XDocument newTree = new XDocument();
                using (XmlWriter writer = newTree.CreateWriter())
                {
                    XslCompiledTransform xslt = new XslCompiledTransform();
                    xslt.Load(XmlReader.Create(new StringReader(XsltString)));
                    DataTable DTT = PersistenceLayer.Query.ProcessSql(LableSqlString, Names.DBName);
                    DataSet DS = new DataSet();
                    DS.Tables.Add(DTT);
                    string XmlStr = "<?xml version=\"1.0\" encoding=\"utf-8\" ?>";
                    XmlStr = XmlStr + DS.GetXml().ToString();
                    XmlDocument XmlDoc = new XmlDocument();
                    XmlDoc.LoadXml(XmlStr);
                    XPathNavigator navgator = XmlDoc.CreateNavigator();
                    xslt.Transform(navgator, argsList, output);
                    reacordCount = 0;
                    if (!"".Equals(LabelSqlCount))
                    {
                        DataTable DTCount = PersistenceLayer.Query.ProcessSql(LabelSqlCount, Names.DBName);
                        reacordCount = Convert.ToInt32(DTCount.Rows[0][0].ToString());
                    }
                    return output;
                }
            }
            catch (Exception ex)
            {
                output.Write(ex.Message.ToString());
                reacordCount = 0;
                return output;
            }

        }

        #endregion

        #region 根据内容类样式展现HTML
        /// <summary>
        /// 根据内容类样式展现HTML
        /// </summary>
        /// <returns></returns>
        public static StringWriter ShowContentLabel(params string[] strString)
        {
            StringWriter output = new StringWriter();
            try
            {
                string LableName = "";
                XsltArgumentList argsList = new XsltArgumentList();
                argsList.AddExtensionObject("WP:BaseClass", new BaseClass());
                LableName = strString[0].Split('=')[1];
                string XMLPath = BaseClass.GetContentLabel() + LableName + ".config";
                string LableSqlString = XMLExplainer.GetXMLValue("root", "LabelSqlString", XMLPath);
                string XsltString = XMLExplainer.GetXMLValue("root", "LabelTemplate", XMLPath);
                for (int i = 1; i < strString.Length; i++)
                {
                    string strObject = strString[i];
                    string[] strObjects = strObject.Split('=');
                    LableSqlString = LableSqlString.Replace("@" + strObjects[0], strObjects[1]);
                    argsList.AddParam(strObjects[0], "", strObjects[1]);
                }
                DataTable DT = XMLExplainer.GetXMLValues("attributes", XMLPath);
                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    LableSqlString = LableSqlString.Replace("@" + DT.Rows[i]["name"].ToString(), DT.Rows[i]["default"].ToString());
                    string tempstring = (string)argsList.GetParam(DT.Rows[i]["name"].ToString(), "");
                    if ("".Equals(tempstring) || tempstring == null)
                        argsList.AddParam(DT.Rows[i]["name"].ToString(), "", DT.Rows[i]["default"].ToString());
                }
                XDocument source = new XDocument();
                XDocument newTree = new XDocument();
                using (XmlWriter writer = newTree.CreateWriter())
                {
                    XslCompiledTransform xslt = new XslCompiledTransform();
                    xslt.Load(XmlReader.Create(new StringReader(XsltString)));
                    DataTable DTT = PersistenceLayer.Query.ProcessSql(LableSqlString, Names.DBName);
                    DataSet DS = new DataSet();
                    DS.Tables.Add(DTT);
                    string XmlStr = "<?xml version=\"1.0\" encoding=\"utf-8\" ?>";
                    XmlStr = XmlStr + DS.GetXml().ToString();
                    XmlDocument XmlDoc = new XmlDocument();
                    XmlDoc.LoadXml(XmlStr);
                    XPathNavigator navgator = XmlDoc.CreateNavigator();
                    xslt.Transform(navgator, argsList, output);
                    return output;
                }
            }
            catch (Exception ex)
            {
                output.Write(ex.Message.ToString());
                return output;
            }

        }

        #endregion

        #region 根据静态类样式展现HTML
        /// <summary>
        /// 根据静态类样式展现HTML
        /// </summary>
        /// <returns></returns>
        public static StringWriter ShowStaticLabel(params string[] strString)
        {
            StringWriter output = new StringWriter();
            try
            {
                string LableName = "";
                XsltArgumentList argsList = new XsltArgumentList();
                argsList.AddExtensionObject("WP:BaseClass", new BaseClass());
                LableName = strString[0].Split('=')[1];
                string XMLPath = BaseClass.GetStaticLabel() + LableName + ".config";
                string XsltString = XMLExplainer.GetXMLValue("root", "LabelTemplate", XMLPath);
                for (int i = 1; i < strString.Length; i++)
                {
                    string strObject = strString[i];
                    string[] strObjects = strObject.Split('=');
                    argsList.AddParam(strObjects[0], "", strObjects[1]);
                }
                DataTable DT = XMLExplainer.GetXMLValues("attributes", XMLPath);
                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    string tempstring = (string)argsList.GetParam(DT.Rows[i]["name"].ToString(), "");
                    if ("".Equals(tempstring) || tempstring == null)
                        argsList.AddParam(DT.Rows[i]["name"].ToString(), "", DT.Rows[i]["default"].ToString());
                }
                XDocument source = new XDocument();
                XDocument newTree = new XDocument();
                using (XmlWriter writer = newTree.CreateWriter())
                {
                    XslCompiledTransform xslt = new XslCompiledTransform();
                    xslt.Load(XmlReader.Create(new StringReader(XsltString)));
                    XmlDocument XmlDoc = new XmlDocument();
                    XPathNavigator navgator = XmlDoc.CreateNavigator();
                    xslt.Transform(navgator, argsList, output);
                    return output;
                }
            }
            catch (Exception ex)
            {
                output.Write(ex.InnerException.ToString());
                return output;
            }

        }

        #endregion

        #region 得到网站访问量
        /// <summary>
        /// 得到网站访问量
        /// </summary>
        /// <returns></returns>
        public static string GetTotalNum()
        {
            string strSql = "SELECT ALLHITS FROM T_WEBHITS";
            DataTable DT = PersistenceLayer.Query.ProcessSql(strSql, Names.DBName);
            if (DT.Rows.Count > 0)
            {
                strSql = "UPDATE T_WEBHITS SET ALLHITS = ALLHITS + 1";
                PersistenceLayer.Query.ProcessSqlNonQuery(strSql, Names.DBName);
                return DT.Rows[0][0].ToString();
            }
            else
            {
                strSql = "INSERT INTO T_WEBHITS (ALLHITS) VALUES (1)";
                PersistenceLayer.Query.ProcessSqlNonQuery(strSql, Names.DBName);
                return "1";
            }
        }

        #endregion

        #region 得到网站网址
        /// <summary>
        /// 得到网站网址
        /// </summary>
        /// <returns></returns>
        public static string GetSiteUrl()
        {
            return SiteInfo.SiteUrl();
        }

        #endregion

        #region 得到网站名称
        /// <summary>
        /// 得到网站名称
        /// </summary>
        /// <returns></returns>
        public static string GetSiteName()
        {
            string tt = SiteInfo.SiteName();
            return SiteInfo.SiteName();
        }

        #endregion

        #region 字符串转换INT
        /// <summary>
        /// 字符串转换INT
        /// </summary>
        /// <returns></returns>
        public static string GetPFNum(string PFNum)
        {
            try
            {
                return Convert.ToString(Convert.ToInt32(PFNum));
            }
            catch
            {
                return "1";
            }
        }

        #endregion

        public static string GetMemberPic(string TransactionID)
        {
            string strSql = "SELECT VAR_HEADURL FROM T_HELPONLINE T1,SYS_BASE_USERS T2 WHERE T1.VAR_ZH = T2.VAR_ZH AND T1.HTRANID = '" + TransactionID + "'";
            DataTable DT = PersistenceLayer.Query.ProcessSql(strSql, Names.DBName);
            if (DT.Rows.Count > 0)
            {
                if (DT.Rows[0][0].ToString().IndexOf("http://") > -1)
                {
                    return DT.Rows[0][0].ToString();
                }
                else
                {
                    return SiteInfo.VirtualPath() + "/"+ DT.Rows[0][0].ToString();
                }
            }
            else
            {
                return SiteInfo.VirtualPath() + "/images/no_photo22.jpg";
            }
        }

        public static string GetTopRentalPic(string SECHOUSEID)
        {
            string strSql = "SELECT PICURL FROM T_RENTHOUSEPIC   WHERE ISTOP=1 AND SECHOUSEID = '" + SECHOUSEID + "'";
            DataTable DT = PersistenceLayer.Query.ProcessSql(strSql, Names.DBName);
            if (DT.Rows.Count > 0)
            {
                if (DT.Rows[0][0].ToString().IndexOf("http://") > -1)
                {
                    return DT.Rows[0][0].ToString();
                }
                else
                {
                    return SiteInfo.VirtualPath() + "/UploadFiles/PictureSite/" + DT.Rows[0][0].ToString();
                }
            }
            else
            {
                return SiteInfo.VirtualPath() + "/images/no_photo22.jpg";
            }
        }
        public static string GetTopProPic(string SECHOUSEID)
        {
            string strSql = "SELECT PICURL FROM T_PRODUCTPIC   WHERE ISTOP=1 AND PROID = '" + SECHOUSEID + "'";
            DataTable DT = PersistenceLayer.Query.ProcessSql(strSql, Names.DBName);
            if (DT.Rows.Count > 0)
            {
                if (DT.Rows[0][0].ToString().IndexOf("http://") > -1)
                {
                    return DT.Rows[0][0].ToString();
                }
                else
                {
                    return SiteInfo.VirtualPath() + "/uploadfile/PictureSite/" + DT.Rows[0][0].ToString();
                }
            }
            else
            {
                return SiteInfo.VirtualPath() + "/images/no_photo22.jpg";
            }
        }



        public static string GetTopSecHousePic(string SECHOUSEID)
        {
            string strSql = "SELECT PICURL FROM T_SECHOUSEPIC  WHERE ISTOP=1 AND SECHOUSEID = '" + SECHOUSEID + "'";
            DataTable DT = PersistenceLayer.Query.ProcessSql(strSql, Names.DBName);
            if (DT.Rows.Count > 0)
            {
                if (DT.Rows[0][0].ToString().IndexOf("http://") > -1)
                {
                    return DT.Rows[0][0].ToString();
                }
                else
                {
                    return SiteInfo.VirtualPath() + "/UploadFiles/PictureSite/" + DT.Rows[0][0].ToString();
                }
            }
            else
            {
                return SiteInfo.VirtualPath() + "/images/no_photo22.jpg";
            }
        }

        public static string GetTopSecCarPic(string SECHOUSEID)
        {
            string strSql = "SELECT PICURL FROM T_SECCARPIC   WHERE ISTOP=1 AND SECCARID = '" + SECHOUSEID + "'";
            DataTable DT = PersistenceLayer.Query.ProcessSql(strSql, Names.DBName);
            if (DT.Rows.Count > 0)
            {
                if (DT.Rows[0][0].ToString().IndexOf("http://") > -1)
                {
                    return DT.Rows[0][0].ToString();
                }
                else
                {
                    return SiteInfo.VirtualPath() + "/UploadFiles/PictureSite/" + DT.Rows[0][0].ToString();
                }
            }
            else
            {
                return SiteInfo.VirtualPath() + "/images/no_photo22.jpg";
            }
        }

        public static string GetSecCarColor(string CARCOLOR)
        {
            string strSql = "SELECT VVALUE FROM ST_CARCOLOR   WHERE IORDER>0 AND CODE = '" + CARCOLOR + "'";
            DataTable DT = PersistenceLayer.Query.ProcessSql(strSql, Names.DBName);
            if (DT.Rows.Count > 0)
            {
                 
                    return DT.Rows[0][0].ToString(); 
            }
            else
            {
                return  "未知颜色";
            }
        }
        public static string GetProtype(string Protype)
        {
            string strSql = "SELECT VVALUE FROM ST_PROTYPE   WHERE IORDER>0 AND CODE = '" + Protype + "'";
            DataTable DT = PersistenceLayer.Query.ProcessSql(strSql, Names.DBName);
            if (DT.Rows.Count > 0)
            {

                return DT.Rows[0][0].ToString();
            }
            else
            {
                return "未知类型";
            }
        }
       


        public static string GetSubString(string str, int length)
        {
            string temp = str;
            int j = 0;
            int k = 0;
            for (int i = 0; i < temp.Length; i++)
            {
                if (Regex.IsMatch(temp.Substring(i, 1), @"[\u4e00-\u9fa5]+"))
                {
                    j += 2;
                }
                else
                {
                    j += 1;
                }
                if (j <= length)
                {
                    k += 1;
                }
                if (j >= length)
                {
                    return temp.Substring(0, k) + "...";
                }
            }
            return temp;
        }

        public static string GetTime(int time)
        {
            try
            {
                string str = "";
                int sum = Convert.ToInt32(time);
                int hour = sum / 60;
                int minute = sum % 60;

                if (hour == 0)
                {
                    str = minute + " 分钟";
                }
                else if (minute == 0)
                {
                    str = hour + " 小时";
                }
                else
                {
                    str = hour + "小时" + minute + "分钟";
                }
                return str;
            }
            catch
            {
                return "0 分钟";
            }
        }

        public static string GetMonthCN(string Code)
        {
            try
            {
                string str = "";

                switch (Code)
                {
                    case "1": str = "一月份";
                        break;
                    case "2": str = "二月份";
                        break;
                    case "3": str = "三月份";
                        break;
                    case "4": str = "四月份";
                        break;
                    case "5": str = "五月份";
                        break;
                    case "6": str = "六月份";
                        break;
                    case "7": str = "七月份";
                        break;
                    case "8": str = "八月份";
                        break;
                    case "9": str = "九月份";
                        break;
                    case "10": str = "十月份";
                        break;
                    case "11": str = "十一月份";
                        break;
                    case "12": str = "十二月份";
                        break;
                    default: str = "";
                        break;
                }

                return str;
            }
            catch
            {
                return "";
            }
        }

        public static bool CheckTime(string Btime, string Etime)
        {
            try
            {
                if (Convert.ToDateTime(Btime) <= Convert.ToDateTime(Etime))
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }



    }
}
