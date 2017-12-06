using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected override void OnPreRender(EventArgs e)
        {
            // Show only relevant panels
            ShowTimePanel.Visible = MovieDropDown.SelectedIndex > 0;
            SeatingPanel.Visible = ShowTimePanel.Visible && ShowTimesListView.SelectedIndex >= 0;

            // Reset selected show-times
            if (!ShowTimePanel.Visible)
                ShowTimesListView.SelectedIndex = -1;

            base.OnPreRender(e);
        }

        protected void PickMovie_Click(object sender, EventArgs e)
        {
            string styling = "btn ";
            styling += MovieDropDown.SelectedIndex == 0 ? "btn-primary" : "btn-default";
            PickMovie.CssClass = styling;
        }

        protected void ShowTimesListView_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            if(e.CommandName.Equals("Deselect"))
            {
                ShowTimesListView.SelectedIndex = -1;
                e.Handled = true;
            }
        }
    }
}