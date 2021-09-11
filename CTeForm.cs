using Regresser.Domain.RobotsActions;
using Regresser.Domain.Shipper;
using Regresser.Domain.Shipper.Documents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Regresser
{
    public partial class CTeForm : Form
    {
        private List<Cte> ctes;

        private List<ComplementaryCte> complCtes;

        public CTeForm()
        {
            InitializeComponent();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (!ctes.Any() && !complCtes.Any()) MessageBox.Show("Não há CT-es Normais nem Complementares a serem salvos!");
            else
            {
                var actions = new BinoActions { UrlWs = textBox_Url_WS.Text };

                if (ctes.Any())
                    actions.Ctes = ctes;

                if (complCtes.Any())
                    actions.ComplementaryCtes = complCtes;

                List<Actions> binoActions = new List<Actions> { actions };

                var bino = new Robot("bino", binoActions);

                MainForm.robots.Add(bino);

                Close();
            }
        }
    }
}
