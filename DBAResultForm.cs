using Regresser.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Regresser
{
    public partial class DBAResultForm : Form
    {

        private DBAResult DBAResult;

        public DBAResultForm()
        {
            InitializeComponent();
        }

        public DBAResultForm(DBAResult DBAResult)
        {
            InitializeComponent();

            textBox_ValidationValue.Text = DBAResult.Value;

            this.DBAResult = DBAResult;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (DBAResult == null)
                DBAForm.results.Add(new DBAResult { Value = textBox_ValidationValue.Text });
            else
                DBAForm.results.Find(x => x == DBAResult).Value = textBox_ValidationValue.Text;

           Close();
        }
    }
}
