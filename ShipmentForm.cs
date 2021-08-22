using Regresser.Domain.Shipper;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Regresser
{
    public partial class ShipmentForm : Form
    {
        #region Properties

        public static Dictionary<string, string> shipmentRefnums;

        public static List<ReleaseRefnum> releaseRefnums;

        private int activeReleaseIndex;

        #endregion

        #region Constructor

        public ShipmentForm()
        {
            InitializeComponent();

            dataGridView_Shipment_Costs.Rows.Add("Base", "900", true, null);

            shipmentRefnums = new Dictionary<string, string>
            {
                {"CLL_CALCULAR_PEDAGIO", "N" },
                {"CLL_PAGAMENTO_PEDAGIO", "N" },
                {"CLL_VIAGEM_RETORNO", "N" },
            };

            InsertShipmentRefNums();

            releaseRefnums = new List<ReleaseRefnum>();
            var defaultReleaseRefnum = new ReleaseRefnum("1");
            releaseRefnums.Add(defaultReleaseRefnum);
        }

        #endregion

        #region Methods
        private void InsertShipmentRefNums()
        {
            listBox_Shipment_Refnums.Items.Clear();

            foreach (var refNum in shipmentRefnums)
            {
                var refNumText = string.Join(" - ", refNum.Key, refNum.Value);
                listBox_Shipment_Refnums.Items.Add(refNumText);
            }
        }

        private void InsertReleases()
        {
            InsertReleaseXids();
            InsertReleaseRefNums();
            listBox_Release_Xids.SelectedIndex = activeReleaseIndex;
        }

        private void InsertReleaseXids()
        {
            listBox_Release_Xids.Items.Clear();

            foreach (var refNum in releaseRefnums) listBox_Release_Xids.Items.Add(refNum.ReleaseXid);
        }

        private void InsertReleaseRefNums()
        {
            listBox_Release_Refnums.Items.Clear();

            if (listBox_Release_Xids.SelectedItem != null)
            {
                var specificReleaseRefnums = GetReleaseRefnumsByXid(listBox_Release_Xids.SelectedItem.ToString());

                foreach (var refNum in specificReleaseRefnums)
                {
                    var refNumText = string.Join(" - ", refNum.Key, refNum.Value);
                    listBox_Release_Refnums.Items.Add(refNumText);
                }
            }
        }

        private Dictionary<string, string> GetReleaseRefnumsByXid(string releaseXid) => releaseRefnums.Find(x => x.ReleaseXid == releaseXid).ReleaseRefnums;

        private string[] GetSelectedRefnum(ListBox listBox) => listBox.SelectedItem.ToString().Split(" - ");

        #endregion

        #region FormMethods
        private void button_Cancelar_Click(object sender, EventArgs e) => Close();

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
            if (tabControl_Shipment_Costs.SelectedTab == tabPage_Shipment_Refnum)
                InsertShipmentRefNums();

            if (tabControl_Shipment_Costs.SelectedTab == tabPage_Release)
                InsertReleases();
        }

        private void button_Remove_Shipment_Refnum_Click(object sender, EventArgs e)
        {
            var refNumKey = GetSelectedRefnum(listBox_Shipment_Refnums)[0];
            listBox_Shipment_Refnums.Items.RemoveAt(listBox_Shipment_Refnums.SelectedIndex);
            shipmentRefnums.Remove(refNumKey);
        }

        private void button_Edit_Shipment_Refnum_Click(object sender, EventArgs e)
        {
            try
            {
                KeyValuePair<string, string> refnum = new KeyValuePair<string, string>(GetSelectedRefnum(listBox_Shipment_Refnums)[0], GetSelectedRefnum(listBox_Shipment_Refnums)[1]);
                RefNumForm refNumForm = new RefNumForm(shipmentRefnums, refnum);
                refNumForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void listBox_Release_Xids_SelectedIndexChanged(object sender, EventArgs e)
        {
            InsertReleaseRefNums();
            button_Add_Release_Refnum.Enabled = true;
        }

        private void button_Add_Release_Refnum_Click(object sender, EventArgs e)
        {
            activeReleaseIndex = listBox_Release_Xids.SelectedIndex;
            RefNumForm refNumForm = new RefNumForm(GetReleaseRefnumsByXid(listBox_Release_Xids.SelectedItem.ToString()), new KeyValuePair<string, string>());
            refNumForm.ShowDialog();
        }

        private void listBox_Release_Refnums_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_Edit_Release_Refnum.Enabled = true;
            button_Remove_Release_Refnum.Enabled = true;
        }

        private void button_Edit_Release_Refnum_Click(object sender, EventArgs e)
        {
            try
            {
                activeReleaseIndex = listBox_Release_Xids.SelectedIndex;

                var releaseRefnum = GetReleaseRefnumsByXid(listBox_Release_Xids.SelectedItem.ToString());

                KeyValuePair<string, string> refnum = new KeyValuePair<string, string>(GetSelectedRefnum(listBox_Release_Refnums)[0], GetSelectedRefnum(listBox_Release_Refnums)[1]);

                RefNumForm refNumForm = new RefNumForm(releaseRefnum, refnum);
                refNumForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_Remove_Release_Refnum_Click(object sender, EventArgs e)
        {
            var refNumKey = GetSelectedRefnum(listBox_Release_Refnums)[0];
            listBox_Release_Refnums.Items.RemoveAt(listBox_Release_Refnums.SelectedIndex);
            var releaseRefnums = GetReleaseRefnumsByXid(listBox_Release_Xids.SelectedItem.ToString());
            releaseRefnums.Remove(refNumKey);
        }

        private void button_Add_Release_Xid_Click(object sender, EventArgs e)
        {
            activeReleaseIndex = listBox_Release_Xids.Items.Count;

            ReleaseXidForm releaseXidForm = new ReleaseXidForm();
            releaseXidForm.ShowDialog();
        }

        private void button_Edit_Release_Xid_Click(object sender, EventArgs e)
        {
            activeReleaseIndex = listBox_Release_Xids.SelectedIndex;

            var release = releaseRefnums.Find(x => x.ReleaseXid == listBox_Release_Xids.SelectedItem.ToString());

            ReleaseXidForm releaseXidForm = new ReleaseXidForm(release);
            releaseXidForm.ShowDialog();
        }

        #endregion

        private void button_Remove_Release_Xid_Click(object sender, EventArgs e)
        {
            var releaseRefnumToDelete = releaseRefnums.Find(x => x.ReleaseXid == listBox_Release_Xids.SelectedItem.ToString());

            listBox_Release_Xids.Items.RemoveAt(listBox_Release_Xids.SelectedIndex);
            releaseRefnums.Remove(releaseRefnumToDelete);
        }
    }
}
