using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TiendaGrupo15Progra3
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
       

        protected void btnParticipa_Click(object sender, EventArgs e)
        {
            Response.Redirect("/WebForm1.aspx");
        }
    }
}