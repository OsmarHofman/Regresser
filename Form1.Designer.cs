
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
            this.components = new System.ComponentModel.Container();
            this.buttonEureka = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_Porta_Tms = new System.Windows.Forms.Label();
            this.listBox_Actions = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Mover_Baixo = new System.Windows.Forms.Button();
            this.button_Mover_Cima = new System.Windows.Forms.Button();
            this.button_Remover = new System.Windows.Forms.Button();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.embarqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divider = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEureka
            // 
            this.buttonEureka.Location = new System.Drawing.Point(272, 661);
            this.buttonEureka.Name = "buttonEureka";
            this.buttonEureka.Size = new System.Drawing.Size(75, 23);
            this.buttonEureka.TabIndex = 0;
            this.buttonEureka.Text = "Eureka";
            this.buttonEureka.UseVisualStyleBackColor = true;
            this.buttonEureka.Click += new System.EventHandler(this.buttonEureka_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 23);
            this.textBox1.TabIndex = 1;
            // 
            // label_Porta_Tms
            // 
            this.label_Porta_Tms.AutoSize = true;
            this.label_Porta_Tms.Location = new System.Drawing.Point(30, 20);
            this.label_Porta_Tms.Name = "label_Porta_Tms";
            this.label_Porta_Tms.Size = new System.Drawing.Size(78, 15);
            this.label_Porta_Tms.TabIndex = 2;
            this.label_Porta_Tms.Text = "Porta do TMS";
            // 
            // listBox_Actions
            // 
            this.listBox_Actions.FormattingEnabled = true;
            this.listBox_Actions.ItemHeight = 15;
            this.listBox_Actions.Items.AddRange(new object[] {
            "Item 1",
            "Item 2"});
            this.listBox_Actions.Location = new System.Drawing.Point(3, 3);
            this.listBox_Actions.Name = "listBox_Actions";
            this.listBox_Actions.Size = new System.Drawing.Size(232, 394);
            this.listBox_Actions.TabIndex = 3;
            this.listBox_Actions.SelectedIndexChanged += new System.EventHandler(this.listBox_Actions_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Location = new System.Drawing.Point(12, 60);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button_Add);
            this.splitContainer1.Panel2.Controls.Add(this.button_Mover_Baixo);
            this.splitContainer1.Panel2.Controls.Add(this.button_Mover_Cima);
            this.splitContainer1.Panel2.Controls.Add(this.button_Remover);
            this.splitContainer1.Panel2.Controls.Add(this.listBox_Actions);
            this.splitContainer1.Panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitContainer1.Size = new System.Drawing.Size(620, 490);
            this.splitContainer1.SplitterDistance = 378;
            this.splitContainer1.TabIndex = 4;
            // 
            // button_Add
            // 
            this.button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Add.Image = global::Regresser.Properties.Resources.add;
            this.button_Add.Location = new System.Drawing.Point(13, 403);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(90, 26);
            this.button_Add.TabIndex = 7;
            this.button_Add.Text = "Adicionar";
            this.button_Add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Mover_Baixo
            // 
            this.button_Mover_Baixo.Enabled = false;
            this.button_Mover_Baixo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Mover_Baixo.Image = global::Regresser.Properties.Resources.download;
            this.button_Mover_Baixo.Location = new System.Drawing.Point(133, 450);
            this.button_Mover_Baixo.Name = "button_Mover_Baixo";
            this.button_Mover_Baixo.Size = new System.Drawing.Size(90, 26);
            this.button_Mover_Baixo.TabIndex = 6;
            this.button_Mover_Baixo.Text = "Mover ";
            this.button_Mover_Baixo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Mover_Baixo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_Mover_Baixo.UseVisualStyleBackColor = true;
            this.button_Mover_Baixo.Click += new System.EventHandler(this.button_Mover_Baixo_Click);
            // 
            // button_Mover_Cima
            // 
            this.button_Mover_Cima.Enabled = false;
            this.button_Mover_Cima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Mover_Cima.Image = global::Regresser.Properties.Resources.upload;
            this.button_Mover_Cima.Location = new System.Drawing.Point(133, 403);
            this.button_Mover_Cima.Name = "button_Mover_Cima";
            this.button_Mover_Cima.Size = new System.Drawing.Size(90, 26);
            this.button_Mover_Cima.TabIndex = 5;
            this.button_Mover_Cima.Text = "Mover ";
            this.button_Mover_Cima.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Mover_Cima.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_Mover_Cima.UseVisualStyleBackColor = true;
            this.button_Mover_Cima.Click += new System.EventHandler(this.button_Mover_Cima_Click);
            // 
            // button_Remover
            // 
            this.button_Remover.Enabled = false;
            this.button_Remover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Remover.Location = new System.Drawing.Point(13, 452);
            this.button_Remover.Name = "button_Remover";
            this.button_Remover.Size = new System.Drawing.Size(90, 26);
            this.button_Remover.TabIndex = 4;
            this.button_Remover.Text = "Remover";
            this.button_Remover.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.embarqueToolStripMenuItem,
            this.timeoutToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(129, 48);
            // 
            // embarqueToolStripMenuItem
            // 
            this.embarqueToolStripMenuItem.Name = "embarqueToolStripMenuItem";
            this.embarqueToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.embarqueToolStripMenuItem.Text = "Embarque";
            // 
            // timeoutToolStripMenuItem
            // 
            this.timeoutToolStripMenuItem.Name = "timeoutToolStripMenuItem";
            this.timeoutToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.timeoutToolStripMenuItem.Text = "Timeout";
            // 
            // divider
            // 
            this.divider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.divider.Location = new System.Drawing.Point(12, 51);
            this.divider.MaximumSize = new System.Drawing.Size(0, 2);
            this.divider.MinimumSize = new System.Drawing.Size(0, 2);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(620, 2);
            this.divider.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 696);
            this.Controls.Add(this.divider);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label_Porta_Tms);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonEureka);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Regresser";
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEureka;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_Porta_Tms;
        private System.Windows.Forms.ListBox listBox_Actions;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button_Mover_Baixo;
        private System.Windows.Forms.Button button_Mover_Cima;
        private System.Windows.Forms.Button button_Remover;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem embarqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeoutToolStripMenuItem;
        private System.Windows.Forms.Label divider;
    }
}

