using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CVES
{
    public partial class Form1 : Form
    {
        private Rule rule;
        private const int IMAGE_SIZE = 250;

        public Form1()
        {
            InitializeComponent();
            Restart();
        }

        private void FireRule(bool input)
        {
            if (input)
                rule.Yes();
            else
                rule.No();

            if (rule.Answer is not null)
            {
                questionLabel.Text = rule.Answer;
                explanationLabel.Text = rule.Explanation;
                pictureBox1.Image = Utils.Resize(rule.Image, new Size(IMAGE_SIZE, IMAGE_SIZE));
                //int offsetX = (IMAGE_SIZE - pictureBox1.Image.Width) / 2;
                //int offsetY = (IMAGE_SIZE - pictureBox1.Image.Height) / 2;
                //pictureBox1.Padding = new Padding(Padding.Left + offsetX, Padding.Top + offsetY, 0, 0);
                yesButton.Hide();
                noButton.Hide();
            }
            else
            {
                rule = rule.NextRule;
                questionLabel.Text = rule.Question;
            }
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            FireRule(true);
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            FireRule(false);
        }

        private void Restart()
        {
            rule = new NvidiaRule();
            questionLabel.Text = rule.Question;
            explanationLabel.Text = "";
            pictureBox1.Image = null;
            yesButton.Show();
            noButton.Show();
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            Restart();
        }

        private void questionLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
