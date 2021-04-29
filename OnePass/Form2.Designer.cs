
namespace OnePass
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Logins = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.select_login = new System.Windows.Forms.Button();
            this.remove_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Logins
            // 
            this.Logins.FormattingEnabled = true;
            this.Logins.Location = new System.Drawing.Point(13, 26);
            this.Logins.Name = "Logins";
            this.Logins.Size = new System.Drawing.Size(296, 121);
            this.Logins.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(13, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(296, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Select a Stored Login";
            // 
            // select_login
            // 
            this.select_login.Location = new System.Drawing.Point(13, 153);
            this.select_login.Name = "select_login";
            this.select_login.Size = new System.Drawing.Size(132, 23);
            this.select_login.TabIndex = 2;
            this.select_login.Text = "Select Login Info";
            this.select_login.UseVisualStyleBackColor = true;
            this.select_login.Click += new System.EventHandler(this.select_login_Click);
            // 
            // remove_login
            // 
            this.remove_login.Location = new System.Drawing.Point(177, 153);
            this.remove_login.Name = "remove_login";
            this.remove_login.Size = new System.Drawing.Size(132, 23);
            this.remove_login.TabIndex = 3;
            this.remove_login.Text = "Delete Login Info";
            this.remove_login.UseVisualStyleBackColor = true;
            this.remove_login.Click += new System.EventHandler(this.remove_login_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 182);
            this.Controls.Add(this.remove_login);
            this.Controls.Add(this.select_login);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Logins);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(337, 221);
            this.MinimumSize = new System.Drawing.Size(337, 221);
            this.Name = "Form2";
            this.Text = "Saved Logins";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Logins;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button select_login;
        private System.Windows.Forms.Button remove_login;
    }
}