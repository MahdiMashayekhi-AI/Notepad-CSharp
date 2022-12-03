namespace My_notepad
{
    partial class Frmfind
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
            this.btnclose = new System.Windows.Forms.Button();
            this.btnfind = new System.Windows.Forms.Button();
            this.txtfind = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkmachcase = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdodown = new System.Windows.Forms.RadioButton();
            this.rdoup = new System.Windows.Forms.RadioButton();
            this.btnfindnext = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(264, 71);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 0;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnfind
            // 
            this.btnfind.Location = new System.Drawing.Point(264, 12);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(75, 23);
            this.btnfind.TabIndex = 1;
            this.btnfind.Text = "Find";
            this.btnfind.UseVisualStyleBackColor = true;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // txtfind
            // 
            this.txtfind.Location = new System.Drawing.Point(77, 19);
            this.txtfind.Name = "txtfind";
            this.txtfind.Size = new System.Drawing.Size(165, 20);
            this.txtfind.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "What Find:";
            // 
            // chkmachcase
            // 
            this.chkmachcase.AutoSize = true;
            this.chkmachcase.Location = new System.Drawing.Point(15, 77);
            this.chkmachcase.Name = "chkmachcase";
            this.chkmachcase.Size = new System.Drawing.Size(80, 17);
            this.chkmachcase.TabIndex = 4;
            this.chkmachcase.Text = "Mach Case";
            this.chkmachcase.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdodown);
            this.groupBox1.Controls.Add(this.rdoup);
            this.groupBox1.Location = new System.Drawing.Point(101, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 43);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Direction";
            // 
            // rdodown
            // 
            this.rdodown.AutoSize = true;
            this.rdodown.Checked = true;
            this.rdodown.Location = new System.Drawing.Point(69, 19);
            this.rdodown.Name = "rdodown";
            this.rdodown.Size = new System.Drawing.Size(53, 17);
            this.rdodown.TabIndex = 6;
            this.rdodown.TabStop = true;
            this.rdodown.Text = "Down";
            this.rdodown.UseVisualStyleBackColor = true;
            // 
            // rdoup
            // 
            this.rdoup.AutoSize = true;
            this.rdoup.Location = new System.Drawing.Point(6, 19);
            this.rdoup.Name = "rdoup";
            this.rdoup.Size = new System.Drawing.Size(39, 17);
            this.rdoup.TabIndex = 7;
            this.rdoup.Text = "Up";
            this.rdoup.UseVisualStyleBackColor = true;
            // 
            // btnfindnext
            // 
            this.btnfindnext.Location = new System.Drawing.Point(264, 42);
            this.btnfindnext.Name = "btnfindnext";
            this.btnfindnext.Size = new System.Drawing.Size(75, 23);
            this.btnfindnext.TabIndex = 6;
            this.btnfindnext.Text = "FindNext";
            this.btnfindnext.UseVisualStyleBackColor = true;
            this.btnfindnext.Click += new System.EventHandler(this.btnfindnext_Click);
            // 
            // Frmfind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 116);
            this.Controls.Add(this.btnfindnext);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkmachcase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfind);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.btnclose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Frmfind";
            this.Text = "Frmfind";
            this.Load += new System.EventHandler(this.Frmfind_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnfindnext;
        protected System.Windows.Forms.Button btnclose;
        protected System.Windows.Forms.TextBox txtfind;
        protected System.Windows.Forms.CheckBox chkmachcase;
        protected System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.RadioButton rdodown;
        protected System.Windows.Forms.RadioButton rdoup;
    }
}