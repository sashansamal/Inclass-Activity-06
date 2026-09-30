using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inclass_Activity_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceRobot s1 = new ServiceRobot("S1", "5000mAh", "v1.0", "Cleaning");

            ServiceRobot s2 = (ServiceRobot)s1.Clone();
            s2.battertCapcity = "6000mAh";

            IndustrialRobot i1 = new IndustrialRobot("I1", "10000mAh", "v2.0", "Welding");

            IndustrialRobot i2 = (IndustrialRobot)i1.Clone();
            i2.softwareVersion = "v2.1";

            EntertainmentRobot e1 = new EntertainmentRobot("E1", "3000mAh", "v1.5", "Music");

            EntertainmentRobot e2 = (EntertainmentRobot)e1.Clone();
            e2.entertainmentFeature = "Dance";

            s1.DisplayDetails();
            s2.DisplayDetails();

            i1.DisplayDetails();
            i2.DisplayDetails();

            e1.DisplayDetails();
            e2.DisplayDetails();




        }
    }
}
