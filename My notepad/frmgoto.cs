using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace My_notepad
{
    public partial class frmgoto : Form
    {
        Form1 frmmain;
        public frmgoto(Form1 frm)
        {
            frmmain = frm;
            InitializeComponent();
        }

        private void frmgoto_Load(object sender, EventArgs e)
        {
            txtlinenumber.Text = frmmain.getlines().ToString();
            txtlinenumber.SelectAll();
        }

        private void btngoto_Click(object sender, EventArgs e)
        {
            int n;
            n = Convert.ToInt16(txtlinenumber.Text) - 1;
            if (n > frmmain.getlines())
            {
                MessageBox.Show("Out of range.");
                txtlinenumber.SelectAll();
                txtlinenumber.Focus();
            }
            else
            {
                frmmain.gotofuction(n);
                this.Close();
            }
        }
    }
}
