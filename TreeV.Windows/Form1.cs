using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TreeV.Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string GetPath()
        {
            var path = string.Empty;
            var fdlg = new OpenFileDialog();
            if (fdlg.ShowDialog() == DialogResult.OK)
                path = fdlg.FileName;
            return path;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void AddNodeToLevelZ(TreeNode nd, string path)
        {
            var directories = System.IO.Directory.GetDirectories(path);
            foreach (var item in directories)
            {
                TreeNode node = new TreeNode();
                node.Text = item;
                node.Tag = item;

                nd.Nodes.Add(node);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = GetPath();
        }

        private void btnFillTree_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            var directories = System.IO.Directory.GetDirectories(
            Directory.GetParent(textBox1.Text).ToString()
                );

            foreach (var item in directories)
            {
                TreeNode node = new TreeNode();
                node.Text = item;
                node.Tag = item;

                AddNodeToLevelZ(node, item);

                treeView1.Nodes.Add(node);
            }
        }
    }
}
