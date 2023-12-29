<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128540886/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4600)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# Grid View for ASP.NET Web Forms - How to implement a single cell edit feature for iOS devices

This example demonstrates how to handle an editor's `GotFocus` and `LostFocus` events to imitate a single cell edit feature for iOS devices.

## Overview

If you take a look at the [Grid View for ASP.NET Web Forms - How to implement a single cell edit feature](https://github.com/DevExpress-Examples/asp-net-web-forms-grid-single-cell-editing) example, you will see that this feature doesn't work correctly on iOS devices. The keyboard appears and cells can be edited only after you click a cell twice. Editors are created dynamically on a grid's callback and iOS prevents setting focus. Therefore, the keyboard doesn't appear since a cell editor does not exist when a user taps the cell.

In this example, we provide a workaround that implements correct behavior. The iOS keyboard is shown if a user taps on an HTML input element and focus is not changed. The main idea is to manipulate the editor's border-width style on the client side by handling the editor's client-side `GotFocus` and `LostFocus` events to imitate the default and edit cell states. In this example, data is instantly updated after leaving a cell. Please note that before sending a callback, the editor's value is checked via client-side validation, so that there are no update errors.

## Files to Review

* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))

## More Examples

* [Grid View for ASP.NET Web Forms - How to implement a single cell edit feature](https://github.com/DevExpress-Examples/asp-net-web-forms-grid-single-cell-editing)

