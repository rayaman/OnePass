
namespace OnePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Generate = new System.Windows.Forms.Button();
            this.passCycle = new System.Windows.Forms.NumericUpDown();
            this.passLength = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sitename = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.masterpass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.atoz = new System.Windows.Forms.Label();
            this.uAtoZ = new System.Windows.Forms.Label();
            this.numbers = new System.Windows.Forms.Label();
            this.special = new System.Windows.Forms.Label();
            this.extspc = new System.Windows.Forms.Label();
            this.help = new System.Windows.Forms.Button();
            this.save_login = new System.Windows.Forms.Button();
            this.load_login = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.passCycle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passLength)).BeginInit();
            this.SuspendLayout();
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(259, 154);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(109, 20);
            this.Generate.TabIndex = 0;
            this.Generate.Text = "Generate Password";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // passCycle
            // 
            this.passCycle.Location = new System.Drawing.Point(209, 154);
            this.passCycle.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.passCycle.Name = "passCycle";
            this.passCycle.Size = new System.Drawing.Size(45, 20);
            this.passCycle.TabIndex = 2;
            // 
            // passLength
            // 
            this.passLength.Location = new System.Drawing.Point(112, 155);
            this.passLength.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.passLength.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.passLength.Name = "passLength";
            this.passLength.Size = new System.Drawing.Size(46, 20);
            this.passLength.TabIndex = 3;
            this.passLength.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(164, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cycle:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(10, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password Length";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(5, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Site:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(3, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Login:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(3, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Master Password:";
            // 
            // sitename
            // 
            this.sitename.Location = new System.Drawing.Point(43, 6);
            this.sitename.Name = "sitename";
            this.sitename.Size = new System.Drawing.Size(321, 20);
            this.sitename.TabIndex = 9;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(43, 31);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(321, 20);
            this.username.TabIndex = 10;
            // 
            // masterpass
            // 
            this.masterpass.Location = new System.Drawing.Point(107, 56);
            this.masterpass.Name = "masterpass";
            this.masterpass.Size = new System.Drawing.Size(257, 20);
            this.masterpass.TabIndex = 11;
            this.masterpass.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(3, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Options:";
            // 
            // atoz
            // 
            this.atoz.AutoSize = true;
            this.atoz.BackColor = System.Drawing.SystemColors.Highlight;
            this.atoz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.atoz.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.atoz.Location = new System.Drawing.Point(17, 100);
            this.atoz.Name = "atoz";
            this.atoz.Size = new System.Drawing.Size(56, 39);
            this.atoz.TabIndex = 13;
            this.atoz.Text = "a-z";
            this.atoz.Click += new System.EventHandler(this.atoz_Click);
            // 
            // uAtoZ
            // 
            this.uAtoZ.AutoSize = true;
            this.uAtoZ.BackColor = System.Drawing.SystemColors.Highlight;
            this.uAtoZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uAtoZ.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.uAtoZ.Location = new System.Drawing.Point(79, 100);
            this.uAtoZ.Name = "uAtoZ";
            this.uAtoZ.Size = new System.Drawing.Size(62, 39);
            this.uAtoZ.TabIndex = 14;
            this.uAtoZ.Text = "A-Z";
            this.uAtoZ.Click += new System.EventHandler(this.uAtoZ_Click);
            // 
            // numbers
            // 
            this.numbers.AutoSize = true;
            this.numbers.BackColor = System.Drawing.SystemColors.Highlight;
            this.numbers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numbers.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.numbers.Location = new System.Drawing.Point(147, 100);
            this.numbers.Name = "numbers";
            this.numbers.Size = new System.Drawing.Size(60, 39);
            this.numbers.TabIndex = 15;
            this.numbers.Text = "0-9";
            this.numbers.Click += new System.EventHandler(this.numbers_Click);
            // 
            // special
            // 
            this.special.AutoSize = true;
            this.special.BackColor = System.Drawing.SystemColors.Highlight;
            this.special.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.special.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.special.Location = new System.Drawing.Point(213, 100);
            this.special.Name = "special";
            this.special.Size = new System.Drawing.Size(69, 39);
            this.special.TabIndex = 16;
            this.special.Text = "!@#";
            this.special.Click += new System.EventHandler(this.special_Click);
            // 
            // extspc
            // 
            this.extspc.AutoSize = true;
            this.extspc.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.extspc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.extspc.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.extspc.Location = new System.Drawing.Point(288, 100);
            this.extspc.Name = "extspc";
            this.extspc.Size = new System.Drawing.Size(76, 39);
            this.extspc.TabIndex = 17;
            this.extspc.Text = "Ext%";
            this.extspc.Click += new System.EventHandler(this.extspc_Click);
            // 
            // help
            // 
            this.help.Location = new System.Drawing.Point(370, 6);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(52, 23);
            this.help.TabIndex = 18;
            this.help.Text = "Help";
            this.help.UseVisualStyleBackColor = true;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // save_login
            // 
            this.save_login.Location = new System.Drawing.Point(370, 29);
            this.save_login.Name = "save_login";
            this.save_login.Size = new System.Drawing.Size(52, 23);
            this.save_login.TabIndex = 19;
            this.save_login.Text = "Save";
            this.save_login.UseVisualStyleBackColor = true;
            this.save_login.Click += new System.EventHandler(this.save_login_Click);
            // 
            // load_login
            // 
            this.load_login.Location = new System.Drawing.Point(370, 53);
            this.load_login.Name = "load_login";
            this.load_login.Size = new System.Drawing.Size(52, 23);
            this.load_login.TabIndex = 20;
            this.load_login.Text = "Load";
            this.load_login.UseVisualStyleBackColor = true;
            this.load_login.Click += new System.EventHandler(this.load_login_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.label7.Location = new System.Drawing.Point(370, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 39);
            this.label7.TabIndex = 21;
            this.label7.Text = "Pn";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.checkBox1.Location = new System.Drawing.Point(371, 79);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(57, 19);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "Show";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 183);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.load_login);
            this.Controls.Add(this.save_login);
            this.Controls.Add(this.help);
            this.Controls.Add(this.extspc);
            this.Controls.Add(this.special);
            this.Controls.Add(this.numbers);
            this.Controls.Add(this.uAtoZ);
            this.Controls.Add(this.atoz);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.masterpass);
            this.Controls.Add(this.username);
            this.Controls.Add(this.sitename);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passLength);
            this.Controls.Add(this.passCycle);
            this.Controls.Add(this.Generate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(442, 222);
            this.MinimumSize = new System.Drawing.Size(442, 222);
            this.Name = "Form1";
            this.Text = "OnePass V5.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.passCycle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.NumericUpDown passCycle;
        private System.Windows.Forms.NumericUpDown passLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sitename;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox masterpass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label atoz;
        private System.Windows.Forms.Label uAtoZ;
        private System.Windows.Forms.Label numbers;
        private System.Windows.Forms.Label special;
        private System.Windows.Forms.Label extspc;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.Button save_login;
        private System.Windows.Forms.Button load_login;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

