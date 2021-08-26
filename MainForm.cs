﻿using Regresser.Domain.RobotsActions;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Regresser
{
    public partial class MainForm : Form
    {
        public static List<Robot> robots = new List<Robot>();

        public static List<string> robotLabels = new List<string>();

        public MainForm()
        {
            InitializeComponent();
        }


        private void SetUrlsOnRobots()
        {
            var url = $"http://191.239.245.232:{textBox_TMS_Port.Text}/exchangeMessage/WSExchangeMessage.asmx";

            foreach (var robot in robots)
            {
                if (robot.actions[0] is JarvisActions)
                {
                    foreach (var action in robot.actions)
                    {
                        var actionWithUrl = (JarvisActions)action;

                        actionWithUrl.URL_WS_OTM = url;
                    }
                }
            }
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
           SetUrlsOnRobots();

           var response = Robot.SendActions(robots);

           MessageBox.Show($"Resposta dos Robozinhos:\n {response}");
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            contextMenuStrip.Show(Cursor.Position.X,Cursor.Position.Y);
        }

        private void listBox_Actions_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBox_Actions.SelectedIndex != 0)
                button_Move_Up.Enabled = true;

            if (listBox_Actions.SelectedIndex == 0)
                button_Move_Up.Enabled = false;

            if (listBox_Actions.SelectedIndex != listBox_Actions.Items.Count)
                button_Move_Down.Enabled = true;

            if (listBox_Actions.SelectedIndex == listBox_Actions.Items.Count - 1)
                button_Move_Down.Enabled = false;
        }

        private void button_Move_Up_Click(object sender, EventArgs e)
        {
            var aux = listBox_Actions.SelectedItem;
            listBox_Actions.Items[listBox_Actions.SelectedIndex] = listBox_Actions.Items[listBox_Actions.SelectedIndex - 1];
            listBox_Actions.Items[listBox_Actions.SelectedIndex - 1] = aux;
            listBox_Actions.SelectedIndex -= 1; 
        }

        private void button_Move_Down_Click(object sender, EventArgs e)
        {
            var aux = listBox_Actions.SelectedItem;
            listBox_Actions.Items[listBox_Actions.SelectedIndex] = listBox_Actions.Items[listBox_Actions.SelectedIndex + 1];
            listBox_Actions.Items[listBox_Actions.SelectedIndex + 1] = aux;
            listBox_Actions.SelectedIndex += 1;
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
            listBox_Actions.Items.Clear();
            listBox_Actions.Items.AddRange(robotLabels.ToArray());
        }
    }
}
