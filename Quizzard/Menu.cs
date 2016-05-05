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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            QuestionForm qf1 = new QuestionForm();
            qf1.Show();
        }
    }
}
