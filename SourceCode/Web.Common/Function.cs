using PersistenceLayer;
using System;
using System.Data;
using System.Text.RegularExpressions;
namespace Web.Common
{
    public class Function
    {
        public static DateTime GetMondayDate(DateTime someDate)
        {
            int num = someDate.DayOfWeek - DayOfWeek.Monday;
            if (num == -1)
            {
                num = 6;
            }
            TimeSpan value = new TimeSpan(num, 0, 0, 0);
            return someDate.Subtract(value);
        }
        public static DateTime GetSundayDate(DateTime someDate)
        {
            int num = (int)someDate.DayOfWeek;
            if (num != 0)
            {
                num = 7 - num;
            }
            TimeSpan value = new TimeSpan(num, 0, 0, 0);
            return someDate.Add(value);
        }
        public static bool IsHandset(string str_handset)
        {
            return Regex.IsMatch(str_handset, "^(86)*0*[1]+[3,5,8]+\\d{9}$");
        }
        public static bool IsTelephone(string str_telephone)
        {
            return Regex.IsMatch(str_telephone, "^(\\d{3,4})?-*\\d{6,8}$");
        }
        public static string GetNullString(string NullString)
        {
            string result;
            if (string.IsNullOrEmpty(NullString))
            {
                result = "";
            }
            else
            {
                result = NullString;
            }
            return result;
        }
        public static string GetChByEn(string temp)
        {
            string result;
            if ("Y".Equals(temp))
            {
                result = "是";
            }
            else
            {
                result = "否";
            }
            return result;
        }

        public static int CalculateAgeCorrect(DateTime birthDate, DateTime now)
        {
            int age = now.Year - birthDate.Year;
            if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day)) age--;
            return age;
        }


        public static DataTable GetPage(string sql, int currentPage, int pagesize, out int recordcount)
        {
            int num = (currentPage - 1) * pagesize;
            int num2 = num + pagesize;
            string text = string.Concat(new object[]
			{
				"SELECT * FROM (SELECT ROWNUM AS RN,T1.* FROM (",
				sql,
				")  T1 WHERE ROWNUM <= ",
				num2,
				") WHERE RN > ",
				num
			});
            recordcount = Function.GetPageRecord(sql);
            return Query.ProcessSql(text, Names.DBName);
        }
        public static int GetPageRecord(string sql)
        {
            sql = Regex.Replace(sql, "ORDER BY.*", "");
            sql = "select count(*) from (" + sql + ")";
            DataTable dataTable = Query.ProcessSql(sql, Names.DBName);
            return int.Parse(dataTable.Rows[0][0].ToString());
        }
        public static DataTable GetStTableSource(string tablename)
        {
            string text = "select * from " + tablename + " where ORDERID >0 order by ORDERID";
            return Query.ProcessSql(text, Names.DBName);
        }
    }
}
