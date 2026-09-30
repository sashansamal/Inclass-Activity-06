using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inclass_Activity_06
{
    public class ServiceRobot : RobotPrototype
    {
        public string serviceTask;

        public ServiceRobot(string modelName, string battertCapcity, string softwareVersion, string serviceTask) : base(modelName, battertCapcity, softwareVersion)
        {
            this.serviceTask = serviceTask;
        }
        
        public override RobotPrototype Clone()
        {
            return new ServiceRobot(this.modelName, this.battertCapcity, this.softwareVersion, this.serviceTask);
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Service Robot: {this.modelName}, Battery Capacity: {this.battertCapcity}, Software Version: {this.softwareVersion}, Service Task: {this.serviceTask}");
        }
    }
}
