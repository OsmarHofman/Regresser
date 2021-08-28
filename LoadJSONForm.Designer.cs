
namespace Regresser
{
    partial class LoadJSONForm
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
            this.button_Load = new System.Windows.Forms.Button();
            this.textBox_File_Path = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.listBox_JSON_Logs = new System.Windows.Forms.ListBox();
            this.button_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Load
            // 
            this.button_Load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Load.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Load.Location = new System.Drawing.Point(12, 12);
            this.button_Load.Name = "button_Load";
            this.button_Load.Size = new System.Drawing.Size(108, 33);
            this.button_Load.TabIndex = 10;
            this.button_Load.Text = "Carregar JSON...";
            this.button_Load.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_Load.UseVisualStyleBackColor = true;
            this.button_Load.Click += new System.EventHandler(this.button_Load_Click);
            // 
            // textBox_File_Path
            // 
            this.textBox_File_Path.Enabled = false;
            this.textBox_File_Path.Location = new System.Drawing.Point(136, 18);
            this.textBox_File_Path.Name = "textBox_File_Path";
            this.textBox_File_Path.Size = new System.Drawing.Size(497, 23);
            this.textBox_File_Path.TabIndex = 11;
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "json";
            this.openFileDialog.Filter = "Arquivos JSON (*.json)|*.json|Todos os arquivos(*.*)|*.*";
            // 
            // listBox_JSON_Logs
            // 
            this.listBox_JSON_Logs.FormattingEnabled = true;
            this.listBox_JSON_Logs.ItemHeight = 15;
            this.listBox_JSON_Logs.Location = new System.Drawing.Point(12, 51);
            this.listBox_JSON_Logs.Name = "listBox_JSON_Logs";
            this.listBox_JSON_Logs.Size = new System.Drawing.Size(776, 139);
            this.listBox_JSON_Logs.TabIndex = 12;
            this.listBox_JSON_Logs.TabStop = false;
            // 
            // button_Close
            // 
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Close.Location = new System.Drawing.Point(654, 12);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(108, 33);
            this.button_Close.TabIndex = 13;
            this.button_Close.Text = "Fechar";
            this.button_Close.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // LoadJSONForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 201);
            this.ControlBox = false;
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.listBox_JSON_Logs);
            this.Controls.Add(this.textBox_File_Path);
            this.Controls.Add(this.button_Load);
            this.Name = "LoadJSONForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carregar JSON";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Load;
        private System.Windows.Forms.TextBox textBox_File_Path;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ListBox listBox_JSON_Logs;
        private System.Windows.Forms.Button button_Close;
    }
}