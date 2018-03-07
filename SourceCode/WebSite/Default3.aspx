<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <link rel='stylesheet'   href='css/StyleSheet.css' type='text/css'
        media='all' />
          <script type="text/javascript" src="js/jquery1.js"></script>
      <script type="text/javascript" src="js/indexSlidePic.js"></script>
    <script src="js/jquery.KinSlideshow-1.1.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {
            $("#KinSlideshow").KinSlideshow({
                moveStyle: "down",
                intervalTime: 8,
                mouseEvent: "mouseover",
                titleFont: { TitleFont_size: 12, TitleFont_color: "#ffffff" }
            });
        })
    </script>
  
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <div class="pic" id="HotPicShow" runat="server">
                    </div>
    </div>
    </form>
</body>
</html>
