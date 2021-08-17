
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_Carrier_Xid = new System.Windows.Forms.TextBox();
            this.textBox_Source_Location_Xid = new System.Windows.Forms.TextBox();
            this.textBox_Destination_Location_Xid = new System.Windows.Forms.TextBox();
            this.textBox_Taker_Xid = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBox_Tax_Included = new System.Windows.Forms.CheckBox();
            this.checkBox_Added_Tax = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CostType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CostValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllocatedCost = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBox_Release_Refnums = new System.Windows.Forms.ListBox();
            this.listBox_Release_Xids = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button_Add_Release_Xid = new System.Windows.Forms.Button();
            this.button_Edit_Release_Xid = new System.Windows.Forms.Button();
            this.button_Remove_Release_Xid = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Cancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Shipment_DomainName
            // 
            this.textBox_Shipment_DomainName.Location = new System.Drawing.Point(150, 39);
            this.textBox_Shipment_DomainName.Name = "textBox_Shipment_DomainName";
            this.textBox_Shipment_DomainName.Size = new System.Drawing.Size(100, 23);
            this.textBox_Shipment_DomainName.TabIndex = 0;
            this.textBox_Shipment_DomainName.Text = "EMBDEV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Shipment Domain Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nº Shipment";
            // 
            // textBox_Shipment_Number
            // 
            this.textBox_Shipment_Number.Location = new System.Drawing.Point(150, 82);
            this.textBox_Shipment_Number.Name = "textBox_Shipment_Number";
            this.textBox_Shipment_Number.Size = new System.Drawing.Size(100, 23);
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
            this.comboBox_Travel_Status.Location = new System.Drawing.Point(150, 126);
            this.comboBox_Travel_Status.Name = "comboBox_Travel_Status";
            this.comboBox_Travel_Status.Size = new System.Drawing.Size(100, 23);
            this.comboBox_Travel_Status.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Status da Viagem";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 172);
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
            this.comboBox_Emission_Status.Location = new System.Drawing.Point(150, 169);
            this.comboBox_Emission_Status.Name = "comboBox_Emission_Status";
            this.comboBox_Emission_Status.Size = new System.Drawing.Size(100, 23);
            this.comboBox_Emission_Status.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_Taker_Xid);
            this.groupBox1.Controls.Add(this.textBox_Destination_Location_Xid);
            this.groupBox1.Controls.Add(this.textBox_Source_Location_Xid);
            this.groupBox1.Controls.Add(this.textBox_Carrier_Xid);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_Shipment_DomainName);
            this.groupBox1.Controls.Add(this.comboBox_Emission_Status);
            this.groupBox1.Controls.Add(this.textBox_Shipment_Number);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox_Travel_Status);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 235);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Planejamento do Embarque";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Xid Transportador";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(302, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Xid Origem";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(302, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Xid Destino";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(295, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Xid Tomador";
            // 
            // textBox_Carrier_Xid
            // 
            this.textBox_Carrier_Xid.Location = new System.Drawing.Point(375, 39);
            this.textBox_Carrier_Xid.Name = "textBox_Carrier_Xid";
            this.textBox_Carrier_Xid.Size = new System.Drawing.Size(171, 23);
            this.textBox_Carrier_Xid.TabIndex = 12;
            // 
            // textBox_Source_Location_Xid
            // 
            this.textBox_Source_Location_Xid.Location = new System.Drawing.Point(375, 82);
            this.textBox_Source_Location_Xid.Name = "textBox_Source_Location_Xid";
            this.textBox_Source_Location_Xid.Size = new System.Drawing.Size(171, 23);
            this.textBox_Source_Location_Xid.TabIndex = 13;
            // 
            // textBox_Destination_Location_Xid
            // 
            this.textBox_Destination_Location_Xid.Location = new System.Drawing.Point(375, 129);
            this.textBox_Destination_Location_Xid.Name = "textBox_Destination_Location_Xid";
            this.textBox_Destination_Location_Xid.Size = new System.Drawing.Size(171, 23);
            this.textBox_Destination_Location_Xid.TabIndex = 14;
            // 
            // textBox_Taker_Xid
            // 
            this.textBox_Taker_Xid.Location = new System.Drawing.Point(375, 169);
            this.textBox_Taker_Xid.Name = "textBox_Taker_Xid";
            this.textBox_Taker_Xid.Size = new System.Drawing.Size(171, 23);
            this.textBox_Taker_Xid.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maskedTextBox1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 170);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "Cidade";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(59, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "São Paulo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "Estado";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
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
            this.comboBox1.Location = new System.Drawing.Point(59, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(47, 23);
            this.comboBox1.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 15);
            this.label11.TabIndex = 22;
            this.label11.Text = "IBGE";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(59, 110);
            this.maskedTextBox1.Mask = "0000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(47, 23);
            this.maskedTextBox1.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.checkBox_Added_Tax);
            this.groupBox3.Controls.Add(this.checkBox_Tax_Included);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(593, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(383, 235);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Custo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 15);
            this.label12.TabIndex = 0;
            // 
            // checkBox_Tax_Included
            // 
            this.checkBox_Tax_Included.AutoSize = true;
            this.checkBox_Tax_Included.Location = new System.Drawing.Point(46, 30);
            this.checkBox_Tax_Included.Name = "checkBox_Tax_Included";
            this.checkBox_Tax_Included.Size = new System.Drawing.Size(111, 19);
            this.checkBox_Tax_Included.TabIndex = 2;
            this.checkBox_Tax_Included.Text = "Imposto Incluso";
            this.checkBox_Tax_Included.UseVisualStyleBackColor = true;
            this.checkBox_Tax_Included.CheckedChanged += new System.EventHandler(this.checkBox_Tax_Included_CheckedChanged);
            // 
            // checkBox_Added_Tax
            // 
            this.checkBox_Added_Tax.AutoSize = true;
            this.checkBox_Added_Tax.Location = new System.Drawing.Point(236, 30);
            this.checkBox_Added_Tax.Name = "checkBox_Added_Tax";
            this.checkBox_Added_Tax.Size = new System.Drawing.Size(117, 19);
            this.checkBox_Added_Tax.TabIndex = 3;
            this.checkBox_Added_Tax.Text = "Imposto Somado";
            this.checkBox_Added_Tax.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CostType,
            this.CostValue,
            this.AllocatedCost});
            this.dataGridView1.Location = new System.Drawing.Point(20, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(343, 150);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.button_Remove_Release_Xid);
            this.groupBox4.Controls.Add(this.button_Edit_Release_Xid);
            this.groupBox4.Controls.Add(this.button_Add_Release_Xid);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.listBox_Release_Xids);
            this.groupBox4.Controls.Add(this.listBox_Release_Refnums);
            this.groupBox4.Location = new System.Drawing.Point(218, 253);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(560, 203);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Planejamento da Ordem";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // listBox_Release_Refnums
            // 
            this.listBox_Release_Refnums.FormattingEnabled = true;
            this.listBox_Release_Refnums.ItemHeight = 15;
            this.listBox_Release_Refnums.Location = new System.Drawing.Point(306, 58);
            this.listBox_Release_Refnums.Name = "listBox_Release_Refnums";
            this.listBox_Release_Refnums.Size = new System.Drawing.Size(226, 94);
            this.listBox_Release_Refnums.TabIndex = 0;
            this.listBox_Release_Refnums.SelectedIndexChanged += new System.EventHandler(this.listBox_Release_Refnums_SelectedIndexChanged);
            // 
            // listBox_Release_Xids
            // 
            this.listBox_Release_Xids.FormattingEnabled = true;
            this.listBox_Release_Xids.ItemHeight = 15;
            this.listBox_Release_Xids.Location = new System.Drawing.Point(24, 58);
            this.listBox_Release_Xids.Name = "listBox_Release_Xids";
            this.listBox_Release_Xids.Size = new System.Drawing.Size(229, 94);
            this.listBox_Release_Xids.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(89, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 15);
            this.label13.TabIndex = 2;
            this.label13.Text = "Xid da Ordem";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(361, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 15);
            this.label14.TabIndex = 3;
            this.label14.Text = "Refnums da Ordem";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Location = new System.Drawing.Point(279, 9);
            this.label15.MinimumSize = new System.Drawing.Size(0, 200);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(2, 200);
            this.label15.TabIndex = 4;
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // button_Add_Release_Xid
            // 
            this.button_Add_Release_Xid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Add_Release_Xid.Location = new System.Drawing.Point(34, 158);
            this.button_Add_Release_Xid.Name = "button_Add_Release_Xid";
            this.button_Add_Release_Xid.Size = new System.Drawing.Size(70, 26);
            this.button_Add_Release_Xid.TabIndex = 8;
            this.button_Add_Release_Xid.Text = "Adicionar";
            this.button_Add_Release_Xid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Add_Release_Xid.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_Add_Release_Xid.UseVisualStyleBackColor = true;
            // 
            // button_Edit_Release_Xid
            // 
            this.button_Edit_Release_Xid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Edit_Release_Xid.Location = new System.Drawing.Point(116, 158);
            this.button_Edit_Release_Xid.Name = "button_Edit_Release_Xid";
            this.button_Edit_Release_Xid.Size = new System.Drawing.Size(52, 26);
            this.button_Edit_Release_Xid.TabIndex = 9;
            this.button_Edit_Release_Xid.Text = "Editar";
            this.button_Edit_Release_Xid.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_Edit_Release_Xid.UseVisualStyleBackColor = true;
            // 
            // button_Remove_Release_Xid
            // 
            this.button_Remove_Release_Xid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Remove_Release_Xid.Location = new System.Drawing.Point(178, 158);
            this.button_Remove_Release_Xid.Name = "button_Remove_Release_Xid";
            this.button_Remove_Release_Xid.Size = new System.Drawing.Size(65, 26);
            this.button_Remove_Release_Xid.TabIndex = 10;
            this.button_Remove_Release_Xid.Text = "Remover";
            this.button_Remove_Release_Xid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Remove_Release_Xid.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_Remove_Release_Xid.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(459, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 26);
            this.button1.TabIndex = 13;
            this.button1.Text = "Remover";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(397, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 26);
            this.button2.TabIndex = 12;
            this.button2.Text = "Editar";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(315, 158);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 26);
            this.button3.TabIndex = 11;
            this.button3.Text = "Adicionar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label16.Location = new System.Drawing.Point(-5, 477);
            this.label16.MaximumSize = new System.Drawing.Size(0, 2);
            this.label16.MinimumSize = new System.Drawing.Size(1000, 2);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(1000, 2);
            this.label16.TabIndex = 13;
            // 
            // button_Save
            // 
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Save.Location = new System.Drawing.Point(334, 485);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(105, 38);
            this.button_Save.TabIndex = 14;
            this.button_Save.Text = "Salvar";
            this.button_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_Save.UseVisualStyleBackColor = true;
            // 
            // button_Cancelar
            // 
            this.button_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cancelar.Location = new System.Drawing.Point(498, 485);
            this.button_Cancelar.Name = "button_Cancelar";
            this.button_Cancelar.Size = new System.Drawing.Size(105, 38);
            this.button_Cancelar.TabIndex = 15;
            this.button_Cancelar.Text = "Cancelar";
            this.button_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_Cancelar.UseVisualStyleBackColor = true;
            // 
            // ShipmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 532);
            this.Controls.Add(this.button_Cancelar);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ShipmentForm";
            this.Text = "ShipmentForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Taker_Xid;
        private System.Windows.Forms.TextBox textBox_Destination_Location_Xid;
        private System.Windows.Forms.TextBox textBox_Source_Location_Xid;
        private System.Windows.Forms.TextBox textBox_Carrier_Xid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkBox_Added_Tax;
        private System.Windows.Forms.CheckBox checkBox_Tax_Included;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewComboBoxColumn CostType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostValue;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AllocatedCost;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listBox_Release_Refnums;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox listBox_Release_Xids;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button_Add_Release_Xid;
        private System.Windows.Forms.Button button_Edit_Release_Xid;
        private System.Windows.Forms.Button button_Remove_Release_Xid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Cancelar;
    }
}