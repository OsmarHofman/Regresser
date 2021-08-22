
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
            this.button_Save.Location = new System.Drawing.Point(98, 72);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(56, 26);
            this.button_Save.TabIndex = 15;
            this.button_Save.Text = "Salvar";
            this.button_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // ReleaseXidForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 111);
            this.ControlBox = false;
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Release_Xid);
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
    }
}