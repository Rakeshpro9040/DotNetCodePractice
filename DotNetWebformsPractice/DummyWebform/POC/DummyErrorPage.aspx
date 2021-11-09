<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DummyErrorPage.aspx.cs" Inherits="DummyWebform.POC.DummyErrorPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../Content/bootstrap.css" rel="stylesheet" />
    <script src="../Scripts/jquery-3.4.1.js"></script>
    <script src="../Scripts/bootstrap.js"></script>
    <title>Error Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="alert alert-danger" role="alert">
            Error Occured!
        </div>
        <div>
            <a href="../Default.aspx">Go Back to Home Page</a>
        </div>
    </form>
</body>
</html>
