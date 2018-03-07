using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PersistenceLayer;

namespace Web.Common
{
    /// <summary>
    /// Pages的摘要说明
    /// </summary>
    public class Pages {
        public Pages() {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }

        #region 得到分页数据

        /// <summary>
        /// 得到分页数据
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="currentPage"></param>
        /// <param name="pagesize"></param>
        /// <param name="recordcount"></param>
        /// <returns></returns>
        public static DataTable GetPage(string sql, int currentPage, int pagesize, out int recordcount) {
            int startRow = (currentPage - 1) * pagesize;
            int LastRowNum = startRow + pagesize;
            //if (startRow != 0)
            //    startRow++;
            //String TempSql = "SELECT * FROM (SELECT ROWNUM AS RN,T1.* FROM (" + sql + ")  T1) T2 WHERE RN BETWEEN " + startRow + " AND " + LastRowNum;
            String TempSql = "SELECT * FROM (SELECT ROWNUM AS RN,T1.* FROM (" + sql + ") T1 WHERE ROWNUM <= " + LastRowNum + ") T2 WHERE RN > " + startRow;
            recordcount = GetPageRecord(sql);
            return PersistenceLayer.Query.ProcessSql(TempSql, Names.DBName);
        }

        #endregion

        #region 得到记录总数

        /// <summary>
        /// 得到记录总数
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int GetPageRecord(string sql) {
            sql = System.Text.RegularExpressions.Regex.Replace(sql, "ORDER BY.*", "");
            sql = "select count(*) from (" + sql + ")";
            DataTable DM = PersistenceLayer.Query.ProcessSql(sql, Names.DBName);
            int recordcount = int.Parse(DM.Rows[0][0].ToString());
            return recordcount;
        }

        #endregion
    }
}
