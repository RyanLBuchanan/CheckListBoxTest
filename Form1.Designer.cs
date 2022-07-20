
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
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Original ");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("The Next Generation");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Voyager");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Deep Space Nine");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Enterprise");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Discovery");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Strange New Worlds");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Star Trek", new System.Windows.Forms.TreeNode[] {
            treeNode33,
            treeNode34,
            treeNode35,
            treeNode36,
            treeNode37,
            treeNode38,
            treeNode39});
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.displaylistBox = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.colorTabPage = new System.Windows.Forms.TabPage();
            this.sizeTabPage = new System.Windows.Forms.TabPage();
            this.messageTabPage = new System.Windows.Forms.TabPage();
            this.aboutTabPage = new System.Windows.Forms.TabPage();
            this.blackRadioButton = new System.Windows.Forms.RadioButton();
            this.redRadioButton = new System.Windows.Forms.RadioButton();
            this.greenRadioButton = new System.Windows.Forms.RadioButton();
            this.size12RadioButton = new System.Windows.Forms.RadioButton();
            this.size16RadioButton = new System.Windows.Forms.RadioButton();
            this.size20RadioButton = new System.Windows.Forms.RadioButton();
            this.helloRadioButton = new System.Windows.Forms.RadioButton();
            this.goodbyeRadioButton = new System.Windows.Forms.RadioButton();
            this.displayLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.colorTabPage.SuspendLayout();
            this.sizeTabPage.SuspendLayout();
            this.messageTabPage.SuspendLayout();
            this.aboutTabPage.SuspendLayout();
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
            this.checkedListBox1.Size = new System.Drawing.Size(379, 274);
            this.checkedListBox1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.checkedListBox1, "Women of Star Trek");
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // displaylistBox
            // 
            this.displaylistBox.FormattingEnabled = true;
            this.displaylistBox.Location = new System.Drawing.Point(398, 13);
            this.displaylistBox.Name = "displaylistBox";
            this.displaylistBox.Size = new System.Drawing.Size(172, 277);
            this.displaylistBox.TabIndex = 1;
            this.toolTip1.SetToolTip(this.displaylistBox, "Your favorite women of Star Trek");
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(589, 53);
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
            this.removeButton.Location = new System.Drawing.Point(589, 83);
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
            this.clearButton.Location = new System.Drawing.Point(589, 113);
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
            this.exitButton.Location = new System.Drawing.Point(589, 143);
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
            treeNode33.Name = "Original";
            treeNode33.Text = "Original ";
            treeNode34.Name = "TheNextGeneration";
            treeNode34.Text = "The Next Generation";
            treeNode35.Name = "Voyager";
            treeNode35.Text = "Voyager";
            treeNode36.Name = "DeepSpaceNine";
            treeNode36.Text = "Deep Space Nine";
            treeNode37.Name = "Enterprise";
            treeNode37.Text = "Enterprise";
            treeNode38.Name = "Discovery";
            treeNode38.Text = "Discovery";
            treeNode39.Name = "StrangeNewWorlds";
            treeNode39.Text = "Strange New Worlds";
            treeNode40.Name = "StarTrekNode";
            treeNode40.Text = "Star Trek";
            treeNode40.ToolTipText = "All Star Trek series fall below ";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode40});
            this.treeView1.Size = new System.Drawing.Size(199, 248);
            this.treeView1.TabIndex = 7;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.colorTabPage);
            this.tabControl1.Controls.Add(this.sizeTabPage);
            this.tabControl1.Controls.Add(this.messageTabPage);
            this.tabControl1.Controls.Add(this.aboutTabPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 302);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 100);
            this.tabControl1.TabIndex = 8;
            // 
            // colorTabPage
            // 
            this.colorTabPage.Controls.Add(this.greenRadioButton);
            this.colorTabPage.Controls.Add(this.redRadioButton);
            this.colorTabPage.Controls.Add(this.blackRadioButton);
            this.colorTabPage.Location = new System.Drawing.Point(4, 22);
            this.colorTabPage.Name = "colorTabPage";
            this.colorTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.colorTabPage.Size = new System.Drawing.Size(192, 74);
            this.colorTabPage.TabIndex = 0;
            this.colorTabPage.Text = "Color";
            this.colorTabPage.UseVisualStyleBackColor = true;
            // 
            // sizeTabPage
            // 
            this.sizeTabPage.Controls.Add(this.size20RadioButton);
            this.sizeTabPage.Controls.Add(this.size16RadioButton);
            this.sizeTabPage.Controls.Add(this.size12RadioButton);
            this.sizeTabPage.Location = new System.Drawing.Point(4, 22);
            this.sizeTabPage.Name = "sizeTabPage";
            this.sizeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.sizeTabPage.Size = new System.Drawing.Size(192, 74);
            this.sizeTabPage.TabIndex = 1;
            this.sizeTabPage.Text = "Size";
            this.sizeTabPage.UseVisualStyleBackColor = true;
            // 
            // messageTabPage
            // 
            this.messageTabPage.Controls.Add(this.goodbyeRadioButton);
            this.messageTabPage.Controls.Add(this.helloRadioButton);
            this.messageTabPage.Location = new System.Drawing.Point(4, 22);
            this.messageTabPage.Name = "messageTabPage";
            this.messageTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.messageTabPage.Size = new System.Drawing.Size(192, 74);
            this.messageTabPage.TabIndex = 2;
            this.messageTabPage.Text = "Message";
            this.messageTabPage.UseVisualStyleBackColor = true;
            // 
            // aboutTabPage
            // 
            this.aboutTabPage.Controls.Add(this.label1);
            this.aboutTabPage.Location = new System.Drawing.Point(4, 22);
            this.aboutTabPage.Name = "aboutTabPage";
            this.aboutTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.aboutTabPage.Size = new System.Drawing.Size(192, 74);
            this.aboutTabPage.TabIndex = 3;
            this.aboutTabPage.Text = "About";
            this.aboutTabPage.UseVisualStyleBackColor = true;
            // 
            // blackRadioButton
            // 
            this.blackRadioButton.AutoSize = true;
            this.blackRadioButton.Location = new System.Drawing.Point(7, 7);
            this.blackRadioButton.Name = "blackRadioButton";
            this.blackRadioButton.Size = new System.Drawing.Size(52, 17);
            this.blackRadioButton.TabIndex = 0;
            this.blackRadioButton.TabStop = true;
            this.blackRadioButton.Text = "Black";
            this.blackRadioButton.UseVisualStyleBackColor = true;
            this.blackRadioButton.CheckedChanged += new System.EventHandler(this.blackRadioButton_CheckedChanged);
            // 
            // redRadioButton
            // 
            this.redRadioButton.AutoSize = true;
            this.redRadioButton.Location = new System.Drawing.Point(7, 30);
            this.redRadioButton.Name = "redRadioButton";
            this.redRadioButton.Size = new System.Drawing.Size(45, 17);
            this.redRadioButton.TabIndex = 1;
            this.redRadioButton.TabStop = true;
            this.redRadioButton.Text = "Red";
            this.redRadioButton.UseVisualStyleBackColor = true;
            this.redRadioButton.CheckedChanged += new System.EventHandler(this.redRadioButton_CheckedChanged);
            // 
            // greenRadioButton
            // 
            this.greenRadioButton.AutoSize = true;
            this.greenRadioButton.Location = new System.Drawing.Point(7, 53);
            this.greenRadioButton.Name = "greenRadioButton";
            this.greenRadioButton.Size = new System.Drawing.Size(54, 17);
            this.greenRadioButton.TabIndex = 2;
            this.greenRadioButton.TabStop = true;
            this.greenRadioButton.Text = "Green";
            this.greenRadioButton.UseVisualStyleBackColor = true;
            this.greenRadioButton.CheckedChanged += new System.EventHandler(this.greenRadioButton_CheckedChanged);
            // 
            // size12RadioButton
            // 
            this.size12RadioButton.AutoSize = true;
            this.size12RadioButton.Location = new System.Drawing.Point(7, 8);
            this.size12RadioButton.Name = "size12RadioButton";
            this.size12RadioButton.Size = new System.Drawing.Size(63, 17);
            this.size12RadioButton.TabIndex = 0;
            this.size12RadioButton.TabStop = true;
            this.size12RadioButton.Text = "12 point";
            this.size12RadioButton.UseVisualStyleBackColor = true;
            this.size12RadioButton.CheckedChanged += new System.EventHandler(this.size12RadioButton_CheckedChanged);
            // 
            // size16RadioButton
            // 
            this.size16RadioButton.AutoSize = true;
            this.size16RadioButton.Location = new System.Drawing.Point(7, 31);
            this.size16RadioButton.Name = "size16RadioButton";
            this.size16RadioButton.Size = new System.Drawing.Size(63, 17);
            this.size16RadioButton.TabIndex = 1;
            this.size16RadioButton.TabStop = true;
            this.size16RadioButton.Text = "16 point";
            this.size16RadioButton.UseVisualStyleBackColor = true;
            this.size16RadioButton.CheckedChanged += new System.EventHandler(this.size16RadioButton_CheckedChanged);
            // 
            // size20RadioButton
            // 
            this.size20RadioButton.AutoSize = true;
            this.size20RadioButton.Location = new System.Drawing.Point(7, 51);
            this.size20RadioButton.Name = "size20RadioButton";
            this.size20RadioButton.Size = new System.Drawing.Size(63, 17);
            this.size20RadioButton.TabIndex = 2;
            this.size20RadioButton.TabStop = true;
            this.size20RadioButton.Text = "20 point";
            this.size20RadioButton.UseVisualStyleBackColor = true;
            this.size20RadioButton.CheckedChanged += new System.EventHandler(this.size20RadioButton_CheckedChanged);
            // 
            // helloRadioButton
            // 
            this.helloRadioButton.AutoSize = true;
            this.helloRadioButton.Location = new System.Drawing.Point(7, 7);
            this.helloRadioButton.Name = "helloRadioButton";
            this.helloRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.helloRadioButton.Size = new System.Drawing.Size(52, 17);
            this.helloRadioButton.TabIndex = 0;
            this.helloRadioButton.TabStop = true;
            this.helloRadioButton.Text = "Hello!";
            this.helloRadioButton.UseVisualStyleBackColor = true;
            this.helloRadioButton.CheckedChanged += new System.EventHandler(this.helloRadioButton_CheckedChanged);
            // 
            // goodbyeRadioButton
            // 
            this.goodbyeRadioButton.AutoSize = true;
            this.goodbyeRadioButton.Location = new System.Drawing.Point(7, 31);
            this.goodbyeRadioButton.Name = "goodbyeRadioButton";
            this.goodbyeRadioButton.Size = new System.Drawing.Size(71, 17);
            this.goodbyeRadioButton.TabIndex = 1;
            this.goodbyeRadioButton.TabStop = true;
            this.goodbyeRadioButton.Text = "Goodbye!";
            this.goodbyeRadioButton.UseVisualStyleBackColor = true;
            this.goodbyeRadioButton.CheckedChanged += new System.EventHandler(this.goodbyeRadioButton_CheckedChanged);
            // 
            // displayLabel
            // 
            this.displayLabel.AutoSize = true;
            this.displayLabel.Location = new System.Drawing.Point(20, 420);
            this.displayLabel.MaximumSize = new System.Drawing.Size(192, 30);
            this.displayLabel.MinimumSize = new System.Drawing.Size(192, 30);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(192, 30);
            this.displayLabel.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tabs are use to organize \r\ncontrols and conserve \r\nscreen space.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 601);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.tabControl1);
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
            this.tabControl1.ResumeLayout(false);
            this.colorTabPage.ResumeLayout(false);
            this.colorTabPage.PerformLayout();
            this.sizeTabPage.ResumeLayout(false);
            this.sizeTabPage.PerformLayout();
            this.messageTabPage.ResumeLayout(false);
            this.messageTabPage.PerformLayout();
            this.aboutTabPage.ResumeLayout(false);
            this.aboutTabPage.PerformLayout();
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage colorTabPage;
        private System.Windows.Forms.RadioButton greenRadioButton;
        private System.Windows.Forms.RadioButton redRadioButton;
        private System.Windows.Forms.RadioButton blackRadioButton;
        private System.Windows.Forms.TabPage sizeTabPage;
        private System.Windows.Forms.TabPage messageTabPage;
        private System.Windows.Forms.TabPage aboutTabPage;
        private System.Windows.Forms.RadioButton size20RadioButton;
        private System.Windows.Forms.RadioButton size16RadioButton;
        private System.Windows.Forms.RadioButton size12RadioButton;
        private System.Windows.Forms.RadioButton goodbyeRadioButton;
        private System.Windows.Forms.RadioButton helloRadioButton;
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.Label label1;
    }
}

