// Developer Express Code Central Example:
// How to implement a single cell editing feature in ASPxGridView for iOS devices
// 
// If you take a look at the http://www.devexpress.com/scid=E430 example, you will
// see that this feature doesn't work correctly on iOS devices. The keyboard
// appears and cells can be edited only after you click a cell twice. Editors are
// created dynamically on a GridView callback and iOS prevents setting focus.
// Therefore, the keyboard doesn't appear since a cell editor does not exist when a
// user taps the cell.
// In this example, we provide a workaround that implements
// correct behavior. The iOS keyboard is shown if a user taps on an HTML input
// element and focus is not changed. The main idea is to manipulate the editor's
// border-width style on the client side by handling the editor's client-side
// GotFocus and LostFocus events to imitate the default and edit cell states. In
// this example, data is instantly updated after leaving a cell. Please note that
// before sending a callback, the editor's value is checked via client-side
// validation, so that there are no update errors.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E4600

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxEditors;
using DevExpress.Web.ASPxGridView;
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

    protected void cb_CallBack(object source, DevExpress.Web.ASPxCallback.CallbackEventArgs e)
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