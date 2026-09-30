using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inclass_Activity_06
{
    public class EntertainmentRobot : RobotPrototype
    {
        public string entertainmentFeature;

        public EntertainmentRobot(string modelName, string battertCapcity, string softwareVersion, string entertainmentFeature) : base(modelName, battertCapcity, softwareVersion)
        {
            this.entertainmentFeature = entertainmentFeature;
        }

        public override RobotPrototype Clone()
        {
            return new EntertainmentRobot(this.modelName, this.battertCapcity, this.softwareVersion, this.entertainmentFeature);
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Entertainment Robot: {this.modelName}, Battery Capacity: {this.battertCapcity}, Software Version: {this.softwareVersion}, Entertainment Feature: {this.entertainmentFeature}");
        }
    }
}
