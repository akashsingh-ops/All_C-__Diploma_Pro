using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class Form1 : Form
    {
        public object resources { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }
       

        private void richTextBox1_TextChanged(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(292, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1TextChanged(object sender, EventArgs e)
        {

        }

        private void newToolStripText(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void openToolStripText(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files(.txt)|*.txt";
            ofd.Title = "Open a File....";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(ofd.FileName);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
        }
        private void SaveToolStripText(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files(.txt)|*.txt";
            sfd.Title = "Open a File....";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(sfd.FileName);
                sw.Write(richTextBox1.Text);
                sw.Close();
            }
        }

        private void SaveasToolStripText(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files(.txt)|*.txt";
            sfd.Title = "Open a File....";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(sfd.FileName);
                sw.Write(richTextBox1.Text);
                sw.Close();
            }
        }

        private void NewToolStripTExt(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void ExitToolStripText(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UndoToolStripTExt(object sender, EventArgs e)
        {
            richTextBox1.Undo();

        }

        private void ReduToolStripText(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void printToolStriptext(object sender, EventArgs e)
        {
          //  this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.printToolStripMenuItem.Text = "&Print";


        }

        private void PrintPreviewToolStripText(object sender, EventArgs e)
        {
            //this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
        }

        private void PastetoolStripTExt(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void CutToolStripText(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void CopyToolStripText(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void SelectAllToolStripText(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void Content(object sender, EventArgs e)
        {
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
        }

        private void customizeToolStrip(object sender, EventArgs e)
        {
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.customizeToolStripMenuItem.Text = "&Customize";
        }

        private void SearchToolStrip(object sender, EventArgs e)
        {
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.searchToolStripMenuItem.Text = "&Search";
        }

        private void IndexToolstrip(object sender, EventArgs e)
        {
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.indexToolStripMenuItem.Text = "&Index";
        }

        private void About(object sender, EventArgs e)
        {
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
        }

        private void Separator(object sender, EventArgs e)
        {
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(149, 6);
        }
    }

    
}
