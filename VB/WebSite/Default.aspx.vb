Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web.ASPxEditors
Imports DevExpress.Web.ASPxGridView
Imports System.Web.UI.HtmlControls

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

	End Sub
	Protected Sub EditorInit(ByVal sender As Object, ByVal e As EventArgs)
		Dim tb As ASPxTextBox = TryCast(sender, ASPxTextBox)
		Dim container As GridViewDataItemTemplateContainer = TryCast(tb.NamingContainer, GridViewDataItemTemplateContainer)
		Dim visibleIndex As Integer = container.VisibleIndex
		tb.ID += visibleIndex.ToString()
		tb.ClientInstanceName += visibleIndex.ToString()
		tb.ClientSideEvents.GotFocus = String.Format("function (s, e) {{ onCellFocus(s, e); }}", visibleIndex)
		tb.ClientSideEvents.LostFocus = String.Format("function (s, e) {{ onCellLostFocus(s, e, {0}); }}", visibleIndex)
	End Sub

	Protected Sub cb_CallBack(ByVal source As Object, ByVal e As DevExpress.Web.ASPxCallback.CallbackEventArgs)
		If String.IsNullOrEmpty(e.Parameter) Then
			Return
		End If
		Dim visibleIndex As Integer = Convert.ToInt32(e.Parameter)

		'---- The code below cofigures update parameters and write changes to database

		'foreach (GridViewDataColumn col in GridView.Columns)
		'{
		'    if (col.FieldName != GridView.KeyFieldName)
		'    {
		'        ASPxTextBox tb = GridView.FindRowCellTemplateControl(visibleIndex, col, col.FieldName + visibleIndex.ToString()) as ASPxTextBox;
		'        SqlDataSource1.UpdateParameters[col.FieldName].DefaultValue = tb.Text;

		'    }

		'}
		'string key = GridView.GetRowValues(visibleIndex, GridView.KeyFieldName).ToString();
		'SqlDataSource1.UpdateParameters[GridView.KeyFieldName].DefaultValue = key;
		'SqlDataSource1.Update();
	End Sub
End Class