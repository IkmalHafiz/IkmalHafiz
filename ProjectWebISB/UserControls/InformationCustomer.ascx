<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="InformationCustomer.ascx.cs" Inherits="ProjectWebISB.UserControls.InformationCustomer" %>
<style type="text/css">
    .newStyle1 {
        background-color: #00FFFF;
    }
    .newStyle2 {
        font-family: ARial, Helvetica, sans-serif;
    }
    .auto-style1 {
        font-family: ARial, Helvetica, sans-serif;
        width: 164px;
    }
    .newStyle3 {
        color: #FF0000;
    }
</style>
<table>
    <tr>
        <td class="auto-style1">Name:</td>
        <td>
            <asp:TextBox ID="txtName" runat="server" Width="200px" CssClass="newStyle1"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvName" runat="server" ErrorMessage="Required Name" ControlToValidate="txtName" CssClass="newStyle3">*name missing</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style1">Ic/Passport no:</td>
        <td>
            <asp:TextBox ID="txtIcPassport" runat="server" Width="200px" CssClass="newStyle1"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvIC" runat="server" ErrorMessage="Required IC/Passport" ControlToValidate="txtIcPassport" CssClass="newStyle3">*ic/passport missing</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style1">Email:</td>
        <td>
            <asp:TextBox ID="txtEmail" runat="server" Width="200px" CssClass="newStyle1"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ErrorMessage="Required Email" ControlToValidate="txtEmail" CssClass="newStyle3">*email missing</asp:RequiredFieldValidator>
        </td>
    </tr>
      <tr>
        <td class="auto-style1">Re-enter Email:</td>
        <td>
            <asp:TextBox ID="txtReEnterEmail" runat="server" Width="200px" CssClass="newStyle1"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvrenterEmail" runat="server" ErrorMessage="Required re-enter Email" ControlToValidate="txtReEnterEmail" CssClass="newStyle3">*email missing</asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidatorrenteremail" runat="server" ControlToCompare="txtEmail" ControlToValidate="txtReEnterEmail" CssClass="newStyle3">*email must be same</asp:CompareValidator>
        </td>
    </tr>

</table>