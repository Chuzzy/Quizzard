using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizzard
{
    public partial class QuestionForm : Form
    {
        public QuestionForm()
        {
            InitializeComponent();
        }
        
        private void changeButton_Click(object sender, EventArgs e)
        {
            questionBox.Rtf = @"{\rtf1\ansi " + questionBox.Text + "}";
        }

        private void changeButton2_Click(object sender, EventArgs e)
        {
            questionBox.SelectionFont = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);

        }
    }
}
