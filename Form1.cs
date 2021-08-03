using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Regresser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEureka_Click(object sender, EventArgs e)
        {
            Robot robot = new Robot();
            var result = robot.SendActions();
        }
    }
}
