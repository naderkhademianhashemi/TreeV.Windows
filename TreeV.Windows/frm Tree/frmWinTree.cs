using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentation.Tree_View
{
    public partial class frmWinTree : Form
    {
        TreeNode tnRoot;
        public frmWinTree()
        {
            InitializeComponent();
        }

        private void RemoveChildren(TreeNode tn)
        {
            try
            {
                while (tn != null && (tn.Nodes.Count > 0))
                {
                    TreeNode tnChild = tn.Nodes[0];

                    if (tnChild.Nodes.Count == 0)
                        RemoveNode(tnChild);
                    else
                        RemoveChildren(tnChild);
                }

                RemoveNode(tn);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void RemoveNode(TreeNode tnChild)
        {
            try
            {
                if (tnChild == null)
                    return;
                tnChild.Remove();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void frmWinTree_Load(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            TreeNode RND = new TreeNode();
            RND.Text = "root";
            treeView1.Nodes.Add(RND);

            var lst = new List<string>() { "1", "2" };
            foreach (var item in lst)
            {
                TreeNode ND = new TreeNode();
                ND.Text = item;
                ND.Tag = item;
                RND.Nodes.Add(ND);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TreeNode selNode = treeView1.SelectedNode;
            TreeNode tnGroup = new TreeNode();
            tnGroup.Text = "new";
            selNode.Nodes.Add(tnGroup);
        }

        private void btnParent_Click(object sender, EventArgs e)
        {
            var ParentNode = treeView1.SelectedNode.Parent;
            MessageBox.Show(ParentNode.Text);
        }

        private void btnDelSubNode_Click(object sender, EventArgs e)
        {
            RemoveChildren(treeView1.SelectedNode);
        }

        private void btnMoveLeft_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddNode_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Nodes.Insert(0, "123");
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var tag = e.Node.Tag;
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            MessageBox.Show(e.Node.Text);
        }
    }
}
