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
    public partial class Frmfind : Form
    {
        Form1 frmmain;
        public Frmfind(Form1 frm)
        {
            frmmain = frm;
            InitializeComponent();
        }
        public Frmfind()
        {
          
            InitializeComponent();
        }


        private void btnfind_Click(object sender, EventArgs e)
        {
           // frmmain.Text = "aa";
            //frmmain.txtnotepad.Text = "ali";
            frmmain.Findfunction(txtfind.Text);
        }

        private void btnfindnext_Click(object sender, EventArgs e)
        {
            StringComparison a = StringComparison.OrdinalIgnoreCase;
            if (chkmachcase.Checked == true)
                a = StringComparison.Ordinal;
                     
            frmmain.FindNextfunction(txtfind.Text,a,rdodown.Checked);
          //  frmmain.FindNextfunction(txtfind.Text, a, rdodown.Checked);
            //frmmain.FindNextfunction(txtfind.Text);
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frmfind_Load(object sender, EventArgs e)
        {

        }
    }
}
