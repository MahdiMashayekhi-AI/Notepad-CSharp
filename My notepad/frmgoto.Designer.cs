namespace My_notepad
{
    partial class frmgoto
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
            this.btngoto = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtlinenumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btngoto
            // 
            this.btngoto.Location = new System.Drawing.Point(59, 60);
            this.btngoto.Name = "btngoto";
            this.btngoto.Size = new System.Drawing.Size(75, 23);
            this.btngoto.TabIndex = 1;
            this.btngoto.Text = "Goto";
            this.btngoto.UseVisualStyleBackColor = true;
            this.btngoto.Click += new System.EventHandler(this.btngoto_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(150, 60);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 2;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Line Number:";
            // 
            // txtlinenumber
            // 
            this.txtlinenumber.Location = new System.Drawing.Point(14, 26);
            this.txtlinenumber.Name = "txtlinenumber";
            this.txtlinenumber.Size = new System.Drawing.Size(215, 20);
            this.txtlinenumber.TabIndex = 0;
            // 
            // frmgoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 99);
            this.Controls.Add(this.txtlinenumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btngoto);
            this.Name = "frmgoto";
            this.Text = "frmgoto";
            this.Load += new System.EventHandler(this.frmgoto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngoto;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtlinenumber;
    }
}