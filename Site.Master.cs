using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercice2_AT5
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (DropDownList1.SelectedIndex)
            {
                case 0:
                    Image1.ImageUrl = "~/Images/printemps.jpg";
                    break;
                case 1:
                    Image1.ImageUrl = "~/Images/été.jpg";

                    break;
                case 2:
                    Image1.ImageUrl = "~/Images/automne.jpg";

                    break;
                case 3:
                    Image1.ImageUrl = "~/Images/hiver.jpg";

                    break;
               
            }
            
        }
    }
}