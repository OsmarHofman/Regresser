using Regresser.Domain;
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
    public partial class DBAForm : Form
    {
        public static List<DBAResult> results;

        private int editingRobotIndex = -1;

        public DBAForm()
        {
            InitializeComponent();
            results = new List<DBAResult>();
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
                    ServerPassword = maskedTextBox_DB_Password.Text,
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
