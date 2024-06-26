<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128540886/12.2.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4600)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# How to implement a single cell editing feature in ASPxGridView for iOS devices


<p>If you take a look at the <a href="https://www.devexpress.com/Support/Center/p/E430">How to implement a single cell editing feature in the ASPxGridView</a> example, you will see that this feature doesn't work correctly on iOS devices. The keyboard appears and cells can be edited only after you click a cell twice. Editors are created dynamically on a GridView callback and iOS prevents setting focus.  Therefore, the keyboard doesn't appear since a cell editor does not exist when a user taps the cell.<br />
In this example, we provide a workaround that implements correct behavior. The iOS keyboard is shown if a user taps on an HTML input element and focus is not changed. </p><p>The main idea is to manipulate the editor's border-width style on the client side by handling the editor's client-side GotFocus and LostFocus events to  imitate the default and edit cell states. </p><p>In this example, data is instantly updated after leaving a cell. Please note that before sending a callback, the editor's value is checked via client-side validation, so that there are no update errors.</p>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=asp-net-web-forms-grid-single-cell-editing-for-ios-devices&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=asp-net-web-forms-grid-single-cell-editing-for-ios-devices&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
