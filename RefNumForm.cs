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
    public partial class RefNumForm : Form
    {
        private List<Refnum> refNums;
        private string releaseXid;
        private bool isEditing = false;

        public RefNumForm()
        {
            InitializeComponent();
        }

        public RefNumForm(List<Refnum> refNums, Refnum editRefNum = null)
        {
            InitializeComponent();

            SetupEdit(refNums, editRefNum);

            this.refNums = refNums;
        }

        public RefNumForm(ReleaseRefnum releaseRefnum, Refnum editRefNum = null)
        {
            InitializeComponent();

            SetupEdit(releaseRefnum.ReleaseRefnums, editRefNum);

            this.releaseXid = releaseRefnum.ReleaseXid;
            this.refNums = releaseRefnum.ReleaseRefnums;
        }

        private void SetupEdit(List<Refnum> refNums, Refnum editRefNum)
        {
            if (editRefNum != null)
            {
                textBox_Refnum_Key.Text = editRefNum.RefnumKey;
                textBox_Refnum_Value.Text = editRefNum.RefnumValue;
                Refnum.RemoveFromRefnumList(refNums, editRefNum.RefnumKey);

                this.isEditing = true;
            }
        }



        private void button_Save_Click(object sender, EventArgs e)
        {

            if (!isEditing && FieldsAreEmpty())
                Close();

            if (!FieldsAreEmpty())
            {
                try
                {
                    if (refNums == null)
                        refNums = new List<Refnum>();

                    refNums.Add(new Refnum(textBox_Refnum_Key.Text, textBox_Refnum_Value.Text));

                    if (string.IsNullOrEmpty(releaseXid))
                        ShipmentForm.shipmentRefnums = this.refNums;
                    else
                        ShipmentForm.releaseRefnums.Find(x => x.ReleaseXid == this.releaseXid).ReleaseRefnums = this.refNums;

                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private bool FieldsAreEmpty()
        {
            return string.IsNullOrEmpty(textBox_Refnum_Key.Text) || string.IsNullOrEmpty(textBox_Refnum_Value.Text);
        }

    }

}
