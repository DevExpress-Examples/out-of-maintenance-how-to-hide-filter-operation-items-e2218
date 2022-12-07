<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>
<%@ Register Assembly="DevExpress.Web.v15.1" Namespace="DevExpress.Web" TagPrefix="dx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <table><tr><td>
            <table width="100%" cellpadding="0" cellspacing="0">
                <tr><td style="width:100px;">
                    <dx:ASPxFilterControl ID="filter" runat="server" ClientInstanceName="filter" OnOperationVisibility="filter_FilterOperationVisibility">
                        <Columns>
                            <dx:FilterControlSpinEditColumn PropertyName="CategoryID" />
                            <dx:FilterControlTextColumn PropertyName="CategoryName" />
                            <dx:FilterControlTextColumn PropertyName="Description" />
                        </Columns>
                        <ClientSideEvents Applied="function(s, e) { grid.ApplyFilter(e.filterExpression);}" />
                    </dx:ASPxFilterControl>
                    <table width="100%" cellpadding="0" cellspacing="5" style="margin-top: 8px">
                        <tr><td align="center">
                            <dx:ASPxButton runat="server" ID="btnApply" Text="Apply" AutoPostBack="false" UseSubmitBehavior="false">
                                <ClientSideEvents Click="function() { filter.Apply(); }" />
                            </dx:ASPxButton>
                        </td></tr>
                    </table>
                    </td><td>
                    </td><td>
                    <dx:ASPxGridView ID="grid" ClientInstanceName="grid" runat="server" DataSourceID="AccessDataSource1"
                        KeyFieldName="CategoryID" Width="100%" AutoGenerateColumns="False">
                        <Columns>
                            <dx:GridViewDataTextColumn FieldName="CategoryID" VisibleIndex="0" />
                            <dx:GridViewDataTextColumn FieldName="CategoryName" VisibleIndex="1" />
                            <dx:GridViewDataTextColumn FieldName="Description" VisibleIndex="2" />
                        </Columns>
                    </dx:ASPxGridView>
                </td></tr>
            </table>
        </td></tr></table>
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/nwind.mdb"
            SelectCommand="SELECT * FROM [Categories]" />
        
    </form>
</body>
</html>
