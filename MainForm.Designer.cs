
namespace Regresser
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.embarqueToolStripMenuItem_Shipment = new System.Windows.Forms.ToolStripMenuItem();
            this.timeoutToolStripMenuItem_Timeout = new System.Windows.Forms.ToolStripMenuItem();
            this.divider = new System.Windows.Forms.Label();
            this.button_Remove = new System.Windows.Forms.Button();
            this.button_Move_Up = new System.Windows.Forms.Button();
            this.button_Move_Down = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.treeView_Actions = new System.Windows.Forms.TreeView();
            this.button_Send = new System.Windows.Forms.Button();
            this.button_Load = new System.Windows.Forms.Button();
            this.button_Save_JSON = new System.Windows.Forms.Button();
            this.saveFileDialog_JSON = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStrip.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.embarqueToolStripMenuItem_Shipment,
            this.timeoutToolStripMenuItem_Timeout});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(129, 48);
            // 
            // embarqueToolStripMenuItem_Shipment
            // 
            this.embarqueToolStripMenuItem_Shipment.Name = "embarqueToolStripMenuItem_Shipment";
            this.embarqueToolStripMenuItem_Shipment.Size = new System.Drawing.Size(128, 22);
            this.embarqueToolStripMenuItem_Shipment.Text = "Embarque";
            this.embarqueToolStripMenuItem_Shipment.Click += new System.EventHandler(this.embarqueToolStripMenuItem_Shipment_Click);
            // 
            // timeoutToolStripMenuItem_Timeout
            // 
            this.timeoutToolStripMenuItem_Timeout.Name = "timeoutToolStripMenuItem_Timeout";
            this.timeoutToolStripMenuItem_Timeout.Size = new System.Drawing.Size(128, 22);
            this.timeoutToolStripMenuItem_Timeout.Text = "Timeout";
            this.timeoutToolStripMenuItem_Timeout.Click += new System.EventHandler(this.timeoutToolStripMenuItem_Timeout_Click);
            // 
            // divider
            // 
            this.divider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.divider.Location = new System.Drawing.Point(12, 51);
            this.divider.MaximumSize = new System.Drawing.Size(0, 2);
            this.divider.MinimumSize = new System.Drawing.Size(0, 2);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(0, 2);
            this.divider.TabIndex = 5;
            // 
            // button_Remove
            // 
            this.button_Remove.Enabled = false;
            this.button_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Remove.Location = new System.Drawing.Point(203, 416);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(130, 40);
            this.button_Remove.TabIndex = 4;
            this.button_Remove.Text = "Remover";
            this.button_Remove.UseVisualStyleBackColor = true;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // button_Move_Up
            // 
            this.button_Move_Up.Enabled = false;
            this.button_Move_Up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Move_Up.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Move_Up.Image = global::Regresser.Properties.Resources.upload;
            this.button_Move_Up.Location = new System.Drawing.Point(371, 416);
            this.button_Move_Up.Name = "button_Move_Up";
            this.button_Move_Up.Size = new System.Drawing.Size(130, 40);
            this.button_Move_Up.TabIndex = 5;
            this.button_Move_Up.Text = "Mover ";
            this.button_Move_Up.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Move_Up.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_Move_Up.UseVisualStyleBackColor = true;
            this.button_Move_Up.Click += new System.EventHandler(this.button_Move_Up_Click);
            // 
            // button_Move_Down
            // 
            this.button_Move_Down.Enabled = false;
            this.button_Move_Down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Move_Down.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Move_Down.Image = global::Regresser.Properties.Resources.download;
            this.button_Move_Down.Location = new System.Drawing.Point(535, 416);
            this.button_Move_Down.Name = "button_Move_Down";
            this.button_Move_Down.Size = new System.Drawing.Size(130, 40);
            this.button_Move_Down.TabIndex = 6;
            this.button_Move_Down.Text = "Mover ";
            this.button_Move_Down.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Move_Down.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_Move_Down.UseVisualStyleBackColor = true;
            this.button_Move_Down.Click += new System.EventHandler(this.button_Move_Down_Click);
            // 
            // button_Add
            // 
            this.button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Add.Image = global::Regresser.Properties.Resources.add;
            this.button_Add.Location = new System.Drawing.Point(27, 416);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(130, 40);
            this.button_Add.TabIndex = 7;
            this.button_Add.Text = "Adicionar";
            this.button_Add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.treeView_Actions);
            this.panel.Controls.Add(this.button_Add);
            this.panel.Controls.Add(this.button_Move_Down);
            this.panel.Controls.Add(this.button_Remove);
            this.panel.Controls.Add(this.button_Move_Up);
            this.panel.Location = new System.Drawing.Point(12, 51);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(706, 473);
            this.panel.TabIndex = 6;
            // 
            // treeView_Actions
            // 
            this.treeView_Actions.Location = new System.Drawing.Point(16, 13);
            this.treeView_Actions.Name = "treeView_Actions";
            this.treeView_Actions.Size = new System.Drawing.Size(674, 387);
            this.treeView_Actions.TabIndex = 10;
            // 
            // button_Send
            // 
            this.button_Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Send.Location = new System.Drawing.Point(282, 5);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(130, 40);
            this.button_Send.TabIndex = 8;
            this.button_Send.Text = "Enviar";
            this.button_Send.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // button_Load
            // 
            this.button_Load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Load.Location = new System.Drawing.Point(56, 5);
            this.button_Load.Name = "button_Load";
            this.button_Load.Size = new System.Drawing.Size(130, 40);
            this.button_Load.TabIndex = 9;
            this.button_Load.Text = "Carregar JSON";
            this.button_Load.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_Load.UseVisualStyleBackColor = true;
            this.button_Load.Click += new System.EventHandler(this.button_Load_Click);
            // 
            // button_Save_JSON
            // 
            this.button_Save_JSON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Save_JSON.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Save_JSON.Location = new System.Drawing.Point(498, 5);
            this.button_Save_JSON.Name = "button_Save_JSON";
            this.button_Save_JSON.Size = new System.Drawing.Size(155, 40);
            this.button_Save_JSON.TabIndex = 10;
            this.button_Save_JSON.Text = "Salvar como JSON";
            this.button_Save_JSON.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_Save_JSON.UseVisualStyleBackColor = true;
            this.button_Save_JSON.Click += new System.EventHandler(this.button_Save_JSON_Click);
            // 
            // saveFileDialog_JSON
            // 
            this.saveFileDialog_JSON.DefaultExt = "json";
            this.saveFileDialog_JSON.FileName = "requisicoes";
            this.saveFileDialog_JSON.Filter = "Arquivos JSON (*.json)|*.json|Todos os arquivos(*.*)|*.*";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 539);
            this.Controls.Add(this.button_Save_JSON);
            this.Controls.Add(this.button_Load);
            this.Controls.Add(this.button_Send);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.divider);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(746, 578);
            this.MinimumSize = new System.Drawing.Size(746, 578);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Regresser";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.contextMenuStrip.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem embarqueToolStripMenuItem_Shipment;
        private System.Windows.Forms.ToolStripMenuItem timeoutToolStripMenuItem_Timeout;
        private System.Windows.Forms.Label divider;
        private System.Windows.Forms.Button button_Remove;
        private System.Windows.Forms.Button button_Move_Up;
        private System.Windows.Forms.Button button_Move_Down;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.Button button_Load;
        private System.Windows.Forms.TreeView treeView_Actions;
        private System.Windows.Forms.Button button_Save_JSON;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_JSON;
    }
}

