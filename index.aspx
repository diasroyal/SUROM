
<%@ Page Title="" Language="C#" AutoEventWireup="true"
    CodeFile="index.aspx.cs" Inherits="_Default" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Here!!!</title>
    <link href="Styles/Site.css" rel="stylesheet" type="text/css" />
    <script src="Scripts/jquery-1.4.1.min.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="page">
        <div class="header">
            <div class="title">
                  <table style="width:40%">
             <tr>
                
             <td><a href="index.aspx"> <font color="white">Home </font></a></td>
             <td><a href="Registration.aspx"><font color="white">Registration</font></a></td>		
            <td><a href="About.aspx"><font color="white">About</font></a></td>
             </tr>
             </table>
                <h1>
                    Sentiment Analysis For Car Review
                </h1>
            </div>
            <div class="loginDisplay">
                <asp:LoginView ID="HeadLoginView" runat="server" EnableViewState="false">
                    <AnonymousTemplate>
                        [ <a href="~/Login.aspx" id="HeadLoginStatus" runat="server">Log In</a>
                        ]
                    </AnonymousTemplate>
                    <LoggedInTemplate>
                        Welcome <span class="bold">
                            <asp:LoginName ID="HeadLoginName" runat="server" />
                        </span>! [
                        <asp:LoginStatus ID="HeadLoginStatus" runat="server" LogoutAction="Redirect" LogoutText="Log Out"
                            LogoutPageUrl="~/" />
                        ]
                    </LoggedInTemplate>
                </asp:LoginView>
            </div>
            <div class="clear hideSkiplink">
                <asp:Menu ID="NavigationMenu" runat="server" CssClass="menu" EnableViewState="false"
                    IncludeStyleBlock="false" Orientation="Horizontal">
                    <Items>
                        <%--<asp:MenuItem NavigateUrl="~/Default.aspx" Text="Home" />
                    <asp:MenuItem NavigateUrl="~/About.aspx" Text="About" />--%>
                    </Items>
                </asp:Menu>
            </div>
        </div>
        <div class="clear">
        </div>
        <div class="main">
          <script type="text/javascript" src="scripts/jquery-1.4.1.min.js"></script>
    <script type="text/javascript" src="scripts/jquery.defaultvalue.js"></script>
    <script type="text/javascript" src="scripts/jquery-ui-1.8.13.custom.min.js"></script>
    <script type="text/javascript" src="scripts/jquery.scrollTo-min.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $("#fullname, #validemail, #message").defaultvalue("Full Name", "Email Address", "Message");
            $('#shout a').click(function () {
                var to = $(this).attr('href');
                $.scrollTo(to, 1200);
                return false;
            });
            $('a.topOfPage').click(function () {
                $.scrollTo(0, 1200);
                return false;
            });
            $("#tabcontainer").tabs({
                event: "click"
            });
        });
    </script>
    <!-- Homepage Only Scripts -->
    <script type="text/javascript" src="scripts/jquery.cycle.min.js"></script>
    <script type="text/javascript" src="scripts/jquery.cycle.setup.js"></script>
    <script type="text/javascript" src="scripts/piecemaker/swfobject/swfobject.js"></script>
    <script type="text/javascript">
        var flashvars = {};
        flashvars.cssSource = "scripts/piecemaker/piecemaker.css";
        flashvars.xmlSource = "scripts/piecemaker/piecemaker.xml";
        var params = {};
        params.play = "false";
        params.menu = "false";
        params.scale = "showall";
        params.wmode = "transparent";
        params.allowfullscreen = "true";
        params.allowscriptaccess = "sameDomain";
        params.allownetworking = "all";
        swfobject.embedSWF('scripts/piecemaker/piecemaker.swf', 'piecemaker', '900', '430', '10', null, flashvars, params, null);
    </script>


    <div id="piecemaker">
        <img src="images/demo/featured-project/1.jpg" alt="" />
      </div>




        </div>
        <div class="clear">
        </div>
    </div>
    </form>
</body>
</html>
