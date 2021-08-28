using Regresser.Domain.RobotsActions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Regresser
{
    public partial class TimeoutForm : Form
    {
        public TimeoutForm()
        {
            InitializeComponent();
        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            var timeout = Int16.Parse(textBox_Valor_Timeout.Text) * 1000;

            var userbolt = new Robot
            {
                TestId = Guid.NewGuid(),
                RobotName = "userbolt",
                actions = new List<Actions>
                {
                    new UserBoltActions
                    {
                        type = "timeout",
                        timeout = timeout
                    }
                }
            };

            MainForm.robots.Add(userbolt);
            this.Close();
        }
    }
}
