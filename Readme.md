<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128540563/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2218)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# How to hide filter operation items


<p>Starting with v2010 vol 1. it is possible to hide filter operation items (Contains, Equals, etc.). In the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxEditorsASPxFilterControlBase_OperationVisibilitytopic"><u>ASPxFilterControl.OperationVisibility</u></a> event handler, a database field name is analyzed, and based on custom conditions, unnecessary operations are hidden.</p>

<br/>


