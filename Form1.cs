using Newtonsoft.Json;
using Regresser.Properties;
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

        private void button_Add_Click(object sender, EventArgs e)
        {
            contextMenuStrip.Show(Cursor.Position.X,Cursor.Position.Y);
        }

        private void listBox_Actions_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBox_Actions.SelectedIndex != 0)
                button_Mover_Cima.Enabled = true;

            if (listBox_Actions.SelectedIndex == 0)
                button_Mover_Cima.Enabled = false;

            if (listBox_Actions.SelectedIndex != listBox_Actions.Items.Count)
                button_Mover_Baixo.Enabled = true;

            if (listBox_Actions.SelectedIndex == listBox_Actions.Items.Count - 1)
                button_Mover_Baixo.Enabled = false;
        }

        private void button_Mover_Cima_Click(object sender, EventArgs e)
        {
            var aux = listBox_Actions.SelectedItem;
            listBox_Actions.Items[listBox_Actions.SelectedIndex] = listBox_Actions.Items[listBox_Actions.SelectedIndex - 1];
            listBox_Actions.Items[listBox_Actions.SelectedIndex - 1] = aux;
            listBox_Actions.SelectedIndex -= 1; 
        }

        private void button_Mover_Baixo_Click(object sender, EventArgs e)
        {
            var aux = listBox_Actions.SelectedItem;
            listBox_Actions.Items[listBox_Actions.SelectedIndex] = listBox_Actions.Items[listBox_Actions.SelectedIndex + 1];
            listBox_Actions.Items[listBox_Actions.SelectedIndex + 1] = aux;
            listBox_Actions.SelectedIndex += 1;
        }
    }
}
