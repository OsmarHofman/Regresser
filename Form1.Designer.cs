
namespace Regresser
{
    partial class Form1
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
            this.buttonEureka = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEureka
            // 
            this.buttonEureka.Location = new System.Drawing.Point(58, 54);
            this.buttonEureka.Name = "buttonEureka";
            this.buttonEureka.Size = new System.Drawing.Size(75, 23);
            this.buttonEureka.TabIndex = 0;
            this.buttonEureka.Text = "Eureka";
            this.buttonEureka.UseVisualStyleBackColor = true;
            this.buttonEureka.Click += new System.EventHandler(this.buttonEureka_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 148);
            this.Controls.Add(this.buttonEureka);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEureka;
    }
}

