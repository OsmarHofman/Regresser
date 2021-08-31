using Regresser.Domain.RobotsActions;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Regresser
{
    public partial class MainForm : Form
    {
        public static List<Robot> robots = new List<Robot>();

        public MainForm()
        {
            InitializeComponent();
        }

        private List<TreeNode> GetRobotLabels()
        {
            var rootNodes = new List<TreeNode>();

            foreach (var robot in robots)
            {
                var children = new List<TreeNode>();

                var testId = new TreeNode($"TestId: {robot.TestId}");

                children.Add(testId);

                TreeNode root;
                try
                {
                    foreach (var action in robot.actions) children.Add(action.ToStringAsTreeNodes());

                    root = new TreeNode(robot.RobotName, children.ToArray());
                }
                catch (Exception e)
                {
                    root = new TreeNode(e.Message);
                }

                rootNodes.Add(root);
            }


            return rootNodes;
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            var response = Robot.SendActions(robots);

            MessageBox.Show($"Resposta dos Robozinhos:\n {response}");
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            contextMenuStrip.Show(Cursor.Position.X, Cursor.Position.Y);
        }

        private void listBox_Actions_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (listBox_Actions.SelectedIndex != -1)
            //{
            //    button_Send.Enabled = true;

            //    if (listBox_Actions.SelectedIndex != 0)
            //        button_Move_Up.Enabled = true;

            //    if (listBox_Actions.SelectedIndex == 0)
            //        button_Move_Up.Enabled = false;

            //    if (listBox_Actions.SelectedIndex != listBox_Actions.Items.Count)
            //        button_Move_Down.Enabled = true;

            //    if (listBox_Actions.SelectedIndex == listBox_Actions.Items.Count - 1)
            //        button_Move_Down.Enabled = false;
            //}
        }

        private void button_Move_Up_Click(object sender, EventArgs e)
        {
            //var aux = listBox_Actions.SelectedItem;
            //listBox_Actions.Items[listBox_Actions.SelectedIndex] = listBox_Actions.Items[listBox_Actions.SelectedIndex - 1];
            //listBox_Actions.Items[listBox_Actions.SelectedIndex - 1] = aux;
            //listBox_Actions.SelectedIndex -= 1;
        }

        private void button_Move_Down_Click(object sender, EventArgs e)
        {
            //var aux = listBox_Actions.SelectedItem;
            //listBox_Actions.Items[listBox_Actions.SelectedIndex] = listBox_Actions.Items[listBox_Actions.SelectedIndex + 1];
            //listBox_Actions.Items[listBox_Actions.SelectedIndex + 1] = aux;
            //listBox_Actions.SelectedIndex += 1;
        }

        private void embarqueToolStripMenuItem_Shipment_Click(object sender, EventArgs e)
        {
            ShipmentForm shipmentForm = new ShipmentForm();
            shipmentForm.ShowDialog();
        }

        private void timeoutToolStripMenuItem_Timeout_Click(object sender, EventArgs e)
        {
            TimeoutForm timeoutForm = new TimeoutForm();
            timeoutForm.ShowDialog();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            treeView_Actions.Nodes.Clear();

            var robotLabels = GetRobotLabels();

            treeView_Actions.Nodes.AddRange(robotLabels.ToArray());
        }

        private void button_Load_Click(object sender, EventArgs e)
        {
            LoadJSONForm loadJSONForm = new LoadJSONForm();
            loadJSONForm.ShowDialog();
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {

        }
    }
}
