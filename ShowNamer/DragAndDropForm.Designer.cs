namespace ShowNamer
{
    partial class DragAndDropForm
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
            this.btnClearAdd = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClearAdd
            // 
            this.btnClearAdd.Location = new System.Drawing.Point(13, 13);
            this.btnClearAdd.Name = "btnClearAdd";
            this.btnClearAdd.Size = new System.Drawing.Size(259, 50);
            this.btnClearAdd.TabIndex = 0;
            this.btnClearAdd.Text = "Clear and Add";
            this.btnClearAdd.UseVisualStyleBackColor = true;
            this.btnClearAdd.Click += new System.EventHandler(this.btnClearAdd_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 69);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(259, 50);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // DragAndDropForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 132);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClearAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DragAndDropForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Action";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClearAdd;
        private System.Windows.Forms.Button btnAdd;
    }
}