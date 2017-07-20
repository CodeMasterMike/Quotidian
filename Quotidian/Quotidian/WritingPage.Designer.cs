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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.generateBibliography = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.searchBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonSplitContainer1 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
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
            this.writingDoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.writingDoc.Name = "writingDoc";
            this.writingDoc.Size = new System.Drawing.Size(731, 1025);
            this.writingDoc.TabIndex = 6;
            this.writingDoc.Text = "";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(12, 52);
            this.searchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(440, 54);
            this.searchBox.TabIndex = 7;
            this.searchBox.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 197);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(727, 256);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(12, 95);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(727, 256);
            this.richTextBox2.TabIndex = 12;
            this.richTextBox2.Text = "";
            // 
            // generateBibliography
            // 
            this.generateBibliography.Location = new System.Drawing.Point(221, 432);
            this.generateBibliography.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generateBibliography.Name = "generateBibliography";
            this.generateBibliography.Size = new System.Drawing.Size(314, 54);
            this.generateBibliography.TabIndex = 13;
            this.generateBibliography.Values.Text = "Generate Bibliography";
            this.generateBibliography.Click += new System.EventHandler(this.generateBibliography_Click);
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.writingDoc);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 42);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(1540, 1077);
            this.kryptonPanel3.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kryptonPanel3.TabIndex = 16;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(505, 52);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(124, 54);
            this.searchBtn.TabIndex = 17;
            this.searchBtn.Values.Text = "Search";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 155);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(171, 37);
            this.kryptonLabel1.TabIndex = 18;
            this.kryptonLabel1.Values.Text = "Search Results";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(12, 53);
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
            this.kryptonSplitContainer1.Name = "kryptonSplitContainer1";
            this.kryptonSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // kryptonSplitContainer1.Panel1
            // 
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.searchBox);
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.kryptonLabel1);
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.richTextBox1);
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.searchBtn);
            this.kryptonSplitContainer1.Panel1.StateCommon.Color1 = System.Drawing.Color.LightSteelBlue;
            // 
            // kryptonSplitContainer1.Panel2
            // 
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.richTextBox2);
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.kryptonLabel2);
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.generateBibliography);
            this.kryptonSplitContainer1.Panel2.StateCommon.Color1 = System.Drawing.Color.LightSteelBlue;
            this.kryptonSplitContainer1.Size = new System.Drawing.Size(760, 1077);
            this.kryptonSplitContainer1.SplitterDistance = 575;
            this.kryptonSplitContainer1.StateCommon.Back.Color1 = System.Drawing.Color.LightSteelBlue;
            this.kryptonSplitContainer1.TabIndex = 20;
            // 
            // WritingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1540, 1119);
            this.Controls.Add(this.kryptonSplitContainer1);
            this.Controls.Add(this.kryptonPanel3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton generateBibliography;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton searchBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer1;
    }
}