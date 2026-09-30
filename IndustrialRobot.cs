using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inclass_Activity_06
{
    public class IndustrialRobot : RobotPrototype
    {
        public string IndustrialTask;

        public IndustrialRobot(string modelName, string battertCapcity, string softwareVersion, string IndustrialTask) : base(modelName, battertCapcity, softwareVersion)
        {
            this.IndustrialTask = IndustrialTask;
        }
        
        public override RobotPrototype Clone()
        {
            return new IndustrialRobot(this.modelName, this.battertCapcity, this.softwareVersion, this.IndustrialTask);
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Industrial Robot: {this.modelName}, Battery Capacity: {this.battertCapcity}, Software Version: {this.softwareVersion}, Industrial Task: {this.IndustrialTask}");
        }
    }
}
