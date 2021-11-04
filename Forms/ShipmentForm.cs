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

        public static List<Release> releases;

        private int activeReleaseIndex;

        private int editingRobotIndex = -1;

        #endregion

        #region Constructor

        public ShipmentForm()
        {
            InitializeComponent();

            dataGridView_Shipment_Costs.Rows.Add("Base", "900,50", true, null);

            shipmentRefnums = new List<Refnum> { new Refnum("CLL_VIAGEM_RETORNO", "N") };

            InsertShipmentRefNums();

            releases = new List<Release> { new Release("1") };
        }

        public ShipmentForm(Robot robot)
        {
            InitializeComponent();

            SetRobotValues(robot);
        }

        #endregion

        #region Methods

        private void SetRobotValues(Robot robot)
        {
            var jarvisActions = robot.actions.First() as JarvisActions;

            var shipment = jarvisActions.Shipments.Single();

            textBox_Shipment_DomainName.Text = shipment.ShipmentDomainName;

            textBox_Shipment_Number.Text = shipment.ShipmentXid;

            comboBox_Travel_Status.Text = shipment.TravelStatus;

            comboBox_Emission_Status.SelectedItem = shipment.EmissionStatus;

            textBox_Occurrence_Xids.Text = string.Join(";", shipment.ShipmentStatus);

            textBox_Carrier_Xid.Text = shipment.XidCarrier;

            textBox_Source_Location_Xid.Text = shipment.XidSourceLocation;

            textBox_Source_CNPJ.Text = shipment.SourceLocationCNPJ;

            textBox_Destination_Location_Xid.Text = shipment.XidDestinationLocation;

            textBox_Destination_CNPJ.Text = shipment.DestinationLocationCNPJ;

            textBox_Taker_Xid.Text = shipment.XidTakerLocation;

            textBox_Driver_Xid.Text = shipment.DriverXid;

            textBox_Driver_Xid.Text = shipment.DriverXid;

            textBox_City.Text = shipment.SourceAddress.City;

            comboBox_UF.SelectedItem = shipment.SourceAddress.State;

            maskedTextBox_IBGE.Text = shipment.SourceAddress.IBGE;

            checkBox_Added_Tax.Checked = shipment.AddedTax == "S";

            checkBox_Tax_Included.Checked = shipment.TaxIncluded == "S";

            checkBox_Toll_Calculation.Checked = shipment.TollCalculation == "S";

            checkBox_Toll_Payment.Checked = shipment.TollPayment == "S";

            shipmentRefnums = new List<Refnum>();

            if (shipment.ShipmentRefnums != null)
            {
                shipmentRefnums.AddRange(shipment.ShipmentRefnums);

                InsertShipmentRefNums();
            }

            dataGridView_Shipment_Costs.Rows.Clear();


            foreach (var cost in shipment.ShipmentCosts)
            {
                var costType = (cost.CostType == "B") ? "Base" : "Acessório";

                dataGridView_Shipment_Costs.Rows.Add(
                    costType,
                    cost.Value.ToString().Replace(".", ","),
                    cost.AllocateCost,
                    cost.AccessorialCostXid);
            }

            releases = shipment.Releases;

            InsertReleases();

            editingRobotIndex = MainForm.robots.IndexOf(robot);
        }

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

            foreach (var release in releases)
            {
                var releaseLabel = (string.IsNullOrEmpty(release.DestinationLocationXid)) ? release.ReleaseXid : $"{release.ReleaseXid} - {release.DestinationLocationXid}";
                listBox_Release_Xids.Items.Add(releaseLabel);
            }
        }

        private void InsertReleaseRefNums()
        {
            listBox_Release_Refnums.Items.Clear();

            if (listBox_Release_Xids.SelectedItem != null)
            {
                var specificReleaseRefnums = releases[listBox_Release_Xids.SelectedIndex].ReleaseRefnums;

                if (specificReleaseRefnums != null)
                {
                    foreach (var refNum in specificReleaseRefnums)
                    {
                        var refNumText = string.Join(" - ", refNum.RefnumKey, refNum.RefnumValue);
                        listBox_Release_Refnums.Items.Add(refNumText);
                    }
                }

            }
        }

        private string[] GetSelectedRefnum(ListBox listBox) => listBox.SelectedItem.ToString().Split(" - ");

        private List<ShipmentCost> GenerateShipmentCosts()
        {
            var shipmentCosts = new List<ShipmentCost>();

            for (int i = 0; i < dataGridView_Shipment_Costs.Rows.Count - 1; i++)
            {
                var row = dataGridView_Shipment_Costs.Rows[i];

                var shipmentCost = new ShipmentCost
                {
                    CostType = (row.Cells[0].Value.ToString() == "Base") ? "B" : "A",
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

            var sourceLocationXid = textBox_Source_Location_Xid.Text;

            var sourceLocationCNPJ = textBox_Source_CNPJ.Text;

            var destinationLocationXid = textBox_Destination_Location_Xid.Text;

            var destinationLocationCNPJ = textBox_Destination_CNPJ.Text;

            var takerXid = textBox_Taker_Xid.Text;

            var addedTax = (checkBox_Added_Tax.Checked) ? "S" : "N";

            var taxIncluded = (checkBox_Tax_Included.Checked) ? "S" : "N";

            var tollCalculation = (checkBox_Toll_Calculation.Checked) ? "S" : "N";

            var tollPayment = (checkBox_Toll_Payment.Checked) ? "S" : "N";

            var driverXid = (string.IsNullOrEmpty(textBox_Driver_Xid.Text)) ? null : textBox_Driver_Xid.Text;

            if (!shipmentRefnums.Any())
                shipmentRefnums = null;

            var occurrencesXids = textBox_Occurrence_Xids.Text.Split(";").ToList();

            var occurrences = new List<ShipmentStatus>();

            foreach (var occurrenceXid in occurrencesXids)
                occurrences.Add(new ShipmentStatus { StatusXid = occurrenceXid });

            return new Shipment
            {
                ShipmentDomainName = domainName,
                ShipmentXid = shipmentNumber,
                TravelStatus = shipmentTravelStatus,
                EmissionStatus = shipmentEmissionStatus,
                XidCarrier = carrierXid,
                XidSourceLocation = sourceLocationXid,
                SourceLocationCNPJ = sourceLocationCNPJ,
                XidDestinationLocation = destinationLocationXid,
                DestinationLocationCNPJ = destinationLocationCNPJ,
                XidTakerLocation = takerXid,
                DriverXid = driverXid,
                AddedTax = addedTax,
                TaxIncluded = taxIncluded,
                TollCalculation = tollCalculation,
                TollPayment = tollPayment,
                SourceAddress = sourceAddress,
                ShipmentCosts = shipmentCosts,
                ShipmentRefnums = shipmentRefnums,
                Releases = releases,
                ShipmentStatus = occurrences,
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

            foreach (var release in ShipmentForm.releases)
            {
                release.ReleaseDomainName = domainName;
                if (release.ReleaseRefnums != null && !release.ReleaseRefnums.Any())
                    release.ReleaseRefnums = null;
            }

            var releases = ShipmentForm.releases;

            var shipmentCosts = GenerateShipmentCosts();

            var shipment = GenerateShipment(domainName, releases, shipmentCosts);

            var jarvisActions = new List<Actions>
            {
                new JarvisActions
                {
                    Shipments = new List<Shipment> { shipment },
                }
            };

            var jarvis = new Robot("jarvis", jarvisActions);

            if (editingRobotIndex == -1)
                MainForm.robots.Add(jarvis);
            else
                MainForm.robots[editingRobotIndex] = jarvis;

            Close();
        }

        private void ShipmentForm_Activated(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabPage_Shipment_Refnum)
                InsertShipmentRefNums();

            if (tabControl.SelectedTab == tabPage_Release)
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
            RefNumForm refNumForm = new RefNumForm(releases[activeReleaseIndex].ReleaseRefnums);
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

                var releaseRefnum = releases[activeReleaseIndex].ReleaseRefnums;

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
            var releaseRefnums = releases[activeReleaseIndex].ReleaseRefnums;
            Refnum.RemoveFromRefnumList(releaseRefnums, refNumKey);
        }

        private void button_Add_Release_Xid_Click(object sender, EventArgs e)
        {
            activeReleaseIndex = listBox_Release_Xids.Items.Count;

            ReleaseXidForm releaseXidForm = new ReleaseXidForm();
            releaseXidForm.ShowDialog();
        }

        private void button_Edit_Release_Xid_Click(object sender, EventArgs e)
        {
            var release = releases[listBox_Release_Xids.SelectedIndex];

            ReleaseXidForm releaseXidForm = new ReleaseXidForm(release);
            releaseXidForm.ShowDialog();
        }

        #endregion

        private void button_Remove_Release_Xid_Click(object sender, EventArgs e)
        {
            var releaseRefnumToDelete = releases.Find(x => x.ReleaseXid == listBox_Release_Xids.SelectedItem.ToString());

            listBox_Release_Xids.Items.RemoveAt(listBox_Release_Xids.SelectedIndex);
            releases.Remove(releaseRefnumToDelete);
        }
    }
}
