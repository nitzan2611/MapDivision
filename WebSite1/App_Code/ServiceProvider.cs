using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ServiceProvider
/// </summary>
public abstract class ServiceProvider
{
    public Location location { get; set; }
  

}

public class Paramedic : ServiceProvider
{
    public Paramedic(Location loc)
    {
        this.location = loc;
    }

   
}

public class ArabicSpeaker : ServiceProvider
{
    public ArabicSpeaker(Location loc)
    {
        this.location = loc;
    }
}