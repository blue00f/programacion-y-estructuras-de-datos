namespace Ejemplo04
{
    partial class frmNodos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TreeNode treeNode5 = new TreeNode("Documentos");
            TreeNode treeNode6 = new TreeNode("Imágenes");
            TreeNode treeNode7 = new TreeNode("Música");
            TreeNode treeNode8 = new TreeNode("Videos");
            treeView1 = new TreeView();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(33, 74);
            treeView1.Name = "treeView1";
            treeNode5.Name = "Nodo1";
            treeNode5.Text = "Documentos";
            treeNode6.Name = "Nodo2";
            treeNode6.Text = "Imágenes";
            treeNode7.Name = "Nodo0";
            treeNode7.Text = "Música";
            treeNode8.Name = "Nodo3";
            treeNode8.Text = "Videos";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode5, treeNode6, treeNode7, treeNode8 });
            treeView1.Size = new Size(203, 247);
            treeView1.TabIndex = 0;
            treeView1.AfterSelect += treeView1_AfterSelect;
            treeView1.NodeMouseClick += treeView1_NodeMouseClick;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(280, 77);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(343, 244);
            listBox1.TabIndex = 1;
            // 
            // frmNodos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 403);
            Controls.Add(listBox1);
            Controls.Add(treeView1);
            Name = "frmNodos";
            Text = "Manejo básico de nodos usando treeView";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeView1;
        private ListBox listBox1;
    }
}
