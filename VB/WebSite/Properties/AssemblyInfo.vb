' Developer Express Code Central Example:
' How to implement a single cell editing feature in ASPxGridView for iOS devices
' 
' If you take a look at the http://www.devexpress.com/scid=E430 example, you will
' see that this feature doesn't work correctly on iOS devices. The keyboard
' appears and cells can be edited only after you click a cell twice. Editors are
' created dynamically on a GridView callback and iOS prevents setting focus.
' Therefore, the keyboard doesn't appear since a cell editor does not exist when a
' user taps the cell.
' In this example, we provide a workaround that implements
' correct behavior. The iOS keyboard is shown if a user taps on an HTML input
' element and focus is not changed. The main idea is to manipulate the editor's
' border-width style on the client side by handling the editor's client-side
' GotFocus and LostFocus events to imitate the default and edit cell states. In
' this example, data is instantly updated after leaving a cell. Please note that
' before sending a callback, the editor's value is checked via client-side
' validation, so that there are no update errors.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E4600

' Developer Express Code Central Example:
' How to implement a single cell editing feature in ASPxGridView for iOS devices
' 
' If you take a look at the http://www.devexpress.com/scid=E430 example, you will
' see that this feature doesn't work correctly on iOS devices. The keyboard
' appears and cells can be edited only after you click a cell twice. Editors are
' created dynamically on a GridView callback and iOS prevents setting focus.
' Therefore, the keyboard doesn't appear since a cell editor does not exist when a
' user taps the cell.
' In this example, we provide a workaround that implements
' correct behavior. The iOS keyboard is shown if a user taps on an HTML input
' element and focus is not changed. The main idea is to manipulate the editor's
' border-width style on the client side by handling the editor's client-side
' GotFocus and LostFocus events to imitate the default and edit cell states. In
' this example, data is instantly updated after leaving a cell. Please note that
' before sending a callback, the editor's value is checked via client-side
' validation, so that there are no update errors.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E4600


Imports Microsoft.VisualBasic
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices

' General Information about an assembly is controlled through the following 
' set of attributes. Change these attribute values to modify the information
' associated with an assembly.
<Assembly: AssemblyTitle("MutiRowEditingIPAD")>
<Assembly: AssemblyDescription("")>
<Assembly: AssemblyConfiguration("")>
<Assembly: AssemblyCompany("")>
<Assembly: AssemblyProduct("MutiRowEditingIPAD")>
<Assembly: AssemblyCopyright("Copyright ? 2013")>
<Assembly: AssemblyTrademark("")>
<Assembly: AssemblyCulture("")>

' Setting ComVisible to false makes the types in this assembly not visible 
' to COM components.  If you need to access a type in this assembly from 
' COM, set the ComVisible attribute to true on that type.
<Assembly: ComVisible(False)>

' The following GUID is for the ID of the typelib if this project is exposed to COM
<Assembly: Guid("15b0727e-133e-4b37-a49d-5aa5d2edabd2")>

' Version information for an assembly consists of the following four values:
'
'      Major Version
'      Minor Version 
'      Build Number
'      Revision
'
' You can specify all the values or you can default the Revision and Build Numbers 
' by using the '*' as shown below:
<Assembly: AssemblyVersion("1.0.0.0")>
<Assembly: AssemblyFileVersion("1.0.0.0")>