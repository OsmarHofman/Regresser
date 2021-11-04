using Regresser.Domain.RobotsActions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Regresser
{
    public partial class TimeoutForm : Form
    {
        private int editingRobotIndex = -1;

        public TimeoutForm()
        {
            InitializeComponent();
        }

        public TimeoutForm(Robot robot)
        {
            InitializeComponent();

            SetRobotValues(robot);
        }

        private void SetRobotValues(Robot robot)
        {
            var userBoltActions = robot.actions.First() as UserBoltActions;

            textBox_Valor_Timeout.Text = (userBoltActions.timeout / 1000).ToString();

            editingRobotIndex = MainForm.robots.IndexOf(robot);
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

            if (editingRobotIndex == -1)
                MainForm.robots.Add(userbolt);
            else
                MainForm.robots[editingRobotIndex] = userbolt;
            Close();
        }
    }
}
