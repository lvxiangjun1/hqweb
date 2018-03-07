<%@ Page Language="C#" AutoEventWireup="true" CodeFile="newsdetail.aspx.cs" Inherits="news_newsdetail" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="UTF-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
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
    <form id="newsForm" runat="server">
    <div id="TopHtml" runat="server">
    </div>
    <div class="wpb_row vc_row-fluid  We are best ">
        <div class="jhmainnei">
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
                    <div class="wenzi7" id="newstitle" runat="server">
                    </div>
                    <div class="wenzi8" id="newsinfo" runat="server">
                    </div>
                    <div class="wenzi9" id="newscontent" runat="server">
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div id="footor" runat="server">
    </div>
    </form>
    <script type="text/javascript" src="../js/jquery-1.4a2.min.js"></script>
    <script type="text/javascript" src="../js/jQuery.autoIMG.js"></script>
    <script type="text/javascript">
        $('#newscontent').autoIMG();
    </script>
</body>
</html>
