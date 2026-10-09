<%@ Page Language="C#" AutoEventWireup="true" CodeFile="KPLogin.aspx.cs" Inherits="KPLogin" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login :: Welcome</title>
    <link href="https://fonts.googleapis.com/css?family=Lato:300,400,500" rel="stylesheet" />
    <link href="OrderPOS/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="css/style.css" rel="stylesheet" type="text/css" />
    <style>
        #parent {
            position: relative;
        }

            #parent::after {
                content: '';
                width: 265px;
                height: 100%;
                background-color: #fff;
                opacity: 0.9;
                position: absolute;
                margin: 0 0 0 75%;
                border-radius: 10px;
                top: 0;
                left: 0;
                z-index: 1;
            }

        #child {
            position: relative;
            z-index: 2;
        }

        .loginPanel {
            margin: 13% 0 0 75%;
            padding: 10px 10px;
        }

        .errorContainer {
            padding: 10px;
            background-color: #fbefef;
            border: Solid 1px #bb0000;
            color: #bb0000;
            font-size: 12px;
            font-family: Verdana;
            width: 77%;
            height: 50px;
            overflow: auto;
        }

        .loginLabel {
            font-family: Lato;
            font-size: 40px;
            font-weight: 300;
            color: #D66D2C;
        }

        .loginInput {
            font-family: Lato;
            font-size: 14px;
            font-weight: 400;
            display: block;
            height: 50px;
            width: 77%;
            padding: 6px 12px;
            color: #555;
            background-color: #fff;
            background-image: none;
            border: 1px solid #ccc;
            margin-top: 10px;
        }

        .loginButton {
            font-family: Lato;
            font-size: 14px;
            font-weight: 400;
            display: block;
            height: 50px;
            width: 77%;
            padding: 6px 12px;
            color: #fff;
            background-color: #16A085;
            border: 1px solid #ccc;
            margin-top: 25px;
        }

        .forgetLabel {
            font-family: Lato;
            font-size: 12px;
            font-weight: 600;
            display: block;
            color: #16A085;
            margin-left: 24%;
            margin-top: 20px;
        }
    </style>
</head>
<body class="login-bg">
    <form runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="upLogin" runat="server">
            <ContentTemplate>
                <div id="parent">
                    <div id="child" class="loginPanel">
                        <img src="images/finallogo.png" alt="logo" style="margin-top: 8px;" /><br />
                        <img src="images/img_Lock.png" alt="lock" style="margin-top: -25px;" /><label class="loginLabel">LOGIN</label>
                        <div runat="server" id="dvError" visible="false" class="errorContainer">
                            <asp:Label ID="lblErrorMsg" runat="server" Text=""></asp:Label>
                        </div>
                        <asp:TextBox ID="txtLogin" runat="server" class="loginInput" placeholder="USER NAME" Style="margin-top: 0px;"></asp:TextBox>
                        <asp:TextBox ID="txtPassword" runat="server" class="loginInput" placeholder="PASSWORD" TextMode="Password"></asp:TextBox>
                        <asp:Button ID="btnSignIn" runat="server" CssClass="loginButton" OnClick="btnSignIn_Click" Text="LOGIN" />
                        <a href="#" class="forgetLabel">LOST PASSWORD</a>
                    </div>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
    <script src="js/jquery-3.1.1.min"></script>
    <script src="AjaxLibrary/bootstrap.min.js" type="text/javascript" language="javascript"></script>
    <script language="JavaScript" type="text/javascript">
        Sys.WebForms.PageRequestManager.getInstance().add_beginRequest(BeginRequestHandler);
        function BeginRequestHandler(sender, args) {
            var oControl = args.get_postBackElement();
            oControl.value = "Wait...";
            oControl.disabled = true;
        }
    </script>
</body>
</html>
