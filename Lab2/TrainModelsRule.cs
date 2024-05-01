using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVES
{
    class TrainModelsRule : Rule
    {
        public TrainModelsRule()
        {
            question = "Do ou need to train ML models and/or optimize their structure?";
        }

        public override void No()
        {
            nextRule = new MaximumSpeedRule();
        }

        public override void Yes()
        {
            answer = "Nvidia TAO Toolkit";
            explanation = @"Eliminate the need for mountains of data and an army of data scientists as you create AI/machine learning models and speed up the development process with transfer learning. 
This powerful technique instantly transfers learned features from an existing neural network model to a new customized one. 
The open-source NVIDIA TAO Toolkit, built on TensorFlow and PyTorch, uses the power of transfer learning while simultaneously simplifying the model training process 
and optimizing the model for inference throughput on practically any platform.The result is an ultra - streamlined workflow.
Take your own models or pre - trained models, adapt them to your own real or synthetic data, then optimize for inference throughput. 
All without needing AI expertise or large training datasets.";
            image = Properties.Resources.Nvidia_TAO;
        }
    }
}
