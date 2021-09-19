using Regresser.Domain.RobotsActions;
using Regresser.Domain.Shipper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Regresser
{
    public partial class NFeForm : Form
    {
        private List<Nfe> nfes = new List<Nfe>();

        private bool isCreating;

        private int editingRobotIndex = -1;

        public NFeForm()
        {
            InitializeComponent();
        }

        public NFeForm(Robot robot)
        {
            InitializeComponent();

            SetRobotValues(robot);
        }

        private void SetRobotValues(Robot robot)
        {
            var gigibaActions = robot.actions.First() as GigibaActions;

            textBox_Url_WS.Text = gigibaActions.UrlWs;

            nfes = gigibaActions.Nfes;
            foreach (var nfe in nfes)
                listBox.Items.Add($"Nota de Número: {nfe.Number}");

            editingRobotIndex = MainForm.robots.IndexOf(robot);
        }

        private void ClearFields()
        {
            textBox_EnterpriseId.Clear();
            textBox_Token.Clear();
            textBox_Issuer.Clear();
            textBox_Recipient.Clear();
            textBox_Release.Clear();
            textBox_Nfe_Number.Clear();
        }

        private void ToggleFields()
        {
            textBox_EnterpriseId.Enabled = !textBox_EnterpriseId.Enabled;
            textBox_Token.Enabled = !textBox_Token.Enabled;
            textBox_Issuer.Enabled = !textBox_Issuer.Enabled;
            textBox_Recipient.Enabled = !textBox_Recipient.Enabled;
            textBox_Release.Enabled = !textBox_Release.Enabled;
            textBox_Nfe_Number.Enabled = !textBox_Nfe_Number.Enabled;
            listBox.Enabled = !listBox.Enabled;
            button_Save.Enabled = !button_Save.Enabled;

            button_Add_Item.Visible = !button_Add_Item.Visible;
            button_Edit_Item.Visible = !button_Edit_Item.Visible;
            button_Remove_Item.Visible = !button_Remove_Item.Visible;
            button_Save_Item.Visible = !button_Save_Item.Visible;
        }

        private void button_Add_Item_Click(object sender, EventArgs e)
        {
            isCreating = true;
            ToggleFields();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (!nfes.Any()) MessageBox.Show("Não há NF-es a serem salvas!");
            else
            {
                List<Actions> gigibaActions = new List<Actions> { new GigibaActions { UrlWs = textBox_Url_WS.Text, Nfes = nfes } };

                var gigiba = new Robot("gigiba", gigibaActions);

                if (editingRobotIndex == -1)
                    MainForm.robots.Add(gigiba);
                else
                    MainForm.robots[editingRobotIndex] = gigiba;

                Close();
            }

        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex != -1)
            {
                button_Edit_Item.Enabled = true;
                button_Remove_Item.Enabled = true;
            }
            else
            {
                button_Edit_Item.Enabled = false;
                button_Remove_Item.Enabled = false;
            }
        }

        private void button_Remove_Item_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex != -1)
            {
                nfes.RemoveAt(listBox.SelectedIndex);

                listBox.Items.RemoveAt(listBox.SelectedIndex);
            }
        }

        private void button_Save_Item_Click(object sender, EventArgs e)
        {
            var nfe = new Nfe
            {
                EnterpriseId = textBox_EnterpriseId.Text,
                Token = textBox_Token.Text,
                Issuer = textBox_Issuer.Text,
                Recipient = textBox_Recipient.Text,
                DomainNameXidRelease = textBox_Release.Text,
                Number = textBox_Nfe_Number.Text
            };

            if (isCreating)
            {
                nfes.Add(nfe);
                listBox.Items.Add($"Nota de Número: {nfe.Number}");
            }
            else
            {
                nfes[listBox.SelectedIndex] = nfe;
                listBox.Items[listBox.SelectedIndex] = $"Nota de Número: {nfe.Number}";
            }


            ClearFields();

            ToggleFields();
        }

        private void button_Edit_Item_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex != -1)
            {
                var nfe = nfes[listBox.SelectedIndex];
                textBox_EnterpriseId.Text = nfe.EnterpriseId;
                textBox_Token.Text = nfe.Token;
                textBox_Issuer.Text = nfe.Issuer;
                textBox_Recipient.Text = nfe.Recipient;
                textBox_Release.Text = nfe.DomainNameXidRelease;
                textBox_Nfe_Number.Text = nfe.Number;

                isCreating = false;

                ToggleFields();
            }
        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
