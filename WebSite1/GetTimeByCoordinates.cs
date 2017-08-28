using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml;

namespace ConsoleApp1
{
    class GetTimeByCoordinates
    {
        static void Main(String[] args)
        {
            double x0 = 41.43206, y0 = -81.38992, x1 = 41.43206, y1 = -85.38992;
            int res = GetTimeByCoordinatesMethod(x0, y0, x1, y1);
            Console.WriteLine(res);
            Console.ReadLine();
        }
        static int GetTimeByCoordinatesMethod(double x0,double y0,double x1,double y1)
        {
         //  double x0 = 41.43206, y0 = -81.38992, x1 = 41.43206, y1 = -85.38992;
            String CallLink = "https://maps.googleapis.com/maps/api/distancematrix/"
        +"xml?origins={0},{1}"
        + "&destinations={2},{3}"
        + "&key=AIzaSyD9wSoCW4x30-RukL5Q4NzLZ7KG2lQpbZw";
            String url = String.Format(CallLink, x0, y0, x1, y1);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;
            String html;
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }


            XmlDocument doc = new XmlDocument();
            doc.LoadXml(html);
            XmlNode node = doc.DocumentElement.SelectSingleNode("/DistanceMatrixResponse/row/element/duration/value");
            int seconds = Int32.Parse(node.InnerText);
            return seconds / 60;
        }
    }
}
