﻿namespace Quotidian
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tagBtn = new System.Windows.Forms.Button();
            this.textBtn = new System.Windows.Forms.Button();
            this.quoteBtn = new System.Windows.Forms.Button();
            this.readingDoc = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(1297, 357);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(0, 0);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.splitContainer1.Location = new System.Drawing.Point(4, 12);
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
            this.splitContainer1.Size = new System.Drawing.Size(421, 1069);
            this.splitContainer1.SplitterDistance = 535;
            this.splitContainer1.TabIndex = 3;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBox2.Location = new System.Drawing.Point(16, 23);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(402, 523);
            this.richTextBox2.TabIndex = 6;
            this.richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBox3.Location = new System.Drawing.Point(16, 12);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(402, 500);
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
            this.panel1.Location = new System.Drawing.Point(1242, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 1073);
            this.panel1.TabIndex = 4;
            // 
            // tagBtn
            // 
            this.tagBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tagBtn.Location = new System.Drawing.Point(55, 889);
            this.tagBtn.Name = "tagBtn";
            this.tagBtn.Size = new System.Drawing.Size(118, 44);
            this.tagBtn.TabIndex = 2;
            this.tagBtn.Text = "Tag";
            this.tagBtn.UseVisualStyleBackColor = true;
            // 
            // textBtn
            // 
            this.textBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBtn.Location = new System.Drawing.Point(55, 794);
            this.textBtn.Name = "textBtn";
            this.textBtn.Size = new System.Drawing.Size(118, 44);
            this.textBtn.TabIndex = 1;
            this.textBtn.Text = "Text";
            this.textBtn.UseVisualStyleBackColor = true;
            this.textBtn.Click += new System.EventHandler(this.textBtn_Click);
            // 
            // quoteBtn
            // 
            this.quoteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quoteBtn.Location = new System.Drawing.Point(55, 695);
            this.quoteBtn.Name = "quoteBtn";
            this.quoteBtn.Size = new System.Drawing.Size(118, 44);
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
            this.readingDoc.Location = new System.Drawing.Point(457, 35);
            this.readingDoc.Name = "readingDoc";
            this.readingDoc.Size = new System.Drawing.Size(744, 1028);
            this.readingDoc.TabIndex = 5;
            this.readingDoc.Text = "";
            this.readingDoc.Click += new System.EventHandler(this.richTextBox1_Click);
            this.readingDoc.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1494, 1089);
            this.Controls.Add(this.readingDoc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Quotidian";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}

