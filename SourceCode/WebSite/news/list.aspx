<%@ Page Language="C#" AutoEventWireup="true" CodeFile="list.aspx.cs" Inherits="news_list" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="UTF-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
    <meta name="description" content="">
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
    <title>三星电子门锁 | 宁波汉奇电子科技有限公司</title>
    <link rel='stylesheet' id='layerslider_css-css' href='../css/layerslider.css?ver=4.6.0'
        type='text/css' media='all' />
    <link rel='stylesheet' id='bootstrap-css' href='../css/bootstrap.min.css?ver=4.0.12'
        type='text/css' media='all' />
    <link rel='stylesheet' id='responsive-css' href='../css/bootstrap-responsive.min.css?ver=4.0.12'
        type='text/css' media='all' />
    <link rel='stylesheet' id='flex-css' href='../css/flexslider.css?ver=4.0.12' type='text/css'
        media='all' />
    <link rel='stylesheet' id='bxslider-css' href='../css/jquery.bxslider.css?ver=4.0.12'
        type='text/css' media='all' />
    <link rel='stylesheet' id='main-css' href='../css/main.css?ver=4.0.12' type='text/css'
        media='all' />
    <link rel='stylesheet' id='animate-css' href='../css/animate.css?ver=4.0.12' type='text/css'
        media='all' />
    <link rel='stylesheet' id='font-css' href='../css/font-awesome.css?ver=4.0.12' type='text/css'
        media='all' />
    <link rel='stylesheet' id='pretty-css' href='../css/prettyPhoto.css?ver=4.0.12' type='text/css'
        media='all' />
          <link rel='stylesheet' id='js_composer_front-css' href='../css/js_composer_front.css?ver=3.6.12'
        type='text/css' media='screen' /> 
    <style type='text/css'>
        body
        {
            background: url('') !important;
        }
        #content .actionbox
        {
            outline: 0 !important;
        }
        .grey-area
        {
            outline: 0 !important;
            border: 0 !important;
        }
        .twitter-feed
        {
            outline: 0 !important;
        }
        .copyright-section
        {
            outline: 0 !important;
        }
    </style>
  
    <style type="text/css">
        .recentcomments a
        {
            display: inline !important;
            padding: 0 !important;
            margin: 0 !important;
        }
      
    </style>  
    <link rel="stylesheet" type="text/css" href="../css/nei.css" />
</head>
<body>
    <form id="newslistForm" runat="server">

    <div id="TopHtml" runat="server">
    </div>
     <div class="wpb_row vc_row-fluid  We are best ">  
    <div class="jhmainnei " height="800px">
        <div class="jhneiLeft">
            <div class="neititle">
                新闻中心</div>
            <div class="neititle2">
                <ul id="newsleftShow" runat="server">
                </ul>
            </div>
            <div class="rdph">
                <h1>
                    热点排行</h1>
                <ul id="hotnewShow" runat="server">
                </ul>
            </div>
        </div>
        <div class="jhneiRight">
            <div class="jhneiRighttitle">
                您现在的位置：三星电子门锁 | 宁波汉奇电子科技有限公司 >> 新闻中心 >> <span id="nodename" runat="server"></span>
            </div>
            <div class="jhneiRightmain">
                <ul id="NewsShow" runat="server">
                </ul>
                <div class="jhzhuanye">
                    <webdiyer:AspNetPager ID="MyAspNetPager" CssClass="paginator" CurrentPageButtonClass="cpb"
                        runat="server" AlwaysShow="True" FirstPageText="首页" LastPageText="尾页" NextPageText="下一页"
                        PageSize="20" PrevPageText="上一页" ShowInputBox="Auto" OnPageChanged="MyAspNetPager_PageChanged"
                        SubmitButtonText="确定" TextBeforeInputBox="第" TextAfterInputBox="页" InputBoxClass="shuru11"
                        SubmitButtonClass="queding" SubmitButtonStyle="" NumericButtonCount="5" CustomInfoTextAlign="Right">
                    </webdiyer:AspNetPager>
                </div>
            </div>
        </div>
    </div>

   </div>
    
       <div id="footor" runat="server">
    </div>
    
    
    </form>
</body>
</html>
