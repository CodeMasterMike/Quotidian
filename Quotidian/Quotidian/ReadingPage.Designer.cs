namespace Quotidian
{
    partial class ReadingPage
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.readingDoc = new System.Windows.Forms.RichTextBox();
            this.tagsListBox = new System.Windows.Forms.ListBox();
            this.tagListLabel = new System.Windows.Forms.Label();
            this.newTagTextBox = new System.Windows.Forms.TextBox();
            this.kryptonSplitContainer1 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.removeTagButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.addTagButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.textBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.quoteBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).BeginInit();
            this.kryptonSplitContainer1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).BeginInit();
            this.kryptonSplitContainer1.Panel2.SuspendLayout();
            this.kryptonSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(974, 286);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(0, 0);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(10, 15);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(241, 434);
            this.richTextBox2.TabIndex = 6;
            this.richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(10, 15);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(241, 434);
            this.richTextBox3.TabIndex = 7;
            this.richTextBox3.Text = "";
            // 
            // readingDoc
            // 
            this.readingDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.readingDoc.Location = new System.Drawing.Point(270, 13);
            this.readingDoc.Name = "readingDoc";
            this.readingDoc.ReadOnly = true;
            this.readingDoc.Size = new System.Drawing.Size(937, 691);
            this.readingDoc.TabIndex = 5;
            this.readingDoc.Text = "";
            this.readingDoc.Click += new System.EventHandler(this.readingTextBox_Click);
            this.readingDoc.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // tagsListBox
            // 
            this.tagsListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tagsListBox.FormattingEnabled = true;
            this.tagsListBox.ItemHeight = 20;
            this.tagsListBox.Location = new System.Drawing.Point(296, 60);
            this.tagsListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tagsListBox.Name = "tagsListBox";
            this.tagsListBox.Size = new System.Drawing.Size(527, 124);
            this.tagsListBox.TabIndex = 8;
            this.tagsListBox.SelectedIndexChanged += new System.EventHandler(this.tagsListBox_SelectedIndexChanged);
            // 
            // tagListLabel
            // 
            this.tagListLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tagListLabel.AutoSize = true;
            this.tagListLabel.BackColor = System.Drawing.Color.Transparent;
            this.tagListLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagListLabel.Location = new System.Drawing.Point(291, 26);
            this.tagListLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tagListLabel.Name = "tagListLabel";
            this.tagListLabel.Size = new System.Drawing.Size(176, 29);
            this.tagListLabel.TabIndex = 9;
            this.tagListLabel.Text = "Reading Tags:";
            // 
            // newTagTextBox
            // 
            this.newTagTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newTagTextBox.Location = new System.Drawing.Point(870, 78);
            this.newTagTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newTagTextBox.Name = "newTagTextBox";
            this.newTagTextBox.Size = new System.Drawing.Size(188, 26);
            this.newTagTextBox.TabIndex = 11;
            // 
            // kryptonSplitContainer1
            // 
            this.kryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.kryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonSplitContainer1.Location = new System.Drawing.Point(0, 33);
            this.kryptonSplitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonSplitContainer1.Name = "kryptonSplitContainer1";
            this.kryptonSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // kryptonSplitContainer1.Panel1
            // 
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.richTextBox2);
            this.kryptonSplitContainer1.Panel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            // 
            // kryptonSplitContainer1.Panel2
            // 
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.richTextBox3);
            this.kryptonSplitContainer1.Panel2.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kryptonSplitContainer1.Size = new System.Drawing.Size(267, 924);
            this.kryptonSplitContainer1.SplitterDistance = 452;
            this.kryptonSplitContainer1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kryptonSplitContainer1.TabIndex = 13;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonPanel3);
            this.kryptonPanel1.Controls.Add(this.readingDoc);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 33);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1478, 924);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kryptonPanel1.TabIndex = 14;
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.removeTagButton);
            this.kryptonPanel3.Controls.Add(this.tagListLabel);
            this.kryptonPanel3.Controls.Add(this.addTagButton);
            this.kryptonPanel3.Controls.Add(this.tagsListBox);
            this.kryptonPanel3.Controls.Add(this.newTagTextBox);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 707);
            this.kryptonPanel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(1478, 217);
            this.kryptonPanel3.StateCommon.Color1 = System.Drawing.Color.LightSteelBlue;
            this.kryptonPanel3.TabIndex = 16;
            // 
            // removeTagButton
            // 
            this.removeTagButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.removeTagButton.Location = new System.Drawing.Point(870, 131);
            this.removeTagButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.removeTagButton.Name = "removeTagButton";
            this.removeTagButton.Size = new System.Drawing.Size(325, 44);
            this.removeTagButton.TabIndex = 17;
            this.removeTagButton.Values.Text = "Remove Selected Tag";
            // 
            // addTagButton
            // 
            this.addTagButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addTagButton.Location = new System.Drawing.Point(1075, 67);
            this.addTagButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addTagButton.Name = "addTagButton";
            this.addTagButton.Size = new System.Drawing.Size(119, 47);
            this.addTagButton.TabIndex = 17;
            this.addTagButton.Values.Text = "Add Tag";
            this.addTagButton.Click += new System.EventHandler(this.addTagButton_Click_1);
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.textBtn);
            this.kryptonPanel2.Controls.Add(this.quoteBtn);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonPanel2.Location = new System.Drawing.Point(1211, 33);
            this.kryptonPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(267, 924);
            this.kryptonPanel2.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kryptonPanel2.StateCommon.Color2 = System.Drawing.Color.White;
            this.kryptonPanel2.TabIndex = 15;
            // 
            // textBtn
            // 
            this.textBtn.Location = new System.Drawing.Point(53, 456);
            this.textBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBtn.Name = "textBtn";
            this.textBtn.Size = new System.Drawing.Size(164, 65);
            this.textBtn.TabIndex = 4;
            this.textBtn.Values.Text = "Text";
            this.textBtn.Click += new System.EventHandler(this.textBtn_Click);
            // 
            // quoteBtn
            // 
            this.quoteBtn.Location = new System.Drawing.Point(53, 288);
            this.quoteBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quoteBtn.Name = "quoteBtn";
            this.quoteBtn.Size = new System.Drawing.Size(164, 65);
            this.quoteBtn.TabIndex = 3;
            this.quoteBtn.Values.Text = "Quote";
            this.quoteBtn.Click += new System.EventHandler(this.quoteBtn_Click);
            // 
            // ReadingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1478, 957);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonSplitContainer1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.kryptonPanel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "ReadingPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Back.Color1 = System.Drawing.SystemColors.GradientActiveCaption;
            this.Text = "Quotidian";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.SetChildIndex(this.kryptonPanel1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.kryptonSplitContainer1, 0);
            this.Controls.SetChildIndex(this.kryptonPanel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).EndInit();
            this.kryptonSplitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).EndInit();
            this.kryptonSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).EndInit();
            this.kryptonSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            this.kryptonPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox readingDoc;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.ListBox tagsListBox;
        private System.Windows.Forms.Label tagListLabel;
        private System.Windows.Forms.TextBox newTagTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton quoteBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton textBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton addTagButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton removeTagButton;
    }
}

