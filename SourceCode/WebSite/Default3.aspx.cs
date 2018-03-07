using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web.Common;
using Web.BaseWeb;
public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
         string id= Request.QueryString["ID"];
            //产品展示
            HotPicShow.InnerHtml = ContentsList.GetPicShow("2", "5", 20, "350", "310", "ID", "Desc").ToString();

        }
    }
}