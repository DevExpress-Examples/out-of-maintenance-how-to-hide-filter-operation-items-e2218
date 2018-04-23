using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;
using DevExpress.Data.Filtering.Helpers;
using DevExpress.Web.ASPxEditors;


public partial class _Default : System.Web.UI.Page {
    static List<ClauseType> AllowedOperations {
        get {
            return new List<ClauseType>(new ClauseType[6]{ 
                    ClauseType.Equals, ClauseType.DoesNotEqual,
                    ClauseType.BeginsWith, ClauseType.EndsWith,
                    ClauseType.Contains, ClauseType.DoesNotContain
                });
        }
    }
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            filter.FilterExpression = grid.FilterExpression = "[CategoryName] Like '%ns%'";
        }
    }
    protected void filter_FilterOperationVisibility(object sender, FilterControlOperationVisibilityEventArgs e) {
        if(e.PropertyInfo.PropertyName == "CategoryName" || e.PropertyInfo.PropertyName == "Description") {
            e.Visible = AllowedOperations.Contains(e.Operation);
        }
    }
}