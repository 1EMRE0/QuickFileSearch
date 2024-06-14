using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickFileSearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.ShowDialog();
            txtDirectory.Text = dlg.SelectedPath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           var files= System.IO.Directory.GetFiles(txtDirectory.Text, "."+comboBox1.Text, System.IO.SearchOption.AllDirectories);
            lstFiles.DataSource= files;
            MessageBox.Show(files.Count()+" " + "Dosya bulundu");
        }

        private void txtDirectory_TextChanged(object sender, EventArgs e)
        {

        }

        


    }
}
