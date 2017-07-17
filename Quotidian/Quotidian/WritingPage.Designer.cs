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
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.searchBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // writingDoc
            // 
            this.writingDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.writingDoc.Location = new System.Drawing.Point(3, 2);
            this.writingDoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.writingDoc.Name = "writingDoc";
            this.writingDoc.Size = new System.Drawing.Size(774, 841);
            this.writingDoc.TabIndex = 6;
            this.writingDoc.Text = "";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(33, 59);
            this.searchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(440, 54);
            this.searchBox.TabIndex = 7;
            this.searchBox.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(3, 2);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(579, 276);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox2.Location = new System.Drawing.Point(3, 2);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(579, 276);
            this.richTextBox2.TabIndex = 12;
            this.richTextBox2.Text = "";
            // 
            // generateBibliography
            // 
            this.generateBibliography.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.generateBibliography.Location = new System.Drawing.Point(39, 507);
            this.generateBibliography.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generateBibliography.Name = "generateBibliography";
            this.generateBibliography.Size = new System.Drawing.Size(264, 62);
            this.generateBibliography.TabIndex = 13;
            this.generateBibliography.Values.Text = "Generate Bibliography";
            this.generateBibliography.Click += new System.EventHandler(this.generateBibliography_Click);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.richTextBox1);
            this.kryptonPanel1.Location = new System.Drawing.Point(33, 207);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(585, 280);
            this.kryptonPanel1.TabIndex = 14;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.richTextBox2);
            this.kryptonPanel2.Location = new System.Drawing.Point(36, 626);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(585, 280);
            this.kryptonPanel2.TabIndex = 15;
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.writingDoc);
            this.kryptonPanel3.Location = new System.Drawing.Point(725, 59);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(780, 845);
            this.kryptonPanel3.TabIndex = 16;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(494, 59);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(124, 54);
            this.searchBtn.TabIndex = 17;
            this.searchBtn.Values.Text = "Search";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(33, 164);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(171, 37);
            this.kryptonLabel1.TabIndex = 18;
            this.kryptonLabel1.Values.Text = "Search Results";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(33, 583);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(261, 37);
            this.kryptonLabel2.TabIndex = 19;
            this.kryptonLabel2.Values.Text = "Suggested Documents";
            // 
            // WritingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1540, 935);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.kryptonPanel3);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.generateBibliography);
            this.Controls.Add(this.searchBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "WritingPage";
            this.Text = "Writing Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.SetChildIndex(this.searchBox, 0);
            this.Controls.SetChildIndex(this.generateBibliography, 0);
            this.Controls.SetChildIndex(this.kryptonPanel1, 0);
            this.Controls.SetChildIndex(this.kryptonPanel2, 0);
            this.Controls.SetChildIndex(this.kryptonPanel3, 0);
            this.Controls.SetChildIndex(this.searchBtn, 0);
            this.Controls.SetChildIndex(this.kryptonLabel1, 0);
            this.Controls.SetChildIndex(this.kryptonLabel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox writingDoc;
        private System.Windows.Forms.RichTextBox searchBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton generateBibliography;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton searchBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
    }
}