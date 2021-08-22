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

        private ReleaseRefnum releaseRefNum;

        public ReleaseXidForm()
        {
            InitializeComponent();
        }

        public ReleaseXidForm(ReleaseRefnum release)
        {
            InitializeComponent();

            releaseRefNum = release;
            textBox_Release_Xid.Text = release.ReleaseXid;
            isEditing = true;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (!isEditing && string.IsNullOrEmpty(textBox_Release_Xid.Text))
                Close();

            if (!string.IsNullOrEmpty(textBox_Release_Xid.Text))
            {
                if (isEditing) releaseRefNum.ReleaseXid = textBox_Release_Xid.Text;
                else ShipmentForm.releaseRefnums.Add(new ReleaseRefnum(textBox_Release_Xid.Text));
                Close();
            }
        }
    }
}
