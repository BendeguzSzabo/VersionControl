namespace UserMaintenance
{
    partial class Form1
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
            this.labelFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listUsers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Location = new System.Drawing.Point(285, 37);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(46, 17);
            this.labelFullName.TabIndex = 0;
            this.labelFullName.Text = "label1";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(338, 34);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(169, 22);
            this.txtFullName.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(288, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listUsers
            // 
            this.listUsers.FormattingEnabled = true;
            this.listUsers.ItemHeight = 16;
            this.listUsers.Location = new System.Drawing.Point(12, 12);
            this.listUsers.Name = "listUsers";
            this.listUsers.Size = new System.Drawing.Size(249, 308);
            this.listUsers.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 333);
            this.Controls.Add(this.listUsers);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.labelFullName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listUsers;
    }
}

