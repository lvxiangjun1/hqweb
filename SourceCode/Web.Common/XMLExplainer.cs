using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Xml.Linq;
namespace Web.Common
{
    public class XMLExplainer
    {
        public static string GetXMLValue(string ParentName, string NodeName, string XMLFileName)
        {
            string result;
            try
            {
                XElement xElement = XElement.Load(XMLFileName);
                IEnumerable<XElement> enumerable =
                    from x in xElement.DescendantsAndSelf(ParentName)
                    select x;
                using (IEnumerator<XElement> enumerator = enumerable.GetEnumerator())
                {
                    if (enumerator.MoveNext())
                    {
                        XElement current = enumerator.Current;
                        result = current.Element(NodeName).Value;
                        return result;
                    }
                }
                result = "";
            }
            catch
            {
                result = "";
            }
            return result;
        }
        public static DataTable GetXMLValues(string ParentName, string XMLFileName)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("name");
            dataTable.Columns.Add("datatype");
            dataTable.Columns.Add("default");
            DataTable result;
            try
            {
                XElement xElement = XElement.Load(XMLFileName);
                IEnumerable<XElement> enumerable =
                    from x in xElement.DescendantsAndSelf(ParentName)
                    select x;
                foreach (XElement current in enumerable)
                {
                    DataRow dataRow = dataTable.NewRow();
                    dataRow["name"] = current.Element("name").Value;
                    dataRow["datatype"] = current.Element("datatype").Value;
                    dataRow["default"] = current.Element("default").Value;
                    dataTable.Rows.Add(dataRow);
                }
                result = dataTable;
            }
            catch
            {
                result = dataTable;
            }
            return result;
        }
    }
}
