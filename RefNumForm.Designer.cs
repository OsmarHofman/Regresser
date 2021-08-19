
namespace Regresser
{
    partial class RefNumForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RefNumForm));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Refnum_Key = new System.Windows.Forms.TextBox();
            this.textBox_Refnum_Value = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textBox_Refnum_Key
            // 
            resources.ApplyResources(this.textBox_Refnum_Key, "textBox_Refnum_Key");
            this.textBox_Refnum_Key.Name = "textBox_Refnum_Key";
            // 
            // textBox_Refnum_Value
            // 
            resources.ApplyResources(this.textBox_Refnum_Value, "textBox_Refnum_Value");
            this.textBox_Refnum_Value.Name = "textBox_Refnum_Value";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // button_Save
            // 
            resources.ApplyResources(this.button_Save, "button_Save");
            this.button_Save.Name = "button_Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // RefNumForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.textBox_Refnum_Value);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Refnum_Key);
            this.Controls.Add(this.label1);
            this.Name = "RefNumForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Refnum_Key;
        private System.Windows.Forms.TextBox textBox_Refnum_Value;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Save;
    }
}