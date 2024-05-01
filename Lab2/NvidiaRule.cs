using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVES
{
    class NvidiaRule : Rule
    {
        public NvidiaRule()
        {
            question = "Do you want to work with Nividia's technology stack?";
        }
        public override void No()
        {
            nextRule = new FlexibilityRule();
        }

        public override void Yes()
        {
            nextRule = new TrainModelsRule();
        }
    }
}
