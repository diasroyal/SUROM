﻿<%@ Page Title="About Us" Language="C#"  AutoEventWireup="true"
    CodeFile="About.aspx.cs" Inherits="About" %>

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
            <fieldset>
                <legend>About</legend>
             

            </fieldset>
        </div>
        <div class="clear">
        </div>
    </div>
    </form>
</body>
</html>
