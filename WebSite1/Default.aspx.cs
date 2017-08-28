using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



public partial class _Default : System.Web.UI.Page
{
    List<ServiceProvider> serviceProviders = new List<ServiceProvider>();
    ServicePlanner servicePlanner = new ServicePlanner();

    protected void Page_Load(object sender, EventArgs e)
    {
        this.servicePlanner.initLocations();
       
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        
    }
}