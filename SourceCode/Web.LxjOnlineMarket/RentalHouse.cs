using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Web.Common;
using PersistenceLayer;
using Action_Log4Net; 

namespace Web.LxjOnlineMarket
{
  public  class RentalHouse
  {

      #region 得到车辆颜色ST_CARCOLOR的值
      public static string GetST_CARCOLORE(string code)
      {
          string result = null;
          string sql = "SELECT * FROM ST_CARCOLORE WHERE CODE='" + code + "'";
          try
          {
              DataTable dt = Query.ProcessSql(sql, Names.DBName);
              if (dt.Rows.Count>0)
              {
                  result = dt.Rows[0]["VVALUE"].ToString();
              }
          }
          catch (Exception ex)
          {
              SysLog.Error("LxjOnlineMarket.GetST_CARCOLORE:", ex);
          }
          return result;
      }
      #endregion


      #region 得到产品类型的值
      public static string GetST_PROTYPE(string code)
      {
          string result = null;
          string sql = "SELECT * FROM ST_PROTYPE WHERE CODE='" + code + "'";
          try
          {
              DataTable dt = Query.ProcessSql(sql, Names.DBName);
              if (dt.Rows.Count > 0)
              {
                  result = dt.Rows[0]["VVALUE"].ToString();
              }
          }
          catch (Exception ex)
          {
              SysLog.Error("LxjOnlineMarket.GetST_CARCOLORE:", ex);
          }
          return result;
      }
      #endregion

      #region 得到数据类型值
      public static string GetTableNameValue(string TableName,string code)
      {
          string result = "";
          string sql = "SELECT * FROM " + TableName + " WHERE CODE='"+ code+"' and IORDER>0";
          try
          {
             DataTable dt= Query.ProcessSql(sql, Names.DBName);
             if (dt.Rows.Count>0)
             {
                 result=dt.Rows[0]["VVALUE"].ToString();
             }
          }
          catch (Exception ex)
          {
              SysLog.Error("LxjOnlineMarket.GetST_HOUSETYPE:", ex);
          }
          return result;
      }
      #endregion

      #region 得到装修类型GetST_DECORATION的数据源
      public static DataTable GetST_DECORATION()
      {
          DataTable result = null;
          string sql = "SELECT * FROM ST_DECORATION WHERE IORDER>0";
          try
          {
              result = Query.ProcessSql(sql, Names.DBName);
          }
          catch (Exception ex)
          {
              SysLog.Error("LxjOnlineMarket.GetST_DECORATION:", ex);
          }
          return result;
      }
      #endregion

      #region 得到朝向类型GetST_DECORATION的数据源
      public static DataTable GetST_TOWARD()
      {
          DataTable result = null;
          string sql = "SELECT * FROM ST_TOWARD WHERE IORDER>0";
          try
          {
              result = Query.ProcessSql(sql, Names.DBName);
          }
          catch (Exception ex)
          {
              SysLog.Error("LxjOnlineMarket.GetST_TOWARD:", ex);
          }
          return result;
      }
      #endregion

      #region 得到单类型的数据源
      public static DataTable GetSTONETYPE(string TableName)
      {
          DataTable result = null;
          string sql = "SELECT * FROM " + TableName + " WHERE IORDER>0";
          try
          {
              result = Query.ProcessSql(sql, Names.DBName);
          }
          catch (Exception ex)
          {
              SysLog.Error("LxjOnlineMarket.GetSTONETYPE:", ex);
          }
          return result;
      }
      #endregion 

    }
}
