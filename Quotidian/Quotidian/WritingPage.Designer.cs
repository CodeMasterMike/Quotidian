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
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.generateBibliography = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.searchBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonSplitContainer1 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.textSearchResultsListBox = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.viewSelectedSearchResultButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
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
            this.writingDoc.Location = new System.Drawing.Point(523, 16);
            this.writingDoc.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.writingDoc.Name = "writingDoc";
            this.writingDoc.Size = new System.Drawing.Size(489, 609);
            this.writingDoc.TabIndex = 6;
            this.writingDoc.Text = "";
            this.writingDoc.TextChanged += new System.EventHandler(this.writingDoc_TextChanged);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(8, 16);
            this.searchBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(270, 36);
            this.searchBox.TabIndex = 7;
            this.searchBox.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(8, 61);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(486, 165);
            this.richTextBox2.TabIndex = 12;
            this.richTextBox2.Text = "";
            // 
            // generateBibliography
            // 
            this.generateBibliography.Location = new System.Drawing.Point(147, 276);
            this.generateBibliography.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.generateBibliography.Name = "generateBibliography";
            this.generateBibliography.Size = new System.Drawing.Size(209, 35);
            this.generateBibliography.TabIndex = 13;
            this.generateBibliography.Values.Text = "Generate Bibliography";
            this.generateBibliography.Click += new System.EventHandler(this.generateBibliography_Click);
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.writingDoc);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 28);
            this.kryptonPanel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(1027, 641);
            this.kryptonPanel3.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kryptonPanel3.StateCommon.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPanel3.TabIndex = 16;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(305, 17);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(189, 35);
            this.searchBtn.TabIndex = 17;
            this.searchBtn.Values.Text = "Search";
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(8, 99);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(109, 24);
            this.kryptonLabel1.TabIndex = 18;
            this.kryptonLabel1.Values.Text = "Search Results";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(8, 34);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(166, 24);
            this.kryptonLabel2.TabIndex = 19;
            this.kryptonLabel2.Values.Text = "Suggested Documents";
            // 
            // kryptonSplitContainer1
            // 
            this.kryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.kryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonSplitContainer1.Location = new System.Drawing.Point(0, 28);
            this.kryptonSplitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonSplitContainer1.Name = "kryptonSplitContainer1";
            this.kryptonSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // kryptonSplitContainer1.Panel1
            // 
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.viewSelectedSearchResultButton);
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.textSearchResultsListBox);
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.searchBox);
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.kryptonLabel1);
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.searchBtn);
            this.kryptonSplitContainer1.Panel1.StateCommon.Color1 = System.Drawing.Color.LightSteelBlue;
            this.kryptonSplitContainer1.Panel1.StateCommon.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            // 
            // kryptonSplitContainer1.Panel2
            // 
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.richTextBox2);
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.kryptonLabel2);
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.generateBibliography);
            this.kryptonSplitContainer1.Panel2.StateCommon.Color1 = System.Drawing.Color.LightSteelBlue;
            this.kryptonSplitContainer1.Panel2.StateCommon.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonSplitContainer1.Size = new System.Drawing.Size(507, 641);
            this.kryptonSplitContainer1.SplitterDistance = 342;
            this.kryptonSplitContainer1.StateCommon.Back.Color1 = System.Drawing.Color.LightSteelBlue;
            this.kryptonSplitContainer1.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonSplitContainer1.TabIndex = 20;
            // 
            // textSearchResultsListBox
            // 
            this.textSearchResultsListBox.Location = new System.Drawing.Point(12, 128);
            this.textSearchResultsListBox.Name = "textSearchResultsListBox";
            this.textSearchResultsListBox.Size = new System.Drawing.Size(482, 200);
            this.textSearchResultsListBox.TabIndex = 19;
            // 
            // viewSelectedSearchResultButton
            // 
            this.viewSelectedSearchResultButton.Location = new System.Drawing.Point(305, 88);
            this.viewSelectedSearchResultButton.Name = "viewSelectedSearchResultButton";
            this.viewSelectedSearchResultButton.Size = new System.Drawing.Size(189, 34);
            this.viewSelectedSearchResultButton.TabIndex = 20;
            this.viewSelectedSearchResultButton.Values.Text = "View Selected Result";
            this.viewSelectedSearchResultButton.Click += new System.EventHandler(this.searchResultSelected);
            // 
            // WritingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1027, 669);
            this.Controls.Add(this.kryptonSplitContainer1);
            this.Controls.Add(this.kryptonPanel3);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "WritingPage";
            this.StateCommon.Back.Color1 = System.Drawing.SystemColors.GradientActiveCaption;
            this.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
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
        private System.Windows.Forms.RichTextBox richTextBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton generateBibliography;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton searchBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer1;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox textSearchResultsListBox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton viewSelectedSearchResultButton;
    }
}