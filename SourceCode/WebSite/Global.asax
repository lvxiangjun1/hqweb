<%@ Application Language="C#" %>
<%@ Import Namespace="PersistenceLayer" %>
<%@ Import Namespace="System.Web" %>
<%@ Import Namespace="System.IO" %>
<%@ Import Namespace="Web.BaseWeb" %>
<script RunAt="server">

    void Application_Start(object sender, EventArgs e)
    {
        // 在应用程序启动时运行的代码
        if (HttpContext.Current.Application["DatabaseSetting"] == null || HttpContext.Current.Application["DatabaseSetting"].ToString() != "Y")
        {
            string m_ApplicationPath = HttpContext.Current.Request.ApplicationPath;
            if (m_ApplicationPath == "")
                m_ApplicationPath = "/";
            if (!m_ApplicationPath.EndsWith("/"))
                m_ApplicationPath += "/";
            PersistenceLayer.Setting.Instance().DatabaseMapFile = System.Web.HttpContext.Current.Request.PhysicalApplicationPath + ("/Config/DatabaseMap.config");
        }
    }

    void Application_BeginRequest(object sender, EventArgs e)
    {
        //对Post和Get的请求进行验证

        //遍历Get参数。 
        foreach (string i in this.Request.QueryString)
        {
            this.goErr(this.Request.QueryString[i].ToString());
        }
        
        string oldUrl = System.Web.HttpContext.Current.Request.RawUrl; //获取初始url 
        //新闻详情页面~/news/123 → ~/newsDetail.aspx?id=123 
        Regex regstr = new Regex(@"^\/news\/\d+$");
        if (regstr.IsMatch(oldUrl))
        {
            string id = regstr.Match(oldUrl).ToString().Substring(6);
            Context.RewritePath(SiteInfo.VirtualPath() + "/news/newsdetail.aspx?ID=" + id);
        }
        //新闻列表页面~/news/123 → ~/newsDetail.aspx?id=123 
        regstr = new Regex(@"^\/listnews\/\d+$");
        if (regstr.IsMatch(oldUrl))
        {
            string id = regstr.Match(oldUrl).ToString().Substring(10);
            Context.RewritePath(SiteInfo.VirtualPath() + "/news/list.aspx?NODEID=" + id);
        }
        //通用文章列表页面~/general/123 → ~/newsDetail.aspx?id=123 
        regstr = new Regex(@"^\/generallist\/\d+$");
        if (regstr.IsMatch(oldUrl))
        {
            string id = regstr.Match(oldUrl).ToString().Substring(13);
            Context.RewritePath(SiteInfo.VirtualPath() + "/generalweb/list.aspx?NODEID=" + id);
        }
        //通用文章详情页面~/general/123 → ~/newsDetail.aspx?id=123 
        regstr = new Regex(@"^\/general\/\d+$");
        if (regstr.IsMatch(oldUrl))
        {
            string id = regstr.Match(oldUrl).ToString().Substring(9);
            Context.RewritePath(SiteInfo.VirtualPath() + "/generalweb/detail.aspx?ID=" + id);
        }
        //中心事迹页面~/news/123 → ~/newsDetail.aspx?id=123 
        regstr = new Regex(@"^\/centerdeed\/\d+$");
        if (regstr.IsMatch(oldUrl))
        {
            string id = regstr.Match(oldUrl).ToString().Substring(12);
            Context.RewritePath(SiteInfo.VirtualPath() + "/centerstyle/centerdeeddetail.aspx?ID=" + id);
        }
        //聚焦8890页面~/news/123 → ~/newsDetail.aspx?id=123 
        regstr = new Regex(@"^\/focus8890\/\d+$");
        if (regstr.IsMatch(oldUrl))
        {
            string id = regstr.Match(oldUrl).ToString().Substring(11);
            Context.RewritePath(SiteInfo.VirtualPath() + "/centerstyle/focus8890detail.aspx?ID=" + id);
        } 
    }

    private void goErr(string tm)
    {
        if (SqlFilter2(tm))
        {
            Response.Redirect("p404.html");
            Response.End();
        }
    }
    public static bool SqlFilter2(string InText)
    {
        string word = @"AND|EXECUTE|INSERT|SELECT|DELETE|UPDATE|ALTER|COUNT|FROM|DROP|ASC|DESC|OR|CHAR|%|;|:|\|CHR|MASTER|TRUNCATE|SYS_CONTEXT|DECLARE|ADD|NETWORK|MASTER";
        if (InText == null)
            return false;
        foreach (string i in word.Split('|'))
        {
            if ((InText.ToUpper().IndexOf(i + " ") > -1) || (InText.ToUpper().IndexOf(" " + i) > -1))
            {
                return true;
            }
        }
        return false;
    }

    void Application_End(object sender, EventArgs e)
    {
        //  在应用程序关闭时运行的代码

    }

    void Application_Error(object sender, EventArgs e)
    {
        // 在出现未处理的错误时运行的代码
        var lastError = Server.GetLastError();
        if (lastError != null)
        {
            var httpError = lastError as HttpException;
            if (httpError != null)
            {
                //ASP.NET的400与404错误不记录日志，并都以自定义404页面响应
                var httpCode = httpError.GetHttpCode();
                if (httpCode == 400 || httpCode == 404)
                {
                    Response.StatusCode = 404;//在IIS中配置自定义404页面
                    Server.ClearError();
                    return;
                }
            }

            //对于路径错误不记录日志，并都以自定义404页面响应
            if (lastError.TargetSite.ReflectedType == typeof(System.IO.Path))
            {
                Response.StatusCode = 404;
                Server.ClearError();
                return;
            }
            Response.StatusCode = 500;
            Server.ClearError();
        }
    }

    void Session_Start(object sender, EventArgs e)
    {
        // 在新会话启动时运行的代码

    }

    void Session_End(object sender, EventArgs e)
    {
        // 在会话结束时运行的代码。 
        // 注意: 只有在 Web.config 文件中的 sessionstate 模式设置为 InProc 时，才会引发 Session_End 事件。
        // 如果会话模式设置为 StateServer 
        // 或 SQLServer，则不会引发该事件。

    }
       
</script>
