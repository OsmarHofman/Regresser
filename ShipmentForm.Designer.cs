
namespace Regresser
{
    partial class ShipmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_Shipment_DomainName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Shipment_Number = new System.Windows.Forms.TextBox();
            this.comboBox_Travel_Status = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_Emission_Status = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_Carrier_Xid = new System.Windows.Forms.TextBox();
            this.textBox_Source_Location_Xid = new System.Windows.Forms.TextBox();
            this.textBox_Destination_Location_Xid = new System.Windows.Forms.TextBox();
            this.textBox_Taker_Xid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_City = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_UF = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.maskedTextBox_IBGE = new System.Windows.Forms.MaskedTextBox();
            this.listBox_Release_Refnums = new System.Windows.Forms.ListBox();
            this.listBox_Release_Xids = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button_Add_Release_Xid = new System.Windows.Forms.Button();
            this.button_Edit_Release_Xid = new System.Windows.Forms.Button();
            this.button_Remove_Release_Xid = new System.Windows.Forms.Button();
            this.button_Remove_Release_Refnum = new System.Windows.Forms.Button();
            this.button_Edit_Release_Refnum = new System.Windows.Forms.Button();
            this.button_Add_Release_Refnum = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Cancelar = new System.Windows.Forms.Button();
            this.tabControl_Shipment_Costs = new System.Windows.Forms.TabControl();
            this.tabPage_Planning = new System.Windows.Forms.TabPage();
            this.textBox_Driver_Xid = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tabPage_Shipment_Cost = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView_Shipment_Costs = new System.Windows.Forms.DataGridView();
            this.CostType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CostValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllocatedCost = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AcessorialCostXid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBox_Added_Tax = new System.Windows.Forms.CheckBox();
            this.checkBox_Tax_Included = new System.Windows.Forms.CheckBox();
            this.tabPage_Shipment_Refnum = new System.Windows.Forms.TabPage();
            this.button_Remove_Shipment_Refnum = new System.Windows.Forms.Button();
            this.button_Edit_Shipment_Refnum = new System.Windows.Forms.Button();
            this.listBox_Shipment_Refnums = new System.Windows.Forms.ListBox();
            this.button_Add_Shipment_Refnum = new System.Windows.Forms.Button();
            this.tabPage_Address = new System.Windows.Forms.TabPage();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tabPage_Release = new System.Windows.Forms.TabPage();
            this.label27 = new System.Windows.Forms.Label();
            this.textBox_Url_WS = new System.Windows.Forms.TextBox();
            this.tabControl_Shipment_Costs.SuspendLayout();
            this.tabPage_Planning.SuspendLayout();
            this.tabPage_Shipment_Cost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Shipment_Costs)).BeginInit();
            this.tabPage_Shipment_Refnum.SuspendLayout();
            this.tabPage_Address.SuspendLayout();
            this.tabPage_Release.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Shipment_DomainName
            // 
            this.textBox_Shipment_DomainName.Location = new System.Drawing.Point(155, 26);
            this.textBox_Shipment_DomainName.Name = "textBox_Shipment_DomainName";
            this.textBox_Shipment_DomainName.Size = new System.Drawing.Size(140, 23);
            this.textBox_Shipment_DomainName.TabIndex = 0;
            this.textBox_Shipment_DomainName.Text = "EMBDEV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Shipment Domain Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nº Shipment";
            // 
            // textBox_Shipment_Number
            // 
            this.textBox_Shipment_Number.Location = new System.Drawing.Point(155, 71);
            this.textBox_Shipment_Number.Name = "textBox_Shipment_Number";
            this.textBox_Shipment_Number.Size = new System.Drawing.Size(140, 23);
            this.textBox_Shipment_Number.TabIndex = 2;
            this.textBox_Shipment_Number.Text = "1";
            // 
            // comboBox_Travel_Status
            // 
            this.comboBox_Travel_Status.FormattingEnabled = true;
            this.comboBox_Travel_Status.Items.AddRange(new object[] {
            "PLANEJADO",
            "INICIADO",
            "EMBARCADO"});
            this.comboBox_Travel_Status.Location = new System.Drawing.Point(155, 123);
            this.comboBox_Travel_Status.Name = "comboBox_Travel_Status";
            this.comboBox_Travel_Status.Size = new System.Drawing.Size(140, 23);
            this.comboBox_Travel_Status.TabIndex = 4;
            this.comboBox_Travel_Status.Text = "PLANEJADO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Status da Viagem";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Status da Emissão";
            // 
            // comboBox_Emission_Status
            // 
            this.comboBox_Emission_Status.FormattingEnabled = true;
            this.comboBox_Emission_Status.Items.AddRange(new object[] {
            "PRE_EMISSAO_ENVIADA",
            "DADOS_DPS_RECEBIDO"});
            this.comboBox_Emission_Status.Location = new System.Drawing.Point(155, 172);
            this.comboBox_Emission_Status.Name = "comboBox_Emission_Status";
            this.comboBox_Emission_Status.Size = new System.Drawing.Size(140, 23);
            this.comboBox_Emission_Status.TabIndex = 6;
            this.comboBox_Emission_Status.Text = "PRE_EMISSAO_ENVIADA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Xid Transportador";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(361, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Xid Origem";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(361, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Xid Destino";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(354, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Xid Tomador";
            // 
            // textBox_Carrier_Xid
            // 
            this.textBox_Carrier_Xid.Location = new System.Drawing.Point(434, 13);
            this.textBox_Carrier_Xid.Name = "textBox_Carrier_Xid";
            this.textBox_Carrier_Xid.Size = new System.Drawing.Size(152, 23);
            this.textBox_Carrier_Xid.TabIndex = 12;
            this.textBox_Carrier_Xid.Text = "CAR-12521";
            // 
            // textBox_Source_Location_Xid
            // 
            this.textBox_Source_Location_Xid.Location = new System.Drawing.Point(434, 56);
            this.textBox_Source_Location_Xid.Name = "textBox_Source_Location_Xid";
            this.textBox_Source_Location_Xid.Size = new System.Drawing.Size(152, 23);
            this.textBox_Source_Location_Xid.TabIndex = 13;
            this.textBox_Source_Location_Xid.Text = "ORG-8027-30018";
            // 
            // textBox_Destination_Location_Xid
            // 
            this.textBox_Destination_Location_Xid.Location = new System.Drawing.Point(434, 99);
            this.textBox_Destination_Location_Xid.Name = "textBox_Destination_Location_Xid";
            this.textBox_Destination_Location_Xid.Size = new System.Drawing.Size(152, 23);
            this.textBox_Destination_Location_Xid.TabIndex = 14;
            this.textBox_Destination_Location_Xid.Text = "CUS-6429-18171";
            // 
            // textBox_Taker_Xid
            // 
            this.textBox_Taker_Xid.Location = new System.Drawing.Point(434, 140);
            this.textBox_Taker_Xid.Name = "textBox_Taker_Xid";
            this.textBox_Taker_Xid.Size = new System.Drawing.Size(152, 23);
            this.textBox_Taker_Xid.TabIndex = 15;
            this.textBox_Taker_Xid.Text = "ORG-8027-30018";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(76, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "Cidade";
            // 
            // textBox_City
            // 
            this.textBox_City.Location = new System.Drawing.Point(126, 64);
            this.textBox_City.Name = "textBox_City";
            this.textBox_City.Size = new System.Drawing.Size(100, 23);
            this.textBox_City.TabIndex = 16;
            this.textBox_City.Text = "São Paulo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(76, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "Estado";
            // 
            // comboBox_UF
            // 
            this.comboBox_UF.FormattingEnabled = true;
            this.comboBox_UF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "EX",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.comboBox_UF.Location = new System.Drawing.Point(126, 106);
            this.comboBox_UF.Name = "comboBox_UF";
            this.comboBox_UF.Size = new System.Drawing.Size(47, 23);
            this.comboBox_UF.TabIndex = 20;
            this.comboBox_UF.Text = "SP";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(89, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 15);
            this.label11.TabIndex = 22;
            this.label11.Text = "IBGE";
            // 
            // maskedTextBox_IBGE
            // 
            this.maskedTextBox_IBGE.Location = new System.Drawing.Point(126, 147);
            this.maskedTextBox_IBGE.Mask = "0000000";
            this.maskedTextBox_IBGE.Name = "maskedTextBox_IBGE";
            this.maskedTextBox_IBGE.Size = new System.Drawing.Size(61, 23);
            this.maskedTextBox_IBGE.TabIndex = 11;
            this.maskedTextBox_IBGE.Text = "3550308";
            // 
            // listBox_Release_Refnums
            // 
            this.listBox_Release_Refnums.FormattingEnabled = true;
            this.listBox_Release_Refnums.ItemHeight = 15;
            this.listBox_Release_Refnums.Location = new System.Drawing.Point(333, 43);
            this.listBox_Release_Refnums.Name = "listBox_Release_Refnums";
            this.listBox_Release_Refnums.Size = new System.Drawing.Size(226, 94);
            this.listBox_Release_Refnums.TabIndex = 0;
            this.listBox_Release_Refnums.SelectedIndexChanged += new System.EventHandler(this.listBox_Release_Refnums_SelectedIndexChanged);
            // 
            // listBox_Release_Xids
            // 
            this.listBox_Release_Xids.FormattingEnabled = true;
            this.listBox_Release_Xids.ItemHeight = 15;
            this.listBox_Release_Xids.Items.AddRange(new object[] {
            "1"});
            this.listBox_Release_Xids.Location = new System.Drawing.Point(51, 43);
            this.listBox_Release_Xids.Name = "listBox_Release_Xids";
            this.listBox_Release_Xids.Size = new System.Drawing.Size(229, 94);
            this.listBox_Release_Xids.TabIndex = 1;
            this.listBox_Release_Xids.SelectedIndexChanged += new System.EventHandler(this.listBox_Release_Xids_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(116, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 15);
            this.label13.TabIndex = 2;
            this.label13.Text = "Xid da Ordem";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(388, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 15);
            this.label14.TabIndex = 3;
            this.label14.Text = "Refnums da Ordem";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Location = new System.Drawing.Point(306, -6);
            this.label15.MinimumSize = new System.Drawing.Size(0, 200);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(2, 200);
            this.label15.TabIndex = 4;
            // 
            // button_Add_Release_Xid
            // 
            this.button_Add_Release_Xid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Add_Release_Xid.Location = new System.Drawing.Point(61, 143);
            this.button_Add_Release_Xid.Name = "button_Add_Release_Xid";
            this.button_Add_Release_Xid.Size = new System.Drawing.Size(70, 26);
            this.button_Add_Release_Xid.TabIndex = 8;
            this.button_Add_Release_Xid.Text = "Adicionar";
            this.button_Add_Release_Xid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Add_Release_Xid.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_Add_Release_Xid.UseVisualStyleBackColor = true;
            this.button_Add_Release_Xid.Click += new System.EventHandler(this.button_Add_Release_Xid_Click);
            // 
            // button_Edit_Release_Xid
            // 
            this.button_Edit_Release_Xid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Edit_Release_Xid.Location = new System.Drawing.Point(143, 143);
            this.button_Edit_Release_Xid.Name = "button_Edit_Release_Xid";
            this.button_Edit_Release_Xid.Size = new System.Drawing.Size(52, 26);
            this.button_Edit_Release_Xid.TabIndex = 9;
            this.button_Edit_Release_Xid.Text = "Editar";
            this.button_Edit_Release_Xid.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_Edit_Release_Xid.UseVisualStyleBackColor = true;
            this.button_Edit_Release_Xid.Click += new System.EventHandler(this.button_Edit_Release_Xid_Click);
            // 
            // button_Remove_Release_Xid
            // 
            this.button_Remove_Release_Xid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Remove_Release_Xid.Location = new System.Drawing.Point(205, 143);
            this.button_Remove_Release_Xid.Name = "button_Remove_Release_Xid";
            this.button_Remove_Release_Xid.Size = new System.Drawing.Size(65, 26);
            this.button_Remove_Release_Xid.TabIndex = 10;
            this.button_Remove_Release_Xid.Text = "Remover";
            this.button_Remove_Release_Xid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Remove_Release_Xid.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_Remove_Release_Xid.UseVisualStyleBackColor = true;
            this.button_Remove_Release_Xid.Click += new System.EventHandler(this.button_Remove_Release_Xid_Click);
            // 
            // button_Remove_Release_Refnum
            // 
            this.button_Remove_Release_Refnum.Enabled = false;
            this.button_Remove_Release_Refnum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Remove_Release_Refnum.Location = new System.Drawing.Point(486, 143);
            this.button_Remove_Release_Refnum.Name = "button_Remove_Release_Refnum";
            this.button_Remove_Release_Refnum.Size = new System.Drawing.Size(65, 26);
            this.button_Remove_Release_Refnum.TabIndex = 13;
            this.button_Remove_Release_Refnum.Text = "Remover";
            this.button_Remove_Release_Refnum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Remove_Release_Refnum.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_Remove_Release_Refnum.UseVisualStyleBackColor = true;
            this.button_Remove_Release_Refnum.Click += new System.EventHandler(this.button_Remove_Release_Refnum_Click);
            // 
            // button_Edit_Release_Refnum
            // 
            this.button_Edit_Release_Refnum.Enabled = false;
            this.button_Edit_Release_Refnum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Edit_Release_Refnum.Location = new System.Drawing.Point(424, 143);
            this.button_Edit_Release_Refnum.Name = "button_Edit_Release_Refnum";
            this.button_Edit_Release_Refnum.Size = new System.Drawing.Size(52, 26);
            this.button_Edit_Release_Refnum.TabIndex = 12;
            this.button_Edit_Release_Refnum.Text = "Editar";
            this.button_Edit_Release_Refnum.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_Edit_Release_Refnum.UseVisualStyleBackColor = true;
            this.button_Edit_Release_Refnum.Click += new System.EventHandler(this.button_Edit_Release_Refnum_Click);
            // 
            // button_Add_Release_Refnum
            // 
            this.button_Add_Release_Refnum.Enabled = false;
            this.button_Add_Release_Refnum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Add_Release_Refnum.Location = new System.Drawing.Point(342, 143);
            this.button_Add_Release_Refnum.Name = "button_Add_Release_Refnum";
            this.button_Add_Release_Refnum.Size = new System.Drawing.Size(70, 26);
            this.button_Add_Release_Refnum.TabIndex = 11;
            this.button_Add_Release_Refnum.Text = "Adicionar";
            this.button_Add_Release_Refnum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Add_Release_Refnum.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_Add_Release_Refnum.UseVisualStyleBackColor = true;
            this.button_Add_Release_Refnum.Click += new System.EventHandler(this.button_Add_Release_Refnum_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label16.Location = new System.Drawing.Point(-28, 301);
            this.label16.MaximumSize = new System.Drawing.Size(0, 2);
            this.label16.MinimumSize = new System.Drawing.Size(700, 2);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(700, 2);
            this.label16.TabIndex = 13;
            // 
            // button_Save
            // 
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Save.Location = new System.Drawing.Point(156, 316);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(105, 38);
            this.button_Save.TabIndex = 14;
            this.button_Save.Text = "Salvar";
            this.button_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Cancelar
            // 
            this.button_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cancelar.Location = new System.Drawing.Point(339, 316);
            this.button_Cancelar.Name = "button_Cancelar";
            this.button_Cancelar.Size = new System.Drawing.Size(105, 38);
            this.button_Cancelar.TabIndex = 15;
            this.button_Cancelar.Text = "Cancelar";
            this.button_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_Cancelar.UseVisualStyleBackColor = true;
            this.button_Cancelar.Click += new System.EventHandler(this.button_Cancelar_Click);
            // 
            // tabControl_Shipment_Costs
            // 
            this.tabControl_Shipment_Costs.Controls.Add(this.tabPage_Planning);
            this.tabControl_Shipment_Costs.Controls.Add(this.tabPage_Shipment_Cost);
            this.tabControl_Shipment_Costs.Controls.Add(this.tabPage_Shipment_Refnum);
            this.tabControl_Shipment_Costs.Controls.Add(this.tabPage_Address);
            this.tabControl_Shipment_Costs.Controls.Add(this.tabPage_Release);
            this.tabControl_Shipment_Costs.Location = new System.Drawing.Point(12, 48);
            this.tabControl_Shipment_Costs.Name = "tabControl_Shipment_Costs";
            this.tabControl_Shipment_Costs.SelectedIndex = 0;
            this.tabControl_Shipment_Costs.Size = new System.Drawing.Size(614, 246);
            this.tabControl_Shipment_Costs.TabIndex = 16;
            // 
            // tabPage_Planning
            // 
            this.tabPage_Planning.Controls.Add(this.textBox_Driver_Xid);
            this.tabPage_Planning.Controls.Add(this.label18);
            this.tabPage_Planning.Controls.Add(this.textBox_Taker_Xid);
            this.tabPage_Planning.Controls.Add(this.label1);
            this.tabPage_Planning.Controls.Add(this.comboBox_Emission_Status);
            this.tabPage_Planning.Controls.Add(this.textBox_Destination_Location_Xid);
            this.tabPage_Planning.Controls.Add(this.label4);
            this.tabPage_Planning.Controls.Add(this.textBox_Shipment_Number);
            this.tabPage_Planning.Controls.Add(this.textBox_Source_Location_Xid);
            this.tabPage_Planning.Controls.Add(this.label3);
            this.tabPage_Planning.Controls.Add(this.label5);
            this.tabPage_Planning.Controls.Add(this.textBox_Carrier_Xid);
            this.tabPage_Planning.Controls.Add(this.label2);
            this.tabPage_Planning.Controls.Add(this.label6);
            this.tabPage_Planning.Controls.Add(this.label8);
            this.tabPage_Planning.Controls.Add(this.comboBox_Travel_Status);
            this.tabPage_Planning.Controls.Add(this.textBox_Shipment_DomainName);
            this.tabPage_Planning.Controls.Add(this.label7);
            this.tabPage_Planning.Location = new System.Drawing.Point(4, 24);
            this.tabPage_Planning.Name = "tabPage_Planning";
            this.tabPage_Planning.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Planning.Size = new System.Drawing.Size(606, 218);
            this.tabPage_Planning.TabIndex = 0;
            this.tabPage_Planning.Text = "Planejamento";
            this.tabPage_Planning.UseVisualStyleBackColor = true;
            // 
            // textBox_Driver_Xid
            // 
            this.textBox_Driver_Xid.Location = new System.Drawing.Point(434, 179);
            this.textBox_Driver_Xid.Name = "textBox_Driver_Xid";
            this.textBox_Driver_Xid.Size = new System.Drawing.Size(152, 23);
            this.textBox_Driver_Xid.TabIndex = 17;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(350, 182);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 15);
            this.label18.TabIndex = 16;
            this.label18.Text = "Xid Motorista";
            // 
            // tabPage_Shipment_Cost
            // 
            this.tabPage_Shipment_Cost.Controls.Add(this.textBox3);
            this.tabPage_Shipment_Cost.Controls.Add(this.label17);
            this.tabPage_Shipment_Cost.Controls.Add(this.label12);
            this.tabPage_Shipment_Cost.Controls.Add(this.textBox2);
            this.tabPage_Shipment_Cost.Controls.Add(this.dataGridView_Shipment_Costs);
            this.tabPage_Shipment_Cost.Controls.Add(this.checkBox_Added_Tax);
            this.tabPage_Shipment_Cost.Controls.Add(this.checkBox_Tax_Included);
            this.tabPage_Shipment_Cost.Location = new System.Drawing.Point(4, 24);
            this.tabPage_Shipment_Cost.Name = "tabPage_Shipment_Cost";
            this.tabPage_Shipment_Cost.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Shipment_Cost.Size = new System.Drawing.Size(606, 218);
            this.tabPage_Shipment_Cost.TabIndex = 1;
            this.tabPage_Shipment_Cost.Text = "Custo";
            this.tabPage_Shipment_Cost.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(525, 122);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(69, 23);
            this.textBox3.TabIndex = 9;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(454, 125);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 15);
            this.label17.TabIndex = 8;
            this.label17.Text = "Advalorem";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(492, 175);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 15);
            this.label12.TabIndex = 6;
            this.label12.Text = "Gris";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(525, 172);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(69, 23);
            this.textBox2.TabIndex = 5;
            // 
            // dataGridView_Shipment_Costs
            // 
            this.dataGridView_Shipment_Costs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Shipment_Costs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CostType,
            this.CostValue,
            this.AllocatedCost,
            this.AcessorialCostXid});
            this.dataGridView_Shipment_Costs.Location = new System.Drawing.Point(6, 6);
            this.dataGridView_Shipment_Costs.Name = "dataGridView_Shipment_Costs";
            this.dataGridView_Shipment_Costs.RowTemplate.Height = 25;
            this.dataGridView_Shipment_Costs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_Shipment_Costs.Size = new System.Drawing.Size(442, 206);
            this.dataGridView_Shipment_Costs.TabIndex = 4;
            // 
            // CostType
            // 
            this.CostType.HeaderText = "Tipo do Custo";
            this.CostType.Items.AddRange(new object[] {
            "Base",
            "Acessório"});
            this.CostType.Name = "CostType";
            // 
            // CostValue
            // 
            this.CostValue.HeaderText = "Valor";
            this.CostValue.Name = "CostValue";
            // 
            // AllocatedCost
            // 
            this.AllocatedCost.HeaderText = "Custo Alocado";
            this.AllocatedCost.Name = "AllocatedCost";
            // 
            // AcessorialCostXid
            // 
            this.AcessorialCostXid.HeaderText = "Xid do Custo Acessório";
            this.AcessorialCostXid.Name = "AcessorialCostXid";
            // 
            // checkBox_Added_Tax
            // 
            this.checkBox_Added_Tax.AutoSize = true;
            this.checkBox_Added_Tax.Location = new System.Drawing.Point(474, 75);
            this.checkBox_Added_Tax.Name = "checkBox_Added_Tax";
            this.checkBox_Added_Tax.Size = new System.Drawing.Size(117, 19);
            this.checkBox_Added_Tax.TabIndex = 3;
            this.checkBox_Added_Tax.Text = "Imposto Somado";
            this.checkBox_Added_Tax.UseVisualStyleBackColor = true;
            // 
            // checkBox_Tax_Included
            // 
            this.checkBox_Tax_Included.AutoSize = true;
            this.checkBox_Tax_Included.Location = new System.Drawing.Point(474, 30);
            this.checkBox_Tax_Included.Name = "checkBox_Tax_Included";
            this.checkBox_Tax_Included.Size = new System.Drawing.Size(111, 19);
            this.checkBox_Tax_Included.TabIndex = 2;
            this.checkBox_Tax_Included.Text = "Imposto Incluso";
            this.checkBox_Tax_Included.UseVisualStyleBackColor = true;
            // 
            // tabPage_Shipment_Refnum
            // 
            this.tabPage_Shipment_Refnum.Controls.Add(this.button_Remove_Shipment_Refnum);
            this.tabPage_Shipment_Refnum.Controls.Add(this.button_Edit_Shipment_Refnum);
            this.tabPage_Shipment_Refnum.Controls.Add(this.listBox_Shipment_Refnums);
            this.tabPage_Shipment_Refnum.Controls.Add(this.button_Add_Shipment_Refnum);
            this.tabPage_Shipment_Refnum.Location = new System.Drawing.Point(4, 24);
            this.tabPage_Shipment_Refnum.Name = "tabPage_Shipment_Refnum";
            this.tabPage_Shipment_Refnum.Size = new System.Drawing.Size(606, 218);
            this.tabPage_Shipment_Refnum.TabIndex = 4;
            this.tabPage_Shipment_Refnum.Text = "Refnum";
            this.tabPage_Shipment_Refnum.UseVisualStyleBackColor = true;
            // 
            // button_Remove_Shipment_Refnum
            // 
            this.button_Remove_Shipment_Refnum.Enabled = false;
            this.button_Remove_Shipment_Refnum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Remove_Shipment_Refnum.Location = new System.Drawing.Point(348, 154);
            this.button_Remove_Shipment_Refnum.Name = "button_Remove_Shipment_Refnum";
            this.button_Remove_Shipment_Refnum.Size = new System.Drawing.Size(65, 26);
            this.button_Remove_Shipment_Refnum.TabIndex = 17;
            this.button_Remove_Shipment_Refnum.Text = "Remover";
            this.button_Remove_Shipment_Refnum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Remove_Shipment_Refnum.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_Remove_Shipment_Refnum.UseVisualStyleBackColor = true;
            this.button_Remove_Shipment_Refnum.Click += new System.EventHandler(this.button_Remove_Shipment_Refnum_Click);
            // 
            // button_Edit_Shipment_Refnum
            // 
            this.button_Edit_Shipment_Refnum.Enabled = false;
            this.button_Edit_Shipment_Refnum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Edit_Shipment_Refnum.Location = new System.Drawing.Point(355, 100);
            this.button_Edit_Shipment_Refnum.Name = "button_Edit_Shipment_Refnum";
            this.button_Edit_Shipment_Refnum.Size = new System.Drawing.Size(52, 26);
            this.button_Edit_Shipment_Refnum.TabIndex = 16;
            this.button_Edit_Shipment_Refnum.Text = "Editar";
            this.button_Edit_Shipment_Refnum.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_Edit_Shipment_Refnum.UseVisualStyleBackColor = true;
            this.button_Edit_Shipment_Refnum.Click += new System.EventHandler(this.button_Edit_Shipment_Refnum_Click);
            // 
            // listBox_Shipment_Refnums
            // 
            this.listBox_Shipment_Refnums.FormattingEnabled = true;
            this.listBox_Shipment_Refnums.ItemHeight = 15;
            this.listBox_Shipment_Refnums.Location = new System.Drawing.Point(112, 19);
            this.listBox_Shipment_Refnums.Name = "listBox_Shipment_Refnums";
            this.listBox_Shipment_Refnums.Size = new System.Drawing.Size(226, 184);
            this.listBox_Shipment_Refnums.TabIndex = 14;
            this.listBox_Shipment_Refnums.SelectedIndexChanged += new System.EventHandler(this.listBox_Shipment_Refnums_SelectedIndexChanged);
            // 
            // button_Add_Shipment_Refnum
            // 
            this.button_Add_Shipment_Refnum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Add_Shipment_Refnum.Location = new System.Drawing.Point(344, 45);
            this.button_Add_Shipment_Refnum.Name = "button_Add_Shipment_Refnum";
            this.button_Add_Shipment_Refnum.Size = new System.Drawing.Size(70, 26);
            this.button_Add_Shipment_Refnum.TabIndex = 15;
            this.button_Add_Shipment_Refnum.Text = "Adicionar";
            this.button_Add_Shipment_Refnum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Add_Shipment_Refnum.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_Add_Shipment_Refnum.UseVisualStyleBackColor = true;
            this.button_Add_Shipment_Refnum.Click += new System.EventHandler(this.button_Add_Shipment_Refnum_Click);
            // 
            // tabPage_Address
            // 
            this.tabPage_Address.Controls.Add(this.label26);
            this.tabPage_Address.Controls.Add(this.label25);
            this.tabPage_Address.Controls.Add(this.label24);
            this.tabPage_Address.Controls.Add(this.label20);
            this.tabPage_Address.Controls.Add(this.label21);
            this.tabPage_Address.Controls.Add(this.label22);
            this.tabPage_Address.Controls.Add(this.label23);
            this.tabPage_Address.Controls.Add(this.label19);
            this.tabPage_Address.Controls.Add(this.maskedTextBox_IBGE);
            this.tabPage_Address.Controls.Add(this.label11);
            this.tabPage_Address.Controls.Add(this.label9);
            this.tabPage_Address.Controls.Add(this.comboBox_UF);
            this.tabPage_Address.Controls.Add(this.textBox_City);
            this.tabPage_Address.Controls.Add(this.label10);
            this.tabPage_Address.Location = new System.Drawing.Point(4, 24);
            this.tabPage_Address.Name = "tabPage_Address";
            this.tabPage_Address.Size = new System.Drawing.Size(606, 218);
            this.tabPage_Address.TabIndex = 2;
            this.tabPage_Address.Text = "Endereço";
            this.tabPage_Address.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(414, 150);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(49, 15);
            this.label26.TabIndex = 33;
            this.label26.Text = "3550308";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(414, 109);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(20, 15);
            this.label25.TabIndex = 32;
            this.label25.Text = "SP";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(411, 67);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(59, 15);
            this.label24.TabIndex = 31;
            this.label24.Text = "São Paulo";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(397, 21);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(76, 25);
            this.label20.TabIndex = 30;
            this.label20.Text = "Destino";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(374, 150);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(31, 15);
            this.label21.TabIndex = 29;
            this.label21.Text = "IBGE";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(361, 67);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(44, 15);
            this.label22.TabIndex = 26;
            this.label22.Text = "Cidade";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(361, 109);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(42, 15);
            this.label23.TabIndex = 27;
            this.label23.Text = "Estado";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(112, 21);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 25);
            this.label19.TabIndex = 23;
            this.label19.Text = "Origem";
            // 
            // tabPage_Release
            // 
            this.tabPage_Release.Controls.Add(this.button_Remove_Release_Refnum);
            this.tabPage_Release.Controls.Add(this.listBox_Release_Xids);
            this.tabPage_Release.Controls.Add(this.label14);
            this.tabPage_Release.Controls.Add(this.button_Edit_Release_Refnum);
            this.tabPage_Release.Controls.Add(this.label15);
            this.tabPage_Release.Controls.Add(this.listBox_Release_Refnums);
            this.tabPage_Release.Controls.Add(this.button_Add_Release_Refnum);
            this.tabPage_Release.Controls.Add(this.button_Add_Release_Xid);
            this.tabPage_Release.Controls.Add(this.label13);
            this.tabPage_Release.Controls.Add(this.button_Remove_Release_Xid);
            this.tabPage_Release.Controls.Add(this.button_Edit_Release_Xid);
            this.tabPage_Release.Location = new System.Drawing.Point(4, 24);
            this.tabPage_Release.Name = "tabPage_Release";
            this.tabPage_Release.Size = new System.Drawing.Size(606, 218);
            this.tabPage_Release.TabIndex = 3;
            this.tabPage_Release.Text = "Ordem";
            this.tabPage_Release.UseVisualStyleBackColor = true;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(16, 18);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(62, 15);
            this.label27.TabIndex = 17;
            this.label27.Text = "Url do WS:";
            // 
            // textBox_Url_WS
            // 
            this.textBox_Url_WS.Location = new System.Drawing.Point(84, 15);
            this.textBox_Url_WS.Name = "textBox_Url_WS";
            this.textBox_Url_WS.Size = new System.Drawing.Size(538, 23);
            this.textBox_Url_WS.TabIndex = 18;
            // 
            // ShipmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 368);
            this.ControlBox = false;
            this.Controls.Add(this.textBox_Url_WS);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.tabControl_Shipment_Costs);
            this.Controls.Add(this.button_Cancelar);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.label16);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShipmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Embarque - Jarvis";
            this.Activated += new System.EventHandler(this.ShipmentForm_Activated);
            this.tabControl_Shipment_Costs.ResumeLayout(false);
            this.tabPage_Planning.ResumeLayout(false);
            this.tabPage_Planning.PerformLayout();
            this.tabPage_Shipment_Cost.ResumeLayout(false);
            this.tabPage_Shipment_Cost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Shipment_Costs)).EndInit();
            this.tabPage_Shipment_Refnum.ResumeLayout(false);
            this.tabPage_Address.ResumeLayout(false);
            this.tabPage_Address.PerformLayout();
            this.tabPage_Release.ResumeLayout(false);
            this.tabPage_Release.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Shipment_DomainName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Shipment_Number;
        private System.Windows.Forms.ComboBox comboBox_Travel_Status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_Emission_Status;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Taker_Xid;
        private System.Windows.Forms.TextBox textBox_Destination_Location_Xid;
        private System.Windows.Forms.TextBox textBox_Source_Location_Xid;
        private System.Windows.Forms.TextBox textBox_Carrier_Xid;
        private System.Windows.Forms.ComboBox comboBox_UF;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_City;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_IBGE;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox listBox_Release_Refnums;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox listBox_Release_Xids;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button_Add_Release_Xid;
        private System.Windows.Forms.Button button_Edit_Release_Xid;
        private System.Windows.Forms.Button button_Remove_Release_Xid;
        private System.Windows.Forms.Button button_Remove_Release_Refnum;
        private System.Windows.Forms.Button button_Edit_Release_Refnum;
        private System.Windows.Forms.Button button_Add_Release_Refnum;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Cancelar;
        private System.Windows.Forms.TabControl tabControl_Shipment_Costs;
        private System.Windows.Forms.TabPage tabPage_Planning;
        private System.Windows.Forms.TabPage tabPage_Shipment_Cost;
        private System.Windows.Forms.DataGridView dataGridView_Shipment_Costs;
        private System.Windows.Forms.CheckBox checkBox_Added_Tax;
        private System.Windows.Forms.CheckBox checkBox_Tax_Included;
        private System.Windows.Forms.TabPage tabPage_Address;
        private System.Windows.Forms.TabPage tabPage_Release;
        private System.Windows.Forms.TabPage tabPage_Shipment_Refnum;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox_Driver_Xid;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button_Remove_Shipment_Refnum;
        private System.Windows.Forms.Button button_Edit_Shipment_Refnum;
        private System.Windows.Forms.ListBox listBox_Shipment_Refnums;
        private System.Windows.Forms.Button button_Add_Shipment_Refnum;
        private System.Windows.Forms.DataGridViewComboBoxColumn CostType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostValue;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AllocatedCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcessorialCostXid;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBox_Url_WS;
    }
}