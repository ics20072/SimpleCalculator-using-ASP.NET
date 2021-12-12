<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color: #C7E1EB">
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Calculator" style="font-size: xx-large; font-weight: 700"></asp:Label>
        <br />
        <br />
        <div>
            <asp:Label ID="Label2" runat="server" Text="Number A:" style="font-weight: 700; font-size: large"></asp:Label>
        &nbsp;
            <asp:TextBox ID="InputNumberA" runat="server" BorderColor="Black" ToolTip="Give the first Number"></asp:TextBox>
    
            <br />
            <br />
            <asp:ImageButton ID="addButton" runat="server" ImageUrl="~/images/add_35px.png" OnClick="addButton_Click" />
    &nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="multiplicationButton" runat="server" ImageUrl="~/images/multiply_35px.png" OnClick="multiplicationButton_Click" />
    &nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="divisionButton" runat="server" ImageUrl="~/images/divide_35px.png" OnClick="divisionButton_Click" />
    &nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="subtractionButton" runat="server" ImageUrl="~/images/minus_35px.png" OnClick="subtractionButton_Click" />
    &nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="resetButton" runat="server" ImageUrl="~/images/reset_35px.png" ToolTip="Reset All" OnClick="resetButton_Click" />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Number B:" style="font-weight: 700; font-size: large"></asp:Label>
        &nbsp;
            <asp:TextBox ID="InputNumberB" runat="server" BorderColor="Black" ToolTip="Give the second Number"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Result: " style="font-weight: 700; font-size: x-large"></asp:Label>
            <asp:Label ID="theResultLabel" runat="server" Text="" style="font-weight: 700; font-size: large; color: #CC0000; font-style: italic;"></asp:Label>
        </div>
    </form>
</body>
</html>
