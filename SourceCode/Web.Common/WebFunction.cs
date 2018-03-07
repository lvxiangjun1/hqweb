using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Web.Common
{
    public class WebFunction
    {

        public WebFunction()
        {
        }

        public static string GetNodeName(string NodeID)
        {
            string strSql = "SELECT NODENAME FROM T_NEWSNODE WHERE ID = "+NodeID;
            DataTable DT = PersistenceLayer.Query.ProcessSql(strSql, Names.DBName);
            if (DT.Rows.Count > 0)
            {
                return DT.Rows[0][0].ToString();
            }
            else
            {
                return "未知栏目";
            }
        }
    }
}
