using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVES
{
    class SimplicityRule : Rule
    {
        public SimplicityRule()
        {
            question = "Do you need simplicity in debugging and experimenting?";
        }

        public override void No()
        {
            nextRule = new CrossPlatformRule();
        }

        public override void Yes()
        {
            answer = "PyTorch";
            explanation = @"PyTorch: PyTorch is highly regarded for its dynamic computation graph and ease of use. 
It has gained popularity among researchers and developers due to its flexibility and intuitive interface. 
PyTorch is particularly well-suited for research and experimentation, and it has a strong community support.";
            image = Properties.Resources.PyTorch;
        }
    }
}
