namespace Presentation.Tree_View
{
    partial class frmWinTree
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnParent = new System.Windows.Forms.Button();
            this.btnDelSubNode = new System.Windows.Forms.Button();
            this.btnAddNode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(46, 18);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(237, 241);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "add to sel node";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnParent
            // 
            this.btnParent.Location = new System.Drawing.Point(394, 112);
            this.btnParent.Name = "btnParent";
            this.btnParent.Size = new System.Drawing.Size(103, 44);
            this.btnParent.TabIndex = 2;
            this.btnParent.Text = "find parent node";
            this.btnParent.UseVisualStyleBackColor = true;
            this.btnParent.Click += new System.EventHandler(this.btnParent_Click);
            // 
            // btnDelSubNode
            // 
            this.btnDelSubNode.Location = new System.Drawing.Point(394, 180);
            this.btnDelSubNode.Name = "btnDelSubNode";
            this.btnDelSubNode.Size = new System.Drawing.Size(103, 44);
            this.btnDelSubNode.TabIndex = 3;
            this.btnDelSubNode.Text = "del sub node";
            this.btnDelSubNode.UseVisualStyleBackColor = true;
            this.btnDelSubNode.Click += new System.EventHandler(this.btnDelSubNode_Click);
            // 
            // btnAddNode
            // 
            this.btnAddNode.Location = new System.Drawing.Point(394, 243);
            this.btnAddNode.Name = "btnAddNode";
            this.btnAddNode.Size = new System.Drawing.Size(103, 44);
            this.btnAddNode.TabIndex = 4;
            this.btnAddNode.Text = "add to sel node";
            this.btnAddNode.UseVisualStyleBackColor = true;
            this.btnAddNode.Click += new System.EventHandler(this.btnAddNode_Click);
            // 
            // frmWinTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnAddNode);
            this.Controls.Add(this.btnDelSubNode);
            this.Controls.Add(this.btnParent);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmWinTree";
            this.Text = "frmWinTree";
            this.Load += new System.EventHandler(this.frmWinTree_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnParent;
        private System.Windows.Forms.Button btnDelSubNode;
        private System.Windows.Forms.Button btnAddNode;
    }
}