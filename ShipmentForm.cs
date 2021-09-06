using Regresser.Domain.RobotsActions;
using Regresser.Domain.Shipper;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace Regresser
{
    public partial class ShipmentForm : Form
    {
        #region Properties

        public static List<Refnum> shipmentRefnums;

        public static List<ReleaseRefnum> releaseRefnums;

        private int activeReleaseIndex;

        #endregion

        #region Constructor

        public ShipmentForm()
        {
            InitializeComponent();

            dataGridView_Shipment_Costs.Rows.Add("Base", "900,50", true, null);

            shipmentRefnums = new List<Refnum>
            {
                new Refnum("CLL_IMPOSTO_SOMADO", "N" ),
                new Refnum("CLL_IMPOSTO_INCLUSO", "N" ),
                new Refnum("CLL_CALCULAR_PEDAGIO", "N" ),
                new Refnum("CLL_PAGAMENTO_PEDAGIO", "N" ),
                new Refnum("CLL_VIAGEM_RETORNO", "N" )
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
                var refNumText = string.Join(" - ", refNum.RefnumKey, refNum.RefnumValue);
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
                var specificReleaseRefnums = GetReleaseRefnumByXid(listBox_Release_Xids.SelectedItem.ToString());

                foreach (var refNum in specificReleaseRefnums.ReleaseRefnums)
                {
                    var refNumText = string.Join(" - ", refNum.RefnumKey, refNum.RefnumValue);
                    listBox_Release_Refnums.Items.Add(refNumText);
                }
            }
        }

        private ReleaseRefnum GetReleaseRefnumByXid(string releaseXid) => releaseRefnums.Find(x => x.ReleaseXid == releaseXid);

        private string[] GetSelectedRefnum(ListBox listBox) => listBox.SelectedItem.ToString().Split(" - ");

        private List<ShipmentCost> GenerateShipmentCosts()
        {
            var shipmentCosts = new List<ShipmentCost>();

            for (int i = 0; i < dataGridView_Shipment_Costs.Rows.Count - 1; i++)
            {
                var row = dataGridView_Shipment_Costs.Rows[i];

                var shipmentCost = new ShipmentCost
                {
                    CostType = row.Cells[0].Value.ToString(),
                    Value = float.Parse(row.Cells[1].Value.ToString(), System.Globalization.NumberStyles.Float),
                    AllocateCost = bool.Parse(row.Cells[2].FormattedValue.ToString()),
                    AccessorialCostXid = (row.Cells[3].Value == null)
                            ? null
                            : row.Cells[3].Value.ToString(),
                };

                shipmentCosts.Add(shipmentCost);
            }

            return shipmentCosts;
        }

        private List<Release> GenerateReleases(string domainName)
        {
            if (!releaseRefnums.Any())
                return null;

            var releases = new List<Release>();

            foreach (var refnum in releaseRefnums)
            {
                var release = new Release
                {
                    ReleaseDomainName = domainName,
                    ReleaseXid = refnum.ReleaseXid,
                    ReleaseRefnums = refnum.ReleaseRefnums
                };

                releases.Add(release);
            }

            return releases;
        }

        private Shipment GenerateShipment(string domainName, List<Release> releases, List<ShipmentCost> shipmentCosts)
        {
            var sourceAddress = new Address
            {
                City = textBox_City.Text,
                State = comboBox_UF.SelectedItem.ToString(),
                IBGE = maskedTextBox_IBGE.Text
            };

            var shipmentNumber = textBox_Shipment_Number.Text;

            var shipmentTravelStatus = comboBox_Travel_Status.SelectedItem.ToString();

            var shipmentEmissionStatus = comboBox_Emission_Status.SelectedItem.ToString();

            var carrierXid = textBox_Carrier_Xid.Text;

            var originLocationXid = textBox_Source_Location_Xid.Text;

            var destinationLocationXid = textBox_Destination_Location_Xid.Text;

            var takerXid = textBox_Taker_Xid.Text;

            var driverXid = (string.IsNullOrEmpty(textBox_Driver_Xid.Text)) ? null : textBox_Driver_Xid.Text;

            if (!shipmentRefnums.Any())
                shipmentRefnums = null;
            return new Shipment
            {
                ShipmentDomainName = domainName,
                ShipmentXid = shipmentNumber,
                TravelStatus = shipmentTravelStatus,
                EmissionStatus = shipmentEmissionStatus,
                XidCarrier = carrierXid,
                XidSourceLocation = originLocationXid,
                XidDestinationLocation = destinationLocationXid,
                XidTakerLocation = takerXid,
                DriverXid = driverXid,
                AddedTax = Refnum.GetValueByKeyOnList(shipmentRefnums, "CLL_IMPOSTO_SOMADO"),
                TaxIncluded = Refnum.GetValueByKeyOnList(shipmentRefnums, "CLL_IMPOSTO_INCLUSO"),
                SourceAddress = sourceAddress,
                ShipmentCosts = shipmentCosts,
                ShipmentRefnums = shipmentRefnums,
                Releases = releases,
            };
        }

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
            RefNumForm refNumForm = new RefNumForm(shipmentRefnums);
            refNumForm.ShowDialog();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            var domainName = textBox_Shipment_DomainName.Text;

            var releases = GenerateReleases(domainName);

            var shipmentCosts = GenerateShipmentCosts();

            var shipment = GenerateShipment(domainName, releases, shipmentCosts);

            var jarvisActions = new List<Actions>
            {
                new JarvisActions
                {
                    UrlWs = textBox_Url_WS.Text,
                    Shipments = new List<Shipment> { shipment },
                }
            };

            var jarvis = new Robot("jarvis", jarvisActions);

            MainForm.robots.Add(jarvis);

            Close();
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
            Refnum.RemoveFromRefnumList(shipmentRefnums, refNumKey);
        }

        private void button_Edit_Shipment_Refnum_Click(object sender, EventArgs e)
        {
            try
            {
                Refnum refnum = new Refnum(GetSelectedRefnum(listBox_Shipment_Refnums)[0], GetSelectedRefnum(listBox_Shipment_Refnums)[1]);
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
            RefNumForm refNumForm = new RefNumForm(GetReleaseRefnumByXid(listBox_Release_Xids.SelectedItem.ToString()));
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

                var releaseRefnum = GetReleaseRefnumByXid(listBox_Release_Xids.SelectedItem.ToString());

                Refnum refnum = new Refnum(GetSelectedRefnum(listBox_Release_Refnums)[0], GetSelectedRefnum(listBox_Release_Refnums)[1]);

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
            var releaseRefnums = GetReleaseRefnumByXid(listBox_Release_Xids.SelectedItem.ToString());
            Refnum.RemoveFromRefnumList(releaseRefnums.ReleaseRefnums, refNumKey);
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
