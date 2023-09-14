namespace pryMoyaIE
{
    partial class frmArchivos
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
            this.treeViewArchivos = new System.Windows.Forms.TreeView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // treeViewArchivos
            // 
            this.treeViewArchivos.Location = new System.Drawing.Point(81, 12);
            this.treeViewArchivos.Name = "treeViewArchivos";
            this.treeViewArchivos.Size = new System.Drawing.Size(434, 168);
            this.treeViewArchivos.TabIndex = 0;
            this.treeViewArchivos.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewArchivos_AfterSelect);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(81, 186);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(434, 149);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // frmArchivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(630, 358);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.treeViewArchivos);
            this.Name = "frmArchivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informacion de Archivos";
            this.Load += new System.EventHandler(this.frmArchivos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewArchivos;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}