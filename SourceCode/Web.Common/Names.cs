using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;

namespace Web.Common
{
    public class Names
    {
        public static string DBName = "JH8890";

        public static string SessionManage = "SessionManage";

        public static string Empty = "";

       
        #region 错误类型
        public static string Error = "Error";
        public static string NotFindTable = "没有该视图或者表！";
        public static string NotFindErr = "您要查看的记录已经被删除，无法查看！";
        public static string SystemErr = "系统发生错误，请联系管理员！";
        public static string ParamFormatErr = "指定参数格式错误！";
        public static string ReasonStr = "原因是：";
        public static string CreateSuccess = "您成功的添加了一条记录！";
        public static string CreateFailure = "添加记录失败！";
        public static string ModifySuccess = "您成功的修改了一条记录！";
        public static string ModifyFailure = "修改记录失败！";
        public static string Deleteprefix = "您成功的删除了 ";
        public static string Deletesuffix = " 条记录";
        public static string NotIn = " 不详";
        public static string NotFindName = "用户不存在";
        public static string Null = "null"; 
        #endregion
        /// <summary
        /// 判断文件是否为图片
        /// </summary
        /// <param name="path"文件的完整路径</param
        /// <returns返回结果</returns
        public static Boolean IsImage(string path)
        {
            try
            {
                System.Drawing.Image img = System.Drawing.Image.FromFile(path);
                return true;
            }
            catch { return false; }
        }

        /// <summary>
        /// 根据文件头判断上传的文件类型
        /// </summary>
        /// <param name="filePath">filePath是文件的完整路径 </param>
        /// <returns>返回true或false</returns>
        public static Boolean IsCorrectFile(string filePath)
        {
            try
            {
                FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                BinaryReader reader = new BinaryReader(fs);
                string fileClass;
                byte buffer;
                buffer = reader.ReadByte();
                fileClass = buffer.ToString();
                buffer = reader.ReadByte();
                fileClass += buffer.ToString();
                reader.Close();
                fs.Close();
                if (fileClass == "255216" || fileClass == "7173" || fileClass == "13780" || fileClass == "6677")

                //255216是jpg;7173是gif;6677是BMP,13780是PNG;7790是exe,8297是rar 
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public static string GetSingQuote(string tm)
        {
            return tm.Replace("'", "''");
        }

        public static string EncryptPassword(string strpwd)
        {
            strpwd = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(strpwd, "MD5");
            return strpwd;
        }


        public static bool IsHasAuth(string userName,string nodeID)
        {
            string strSql = "SELECT ID FROM T_WEBMANAGEROLE WHERE USERNAME = '" + userName + "' AND NODEID = '" + nodeID + "'";
            DataTable DT = PersistenceLayer.Query.ProcessSql(strSql, DBName);
            if (DT.Rows.Count > 0)
                return true;
            else
                return false;
        }

    }
}
