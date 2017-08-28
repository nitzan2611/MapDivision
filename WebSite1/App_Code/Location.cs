using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Location
/// </summary>
public class Location
{
    public double xCoord { get; set; }
    public double yCoord { get; set; }
    public Location()   {  }
    public Location(double _xCoord, double _yCoord)
    {
        this.xCoord = _xCoord;
        this.yCoord = _yCoord;
    }
}