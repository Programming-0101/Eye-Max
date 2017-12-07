using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.CustomerServerControls
{
    public class CleanCheckBox : CheckBox
    {
        protected override void OnPreRender(EventArgs e)
        {
            InputAttributes["class"] = InputCssClass;
            InputAttributes["style"] = InputStyle;
        }

        public string InputCssClass { get; set; }
        public string InputStyle { get; set; }
    }
}