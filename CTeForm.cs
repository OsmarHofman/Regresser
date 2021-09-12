using Regresser.Domain.Enums;
using Regresser.Domain.RobotsActions;
using Regresser.Domain.Shipper;
using Regresser.Domain.Shipper.Documents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Regresser
{
    public partial class CTeForm : Form
    {
        private List<Cte> ctes = new List<Cte>();

        private List<ComplementaryCte> complCtes = new List<ComplementaryCte>();

        private bool isCreating;

        public CTeForm()
        {
            InitializeComponent();
        }
        private void ToggleFields()
        {
            textBox_EnterpriseId.Enabled = !textBox_EnterpriseId.Enabled;
            textBox_Token.Enabled = !textBox_Token.Enabled;
            textBox_Emitter.Enabled = !textBox_Emitter.Enabled;
            textBox_Sender.Enabled = !textBox_Sender.Enabled;
            textBox_Recipient.Enabled = !textBox_Recipient.Enabled;
            checkBox_Taker.Enabled = !checkBox_Taker.Enabled;
            textBox_CTe_Number.Enabled = !textBox_CTe_Number.Enabled;
            textBox_Nfe_Numbers.Enabled = !textBox_Nfe_Numbers.Enabled;
            textBox_CTe_Value.Enabled = !textBox_CTe_Value.Enabled;
            comboBox_CST_Type.Enabled = !comboBox_CST_Type.Enabled;
            textBox_vBC.Enabled = !textBox_vBC.Enabled;
            textBox_pICMS.Enabled = !textBox_pICMS.Enabled;
            textBox_vICMS.Enabled = !textBox_vICMS.Enabled;
            listBox.Enabled = !listBox.Enabled;
            button_Save.Enabled = !button_Save.Enabled;

            button_Add_Item.Visible = !button_Add_Item.Visible;
            button_Edit_Item.Visible = !button_Edit_Item.Visible;
            button_Remove_Item.Visible = !button_Remove_Item.Visible;
            button_Save_Item.Visible = !button_Save_Item.Visible;
        }

        private void ClearFields()
        {
            textBox_EnterpriseId.Clear();
            textBox_Token.Clear();
            textBox_Emitter.Clear();
            textBox_Sender.Clear();
            textBox_Recipient.Clear();
            textBox_CTe_Number.Clear();
            textBox_Nfe_Numbers.Clear();
            textBox_CTe_Value.Clear();
            textBox_vBC.Clear();
            textBox_pICMS.Clear();
            textBox_vICMS.Clear();
            comboBox_CST_Type.SelectedIndex = 0;
            checkBox_Taker.Checked = true;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (!ctes.Any() && !complCtes.Any()) MessageBox.Show("Não há CT-es Normais nem Complementares a serem salvos!");
            else
            {
                var actions = new BinoActions { UrlWs = textBox_Url_WS.Text };

                if (ctes.Any())
                    actions.Ctes = ctes;

                if (complCtes.Any())
                    actions.ComplementaryCtes = complCtes;

                List<Actions> binoActions = new List<Actions> { actions };

                var bino = new Robot("bino", binoActions);

                MainForm.robots.Add(bino);

                Close();
            }
        }

        private void button_Add_Item_Click(object sender, EventArgs e)
        {
            isCreating = true;
            ToggleFields();
        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Save_Item_Click(object sender, EventArgs e)
        {
            var nfeNumbers = new List<string>();
            nfeNumbers.AddRange(textBox_Nfe_Numbers.Text.Split(";"));

            Icms icms;

            try
            {
                icms = new Icms(comboBox_CST_Type.Text, textBox_vBC.Text, textBox_pICMS.Text, textBox_vICMS.Text);
            }
            catch (NotImplementedException exp)
            {
                MessageBox.Show($"Erro ao tentar gerar o ICMS:\n{exp.Message}");
                return;
            }

            var cte = new Cte
            {
                EnterpriseId = textBox_EnterpriseId.Text,
                Token = textBox_Token.Text,
                Emitter = textBox_Emitter.Text,
                Sender = textBox_Sender.Text,
                Recipient = textBox_Recipient.Text,
                RecipientIsTaker = checkBox_Taker.Checked,
                NfeNumbers = nfeNumbers,
                Value = decimal.Parse(textBox_CTe_Value.Text),
                Number = textBox_CTe_Number.Text,
                Icms = icms
            };

            if (isCreating)
            {
                ctes.Add(cte);
                listBox.Items.Add($"CT-e de Número: {cte.Number}");
            }
            else
            {
                ctes[listBox.SelectedIndex] = cte;
                listBox.Items[listBox.SelectedIndex] = $"CT-e de Número: {cte.Number}";
            }


            ClearFields();

            ToggleFields();
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
                ctes.RemoveAt(listBox.SelectedIndex);

                listBox.Items.RemoveAt(listBox.SelectedIndex);
            }
        }

        private void button_Edit_Item_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex != -1)
            {
                var cte = ctes[listBox.SelectedIndex];
                textBox_EnterpriseId.Text = cte.EnterpriseId;
                textBox_Token.Text = cte.Token;
                textBox_CTe_Number.Text = cte.Number;
                textBox_CTe_Value.Text = cte.Value.ToString();
                textBox_Emitter.Text = cte.Emitter;
                textBox_Sender.Text = cte.Sender;
                textBox_Recipient.Text = cte.Recipient;
                checkBox_Taker.Checked = cte.RecipientIsTaker;

                var nfeNumbers = String.Join(";", cte.NfeNumbers);
                textBox_Nfe_Numbers.Text = nfeNumbers;

                var icms = cte.Icms;
                comboBox_CST_Type.Text = icms.IcmsType;
                textBox_vBC.Text = icms.vBC.ToString();
                textBox_pICMS.Text = icms.pICMS.ToString();
                textBox_vICMS.Text = icms.vICMS.ToString();

                isCreating = false;

                ToggleFields();
            }
        }
    }
}
