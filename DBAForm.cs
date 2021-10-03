using Regresser.Domain;
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
    public partial class DBAForm : Form
    {
        public static List<DBAResult> results;

        private int editingRobotIndex = -1;

        public DBAForm()
        {
            InitializeComponent();
            results = new List<DBAResult>();
        }

        public DBAForm(Robot robot)
        {
            InitializeComponent();
            results = new List<DBAResult>();

            SetRobotValues(robot);
        }

        private void SetRobotValues(Robot robot)
        {
            var dbaActions = robot.actions.First() as DBAActions;

            textBox_Server_IP.Text = dbaActions.Server;

            textBox_DB_User.Text = dbaActions.ServerUser;

            textBox_DB_Password.Text = dbaActions.ServerPassword;

            textBox_ShipperContext.Text = dbaActions.ShipperContext;

            textBox_MonitoringContext.Text = dbaActions.MonitoringContext;

            textBox_PaymentContext.Text = dbaActions.PaymentContext;

            textBox_Query.Text = dbaActions.QueryString;

            results = dbaActions.Results;

            InsertResults();

            editingRobotIndex = MainForm.robots.IndexOf(robot);
        }


        private void InsertResults()
        {
            listBox.Items.Clear();

            foreach (var result in results) listBox.Items.Add(result.Value);
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            DBAResultForm dbaResultForm = new DBAResultForm();
            dbaResultForm.ShowDialog();
        }


        private void button_Edit_Click(object sender, EventArgs e)
        {
            DBAResultForm dbaResultForm = new DBAResultForm(results[listBox.SelectedIndex]);
            dbaResultForm.ShowDialog();
        }

        private void DBAForm_Activated(object sender, EventArgs e)
        {
            InsertResults();
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {

            results.RemoveAt(listBox.SelectedIndex);
            InsertResults();
        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < results.Count; i++)
            {
                var result = results[i];
                result.Sequence = i;
            }

            var dbaActions = new List<Actions>
            {
                new DBAActions
                {
                    Server = textBox_Server_IP.Text,
                    ServerUser = textBox_DB_User.Text,
                    ServerPassword = textBox_DB_Password.Text,
                    ShipperContext = textBox_ShipperContext.Text,
                    MonitoringContext = textBox_MonitoringContext.Text,
                    PaymentContext = textBox_PaymentContext.Text,
                    QueryString = textBox_Query.Text,
                    Results = results
                }
            };

            var dba = new Robot("dba", dbaActions);

            if (editingRobotIndex == -1)
                MainForm.robots.Add(dba);
            else
                MainForm.robots[editingRobotIndex] = dba;

            Close();
        }
    }
}
