using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;

namespace Web.BaseWeb
{

    /// <summary>
    /// CheckLogin 的摘要说明。
    /// </summary>
    public class XMLExplainer
    {
        public XMLExplainer()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }

        public static string GetXMLValue(string ParentName,string NodeName, string XMLFileName)
        {
            try
            {
                XElement xmlReader = XElement.Load(XMLFileName);
                IEnumerable<XElement> ie = from x in xmlReader.DescendantsAndSelf(ParentName) select x;
                foreach (XElement xl in ie)
                {
                    return xl.Element(NodeName).Value;
                }
                return "";
            }
            catch
            {
                return "";
            }
        }

        public static DataTable GetXMLValues(string ParentName, string XMLFileName)
        {
            DataTable DT = new DataTable();
            DT.Columns.Add("name");
            DT.Columns.Add("datatype");
            DT.Columns.Add("default");
            try
            {
                XElement xmlReader = XElement.Load(XMLFileName);
                IEnumerable<XElement> ie = from x in xmlReader.DescendantsAndSelf(ParentName) select x;
                foreach (XElement xl in ie)
                {
                    DataRow DR = DT.NewRow();
                    DR["name"] = xl.Element("name").Value;
                    DR["datatype"] = xl.Element("datatype").Value;
                    DR["default"] = xl.Element("default").Value;
                    DT.Rows.Add(DR);
                }
                return DT;
            }
            catch
            {
                return DT;
            }
        }
    }
}
