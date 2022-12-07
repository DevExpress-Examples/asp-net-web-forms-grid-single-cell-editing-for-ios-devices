using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;
using System.Web.UI.HtmlControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void EditorInit(object sender, EventArgs e)
    {
        ASPxTextBox tb = sender as ASPxTextBox;
        GridViewDataItemTemplateContainer container = tb.NamingContainer as GridViewDataItemTemplateContainer;
        int visibleIndex = container.VisibleIndex;
        tb.ID += visibleIndex.ToString();
        tb.ClientInstanceName += visibleIndex.ToString();
        tb.ClientSideEvents.GotFocus = String.Format("function (s, e) {{ onCellFocus(s, e); }}", visibleIndex);
        tb.ClientSideEvents.LostFocus = String.Format("function (s, e) {{ onCellLostFocus(s, e, {0}); }}", visibleIndex);
    }

    protected void cb_CallBack(object source, DevExpress.Web.CallbackEventArgs e)
    {
        if (String.IsNullOrEmpty(e.Parameter)) return;
        int visibleIndex = Convert.ToInt32(e.Parameter); 

        //---- The code below cofigures update parameters and write changes to database

        //foreach (GridViewDataColumn col in GridView.Columns)
        //{
        //    if (col.FieldName != GridView.KeyFieldName)
        //    {
        //        ASPxTextBox tb = GridView.FindRowCellTemplateControl(visibleIndex, col, col.FieldName + visibleIndex.ToString()) as ASPxTextBox;
        //        SqlDataSource1.UpdateParameters[col.FieldName].DefaultValue = tb.Text;
               
        //    }
                    
        //}
        //string key = GridView.GetRowValues(visibleIndex, GridView.KeyFieldName).ToString();
        //SqlDataSource1.UpdateParameters[GridView.KeyFieldName].DefaultValue = key;
        //SqlDataSource1.Update();
    }
}