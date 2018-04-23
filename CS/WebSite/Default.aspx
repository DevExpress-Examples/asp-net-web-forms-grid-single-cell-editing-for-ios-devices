<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <script type="text/javascript" language="javascript">
        function onCellFocus(s, e) {
            var tb = s.GetMainElement();
            tb.style.borderWidth = "1px";
        }
        function onCellLostFocus(s, e, visibleIndex) {
            var tb = s.GetMainElement();
            tb.style.borderWidth = "0px";
            if (s.GetIsValid())
                clientCb.PerformCallback(visibleIndex.toString());
        }
        function checkTextLength(s, e) {
            if (e.value.toString().length > 15)
                e.isValid = false;
        }
    </script>
    <form id="form1" runat="server">
    <div>
        <dx:ASPxGridView ID="GridView" runat="server" ClientInstanceName="grid" AutoGenerateColumns="False"
            DataSourceID="SqlDataSource1" KeyFieldName="CategoryID">
            <Columns>
                <dx:GridViewDataTextColumn FieldName="CategoryID" ReadOnly="True" VisibleIndex="1">
                    <EditFormSettings Visible="False" />
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="CategoryName" VisibleIndex="2">
                    <DataItemTemplate>
                        <dx:ASPxTextBox ID="CategoryName" Text='<%# Eval("CategoryName") %>' ClientInstanceName="clientCategoryName"
                            Border-BorderWidth="0px" OnInit="EditorInit" runat="server">
                            <ClientSideEvents Validation="checkTextLength" />
                            <ValidationSettings EnableCustomValidation="true" ErrorDisplayMode="ImageWithTooltip"
                                ErrorText="Invalid text length" Display="Dynamic">
                            </ValidationSettings>
                            <Border BorderWidth="0px" />
                        </dx:ASPxTextBox>
                    </DataItemTemplate>
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="Description" VisibleIndex="3">
                    <DataItemTemplate>
                        <dx:ASPxTextBox ID="Description" Text='<%# Eval("Description") %>' ClientInstanceName="clientDescription"
                            Border-BorderWidth="0px" OnInit="EditorInit" runat="server">
                        </dx:ASPxTextBox>
                    </DataItemTemplate>
                </dx:GridViewDataTextColumn>
            </Columns>
        </dx:ASPxGridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>"
            SelectCommand="SELECT [CategoryID], [CategoryName], [Description] FROM [Categories]"
            DeleteCommand="DELETE FROM [Categories] WHERE [CategoryID] = @CategoryID" InsertCommand="INSERT INTO [Categories] ([CategoryName], [Description]) VALUES (@CategoryName, @Description)"
            UpdateCommand="UPDATE [Categories] SET [CategoryName] = @CategoryName, [Description] = @Description WHERE [CategoryID] = @CategoryID">
            <DeleteParameters>
                <asp:Parameter Name="CategoryID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="CategoryName" Type="String" />
                <asp:Parameter Name="Description" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="CategoryName" Type="String" />
                <asp:Parameter Name="Description" Type="String" />
                <asp:Parameter Name="CategoryID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <dx:ASPxCallback ID="Callback" ClientInstanceName="clientCb" runat="server" OnCallback="cb_CallBack">
        </dx:ASPxCallback>
    </div>
    </form>
</body>
</html>
