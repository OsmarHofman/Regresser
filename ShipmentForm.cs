using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Regresser
{
    public partial class ShipmentForm : Form
    {
        public Dictionary<string, string> shipmentRefnums;

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

        public void InsertRefNums()
        {
            listBox_Shipment_Refnums.Items.Clear();

            foreach (var refNum in shipmentRefnums)
            {
                var refNumText = string.Join("|", refNum.Key, refNum.Value);
                listBox_Shipment_Refnums.Items.Add(refNumText);
            }
        }
    }
}
