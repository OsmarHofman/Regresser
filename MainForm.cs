using Newtonsoft.Json;
using System.Linq;
using System;
using System.Collections.Generic;
using System.IO;
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

        private void RefreshRobotLabels()
        {
            treeView_Actions.Nodes.Clear();

            var robotLabels = GetRobotLabels();

            treeView_Actions.Nodes.AddRange(robotLabels.ToArray());
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            var response = Robot.SendActions(robots);

            MessageBox.Show("Enviado aos robozinhos!");

            //MessageBox.Show($"Resposta dos Robozinhos:\n {response}");
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            contextMenuStrip.Show(Cursor.Position.X, Cursor.Position.Y);
        }

        private void listBox_Actions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_Move_Up_Click(object sender, EventArgs e)
        {
            var selectedIndex = treeView_Actions.Nodes.IndexOf(treeView_Actions.SelectedNode);
            var selectedRobotToMoveUp = robots[selectedIndex];
            robots[selectedIndex] = robots[selectedIndex - 1];
            robots[selectedIndex - 1] = selectedRobotToMoveUp;

            RefreshRobotLabels();
        }

        private void button_Move_Down_Click(object sender, EventArgs e)
        {
            var selectedIndex = treeView_Actions.Nodes.IndexOf(treeView_Actions.SelectedNode);
            var selectedRobotToMoveDown = robots[selectedIndex];
            robots[selectedIndex] = robots[selectedIndex + 1];
            robots[selectedIndex + 1] = selectedRobotToMoveDown;

            RefreshRobotLabels();
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
            RefreshRobotLabels();

            if (treeView_Actions.Nodes.Count != 0)
                button_Send.Enabled = true;
        }

        private void button_Load_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = @"C:\git.nddigital";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileStream = openFileDialog.OpenFile();

                var reader = new StreamReader(fileStream);

                try
                {
                    var robotJson = reader.ReadToEnd();
                    
                    var convertedRobots = JsonConvert.DeserializeObject<List<Robot>>(robotJson, new JsonSerializerSettings
                    {
                        TypeNameHandling = TypeNameHandling.Auto
                    });

                    MessageBox.Show("Arquivo carregado com sucesso!");
                    robots = convertedRobots;

                    RefreshRobotLabels();

                }
                catch (IOException ioe)
                {
                    MessageBox.Show($"Erro ao tentar ler o arquivo {openFileDialog.FileName}:\n{ioe.Message}");
                }
                catch (JsonSerializationException jsonExp)
                {
                    MessageBox.Show($"Erro ao tentar converter arquivo {openFileDialog.FileName} para a modelagem dos robôs:\n{jsonExp.Message}");
                }
                catch (NotImplementedException notImpExp)
                {
                    MessageBox.Show(notImpExp.Message);
                }
                catch (Exception exp)
                {
                    MessageBox.Show($"Erro: {exp.Message}");
                }

            }

        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            if (treeView_Actions.SelectedNode != null)
            {
                robots.RemoveAt(treeView_Actions.SelectedNode.Index);

                RefreshRobotLabels();

                if (!robots.Any())
                {
                    button_Send.Enabled = false;
                    button_Remove.Enabled = false;
                }
            }
        }

        private void button_Save_JSON_Click(object sender, EventArgs e)
        {

            if (robots.Any())
            {
                saveFileDialog_JSON.RestoreDirectory = true;

                if (saveFileDialog_JSON.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var json = JsonConvert.SerializeObject(robots,
                            new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

                        File.WriteAllText(saveFileDialog_JSON.FileName, json);
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show($"Erro ao tentar salvar o arquivo:\n {exp.Message}");
                        throw;
                    }

                }
            }
            else
                MessageBox.Show("Nenhuma requisição para ser salva!");

        }

        private void treeView_Actions_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView_Actions.SelectedNode.Index != -1)
            {
                button_Remove.Enabled = true;

                if (treeView_Actions.SelectedNode.Index != 0)
                    button_Move_Up.Enabled = true;

                if (treeView_Actions.SelectedNode.Index == 0)
                    button_Move_Up.Enabled = false;

                if (treeView_Actions.SelectedNode.Index != treeView_Actions.Nodes.Count)
                    button_Move_Down.Enabled = true;

                if (treeView_Actions.SelectedNode.Index == treeView_Actions.Nodes.Count - 1)
                    button_Move_Down.Enabled = false;
            }
            else
                button_Remove.Enabled = false;
        }
    }
}
