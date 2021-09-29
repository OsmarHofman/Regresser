
namespace Regresser
{
    partial class DBAResultForm
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
            this.button_Save = new System.Windows.Forms.Button();
            this.textBox_ValidationValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Save
            // 
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Save.Location = new System.Drawing.Point(112, 53);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(105, 38);
            this.button_Save.TabIndex = 19;
            this.button_Save.Text = "Salvar";
            this.button_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // textBox_ValidationValue
            // 
            this.textBox_ValidationValue.Location = new System.Drawing.Point(126, 13);
            this.textBox_ValidationValue.Name = "textBox_ValidationValue";
            this.textBox_ValidationValue.Size = new System.Drawing.Size(220, 23);
            this.textBox_ValidationValue.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Valor a ser validado";
            // 
            // DBAResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 113);
            this.ControlBox = false;
            this.Controls.Add(this.textBox_ValidationValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Save);
            this.MaximumSize = new System.Drawing.Size(380, 152);
            this.MinimumSize = new System.Drawing.Size(380, 152);
            this.Name = "DBAResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBAResultForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.TextBox textBox_ValidationValue;
        private System.Windows.Forms.Label label1;
    }
}