using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Web.Common
{
    /// <summary>
    /// Sequence的摘要说明
    /// </summary>
    public class Sequence
    {
        #region
        /// <summary>
        /// 得到Sequence下一个值
        /// </summary>
        /// <param name="SequenceName"></param>
        /// <returns></returns>
        public static int GetNextValue(String SequenceName)
        {
            string strsql = "Select " + SequenceName + ".nextval from dual";
            DataTable dt = PersistenceLayer.Query.ProcessSql(strsql, Names.DBName);
            int ret = int.Parse(dt.Rows[0][0].ToString());
            return ret;
        }
        #endregion
    }
}
