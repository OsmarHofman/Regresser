
namespace Regresser
{
    partial class TimeoutForm
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
            this.textBox_Valor_Timeout = new System.Windows.Forms.TextBox();
            this.label_Timeout = new System.Windows.Forms.Label();
            this.button_Ok = new System.Windows.Forms.Button();
            this.button_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Valor_Timeout
            // 
            this.textBox_Valor_Timeout.AcceptsTab = true;
            this.textBox_Valor_Timeout.Location = new System.Drawing.Point(162, 25);
            this.textBox_Valor_Timeout.Name = "textBox_Valor_Timeout";
            this.textBox_Valor_Timeout.Size = new System.Drawing.Size(110, 23);
            this.textBox_Valor_Timeout.TabIndex = 0;
            // 
            // label_Timeout
            // 
            this.label_Timeout.AutoSize = true;
            this.label_Timeout.Location = new System.Drawing.Point(34, 28);
            this.label_Timeout.Name = "label_Timeout";
            this.label_Timeout.Size = new System.Drawing.Size(122, 15);
            this.label_Timeout.TabIndex = 1;
            this.label_Timeout.Text = "Tempo de Timeout (s)";
            // 
            // button_Ok
            // 
            this.button_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Ok.Location = new System.Drawing.Point(66, 67);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(90, 26);
            this.button_Ok.TabIndex = 5;
            this.button_Ok.Text = "OK";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // button_Cancelar
            // 
            this.button_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cancelar.Location = new System.Drawing.Point(196, 67);
            this.button_Cancelar.Name = "button_Cancelar";
            this.button_Cancelar.Size = new System.Drawing.Size(90, 26);
            this.button_Cancelar.TabIndex = 6;
            this.button_Cancelar.Text = "Cancelar";
            this.button_Cancelar.UseVisualStyleBackColor = true;
            this.button_Cancelar.Click += new System.EventHandler(this.button_Cancelar_Click);
            // 
            // TimeoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 115);
            this.ControlBox = false;
            this.Controls.Add(this.button_Cancelar);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(this.label_Timeout);
            this.Controls.Add(this.textBox_Valor_Timeout);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TimeoutForm";
            this.Text = "Timeout - UserBolt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Valor_Timeout;
        private System.Windows.Forms.Label label_Timeout;
        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.Button button_Cancelar;
    }
}