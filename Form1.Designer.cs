
namespace CheckListBoxTest
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Original ");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("The Next Generation");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Voyager");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Deep Space Nine");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Enterprise");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Discovery");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Strange New Worlds");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Star Trek", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.displaylistBox = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Lieutenant Ohura",
            "Diana Troy",
            "Seven of Nine",
            "T\'Pol Vulcaness",
            "Michael Burnham",
            "Nurse Chapel"});
            this.checkedListBox1.Location = new System.Drawing.Point(13, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(379, 424);
            this.checkedListBox1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.checkedListBox1, "Women of Star Trek");
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // displaylistBox
            // 
            this.displaylistBox.FormattingEnabled = true;
            this.displaylistBox.Location = new System.Drawing.Point(398, 13);
            this.displaylistBox.MaximumSize = new System.Drawing.Size(172, 424);
            this.displaylistBox.MinimumSize = new System.Drawing.Size(172, 424);
            this.displaylistBox.Name = "displaylistBox";
            this.displaylistBox.Size = new System.Drawing.Size(172, 420);
            this.displaylistBox.TabIndex = 1;
            this.toolTip1.SetToolTip(this.displaylistBox, "Your favorite women of Star Trek");
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(589, 64);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(199, 24);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.toolTip1.SetToolTip(this.addButton, "Add to Women of Star Trek");
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(589, 94);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(199, 24);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "Remove";
            this.toolTip1.SetToolTip(this.removeButton, "Remove from Women of Star Trek");
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(589, 124);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(199, 24);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.toolTip1.SetToolTip(this.clearButton, "Remove from Women of Star Trek");
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(589, 154);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(199, 24);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.toolTip1.SetToolTip(this.exitButton, "Remove from Women of Star Trek");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(589, 13);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(199, 20);
            this.inputTextBox.TabIndex = 3;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(589, 185);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Original";
            treeNode1.Text = "Original ";
            treeNode2.Name = "TheNextGeneration";
            treeNode2.Text = "The Next Generation";
            treeNode3.Name = "Voyager";
            treeNode3.Text = "Voyager";
            treeNode4.Name = "DeepSpaceNine";
            treeNode4.Text = "Deep Space Nine";
            treeNode5.Name = "Enterprise";
            treeNode5.Text = "Enterprise";
            treeNode6.Name = "Discovery";
            treeNode6.Text = "Discovery";
            treeNode7.Name = "StrangeNewWorlds";
            treeNode7.Text = "Strange New Worlds";
            treeNode8.Name = "StarTrekNode";
            treeNode8.Text = "Star Trek";
            treeNode8.ToolTipText = "All Star Trek series fall below ";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8});
            this.treeView1.Size = new System.Drawing.Size(199, 248);
            this.treeView1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.displaylistBox);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ListBox displaylistBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button exitButton;
        protected System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TreeView treeView1;
    }
}

