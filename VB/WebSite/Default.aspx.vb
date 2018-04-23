Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports System.Collections.Generic
Imports DevExpress.Data.Filtering.Helpers
Imports DevExpress.Web.ASPxEditors


Partial Public Class _Default
	Inherits System.Web.UI.Page
	Private Shared ReadOnly Property AllowedTypes() As List(Of ClauseType)
		Get
			Return New List(Of ClauseType)(New ClauseType(5){ ClauseType.Equals, ClauseType.DoesNotEqual, ClauseType.BeginsWith, ClauseType.EndsWith, ClauseType.Contains, ClauseType.DoesNotContain })
		End Get
	End Property
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			grid.FilterExpression = "[CategoryName] Like '%ns%'"
			filter.FilterExpression = grid.FilterExpression
		End If
	End Sub
	Protected Sub filter_FilterOperationVisibility(ByVal sender As Object, ByVal e As FilterControlOperationVisibilityEventArgs)
		If e.PropertyInfo.PropertyName = "CategoryName" OrElse e.PropertyInfo.PropertyName = "Description" Then
			e.Visible = AllowedTypes.Contains(e.Operation)
		End If
	End Sub
End Class