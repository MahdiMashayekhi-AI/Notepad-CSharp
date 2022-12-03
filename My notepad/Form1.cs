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
    
    public partial class Form1 : Form
    {
         public string fn;
        Boolean saveflag;
        MyUndo notepadUndo = new MyUndo();
        public Form1()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void foreColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.FullOpen = true;
            colorDialog1.ShowDialog();
            txtnotepad.ForeColor = colorDialog1.Color;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void Setbk(object sender, EventArgs e)
        {
            txtnotepad.BackColor = Color.FromName(((ToolStripMenuItem)sender).Text);
            foreach (ToolStripMenuItem x in backColorToolStripMenuItem.DropDownItems)
                if (x.Text== ((ToolStripMenuItem)sender).Text)
                    x.Checked = true;
                else
                    x.Checked = false;
        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusbar1.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void formatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = txtnotepad.Font;
            fontDialog1.ShowDialog();
            txtnotepad.Font = fontDialog1.Font;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string[] a = new string[5];
            a[0] = txtnotepad.BackColor.Name;
            a[1] = txtnotepad.Font.Name;
            a[2] = txtnotepad.Font.Size.ToString();
            a[3] = this.Height.ToString();
            a[4] = this.Width.ToString();
            System.IO.File.WriteAllLines(@"c:\c", a);
            //System.IO.File.WriteAllText(@"c:\layout.txt",txtnotepad.BackColor.Name);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] x = new string[5];
            if (System.IO.File.Exists("D:\\layout.txt")==true)
            {

               x= System.IO.File.ReadAllLines(@"c:\layout.txt");
                ToolStripMenuItem temp = new ToolStripMenuItem();
                temp.Text = x[0];
               // txtnotepad.BackColor = Color.FromName(s);
                Setbk(temp, null);
                //txtnotepad.Font = new Font(x[1], Convert.ToInt16(x[2]));
                //this.Height = Convert.ToInt16(x[3]);
                //this.Width = Convert.ToInt16(x[4]);
                saveflag = true;
            }
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtnotepad.WordWrap = wordWrapToolStripMenuItem.Checked;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fn == null)
            {
                DialogResult x;
                saveFileDialog1.DefaultExt = "txt";
                x=saveFileDialog1.ShowDialog();
                if (x == DialogResult.Cancel)
                    return;
                fn = saveFileDialog1.FileName;
            }
            System.IO.File.WriteAllText(fn, txtnotepad.Text);
            saveflag = true;
            this.Text = fn;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveflag != true)
            {
                DialogResult r;
                r=MessageBox.Show("Do you want to save?", "Save...", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                    saveToolStripMenuItem_Click(null, null);
            }
            txtnotepad.Text = "";
            this.Text = "My Notepad";
            saveflag = true;
            fn = null;
        }

        private void txtnotepad_TextChanged(object sender, EventArgs e)
        {
            saveflag = false;
            setrowcol();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newToolStripMenuItem_Click(null, null);
            openFileDialog1.Filter = "Text File|*.txt|Document File|*.doc|All Files|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            fn = openFileDialog1.FileName;
            txtnotepad.Text = System.IO.File.ReadAllText(fn);
            saveflag = true;
            this.Text = fn;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            newToolStripMenuItem_Click(null, null);
}

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fn = null;
            saveToolStripMenuItem_Click(null, null);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtnotepad.SelectedText);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtnotepad.SelectedText = Clipboard.GetText();
        }

        private void delToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtnotepad.SelectedText = "";
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copyToolStripMenuItem_Click(null, null);
            delToolStripMenuItem_Click(null, null);
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtnotepad.SelectAll();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmfind f1 = new Frmfind(this);
            f1.Show(this);
        }

         public Boolean Findfunction(string s)
         {
             int i;
             i=txtnotepad.Text.IndexOf(s);
             if (i == -1)
             {
                 MessageBox.Show("Not Found");
                 return false;
             }
             else
             {
                 txtnotepad.SelectionStart = i;
                 txtnotepad.SelectionLength = s.Length;
                 txtnotepad.Focus();
                 return true;
             
             }
        
        }
        /// <summary>
        /// متدی برای جستجوی در جعبه متن
        /// </summary>
        /// <param name="s"> رشته مورد جستجو</param>
        /// <param name="compairtype">نوع مقایسه</param>
        /// <param name="righttoleft">نوع مقایسه</param>
        /// <returns></returns>
         public Boolean FindNextfunction(string s , StringComparison compairtype=StringComparison.OrdinalIgnoreCase, Boolean righttoleft=true)
         {
             int i=0;
             if(righttoleft==true)
             i = txtnotepad.Text.IndexOf(s, txtnotepad.SelectionStart + 1, compairtype);
             else
                 i = txtnotepad.Text.LastIndexOf(s, txtnotepad.SelectionStart - 1, compairtype);

             if (i == -1)
             {
                 MessageBox.Show("Not Found");
                 return false;
             }
             else
             {
                 txtnotepad.SelectionStart = i;
                 txtnotepad.SelectionLength = s.Length;
                 txtnotepad.Focus();
                 return true;

             }

         }

         private void undoToolStripMenuItem_Click(object sender, EventArgs e)
         {
             txtnotepad.Text = notepadUndo.Undo();
         }

         private void redoToolStripMenuItem_Click(object sender, EventArgs e)
         {
             txtnotepad.Text = notepadUndo.Redo();
         }

         private void Form1_KeyUp(object sender, KeyEventArgs e)
         {
             notepadUndo.settext(txtnotepad.Text);
         }

         private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
         {
             Frmreplace f = new Frmreplace(this);
             f.Show(this);
         }
    /// <summary>
    /// متدی برای جایگزین کردن متن انتخاب شده
    /// </summary>
    /// <param name="str">رشته مورد نظر کهمی خواهیم جایگزین متن انتخاب شده شود</param>
    public void replacefunction(string str){
        if (txtnotepad.SelectionLength > 0)
            txtnotepad.SelectedText = str;

}
        /// <summary>
        /// متدی برای جاگزینی همه موارد یافت شده
        /// </summary>
        /// <param name="str1">رشته مورد جستجو</param>
        /// <param name="str2">رشته جایگزین</param>
        /// <param name="cmptype">نوع مقایسه</param>
        /// <param name="lefttoright">جهت مقایسه</param>
    public void replaceallfuction(string str1, string str2, StringComparison cmptype, Boolean lefttoright) { 
    
    while( FindNextfunction(str1,cmptype,lefttoright))
        replacefunction(str2);
    
    }

    private void gotoToolStripMenuItem_Click(object sender, EventArgs e)
    {
        frmgoto f = new frmgoto(this);
        f.ShowDialog();
        
    }
        /// <summary>
        /// متدی برای برگرداندن تعداد خطوط جعبه متن
        /// </summary>
        /// <returns></returns>
    public int getlines() {

        return txtnotepad.Lines.Count();
    
    }
        public void gotofuction(int x)
        {
            txtnotepad.SelectionStart = txtnotepad.GetFirstCharIndexFromLine(x);
        
        }

        public void setrowcol() {
            int row = txtnotepad.GetLineFromCharIndex(txtnotepad.SelectionStart)+1;
            int col = txtnotepad.SelectionStart - txtnotepad.GetFirstCharIndexOfCurrentLine() + 1;
            lblrowcol.Text = "Ln " + row.ToString() + ", Col " + col.ToString();
        
        }

        private void txtnotepad_Click(object sender, EventArgs e)
        {
            setrowcol();
        }

        private void txtnotepad_KeyUp(object sender, KeyEventArgs e)
        {
            setrowcol();
        }

        private void txtnotepad_KeyDown(object sender, KeyEventArgs e)
        {
            //setrowcol();
        }

        public void setenables() {

            copyToolStripMenuItem.Enabled = Convert.ToBoolean(txtnotepad.SelectionLength);
            cutToolStripMenuItem.Enabled = txtnotepad.SelectionLength > 0;
            delToolStripMenuItem.Enabled = txtnotepad.SelectionLength > 0;
            pasteToolStripMenuItem.Enabled = Clipboard.ContainsText();
            findToolStripMenuItem.Enabled = txtnotepad.Text.Length > 0;
            gotoToolStripMenuItem.Enabled = txtnotepad.TextLength > 0;
            saveToolStripMenuItem.Enabled = !saveflag;
        }

        private void fileToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            setenables();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult x;
            printDialog1.Document = printDocument1;
            x=printDialog1.ShowDialog();
            if (x == DialogResult.OK)
                printDocument1.Print();


        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtnotepad.Text, txtnotepad.Font, Brushes.Black, 0, 0);
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
    public class MyUndo
    {
        string[] temp = new string[100];
        int index;
        int currentposition;
        public MyUndo()
        {
            index = 0;
            currentposition = 0;

        }

        public void settext(string s)
        {
            temp[index] = s;
            currentposition = index;
            ++index;

        }
        public string Undo()
        {
            if (currentposition > 0)
                return temp[--currentposition];
            return null;

        }

        public string Redo()
        {
            if (currentposition < index)
                return temp[++currentposition];
            return null;


        }
    } //end of MyUndo class
}
