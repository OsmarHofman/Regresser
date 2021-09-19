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

        private bool isCreatingCTeNormal;

        private bool isCreatingCTeCompl;

        public CTeForm()
        {
            InitializeComponent();
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

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region CTe Normal
        private void ToggleFields()
        {
            textBox_Normal_EnterpriseId.Enabled = !textBox_Normal_EnterpriseId.Enabled;
            textBox_Normal_Token.Enabled = !textBox_Normal_Token.Enabled;
            textBox_Normal_Emitter.Enabled = !textBox_Normal_Emitter.Enabled;
            textBox_Normal_Sender.Enabled = !textBox_Normal_Sender.Enabled;
            textBox_Normal_Recipient.Enabled = !textBox_Normal_Recipient.Enabled;
            checkBox_Normal_Taker.Enabled = !checkBox_Normal_Taker.Enabled;
            textBox_CTe_Normal_Number.Enabled = !textBox_CTe_Normal_Number.Enabled;
            textBox_Normal_Nfe_Numbers.Enabled = !textBox_Normal_Nfe_Numbers.Enabled;
            textBox_CTe_Normal_Value.Enabled = !textBox_CTe_Normal_Value.Enabled;
            comboBox_Normal_CST_Type.Enabled = !comboBox_Normal_CST_Type.Enabled;
            textBox_Normal_vBC.Enabled = !textBox_Normal_vBC.Enabled;
            textBox_Normal_pICMS.Enabled = !textBox_Normal_pICMS.Enabled;
            textBox_Normal_vICMS.Enabled = !textBox_Normal_vICMS.Enabled;
            listBox_CTe_Normal.Enabled = !listBox_CTe_Normal.Enabled;
            button_Save.Enabled = !button_Save.Enabled;

            button_Normal_Add_Item.Visible = !button_Normal_Add_Item.Visible;
            button_Normal_Edit_Item.Visible = !button_Normal_Edit_Item.Visible;
            button_Normal_Remove_Item.Visible = !button_Normal_Remove_Item.Visible;
            button_Normal_Save_Item.Visible = !button_Normal_Save_Item.Visible;
        }

        private void ClearFields()
        {
            textBox_Normal_EnterpriseId.Clear();
            textBox_Normal_Token.Clear();
            textBox_Normal_Emitter.Clear();
            textBox_Normal_Sender.Clear();
            textBox_Normal_Recipient.Clear();
            textBox_CTe_Normal_Number.Clear();
            textBox_Normal_Nfe_Numbers.Clear();
            textBox_CTe_Normal_Value.Clear();
            textBox_Normal_vBC.Clear();
            textBox_Normal_pICMS.Clear();
            textBox_Normal_vICMS.Clear();
            comboBox_Normal_CST_Type.SelectedIndex = 0;
            checkBox_Normal_Taker.Checked = true;
        }

        private void button_Add_Item_Click(object sender, EventArgs e)
        {
            isCreatingCTeNormal = true;
            ToggleFields();
        }

        private void button_Save_Item_Click(object sender, EventArgs e)
        {
            var nfeNumbers = new List<string>();
            nfeNumbers.AddRange(textBox_Normal_Nfe_Numbers.Text.Split(";"));

            Icms icms;

            try
            {
                icms = new Icms(comboBox_Normal_CST_Type.Text, textBox_Normal_vBC.Text, textBox_Normal_pICMS.Text, textBox_Normal_vICMS.Text);
            }
            catch (NotImplementedException exp)
            {
                MessageBox.Show($"Erro ao tentar gerar o ICMS:\n{exp.Message}");
                return;
            }

            var cte = new Cte
            {
                EnterpriseId = textBox_Normal_EnterpriseId.Text,
                Token = textBox_Normal_Token.Text,
                Emitter = textBox_Normal_Emitter.Text,
                Sender = textBox_Normal_Sender.Text,
                Recipient = textBox_Normal_Recipient.Text,
                RecipientIsTaker = checkBox_Normal_Taker.Checked,
                NfeNumbers = nfeNumbers,
                Value = decimal.Parse(textBox_CTe_Normal_Value.Text),
                Number = textBox_CTe_Normal_Number.Text,
                Icms = icms
            };

            if (isCreatingCTeNormal)
            {
                ctes.Add(cte);
                listBox_CTe_Normal.Items.Add($"CT-e de Número: {cte.Number}");
            }
            else
            {
                ctes[listBox_CTe_Normal.SelectedIndex] = cte;
                listBox_CTe_Normal.Items[listBox_CTe_Normal.SelectedIndex] = $"CT-e de Número: {cte.Number}";
            }

            ClearFields();

            ToggleFields();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_CTe_Normal.SelectedIndex != -1)
            {
                button_Normal_Edit_Item.Enabled = true;
                button_Normal_Remove_Item.Enabled = true;
            }
            else
            {
                button_Normal_Edit_Item.Enabled = false;
                button_Normal_Remove_Item.Enabled = false;
            }
        }

        private void button_Remove_Item_Click(object sender, EventArgs e)
        {
            if (listBox_CTe_Normal.SelectedIndex != -1)
            {
                ctes.RemoveAt(listBox_CTe_Normal.SelectedIndex);

                listBox_CTe_Normal.Items.RemoveAt(listBox_CTe_Normal.SelectedIndex);
            }
        }

        private void button_Edit_Item_Click(object sender, EventArgs e)
        {
            if (listBox_CTe_Normal.SelectedIndex != -1)
            {
                var cte = ctes[listBox_CTe_Normal.SelectedIndex];
                textBox_Normal_EnterpriseId.Text = cte.EnterpriseId;
                textBox_Normal_Token.Text = cte.Token;
                textBox_CTe_Normal_Number.Text = cte.Number;
                textBox_CTe_Normal_Value.Text = cte.Value.ToString();
                textBox_Normal_Emitter.Text = cte.Emitter;
                textBox_Normal_Sender.Text = cte.Sender;
                textBox_Normal_Recipient.Text = cte.Recipient;
                checkBox_Normal_Taker.Checked = cte.RecipientIsTaker;

                var nfeNumbers = String.Join(";", cte.NfeNumbers);
                textBox_Normal_Nfe_Numbers.Text = nfeNumbers;

                var icms = cte.Icms;
                comboBox_Normal_CST_Type.Text = icms.Type;
                textBox_Normal_vBC.Text = icms.vBC.ToString();
                textBox_Normal_pICMS.Text = icms.pICMS.ToString();
                textBox_Normal_vICMS.Text = icms.vICMS.ToString();

                isCreatingCTeNormal = false;

                ToggleFields();
            }
        }

        #endregion

        #region CTe Complementary
        private void ToggleComplFields()
        {
            textBox_Compl_EnterpriseId.Enabled = !textBox_Compl_EnterpriseId.Enabled;
            textBox_Compl_Token.Enabled = !textBox_Compl_Token.Enabled;
            textBox_Compl_Emitter.Enabled = !textBox_Compl_Emitter.Enabled;
            textBox_Compl_Sender.Enabled = !textBox_Compl_Sender.Enabled;
            textBox_Compl_Recipient.Enabled = !textBox_Compl_Recipient.Enabled;
            checkBox_Compl_Taker.Enabled = !checkBox_Compl_Taker.Enabled;
            textBox_CTe_Compl_Number.Enabled = !textBox_CTe_Compl_Number.Enabled;
            textBox_Compl_Nfe_Numbers.Enabled = !textBox_Compl_Nfe_Numbers.Enabled;
            textBox_CTe_Compl_Value.Enabled = !textBox_CTe_Compl_Value.Enabled;
            comboBox_Compl_CST_Type.Enabled = !comboBox_Compl_CST_Type.Enabled;
            textBox_Compl_vBC.Enabled = !textBox_Compl_vBC.Enabled;
            textBox_Compl_pICMS.Enabled = !textBox_Compl_pICMS.Enabled;
            textBox_Compl_vICMS.Enabled = !textBox_Compl_vICMS.Enabled;
            listBox_CTe_Compl.Enabled = !listBox_CTe_Compl.Enabled;
            button_Save.Enabled = !button_Save.Enabled;

            button_Compl_Add_Item.Visible = !button_Compl_Add_Item.Visible;
            button_Compl_Edit_Item.Visible = !button_Compl_Edit_Item.Visible;
            button_Compl_Remove_Item.Visible = !button_Compl_Remove_Item.Visible;
            button_Compl_Save_Item.Visible = !button_Compl_Save_Item.Visible;
        }

        private void ClearComplFields()
        {
            textBox_Compl_EnterpriseId.Clear();
            textBox_Compl_Token.Clear();
            textBox_Compl_Emitter.Clear();
            textBox_Compl_Sender.Clear();
            textBox_Compl_Recipient.Clear();
            textBox_CTe_Compl_Number.Clear();
            textBox_Compl_Nfe_Numbers.Clear();
            textBox_CTe_Compl_Value.Clear();
            textBox_Compl_vBC.Clear();
            textBox_Compl_pICMS.Clear();
            textBox_Compl_vICMS.Clear();
            comboBox_Compl_CST_Type.SelectedIndex = 0;
            checkBox_Compl_Taker.Checked = true;
        }

        private void button_Compl_Add_Item_Click(object sender, EventArgs e)
        {
            isCreatingCTeCompl = true;
            ToggleComplFields();
        }

        #endregion

        private void button_Compl_Save_Item_Click(object sender, EventArgs e)
        {
            var nfeNumbers = new List<string>();
            nfeNumbers.AddRange(textBox_Compl_Nfe_Numbers.Text.Split(";"));

            Icms icms;

            try
            {
                icms = new Icms(comboBox_Compl_CST_Type.Text, textBox_Compl_vBC.Text, textBox_Compl_pICMS.Text, textBox_Compl_vICMS.Text);
            }
            catch (NotImplementedException exp)
            {
                MessageBox.Show($"Erro ao tentar gerar o ICMS:\n{exp.Message}");
                return;
            }

            var cteComplementary = new ComplementaryCte
            {
                EnterpriseId = textBox_Compl_EnterpriseId.Text,
                Token = textBox_Compl_Token.Text,
                Emitter = textBox_Compl_Emitter.Text,
                Sender = textBox_Compl_Sender.Text,
                Recipient = textBox_Compl_Recipient.Text,
                RecipientIsTaker = checkBox_Compl_Taker.Checked,
                NfeNumbers = nfeNumbers,
                Value = decimal.Parse(textBox_CTe_Compl_Value.Text),
                Number = textBox_CTe_Compl_Number.Text,
                Icms = icms,
                CteNorm = textBox_Compl_Link_Normal.Text
            };

            if (isCreatingCTeCompl)
            {
                complCtes.Add(cteComplementary);
                listBox_CTe_Compl.Items.Add($"CT-e Complementar de Número: {cteComplementary.Number}");
            }
            else
            {
                complCtes[listBox_CTe_Compl.SelectedIndex] = cteComplementary;
                listBox_CTe_Compl.Items[listBox_CTe_Compl.SelectedIndex] = $"CT-e Complementar de Número: {cteComplementary.Number}";
            }

            ClearComplFields();

            ToggleComplFields();
        }

        private void listBox_CTe_Compl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_CTe_Compl.SelectedIndex != -1)
            {
                button_Compl_Edit_Item.Enabled = true;
                button_Compl_Remove_Item.Enabled = true;
            }
            else
            {
                button_Compl_Edit_Item.Enabled = false;
                button_Compl_Remove_Item.Enabled = false;
            }
        }

        private void button_Compl_Remove_Item_Click(object sender, EventArgs e)
        {
            if (listBox_CTe_Compl.SelectedIndex != -1)
            {
                ctes.RemoveAt(listBox_CTe_Compl.SelectedIndex);

                listBox_CTe_Compl.Items.RemoveAt(listBox_CTe_Compl.SelectedIndex);
            }
        }

        private void button_Compl_Edit_Item_Click(object sender, EventArgs e)
        {
            if (listBox_CTe_Compl.SelectedIndex != -1)
            {
                var cteComplementary = complCtes[listBox_CTe_Compl.SelectedIndex];
                textBox_Compl_EnterpriseId.Text = cteComplementary.EnterpriseId;
                textBox_Compl_Token.Text = cteComplementary.Token;
                textBox_CTe_Compl_Number.Text = cteComplementary.Number;
                textBox_CTe_Compl_Value.Text = cteComplementary.Value.ToString();
                textBox_Compl_Link_Normal.Text = cteComplementary.CteNorm;
                textBox_Compl_Emitter.Text = cteComplementary.Emitter;
                textBox_Compl_Sender.Text = cteComplementary.Sender;
                textBox_Compl_Recipient.Text = cteComplementary.Recipient;
                checkBox_Compl_Taker.Checked = cteComplementary.RecipientIsTaker;

                var nfeNumbers = String.Join(";", cteComplementary.NfeNumbers);
                textBox_Compl_Nfe_Numbers.Text = nfeNumbers;

                var icms = cteComplementary.Icms;
                comboBox_Compl_CST_Type.Text = icms.Type;
                textBox_Compl_vBC.Text = icms.vBC.ToString();
                textBox_Compl_pICMS.Text = icms.pICMS.ToString();
                textBox_Compl_vICMS.Text = icms.vICMS.ToString();

                isCreatingCTeCompl = false;

                ToggleComplFields();
            }
        }
    }
}
