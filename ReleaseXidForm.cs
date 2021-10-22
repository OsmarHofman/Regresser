using Regresser.Domain.Shipper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Regresser
{
    public partial class ReleaseXidForm : Form
    {

        private bool isEditing = false;

        private Release release;

        public ReleaseXidForm()
        {
            InitializeComponent();
        }

        public ReleaseXidForm(Release release)
        {
            InitializeComponent();

            this.release = release;
            textBox_Release_Xid.Text = release.ReleaseXid;
            if (release.DestinationLocationXid != null)
            {
                checkBox_DestinationToggle.Enabled = true;
                textBox_DestinationLocationXid.Text = release.DestinationLocationXid;
            }
            isEditing = true;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (!isEditing && string.IsNullOrEmpty(textBox_Release_Xid.Text))
                Close();

            if (!string.IsNullOrEmpty(textBox_Release_Xid.Text))
            {
                if (isEditing)
                {
                    release.ReleaseXid = textBox_Release_Xid.Text;
                    release.DestinationLocationXid = textBox_DestinationLocationXid.Text;
                }
                else ShipmentForm.releases.Add(new Release(textBox_Release_Xid.Text, textBox_DestinationLocationXid.Text));
                Close();
            }
        }

        private void checkBox_DestinationToggle_CheckedChanged(object sender, EventArgs e)
        {
            textBox_DestinationLocationXid.Enabled = !textBox_DestinationLocationXid.Enabled;
        }
    }
}
