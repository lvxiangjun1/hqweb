using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Text;
using System.Data;
using PersistenceLayer;
using System.Xml.Xsl;
using System.Xml.XPath;
using System.IO;
using System.Web; 
namespace Web.BaseWeb
{
    /// <summary>
    /// LabelManage 的摘要说明。
    /// 网站标签管理
    /// </summary>
    public class LabelManage
    {
        public LabelManage()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }


        #region 动态标签转化成HTML输出
        /// <summary>
        /// 动态标签转化成HTML输出
        /// </summary>
        /// <param name="strsql"></param>
        /// <param name="xlstPath"></param>
        /// <param name="argsList"></param>
        /// <returns></returns>
        public static StringWriter GetOutPrint(DataTable DT, string xlstPath, XsltArgumentList argsList)
        {
            DataSet DS = new DataSet();
            DS.Tables.Add(DT);
            string XmlStr = "<?xml version=\"1.0\" encoding=\"utf-8\" ?>";
            XmlStr = XmlStr + DS.GetXml().ToString();
            XmlDocument XmlDoc = new XmlDocument();
            XmlDoc.LoadXml(XmlStr);

            XslCompiledTransform transform = new XslCompiledTransform();
            transform.Load(xlstPath);
            XPathNavigator navgator = XmlDoc.CreateNavigator();
            argsList.AddExtensionObject("WP:BaseClass", new BaseClass());
            StringWriter output = new StringWriter();
            transform.Transform(navgator, argsList, output);
            return output;
        }

        #endregion


 

    }
}
