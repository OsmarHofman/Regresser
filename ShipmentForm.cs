using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Regresser
{
    public partial class ShipmentForm : Form
    {
        public static Dictionary<string, string> shipmentRefnums;

        public ShipmentForm()
        {
            InitializeComponent();
            shipmentRefnums = new Dictionary<string, string>
            {
                {"CLL_CALCULAR_PEDAGIO", "N" },
                {"CLL_PAGAMENTO_PEDAGIO", "N" },
                {"CLL_VIAGEM_RETORNO", "N" },
            };

            InsertRefNums();
        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tabPage_Shipment_Cost_Click(object sender, EventArgs e)
        {

        }

        private void InsertRefNums()
        {
            listBox_Shipment_Refnums.Items.Clear();

            foreach (var refNum in shipmentRefnums)
            {
                var refNumText = string.Join(" - ", refNum.Key, refNum.Value);
                listBox_Shipment_Refnums.Items.Add(refNumText);
            }
        }

        private void listBox_Shipment_Refnums_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_Edit_Shipment_Refnum.Enabled = true;
            button_Remove_Shipment_Refnum.Enabled = true;
        }

        private void button_Add_Shipment_Refnum_Click(object sender, EventArgs e)
        {

            RefNumForm refNumForm = new RefNumForm(shipmentRefnums, new KeyValuePair<string, string>());
            refNumForm.ShowDialog();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {

        }

        private void ShipmentForm_Activated(object sender, EventArgs e)
        {
            InsertRefNums();
        }

        private void button_Remove_Shipment_Refnum_Click(object sender, EventArgs e)
        {
            var refNumKey = getSelectedRefnum()[0];
            listBox_Shipment_Refnums.Items.RemoveAt(listBox_Shipment_Refnums.SelectedIndex);
            shipmentRefnums.Remove(refNumKey);
        }

        private void button_Edit_Shipment_Refnum_Click(object sender, EventArgs e)
        {
            try
            {
                KeyValuePair<string, string> refnum = new KeyValuePair<string, string>(getSelectedRefnum()[0], getSelectedRefnum()[1]);
                RefNumForm refNumForm = new RefNumForm(shipmentRefnums, refnum);
                refNumForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private string[] getSelectedRefnum()
        {
            return listBox_Shipment_Refnums.SelectedItem.ToString().Split(" - ");
        }
    }
}
