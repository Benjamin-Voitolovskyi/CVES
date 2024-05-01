using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVES
{
    class MaximumSpeedRule : Rule
    {
        public MaximumSpeedRule()
        {
            question = "Do you need maximum speed?";
        }

        public override void No()
        {
            nextRule = new FlexibilityRule();
        }

        public override void Yes()
        {
            answer = "Nvidia TensorRT";
            explanation = @"NVIDIA® TensorRT™, an SDK for high-performance deep learning inference, 
includes a deep learning inference optimizer and runtime that delivers low latency and high throughput for inference applications.";
            image = Properties.Resources.tensorrt_logo_625x290;
        }
    }
}
