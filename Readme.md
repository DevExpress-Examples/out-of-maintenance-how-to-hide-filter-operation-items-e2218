<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# How to hide filter operation items


<p>Starting with v2010 vol 1. it is possible to hide filter operation items (Contains, Equals, etc.). In the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxEditorsASPxFilterControlBase_OperationVisibilitytopic"><u>ASPxFilterControl.OperationVisibility</u></a> event handler, a database field name is analyzed, and based on custom conditions, unnecessary operations are hidden.</p>

<br/>


