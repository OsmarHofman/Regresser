
namespace Regresser
{
    partial class ReleaseXidForm
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
            this.textBox_Release_Xid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Save = new System.Windows.Forms.Button();
            this.checkBox_DestinationToggle = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_DestinationLocationXid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_Release_Xid
            // 
            this.textBox_Release_Xid.Location = new System.Drawing.Point(98, 30);
            this.textBox_Release_Xid.Name = "textBox_Release_Xid";
            this.textBox_Release_Xid.Size = new System.Drawing.Size(160, 23);
            this.textBox_Release_Xid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Xid da Ordem";
            // 
            // button_Save
            // 
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Save.Location = new System.Drawing.Point(115, 152);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(56, 26);
            this.button_Save.TabIndex = 15;
            this.button_Save.Text = "Salvar";
            this.button_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // checkBox_DestinationToggle
            // 
            this.checkBox_DestinationToggle.AutoSize = true;
            this.checkBox_DestinationToggle.Location = new System.Drawing.Point(12, 71);
            this.checkBox_DestinationToggle.Name = "checkBox_DestinationToggle";
            this.checkBox_DestinationToggle.Size = new System.Drawing.Size(286, 19);
            this.checkBox_DestinationToggle.TabIndex = 16;
            this.checkBox_DestinationToggle.Text = "Usar a location de destino diferente do embarque";
            this.checkBox_DestinationToggle.UseVisualStyleBackColor = true;
            this.checkBox_DestinationToggle.CheckedChanged += new System.EventHandler(this.checkBox_DestinationToggle_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Xid da Location";
            // 
            // textBox_DestinationLocationXid
            // 
            this.textBox_DestinationLocationXid.Enabled = false;
            this.textBox_DestinationLocationXid.Location = new System.Drawing.Point(98, 106);
            this.textBox_DestinationLocationXid.Name = "textBox_DestinationLocationXid";
            this.textBox_DestinationLocationXid.Size = new System.Drawing.Size(160, 23);
            this.textBox_DestinationLocationXid.TabIndex = 17;
            // 
            // ReleaseXidForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 194);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_DestinationLocationXid);
            this.Controls.Add(this.checkBox_DestinationToggle);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Release_Xid);
            this.MaximumSize = new System.Drawing.Size(330, 233);
            this.MinimumSize = new System.Drawing.Size(330, 233);
            this.Name = "ReleaseXidForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xid da Ordem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Release_Xid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.CheckBox checkBox_DestinationToggle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_DestinationLocationXid;
    }
}