namespace Quotidian
{
    partial class WritingPage
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
            this.writingDoc = new System.Windows.Forms.RichTextBox();
            this.searchBox = new System.Windows.Forms.RichTextBox();
            this.generateBibliography = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.searchBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonSplitContainer1 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.insertHighlightButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.highlightResults = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.viewSelectedSearchResultButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.textSearchResultsListBox = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.suggestedReadingsList = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.startTagSearch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.beginningTag = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).BeginInit();
            this.kryptonSplitContainer1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).BeginInit();
            this.kryptonSplitContainer1.Panel2.SuspendLayout();
            this.kryptonSplitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // writingDoc
            // 
            this.writingDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.writingDoc.Location = new System.Drawing.Point(784, 25);
            this.writingDoc.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.writingDoc.Name = "writingDoc";
            this.writingDoc.Size = new System.Drawing.Size(848, 1064);
            this.writingDoc.TabIndex = 6;
            this.writingDoc.Text = "";
            this.writingDoc.TextChanged += new System.EventHandler(this.writingDoc_TextChanged);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(12, 25);
            this.searchBox.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(403, 54);
            this.searchBox.TabIndex = 7;
            this.searchBox.Text = "";
            // 
            // generateBibliography
            // 
            this.generateBibliography.Location = new System.Drawing.Point(220, 431);
            this.generateBibliography.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.generateBibliography.Name = "generateBibliography";
            this.generateBibliography.Size = new System.Drawing.Size(313, 55);
            this.generateBibliography.TabIndex = 13;
            this.generateBibliography.Values.Text = "Generate Bibliography";
            this.generateBibliography.Click += new System.EventHandler(this.generateBibliography_Click);
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.writingDoc);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 42);
            this.kryptonPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(1656, 1116);
            this.kryptonPanel3.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kryptonPanel3.TabIndex = 16;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(457, 26);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(284, 55);
            this.searchBtn.TabIndex = 17;
            this.searchBtn.Values.Text = "Search";
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 155);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(188, 37);
            this.kryptonLabel1.TabIndex = 18;
            this.kryptonLabel1.Values.Text = "Reading Results";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(12, 119);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(261, 37);
            this.kryptonLabel2.TabIndex = 19;
            this.kryptonLabel2.Values.Text = "Suggested Documents";
            // 
            // kryptonSplitContainer1
            // 
            this.kryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.kryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonSplitContainer1.Location = new System.Drawing.Point(0, 42);
            this.kryptonSplitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonSplitContainer1.Name = "kryptonSplitContainer1";
            this.kryptonSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // kryptonSplitContainer1.Panel1
            // 
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.kryptonLabel3);
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.insertHighlightButton);
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.highlightResults);
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.viewSelectedSearchResultButton);
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.textSearchResultsListBox);
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.searchBox);
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.kryptonLabel1);
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.searchBtn);
            this.kryptonSplitContainer1.Panel1.StateCommon.Color1 = System.Drawing.Color.LightSteelBlue;
            // 
            // kryptonSplitContainer1.Panel2
            // 
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.suggestedReadingsList);
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.startTagSearch);
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.beginningTag);
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.kryptonLabel2);
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.generateBibliography);
            this.kryptonSplitContainer1.Panel2.StateCommon.Color1 = System.Drawing.Color.LightSteelBlue;
            this.kryptonSplitContainer1.Size = new System.Drawing.Size(760, 1116);
            this.kryptonSplitContainer1.SplitterDistance = 593;
            this.kryptonSplitContainer1.StateCommon.Back.Color1 = System.Drawing.Color.LightSteelBlue;
            this.kryptonSplitContainer1.TabIndex = 20;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(19, 389);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(199, 37);
            this.kryptonLabel3.TabIndex = 23;
            this.kryptonLabel3.Values.Text = "Highlight Results";
            // 
            // insertHighlightButton
            // 
            this.insertHighlightButton.Location = new System.Drawing.Point(399, 371);
            this.insertHighlightButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.insertHighlightButton.Name = "insertHighlightButton";
            this.insertHighlightButton.Size = new System.Drawing.Size(342, 52);
            this.insertHighlightButton.TabIndex = 22;
            this.insertHighlightButton.Values.Text = "Insert Selected Highlight";
            this.insertHighlightButton.Click += new System.EventHandler(this.insertHighlightButton_Click);
            // 
            // highlightResults
            // 
            this.highlightResults.Location = new System.Drawing.Point(19, 433);
            this.highlightResults.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.highlightResults.Name = "highlightResults";
            this.highlightResults.Size = new System.Drawing.Size(723, 144);
            this.highlightResults.TabIndex = 21;
            // 
            // viewSelectedSearchResultButton
            // 
            this.viewSelectedSearchResultButton.Location = new System.Drawing.Point(457, 138);
            this.viewSelectedSearchResultButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewSelectedSearchResultButton.Name = "viewSelectedSearchResultButton";
            this.viewSelectedSearchResultButton.Size = new System.Drawing.Size(284, 52);
            this.viewSelectedSearchResultButton.TabIndex = 20;
            this.viewSelectedSearchResultButton.Values.Text = "View Selected Result";
            this.viewSelectedSearchResultButton.Click += new System.EventHandler(this.searchResultSelected);
            // 
            // textSearchResultsListBox
            // 
            this.textSearchResultsListBox.Location = new System.Drawing.Point(19, 200);
            this.textSearchResultsListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textSearchResultsListBox.Name = "textSearchResultsListBox";
            this.textSearchResultsListBox.Size = new System.Drawing.Size(723, 161);
            this.textSearchResultsListBox.TabIndex = 19;
            // 
            // suggestedReadingsList
            // 
            this.suggestedReadingsList.Location = new System.Drawing.Point(12, 162);
            this.suggestedReadingsList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.suggestedReadingsList.Name = "suggestedReadingsList";
            this.suggestedReadingsList.Size = new System.Drawing.Size(729, 262);
            this.suggestedReadingsList.TabIndex = 28;
            // 
            // startTagSearch
            // 
            this.startTagSearch.Location = new System.Drawing.Point(457, 56);
            this.startTagSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startTagSearch.Name = "startTagSearch";
            this.startTagSearch.Size = new System.Drawing.Size(284, 55);
            this.startTagSearch.TabIndex = 27;
            this.startTagSearch.Values.Text = "Smart Lookup";
            this.startTagSearch.Click += new System.EventHandler(this.startTagSearch_Click);
            // 
            // beginningTag
            // 
            this.beginningTag.FormattingEnabled = true;
            this.beginningTag.Items.AddRange(new object[] {
            "MLA",
            "Chicago"});
            this.beginningTag.Location = new System.Drawing.Point(19, 56);
            this.beginningTag.Margin = new System.Windows.Forms.Padding(4);
            this.beginningTag.Name = "beginningTag";
            this.beginningTag.Size = new System.Drawing.Size(228, 33);
            this.beginningTag.TabIndex = 26;
            this.beginningTag.Text = "Select A Tag";
            // 
            // WritingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1656, 1158);
            this.Controls.Add(this.kryptonSplitContainer1);
            this.Controls.Add(this.kryptonPanel3);
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Name = "WritingPage";
            this.StateCommon.Back.Color1 = System.Drawing.SystemColors.GradientActiveCaption;
            this.Text = "Writing Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.SetChildIndex(this.kryptonPanel3, 0);
            this.Controls.SetChildIndex(this.kryptonSplitContainer1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).EndInit();
            this.kryptonSplitContainer1.Panel1.ResumeLayout(false);
            this.kryptonSplitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).EndInit();
            this.kryptonSplitContainer1.Panel2.ResumeLayout(false);
            this.kryptonSplitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).EndInit();
            this.kryptonSplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox writingDoc;
        private System.Windows.Forms.RichTextBox searchBox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton generateBibliography;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton searchBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer1;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox textSearchResultsListBox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton viewSelectedSearchResultButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton startTagSearch;
        private System.Windows.Forms.ComboBox beginningTag;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox suggestedReadingsList;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox highlightResults;
        private ComponentFactory.Krypton.Toolkit.KryptonButton insertHighlightButton;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
    }
}