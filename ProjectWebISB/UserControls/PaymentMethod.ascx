<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PaymentMethod.ascx.cs" Inherits="ProjectWebISB.UserControls.PaymentMethod" %>
<style type="text/css">
    .auto-style1 {
        width: 200px;
    }
    .newStyle1 {
        color: #FF0000;
        font-family: arial, Helvetica, sans-serif;
    }
    .newStyle2 {
        font-family: arial, Helvetica, sans-serif;
    }
</style>

<table>
    <tr>
        <td class="auto-style1">Card Name:</td>
        <td>
            <asp:TextBox ID="txtCardName" runat="server" Width="200px" CssClass="newStyle2"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvCardName" runat="server" ControlToValidate="txtCardName" CssClass="newStyle1" >*missing name</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style1">Card Bank:</td>
        <td>
            <asp:DropDownList ID="DropDownList1" runat="server" Width="185px">
                <asp:ListItem>MAYBANK</asp:ListItem>
                <asp:ListItem>CIMB BANK</asp:ListItem>
                <asp:ListItem>HONG LEONG BANK</asp:ListItem>
                <asp:ListItem>PUBLIC BANK BERHAD</asp:ListItem>
                <asp:ListItem>BANK ISLAM BERHAD</asp:ListItem>
                <asp:ListItem>RHB BANK</asp:ListItem>
                <asp:ListItem>AMBANK GROUP</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="auto-style1">Card no:</td>
        <td>
            <asp:TextBox ID="txtCardNo" runat="server" Width="200px" CssClass="newStyle2"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvCardNo" runat="server" ControlToValidate="txtCardNo" CssClass="newStyle1" >*missing card number</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>CVV</td>
        <td>
            <asp:TextBox ID="txtCVV" runat="server" Width="43px" CssClass="newStyle2"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvCVV" runat="server" ControlToValidate="txtCVV" CssClass="newStyle1" >*missing cvv number</asp:RequiredFieldValidator>
            <asp:RangeValidator ID="rvCvv" runat="server" ControlToValidate="txtCVV" CssClass="newStyle1"  MaximumValue="999" MinimumValue="100" Type="Integer">*must put 3 digit number</asp:RangeValidator>
        </td>
    </tr>
</table>


