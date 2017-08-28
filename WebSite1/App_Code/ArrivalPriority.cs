using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ArrivalPriority
/// </summary>
public class ArrivalPriority
{
    public ServiceProvider serviceProvider { get; set; }
    public double duration { get; set; }
    public ArrivalPriority(ServiceProvider _sp, double _dt) 
    {
        this.serviceProvider = _sp;
        this.duration = _dt;
    }
}