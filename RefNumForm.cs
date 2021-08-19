using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Regresser
{
    public partial class RefNumForm : Form
    {
        private Dictionary<string, string> refNums;

        public RefNumForm()
        {
            InitializeComponent();
        }

        public RefNumForm(Dictionary<string, string> refNums, KeyValuePair<string, string> editRefNum)
        {
            InitializeComponent();

            if (!string.IsNullOrEmpty(editRefNum.Key))
            {
                textBox_Refnum_Key.Text = editRefNum.Key;
                textBox_Refnum_Value.Text = editRefNum.Value;
                refNums.Remove(editRefNum.Key);
            }

            this.refNums = refNums;

        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textBox_Refnum_Key.Text) || !string.IsNullOrEmpty(textBox_Refnum_Value.Text))
            {
                try
                {
                    this.refNums.Add(textBox_Refnum_Key.Text, textBox_Refnum_Value.Text);
                    ShipmentForm.shipmentRefnums = this.refNums;
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
