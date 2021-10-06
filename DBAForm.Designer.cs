
namespace Regresser
{
    partial class DBAForm
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
            this.textBox_Server_IP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_DB_User = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_MonitoringContext = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_ShipperContext = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_PaymentContext = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Query = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.button_Cancelar = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Edit = new System.Windows.Forms.Button();
            this.button_Remove = new System.Windows.Forms.Button();
            this.textBox_DB_Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_Server_IP
            // 
            this.textBox_Server_IP.Location = new System.Drawing.Point(173, 20);
            this.textBox_Server_IP.Name = "textBox_Server_IP";
            this.textBox_Server_IP.Size = new System.Drawing.Size(220, 23);
            this.textBox_Server_IP.TabIndex = 2;
            this.textBox_Server_IP.Text = "191.238.220.133";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP do Servidor";
            // 
            // textBox_DB_User
            // 
            this.textBox_DB_User.Location = new System.Drawing.Point(173, 62);
            this.textBox_DB_User.Name = "textBox_DB_User";
            this.textBox_DB_User.Size = new System.Drawing.Size(220, 23);
            this.textBox_DB_User.TabIndex = 4;
            this.textBox_DB_User.Text = "sa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usuário do Banco";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Senha do Banco";
            // 
            // textBox_MonitoringContext
            // 
            this.textBox_MonitoringContext.Location = new System.Drawing.Point(567, 65);
            this.textBox_MonitoringContext.Name = "textBox_MonitoringContext";
            this.textBox_MonitoringContext.Size = new System.Drawing.Size(235, 23);
            this.textBox_MonitoringContext.TabIndex = 10;
            this.textBox_MonitoringContext.Text = "ShipperMonitoring";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Contexto Monitoring";
            // 
            // textBox_ShipperContext
            // 
            this.textBox_ShipperContext.Location = new System.Drawing.Point(567, 23);
            this.textBox_ShipperContext.Name = "textBox_ShipperContext";
            this.textBox_ShipperContext.Size = new System.Drawing.Size(235, 23);
            this.textBox_ShipperContext.TabIndex = 8;
            this.textBox_ShipperContext.Text = "Shipper";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(462, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Contexto Shipper";
            // 
            // textBox_PaymentContext
            // 
            this.textBox_PaymentContext.Location = new System.Drawing.Point(567, 107);
            this.textBox_PaymentContext.Name = "textBox_PaymentContext";
            this.textBox_PaymentContext.Size = new System.Drawing.Size(235, 23);
            this.textBox_PaymentContext.TabIndex = 12;
            this.textBox_PaymentContext.Text = "ShipperPayment";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(455, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Contexto Payment";
            // 
            // textBox_Query
            // 
            this.textBox_Query.Location = new System.Drawing.Point(18, 176);
            this.textBox_Query.Multiline = true;
            this.textBox_Query.Name = "textBox_Query";
            this.textBox_Query.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Query.Size = new System.Drawing.Size(526, 264);
            this.textBox_Query.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Consulta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(595, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Valores à validar:";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 15;
            this.listBox.Location = new System.Drawing.Point(577, 176);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(343, 214);
            this.listBox.TabIndex = 17;
            // 
            // button_Cancelar
            // 
            this.button_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cancelar.Location = new System.Drawing.Point(598, 486);
            this.button_Cancelar.Name = "button_Cancelar";
            this.button_Cancelar.Size = new System.Drawing.Size(105, 38);
            this.button_Cancelar.TabIndex = 19;
            this.button_Cancelar.Text = "Cancelar";
            this.button_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_Cancelar.UseVisualStyleBackColor = true;
            this.button_Cancelar.Click += new System.EventHandler(this.button_Cancelar_Click);
            // 
            // button_Save
            // 
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Save.Location = new System.Drawing.Point(415, 486);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(105, 38);
            this.button_Save.TabIndex = 18;
            this.button_Save.Text = "Salvar";
            this.button_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label16.Location = new System.Drawing.Point(-11, 467);
            this.label16.MaximumSize = new System.Drawing.Size(0, 2);
            this.label16.MinimumSize = new System.Drawing.Size(1100, 2);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(1100, 2);
            this.label16.TabIndex = 20;
            // 
            // button_Add
            // 
            this.button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Add.Location = new System.Drawing.Point(589, 406);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(100, 34);
            this.button_Add.TabIndex = 21;
            this.button_Add.Text = "Adicionar";
            this.button_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Edit
            // 
            this.button_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Edit.Location = new System.Drawing.Point(700, 406);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(100, 34);
            this.button_Edit.TabIndex = 22;
            this.button_Edit.Text = "Editar";
            this.button_Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // button_Remove
            // 
            this.button_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Remove.Location = new System.Drawing.Point(811, 406);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(100, 34);
            this.button_Remove.TabIndex = 23;
            this.button_Remove.Text = "Remover";
            this.button_Remove.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_Remove.UseVisualStyleBackColor = true;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // textBox_DB_Password
            // 
            this.textBox_DB_Password.Location = new System.Drawing.Point(173, 104);
            this.textBox_DB_Password.Name = "textBox_DB_Password";
            this.textBox_DB_Password.Size = new System.Drawing.Size(220, 23);
            this.textBox_DB_Password.TabIndex = 24;
            this.textBox_DB_Password.Text = "321";
            // 
            // DBAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 535);
            this.Controls.Add(this.textBox_DB_Password);
            this.Controls.Add(this.button_Remove);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button_Cancelar);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_Query);
            this.Controls.Add(this.textBox_PaymentContext);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_MonitoringContext);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_ShipperContext);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_DB_User);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Server_IP);
            this.Controls.Add(this.label1);
            this.Name = "DBAForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBAForm";
            this.Activated += new System.EventHandler(this.DBAForm_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Server_IP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_DB_User;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_MonitoringContext;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_ShipperContext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_PaymentContext;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Query;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button button_Cancelar;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Button button_Remove;
        private System.Windows.Forms.TextBox textBox_DB_Password;
    }
}