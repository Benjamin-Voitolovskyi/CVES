using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVES
{
    class FlexibilityRule : Rule
    {
        public FlexibilityRule()
        {
            question = "Do you need flexibility to work with different ML backends?";
        }

        public override void No()
        {
            nextRule = new SimplicityRule();
        }

        public override void Yes()
        {
            answer = "Nvidia Triton Inference Server";
            explanation = @"Triton Inference Server enables teams to deploy any AI model from multiple deep learning and machine learning frameworks, 
including TensorRT, TensorFlow, PyTorch, ONNX, OpenVINO, Python, RAPIDS FIL, and more. 
Triton supports inference across cloud, data center, edge and embedded devices on NVIDIA GPUs, x86 and ARM CPU, or AWS Inferentia. 
Triton Inference Server delivers optimized performance for many query types, including real time, batched, ensembles and audio/video streaming. ";
            image = Properties.Resources.Nvidia_Triton;
        }
    }
}
