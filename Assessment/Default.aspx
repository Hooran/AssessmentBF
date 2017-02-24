<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Assessment.Default" %>

<!DOCTYPE html>

<head runat="server">
    <title></title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <script src="Scripts/jquery.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <link href="Styles/bootstrap.min.css" rel="stylesheet" />
    <link href="Styles/Style.css" rel="stylesheet" />
</head>
<html>
<body>
    <form id="formAssessment" runat="server" class="form-horizontal">
        <div class="panel panel-primary panelBody">
            <div class="panel-heading">Triangle Categorisation</div>
            <div class="panel-body">
                <div class="row">
                    <div class="col-sm-4">
                        Side A: <asp:TextBox ID="txtSideA" runat="server" class="form-control"></asp:TextBox>
                    </div>
                    <div class="col-md-4">
                        Side B: <asp:TextBox ID="txtSideB" runat="server" class="form-control"></asp:TextBox>
                    </div>
                    <div class="col-md-4">
                        Side C: <asp:TextBox ID="txtSideC" runat="server" class="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="row top-buffer bottom-buffer">
                    <div class="col-md-1">
                        <asp:Button ID="btnTriangleType" runat="server" Text="Check" CssClass="btn btn-default" OnClick="btnTriangleType_Click" />
                    </div>
                </div>
                <div class="row top-buffer">
                    <div class="col-md-12">
                        <asp:Label ID="lblTriangleResult" runat="server" CssClass="well-sm alert alert-success" Text="" Visible="false"></asp:Label>
                        <asp:Label ID="lblTriangleError" runat="server" CssClass="well-sm alert alert-warning" Text="" Visible="false"></asp:Label>
                    </div>
                </div>
            </div>
        </div>
        <div class="panel panel-primary">
            <div class="panel-heading">Word Reversal</div>
            <div class="panel-body panelBody">
                <div class="row">
                    <div class="col-md-12">
                        Sentence : <asp:TextBox ID="txtSentence" runat="server" MaxLength="100" Width="60%" class="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="row top-buffer">
                    <div class="col-md-12">
                        <asp:Button ID="btnReverse" runat="server" Text="Reverse" CssClass="btn btn-default" OnClick="btnReverse_Click" />
                    </div>
                </div>
                <div class="row top-buffer">
                    <div class="col-md-12">
                        <asp:Label ID="lblReverseResult" runat="server" CssClass="well-sm alert alert-success" Text="" Visible="false"></asp:Label>
                        <asp:Label ID="lblReverseError" runat="server" CssClass="well-sm alert alert-warning" Text="" Visible="false"></asp:Label>
                    </div>
                </div>
             </div>
        </div>
        <div class="panel panel-primary">
            <div class="panel-heading">Linked List Traversal</div>
            <div class="panel-body panelBody">
                <div class="row top-buffer">
                    <div class="col-md-12">
                        List : <asp:Label ID="lblList" runat="server" Text=""></asp:Label>
                    </div>
                </div>
                <div class="row top-buffer">
                    <div class="col-md-12">
                        <asp:Button ID="btnList" runat="server" Text="Get 5th Element" CssClass="btn btn-default" OnClick="btnList_Click"/>
                    </div>
                </div>
                <div class="row top-buffer">
                    <div class="col-md-12">
                        <asp:Label ID="lblListResult" runat="server" CssClass="well-sm alert alert-success" Text="" Visible="false"></asp:Label>
                        <asp:Label ID="lblListError" runat="server" CssClass="well-sm alert alert-warning" Text="" Visible="false"></asp:Label>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
