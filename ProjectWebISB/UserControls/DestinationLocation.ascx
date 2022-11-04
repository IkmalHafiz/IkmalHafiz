<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DestinationLocation.ascx.cs" Inherits="ProjectWebISB.UserControls.DestinationLocation" %>
<style type="text/css">
    .auto-style1 {
        width: 196px;
    }

    .auto-style2 {
        width: 230px;
    }

    .auto-style3 {
        width: 193px;
    }
</style>
<table>
    <tr>
        <td class="auto-style1">From:</td>
        <td class="auto-style2">
            <asp:DropDownList ID="ddlFrom" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlFrom_SelectedIndexChanged" BackColor="#CCCCCC">
                <asp:ListItem Selected="True">PEL. KLANG</asp:ListItem>
                <asp:ListItem>JLN. KASTAM</asp:ListItem>
                <asp:ListItem>KG RAJA MUDA</asp:ListItem>
                <asp:ListItem>TELUK GADUNG</asp:ListItem>
                <asp:ListItem>TELUK PULAI</asp:ListItem>
                <asp:ListItem>KLUANG</asp:ListItem>
                <asp:ListItem>BUKIT BADAK</asp:ListItem>
                <asp:ListItem>PADANG JAWA</asp:ListItem>
                <asp:ListItem>SHAH ALAM</asp:ListItem>
                <asp:ListItem>BATU TIGA</asp:ListItem>
                <asp:ListItem>SUBANG JAYA</asp:ListItem>
                <asp:ListItem>SEIA JAYA</asp:ListItem>
                <asp:ListItem>SERI SETIA</asp:ListItem>
                <asp:ListItem>KG. DATO HARUN</asp:ListItem>
                <asp:ListItem>JLN. TEMPLER</asp:ListItem>
                <asp:ListItem>PETALING</asp:ListItem>
                <asp:ListItem>PANTAI DALAM</asp:ListItem>
                <asp:ListItem>ANGKASAPURI</asp:ListItem>
                <asp:ListItem>KL SENTRAL</asp:ListItem>
                <asp:ListItem>KUALA LUMPUR</asp:ListItem>
                <asp:ListItem>BANK NEGARA</asp:ListItem>
                <asp:ListItem>PUTRA</asp:ListItem>
                <asp:ListItem>SENTUL</asp:ListItem>
                <asp:ListItem>BATU KENTONMEN</asp:ListItem>
                <asp:ListItem>KG. BATU</asp:ListItem>
                <asp:ListItem>TAMAN WAHYU</asp:ListItem>
                <asp:ListItem>BATU CAVES</asp:ListItem>
                <asp:ListItem>TANJUNG MALIM</asp:ListItem>
                <asp:ListItem>KUALA KUBU</asp:ListItem>
                <asp:ListItem>RASA</asp:ListItem>
                <asp:ListItem>BATANG KALI</asp:ListItem>
                <asp:ListItem>SERENDAH</asp:ListItem>
                <asp:ListItem>RAWANG</asp:ListItem>
                <asp:ListItem>KUANG</asp:ListItem>
                <asp:ListItem>SUNGAI BULOH</asp:ListItem>
                <asp:ListItem>KEPONG SENTRAL</asp:ListItem>
                <asp:ListItem>KEPONG</asp:ListItem>
                <asp:ListItem>SEGAMBUT</asp:ListItem>
                <asp:ListItem>MID VALLEY</asp:ListItem>
                <asp:ListItem>SEPUTEH</asp:ListItem>
                <asp:ListItem>SALAK SELATAN</asp:ListItem>
                <asp:ListItem>B. T. SELATAN</asp:ListItem>
                <asp:ListItem>SERDANG</asp:ListItem>
                <asp:ListItem>KAJANG</asp:ListItem>
                <asp:ListItem>UKM</asp:ListItem>
                <asp:ListItem>BANGI</asp:ListItem>
                <asp:ListItem>BATANG BENAR</asp:ListItem>
                <asp:ListItem>NILAI</asp:ListItem>
                <asp:ListItem>LABU</asp:ListItem>
                <asp:ListItem>TIROI</asp:ListItem>
                <asp:ListItem>SEREMBAN</asp:ListItem>
                <asp:ListItem>SENAWANG</asp:ListItem>
                <asp:ListItem>SUNGAI GADUT</asp:ListItem>
                <asp:ListItem>REMBAU</asp:ListItem>
                <asp:ListItem>TAMPIN</asp:ListItem>
                <asp:ListItem>BTG MELAKA</asp:ListItem>
                <asp:ListItem>GEMAS</asp:ListItem>
            </asp:DropDownList>
        <td class="auto-style3">To:</td>
        <td>
            <asp:DropDownList ID="ddlTo" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlTo_SelectedIndexChanged" BackColor="#CCCCCC">
                <asp:ListItem Selected="True">PEL. KLANG</asp:ListItem>
                <asp:ListItem>JLN. KASTAM</asp:ListItem>
                <asp:ListItem>KG RAJA MUDA</asp:ListItem>
                <asp:ListItem>TELUK GADUNG</asp:ListItem>
                <asp:ListItem>TELUK PULAI</asp:ListItem>
                <asp:ListItem>KLUANG</asp:ListItem>
                <asp:ListItem>BUKIT BADAK</asp:ListItem>
                <asp:ListItem>PADANG JAWA</asp:ListItem>
                <asp:ListItem>SHAH ALAM</asp:ListItem>
                <asp:ListItem>BATU TIGA</asp:ListItem>
                <asp:ListItem>SUBANG JAYA</asp:ListItem>
                <asp:ListItem>SEIA JAYA</asp:ListItem>
                <asp:ListItem>SERI SETIA</asp:ListItem>
                <asp:ListItem>KG. DATO HARUN</asp:ListItem>
                <asp:ListItem>JLN. TEMPLER</asp:ListItem>
                <asp:ListItem>PETALING</asp:ListItem>
                <asp:ListItem>PANTAI DALAM</asp:ListItem>
                <asp:ListItem>ANGKASAPURI</asp:ListItem>
                <asp:ListItem>KL SENTRAL</asp:ListItem>
                <asp:ListItem>KUALA LUMPUR</asp:ListItem>
                <asp:ListItem>BANK NEGARA</asp:ListItem>
                <asp:ListItem>PUTRA</asp:ListItem>
                <asp:ListItem>SENTUL</asp:ListItem>
                <asp:ListItem>BATU KENTONMEN</asp:ListItem>
                <asp:ListItem>KG. BATU</asp:ListItem>
                <asp:ListItem>TAMAN WAHYU</asp:ListItem>
                <asp:ListItem>BATU CAVES</asp:ListItem>
                <asp:ListItem>TANJUNG MALIM</asp:ListItem>
                <asp:ListItem>KUALA KUBU</asp:ListItem>
                <asp:ListItem>RASA</asp:ListItem>
                <asp:ListItem>BATANG KALI</asp:ListItem>
                <asp:ListItem>SERENDAH</asp:ListItem>
                <asp:ListItem>RAWANG</asp:ListItem>
                <asp:ListItem>KUANG</asp:ListItem>
                <asp:ListItem>SUNGAI BULOH</asp:ListItem>
                <asp:ListItem>KEPONG SENTRAL</asp:ListItem>
                <asp:ListItem>KEPONG</asp:ListItem>
                <asp:ListItem>SEGAMBUT</asp:ListItem>
                <asp:ListItem>MID VALLEY</asp:ListItem>
                <asp:ListItem>SEPUTEH</asp:ListItem>
                <asp:ListItem>SALAK SELATAN</asp:ListItem>
                <asp:ListItem>B. T. SELATAN</asp:ListItem>
                <asp:ListItem>SERDANG</asp:ListItem>
                <asp:ListItem>KAJANG</asp:ListItem>
                <asp:ListItem>UKM</asp:ListItem>
                <asp:ListItem>BANGI</asp:ListItem>
                <asp:ListItem>BATANG BENAR</asp:ListItem>
                <asp:ListItem>NILAI</asp:ListItem>
                <asp:ListItem>LABU</asp:ListItem>
                <asp:ListItem>TIROI</asp:ListItem>
                <asp:ListItem>SEREMBAN</asp:ListItem>
                <asp:ListItem>SENAWANG</asp:ListItem>
                <asp:ListItem>SUNGAI GADUT</asp:ListItem>
                <asp:ListItem>REMBAU</asp:ListItem>
                <asp:ListItem>TAMPIN</asp:ListItem>
                <asp:ListItem>BTG MELAKA</asp:ListItem>
                <asp:ListItem>GEMAS</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>

        <td>One or Two Way Ticket?

        </td>
        <td>
            <asp:DropDownList ID="ddlonetwoticket" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlonetwoticket_SelectedIndexChanged">
                <asp:ListItem Selected="True">One Way Ticket</asp:ListItem>
                <asp:ListItem>Two Way Ticket</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td></td>
        <td>Going Date
        </td>
    </tr>
    <tr>
        <td>How many Persenger</td>
  
        <td>
            <asp:DropDownList ID="ddlHowMany" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlHowMany_SelectedIndexChanged">
                <asp:ListItem>1 Person</asp:ListItem>
                <asp:ListItem>2 Person</asp:ListItem>
                <asp:ListItem>3 Person</asp:ListItem>
                <asp:ListItem>4 Person</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td>Category:</td>
        <td>
            <asp:DropDownList ID="ddlCategory" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlCategory_SelectedIndexChanged" BackColor="White">
                <asp:ListItem Selected="True">Normal</asp:ListItem>
                <asp:ListItem>Senior Netizen</asp:ListItem>
                <asp:ListItem>Disabled</asp:ListItem>
                <asp:ListItem>Students</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>Your ticket ftom:</td>
        <td class="auto-style2">
            <asp:Label ID="lblTicketFrom" runat="server" BackColor="#0099CC" Font-Bold="True" Font-Names="Arial"></asp:Label>
        </td>
        <td class="auto-style3">To:</td>
        <td>
            <asp:Label ID="lblTicketTo" runat="server" BackColor="#0099CC" Font-Bold="True" Font-Names="Arial"></asp:Label>
        </td>
    </tr>

    <tr>
        <td>For</td>
        <td class="auto-style2">
            <asp:Label ID="lblForPeople" runat="server" Text="..."></asp:Label>
        </td>

    </tr>
    <tr>
        <td>
        Date Going:
            <td>
                <asp:Calendar ID="datePicker" runat="server" OnSelectionChanged="datePicker_SelectionChanged" SelectionMode="DayWeekMonth" CaptionAlign="Left">
                    <DayHeaderStyle BackColor="White" />
                    <DayStyle BackColor="White" />
                    <OtherMonthDayStyle BackColor="#CC99FF" />
                    <TitleStyle BackColor="#009999" />
                </asp:Calendar>
                <asp:CustomValidator ID="CustomValidator2" runat="server" ErrorMessage="CustomValidator"></asp:CustomValidator>
            </td>
    </tr>
    <tr>
        <td>

            <asp:Label ID="lbldateONGoing" runat="server" Font-Size="Medium"></asp:Label>
            <asp:LinkButton ID="lnkpickdate" runat="server" OnClick="lnkpickdate_Clink"></asp:LinkButton>
        </td>
    </tr>
    <tr>
        <td>Price (RM):</td>
        <td class="auto-style2">
            <asp:Label ID="lblPrice" runat="server" BackColor="#00CCFF" Font-Bold="True" Font-Names="Arial" Font-Size="Medium"></asp:Label>
        </td>
    </tr>

</table>
