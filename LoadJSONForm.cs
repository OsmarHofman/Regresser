using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Regresser
{
    public partial class LoadJSONForm : Form
    {
        public LoadJSONForm()
        {
            InitializeComponent();
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
                    listBox_JSON_Logs.Items.Add($"Arquivo: { openFileDialog.FileName} lido com sucesso!");

                    textBox_File_Path.Text = openFileDialog.FileName;

                    var robots = JsonConvert.DeserializeObject<List<Robot>>(robotJson, new JsonSerializerSettings
                    {
                        TypeNameHandling = TypeNameHandling.Auto
                    });

                    listBox_JSON_Logs.Items.Add("Dados desserealizados com sucesso!");

                    listBox_JSON_Logs.Items.Add($"Identificado [{robots.Count}] chamada(s) de robozinhos");

                    var robotNames = new StringBuilder();
                    foreach (var robot in robots) robotNames.Append(robot.RobotName + ";");

                    listBox_JSON_Logs.Items.Add($"Chamadas identificados dos robôs: {robotNames}");

                    MainForm.robots = robots;

                    listBox_JSON_Logs.Items.Add($"Adicionado chamadas a lista principal! Aperte no botão \"Fechar\" para sair...");

                }
                catch (IOException ioe)
                {
                    listBox_JSON_Logs.Items.Add($"Erro ao tentar ler o arquivo {openFileDialog.FileName}:\n{ioe.Message}");
                }
                catch (JsonSerializationException jsonExp)
                {
                    listBox_JSON_Logs.Items.Add($"Erro ao tentar converter arquivo {openFileDialog.FileName} para a modelagem dos robôs:\n{jsonExp.Message}");
                }
                catch (NotImplementedException notImpExp)
                {
                    listBox_JSON_Logs.Items.Add(notImpExp.Message);
                }
                catch (Exception exp)
                {
                    listBox_JSON_Logs.Items.Add($"Erro: {exp.Message}");
                }

            }
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
