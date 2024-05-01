using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVES
{
    abstract class Rule
    {
        protected Rule nextRule;
        protected string answer;
        protected string explanation;
        protected string question;
        protected Image image;

        public Rule NextRule => nextRule;
        public string Answer => answer;
        public string Explanation => explanation;
        public string Question => question;
        public Image Image => image;

        abstract public void Yes();
        abstract public void No();
    }
}
