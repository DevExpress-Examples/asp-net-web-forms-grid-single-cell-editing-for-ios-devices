<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# How to implement a single cell editing feature in ASPxGridView for iOS devices
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e4600/)**
<!-- run online end -->


<p>If you take a look at the <a href="https://www.devexpress.com/Support/Center/p/E430">How to implement a single cell editing feature in the ASPxGridView</a> example, you will see that this feature doesn't work correctly on iOS devices. The keyboard appears and cells can be edited only after you click a cell twice. Editors are created dynamically on a GridView callback and iOS prevents setting focus.  Therefore, the keyboard doesn't appear since a cell editor does not exist when a user taps the cell.<br />
In this example, we provide a workaround that implements correct behavior. The iOS keyboard is shown if a user taps on an HTML input element and focus is not changed. </p><p>The main idea is to manipulate the editor's border-width style on the client side by handling the editor's client-side GotFocus and LostFocus events to  imitate the default and edit cell states. </p><p>In this example, data is instantly updated after leaving a cell. Please note that before sending a callback, the editor's value is checked via client-side validation, so that there are no update errors.</p>

<br/>


