using Newtonsoft.Json;
using System.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Regresser.Domain.RobotsActions;

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

        private void OpenRobotForm(Robot robot)
        {
            Form form;
            switch (robot.RobotName)
            {
                case "jarvis":
                    form = new ShipmentForm(robot);
                    break;

                case "userbolt":
                    form = new TimeoutForm(robot);
                    break;

                case "gigiba":
                    form = new NFeForm(robot);
                    break;

                case "bino":
                    form = new CTeForm(robot);
                    break;

                case "dba":
                    form = new DBAForm(robot);
                    break;

                default:
                    MessageBox.Show("Tela não encontrada para editar requisição selecionada!");
                    return;
            }

            form.ShowDialog();
        }

        private void SetUrlWsOnRobots()
        {
            foreach (var robot in robots)
            {
                switch (robot.RobotName)
                {
                    case "jarvis":
                        var jarvis = robot.actions.First() as JarvisActions;

                        jarvis.UrlWs = textBox_Url_WS.Text;

                        break;

                    case "gigiba":

                        var gigiba = robot.actions.First() as GigibaActions;

                        gigiba.UrlWs = textBox_Url_WS.Text;

                        break;

                    case "bino":
                        var bino = robot.actions.First() as BinoActions;

                        bino.UrlWs = textBox_Url_WS.Text;

                        break;
                }
            }
        }

        private void SetUrlWsOnScreen()
        {
            foreach (var robot in robots)
            {
                switch (robot.RobotName)
                {
                    case "jarvis":
                        var jarvis = robot.actions.First() as JarvisActions;

                        textBox_Url_WS.Text = jarvis.UrlWs;

                        return;

                    case "gigiba":

                        var gigiba = robot.actions.First() as GigibaActions;

                        gigiba.UrlWs = textBox_Url_WS.Text;

                        return;


                    case "bino":
                        var bino = robot.actions.First() as BinoActions;

                        bino.UrlWs = textBox_Url_WS.Text;

                        return;
                }
            }
        }

        public bool RobotsNeedsUrlWs()
        {
            foreach (var robot in robots)
            {
                if (robot.RobotName == "jarvis" ||
                    robot.RobotName == "gigiba" ||
                    robot.RobotName == "bino") return true;
            }

            return false;
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Url_WS.Text))
            {
                MessageBox.Show("Preencha a URL do WS!");
                return;
            }

            SetUrlWsOnRobots();

            var response = Robot.SendActions(robots);

            MessageBox.Show("Enviado aos robozinhos!");

            //MessageBox.Show($"Resposta dos Robozinhos:\n {response}");
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            contextMenuStrip.Show(Cursor.Position.X, Cursor.Position.Y);
        }

        private void button_Move_Up_Click(object sender, EventArgs e)
        {
            if (treeView_Actions.SelectedNode != null)
            {
                if (treeView_Actions.SelectedNode.Level == 0)
                {
                    var selectedIndex = treeView_Actions.Nodes.IndexOf(treeView_Actions.SelectedNode);
                    var selectedRobotToMoveUp = robots[selectedIndex];
                    robots[selectedIndex] = robots[selectedIndex - 1];
                    robots[selectedIndex - 1] = selectedRobotToMoveUp;

                    RefreshRobotLabels();
                }
                else
                    MessageBox.Show("Por favor selecione o nodo raiz para mover!");
            }
            else
                MessageBox.Show("Selecione um item a ser movido!");

        }

        private void button_Move_Down_Click(object sender, EventArgs e)
        {
            if (treeView_Actions.SelectedNode != null)
            {
                if (treeView_Actions.SelectedNode.Level == 0)
                {
                    var selectedIndex = treeView_Actions.Nodes.IndexOf(treeView_Actions.SelectedNode);
                    var selectedRobotToMoveDown = robots[selectedIndex];
                    robots[selectedIndex] = robots[selectedIndex + 1];
                    robots[selectedIndex + 1] = selectedRobotToMoveDown;

                    RefreshRobotLabels();
                }
                else
                    MessageBox.Show("Por favor selecione o nodo raiz para mover!");

            }
            else
                MessageBox.Show("Selecione um item a ser movido!");

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
            if (robots.Any())
            {
                var result = MessageBox.Show($"Já existem requisições cadastradas, deseja carregar um arquivo e substituir as existentes?", "Confirmação", MessageBoxButtons.YesNo);

                if (result == DialogResult.No) return;
            }

            //TODO: Deixar para somente C:\
            openFileDialog.InitialDirectory = @"C:\git.nddigital\JSONs";
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

                    SetUrlWsOnScreen();

                    RefreshRobotLabels();

                    button_Send.Enabled = true;
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
                finally
                {
                    reader.Close();

                    fileStream.Close();

                    openFileDialog.Reset();
                }

            }

        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            if (treeView_Actions.SelectedNode != null)
            {
                if (treeView_Actions.SelectedNode.Level == 0)
                {
                    robots.RemoveAt(treeView_Actions.SelectedNode.Index);

                    RefreshRobotLabels();

                    if (!robots.Any())
                    {
                        button_Send.Enabled = false;
                        button_Remove.Enabled = false;
                    }
                }
                else
                    MessageBox.Show("Por favor selecione o nodo raiz para remover!");

            }
        }

        private void button_Save_JSON_Click(object sender, EventArgs e)
        {
            if (RobotsNeedsUrlWs() &&
                string.IsNullOrEmpty(textBox_Url_WS.Text))
            {
                MessageBox.Show("Preencha a URL do WS!");
                return;
            }

            if (robots.Any())
            {
                saveFileDialog_JSON.RestoreDirectory = true;

                if (saveFileDialog_JSON.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        SetUrlWsOnRobots();

                        var json = JsonConvert.SerializeObject(robots,
                            new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

                        File.WriteAllText(saveFileDialog_JSON.FileName, json);

                        MessageBox.Show($"Arquivo {saveFileDialog_JSON.FileName} salvo com sucesso!");
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show($"Erro ao tentar salvar o arquivo:\n {exp.Message}");
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

                button_Clone.Enabled = true;

                button_Edit.Enabled = true;

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

        private void nFeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NFeForm nfeForm = new NFeForm();
            nfeForm.ShowDialog();
        }

        private void button_Clone_Click(object sender, EventArgs e)
        {
            var robotIndex = treeView_Actions.SelectedNode.Index;

            if (treeView_Actions.SelectedNode.Level == 0)
            {
                var result = MessageBox.Show($"Deseja realmente duplicar essa requisição do robô?", "Duplicar", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    var robot = new Robot(robots[robotIndex]);
                    robots.Add(robot);

                    RefreshRobotLabels();
                }
            }
            else
                MessageBox.Show("Por favor selecione o nodo raiz para duplicar!");

        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            if (treeView_Actions.SelectedNode.Level == 0)
                OpenRobotForm(robots[treeView_Actions.SelectedNode.Index]);
            else
                MessageBox.Show("Por favor selecione o nodo raiz para editar!");

        }

        private void cTeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CTeForm cteForm = new CTeForm();
            cteForm.ShowDialog();
        }

        private void validaçãoNoBancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBAForm dBAForm = new DBAForm();
            dBAForm.ShowDialog();
        }
    }
}
