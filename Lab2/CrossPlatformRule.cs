using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVES
{
    class CrossPlatformRule : Rule
    {
        public CrossPlatformRule()
        {
            question = "Do you need a cross-platform framework?";
        }

        public override void No()
        {
            answer = "TensorFlow";
            explanation = @"TensorFlow is one of the most widely used open-source libraries for deep learning. 
Originally developed by Google, it provides robust support for numerical computation and deep learning tasks. 
TensorFlow allows you to create dataflow graphs and structures, making it easier to process desired outcomes. 
Applications of TensorFlow include text-based applications like language detection and sentiment analysis.";
            image = Properties.Resources.TensorFlowLogo;
        }

        public override void Yes()
        {
            answer = "OpenCV";
            explanation = @"OpenCV is the world's biggest computer vision library.
It's open source, contains over 2500 algorithms and is operated by the non-profit Open Source Vision Foundation.
OpenCV is a highly optimized library with focus on real-time applications.
C++, Python and Java interfaces support Linux, MacOS, Windows, iOS, and Android.";
            image = Properties.Resources.OpenCV_Logo;
        }
    }
}
