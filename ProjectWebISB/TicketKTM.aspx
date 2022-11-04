<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TicketKTM.aspx.cs" Inherits="ProjectWebISB.TicketKTM" %>

<%@ Register Src="~/UserControls/InformationCustomer.ascx" TagPrefix="uc1" TagName="InformationCustomer" %>
<%@ Register Src="~/UserControls/DestinationLocation.ascx" TagPrefix="uc1" TagName="DestinationLocation" %>
<%@ Register Src="~/UserControls/PaymentMethod.ascx" TagPrefix="uc1" TagName="PaymentMethod" %>







<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .newStyle4 {
            font-family: arial, Helvetica, sans-serif;
            line-height: 25px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <img src="Image/ktm.jpg" height="250" />
             <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">

            <asp:View ID="InformationStatement" runat="server">
                <h3>Information Statement</h3>
                <uc1:InformationCustomer runat="server" ID="InformationCustomer" />
        
                <asp:Button ID="btnNext1" runat="server" Text="Next" CommandName="NextView" Width="75px" />
            </asp:View>

            <asp:View ID="View1" runat="server">
                <h3>KTM Ticket Online</h3>

                <uc1:DestinationLocation runat="server" id="DestinationLocation" />

                <asp:Button ID="btnPrevs2" runat="server" Text="Previous" CommandName="PrevView" Width="75px" />&nbsp;&nbsp;
                <asp:Button ID="btnNext2" runat="server" Text="Next" CommandName="NextView" Width="75px" />
            </asp:View>

            <asp:View ID="View2" runat="server">
                <h3>Payment</h3>

                <uc1:PaymentMethod runat="server" ID="PaymentMethod" />

                <asp:Button ID="btnPrevs3" runat="server" Text="Previous" CommandName="PrevView" Width="75px" />&nbsp;&nbsp;
                <asp:Button ID="btnNext3" runat="server" Text="Next" CommandName="NextView" Width="75px" />
            </asp:View>

            <asp:View ID="View3" runat="server">
                <h3>Invoice</h3>

                <table>
                    <tr>
                        <td>Date :</td>
                        <td>
                            <asp:Label ID="lblDateBuy" runat="server" CssClass="newStyle4"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Inovice no :</td>
                        <td>
                            <asp:Label ID="lblInvoiceNo" runat="server" CssClass="newStyle4"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Name :</td>
                        <td>
                            <asp:Label ID="lblName" runat="server" CssClass="newStyle4"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Ic/Passport No :</td>
                        <td>
                            <asp:Label ID="lblICpassport" runat="server" CssClass="newStyle4"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Email :</td>
                        <td>
                            <asp:Label ID="lblEmail" runat="server" CssClass="newStyle4"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>From :</td>
                        <td>
                            <asp:Label ID="lblFrom" runat="server" CssClass="newStyle4"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>To :</td>
                        <td>
                            <asp:Label ID="lblTo" runat="server" CssClass="newStyle4"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Date :</td>
                        <td>
                            <asp:Label ID="lblDate" runat="server" CssClass="newStyle4"></asp:Label>
                        </td>
                    </tr>
                   <tr>
                        <td>For :</td>
                        <td>
                            <asp:Label ID="lblForPerson" runat="server" CssClass="newStyle4"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>For :</td>
                        <td>
                            <asp:Label ID="lbl1or2way" runat="server" CssClass="newStyle4"></asp:Label>
                            <br? /> <br />
                        </td>
                    </tr>
                     <tr>
                        <td>Price (RM) :</td>
                        <td>
                            <asp:Label ID="lblTotalPrice" runat="server" CssClass="newStyle4"></asp:Label>
                        </td>
                    </tr>
                </table>


                <asp:Button ID="btnPrev4" runat="server" Text="Previous" CommandName="PrevView" Width="75px" />&nbsp;&nbsp;
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" Width="75px" />
            </asp:View>
        </asp:MultiView>
        &nbsp;</form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        <img src="Image/1200px-Keretapi_Tanah_Melayu_Berhad_Logo.svg.png" height="95" /></p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>
