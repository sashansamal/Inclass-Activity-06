using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inclass_Activity_06
{
    public abstract class RobotPrototype
    {
        public string modelName, battertCapcity, softwareVersion;

        public RobotPrototype(string modelName, string battertCapcity, string softwareVersion)
        {
            this.modelName = modelName;
            this.battertCapcity = battertCapcity;
            this.softwareVersion = softwareVersion;
        }

        public abstract RobotPrototype Clone();

        public abstract void DisplayDetails();
    }
}

