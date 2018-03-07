using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Web.BaseWeb
{
    public class SiteInfo
    {
        /// <summary>
        /// Function 的摘要说明。
        /// 网站基本配置
        /// </summary>
        public SiteInfo()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }

        public static string filePath = System.Web.HttpContext.Current.Server.MapPath("~/") + "Config/SiteInfo.config";

        public static string SiteTitle()
        {
            return XMLExplainer.GetXMLValue("SiteInfo", "SiteTitle", filePath);
        }

        public static string SiteName()
        {
            return XMLExplainer.GetXMLValue("SiteInfo", "SiteName", filePath);
        }

        public static string SiteUrl()
        {
            return XMLExplainer.GetXMLValue("SiteInfo", "SiteUrl", filePath);
        }

        public static string VirtualPath()
        {
            return XMLExplainer.GetXMLValue("SiteInfo", "VirtualPath", filePath);
        }

        public static string CookieName()
        {
            return XMLExplainer.GetXMLValue("SiteInfo", "CookieName", filePath);
        }

        public static string Domain()
        {
            return XMLExplainer.GetXMLValue("SiteInfo", "Domain", filePath);
        }

        public static string TemplateDir()
        {
            return XMLExplainer.GetXMLValue("SiteInfo", "TemplateDir", filePath);
        }
    }
}
