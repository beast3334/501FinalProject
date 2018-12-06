using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _501FinalProject
{
    public partial class uxUserInterface : Form
    {
        Semester localSemester;
        public uxUserInterface()
        {
            InitializeComponent();
        }

        private void uxAboutMenu_Click(object sender, EventArgs e)
        {
            EventHandler Handler = new EventHandler();
            uxOutputTextbox.Text = Handler.RegisterAbout();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void localFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EventHandler Handler = new EventHandler();
            string fileName = null;
            if (uxopenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileName = uxopenFileDialog.FileName;
                uxLocalFileTextbox.Text = fileName;
            }
            localSemester = Handler.RegisterLoad(fileName);
        }

        private void kSISFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EventHandler Handler = new EventHandler();
            string fileName = null;
            if(uxopenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileName = uxopenFileDialog.FileName;
                uxKSISTextBox.Text = fileName;
            }
            List<String> output = Handler.RegisterVerify(localSemester,fileName);
            foreach(string line in output)
            {
                uxOutputTextbox.AppendText(line + "\n");
            }
        }
    }
}
