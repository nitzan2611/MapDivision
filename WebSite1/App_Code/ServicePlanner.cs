using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ServicePlanner
/// </summary>
public class ServicePlanner
{
    List<ServiceProvider> serviceProviders;
    public ServicePlanner()
    {
        serviceProviders = new List<ServiceProvider>();
    }
    public void initLocations()
    {
        this.serviceProviders.Add(new Paramedic(new Location(31.8801887, 35.2525093)));
        this.serviceProviders.Add(new Paramedic(new Location(31.903419, 35.203353)));

    }
    public List<ArrivalPriority> getDirections(Location dst, List<ServiceProviderRequest> requests)
    {
        foreach (ServiceProviderRequest req in requests)
        {
            List<ServiceProvider> relevantServiceProviders = serviceProviders.Where(x => x.GetType() == req.serviceProvider.GetType()).ToList();



        }
        return null;
    }
}