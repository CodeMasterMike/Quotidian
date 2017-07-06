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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tagBtn = new System.Windows.Forms.Button();
            this.textBtn = new System.Windows.Forms.Button();
            this.quoteBtn = new System.Windows.Forms.Button();
            this.readingDoc = new System.Windows.Forms.RichTextBox();
            this.tagsListBox = new System.Windows.Forms.ListBox();
            this.tagListLabel = new System.Windows.Forms.Label();
            this.addTagButton = new System.Windows.Forms.Button();
            this.newTagTextBox = new System.Windows.Forms.TextBox();
            this.removeTagButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(649, 186);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(0, 0);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.splitContainer1.Location = new System.Drawing.Point(6, 23);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.richTextBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox3);
            this.splitContainer1.Size = new System.Drawing.Size(211, 718);
            this.splitContainer1.SplitterDistance = 260;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 3;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBox2.Location = new System.Drawing.Point(8, 15);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(203, 118);
            this.richTextBox2.TabIndex = 6;
            this.richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBox3.Location = new System.Drawing.Point(8, 15);
            this.richTextBox3.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(203, 318);
            this.richTextBox3.TabIndex = 7;
            this.richTextBox3.Text = "";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tagBtn);
            this.panel1.Controls.Add(this.textBtn);
            this.panel1.Controls.Add(this.quoteBtn);
            this.panel1.Location = new System.Drawing.Point(763, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 550);
            this.panel1.TabIndex = 4;
            // 
            // tagBtn
            // 
            this.tagBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tagBtn.Location = new System.Drawing.Point(36, 306);
            this.tagBtn.Margin = new System.Windows.Forms.Padding(2);
            this.tagBtn.Name = "tagBtn";
            this.tagBtn.Size = new System.Drawing.Size(153, 23);
            this.tagBtn.TabIndex = 2;
            this.tagBtn.Text = "Tag";
            this.tagBtn.UseVisualStyleBackColor = true;
            // 
            // textBtn
            // 
            this.textBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBtn.Location = new System.Drawing.Point(36, 257);
            this.textBtn.Margin = new System.Windows.Forms.Padding(2);
            this.textBtn.Name = "textBtn";
            this.textBtn.Size = new System.Drawing.Size(153, 23);
            this.textBtn.TabIndex = 1;
            this.textBtn.Text = "Text";
            this.textBtn.UseVisualStyleBackColor = true;
            this.textBtn.Click += new System.EventHandler(this.textBtn_Click);
            // 
            // quoteBtn
            // 
            this.quoteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quoteBtn.Location = new System.Drawing.Point(36, 205);
            this.quoteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.quoteBtn.Name = "quoteBtn";
            this.quoteBtn.Size = new System.Drawing.Size(153, 23);
            this.quoteBtn.TabIndex = 0;
            this.quoteBtn.Text = "Quote";
            this.quoteBtn.UseVisualStyleBackColor = true;
            this.quoteBtn.Click += new System.EventHandler(this.quoteBtn_Click);
            // 
            // readingDoc
            // 
            this.readingDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.readingDoc.Location = new System.Drawing.Point(221, 39);
            this.readingDoc.Margin = new System.Windows.Forms.Padding(2);
            this.readingDoc.Name = "readingDoc";
            this.readingDoc.Size = new System.Drawing.Size(526, 435);
            this.readingDoc.TabIndex = 5;
            this.readingDoc.Text = "";
            this.readingDoc.Click += new System.EventHandler(this.readingTextBox_Click);
            this.readingDoc.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // tagsListBox
            // 
            this.tagsListBox.FormattingEnabled = true;
            this.tagsListBox.Location = new System.Drawing.Point(222, 503);
            this.tagsListBox.Name = "tagsListBox";
            this.tagsListBox.Size = new System.Drawing.Size(261, 82);
            this.tagsListBox.TabIndex = 8;
            // 
            // tagListLabel
            // 
            this.tagListLabel.AutoSize = true;
            this.tagListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagListLabel.Location = new System.Drawing.Point(222, 480);
            this.tagListLabel.Name = "tagListLabel";
            this.tagListLabel.Size = new System.Drawing.Size(125, 20);
            this.tagListLabel.TabIndex = 9;
            this.tagListLabel.Text = "Reading Tags:";
            // 
            // addTagButton
            // 
            this.addTagButton.Location = new System.Drawing.Point(622, 515);
            this.addTagButton.Name = "addTagButton";
            this.addTagButton.Size = new System.Drawing.Size(75, 23);
            this.addTagButton.TabIndex = 10;
            this.addTagButton.Text = "Add Tag";
            this.addTagButton.UseVisualStyleBackColor = true;
            this.addTagButton.Click += new System.EventHandler(this.addTagButton_Click);
            // 
            // newTagTextBox
            // 
            this.newTagTextBox.Location = new System.Drawing.Point(489, 518);
            this.newTagTextBox.Name = "newTagTextBox";
            this.newTagTextBox.Size = new System.Drawing.Size(127, 20);
            this.newTagTextBox.TabIndex = 11;
            // 
            // removeTagButton
            // 
            this.removeTagButton.Location = new System.Drawing.Point(489, 544);
            this.removeTagButton.Name = "removeTagButton";
            this.removeTagButton.Size = new System.Drawing.Size(208, 23);
            this.removeTagButton.TabIndex = 12;
            this.removeTagButton.Text = "Remove Selected Tag";
            this.removeTagButton.UseVisualStyleBackColor = true;
            // 
            // ReadingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(985, 597);
            this.Controls.Add(this.removeTagButton);
            this.Controls.Add(this.newTagTextBox);
            this.Controls.Add(this.addTagButton);
            this.Controls.Add(this.tagListLabel);
            this.Controls.Add(this.tagsListBox);
            this.Controls.Add(this.readingDoc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ReadingPage";
            this.Text = "Quotidian";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.splitContainer1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.readingDoc, 0);
            this.Controls.SetChildIndex(this.tagsListBox, 0);
            this.Controls.SetChildIndex(this.tagListLabel, 0);
            this.Controls.SetChildIndex(this.addTagButton, 0);
            this.Controls.SetChildIndex(this.newTagTextBox, 0);
            this.Controls.SetChildIndex(this.removeTagButton, 0);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button tagBtn;
        private System.Windows.Forms.Button textBtn;
        private System.Windows.Forms.Button quoteBtn;
        private System.Windows.Forms.RichTextBox readingDoc;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.ListBox tagsListBox;
        private System.Windows.Forms.Label tagListLabel;
        private System.Windows.Forms.Button addTagButton;
        private System.Windows.Forms.TextBox newTagTextBox;
        private System.Windows.Forms.Button removeTagButton;
    }
}

