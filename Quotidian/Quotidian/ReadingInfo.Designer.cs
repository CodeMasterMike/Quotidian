﻿namespace Quotidian
{
    partial class ReadingInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.docTitleBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tagsBox = new System.Windows.Forms.RichTextBox();
            this.firstBox = new System.Windows.Forms.RichTextBox();
            this.dateBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.publisherBox = new System.Windows.Forms.RichTextBox();
            this.nextBtn = new System.Windows.Forms.Button();
            this.middleNameBox = new System.Windows.Forms.Label();
            this.middleBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lastBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Document Title";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // docTitleBox
            // 
            this.docTitleBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.docTitleBox.Location = new System.Drawing.Point(521, 90);
            this.docTitleBox.Name = "docTitleBox";
            this.docTitleBox.Size = new System.Drawing.Size(512, 54);
            this.docTitleBox.TabIndex = 1;
            this.docTitleBox.Text = "";
            this.docTitleBox.TextChanged += new System.EventHandler(this.docTitleBox_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 31);
            this.label2.TabIndex = 14;
            this.label2.Text = "Author First";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 632);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 31);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tags (Comma Separated)";
            // 
            // tagsBox
            // 
            this.tagsBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tagsBox.Location = new System.Drawing.Point(521, 622);
            this.tagsBox.Name = "tagsBox";
            this.tagsBox.Size = new System.Drawing.Size(512, 54);
            this.tagsBox.TabIndex = 5;
            this.tagsBox.Text = "";
            // 
            // firstBox
            // 
            this.firstBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.firstBox.Location = new System.Drawing.Point(521, 223);
            this.firstBox.Name = "firstBox";
            this.firstBox.Size = new System.Drawing.Size(512, 54);
            this.firstBox.TabIndex = 2;
            this.firstBox.Text = "";
            // 
            // dateBox
            // 
            this.dateBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateBox.Location = new System.Drawing.Point(521, 888);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(512, 54);
            this.dateBox.TabIndex = 7;
            this.dateBox.Text = "";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(98, 898);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(395, 31);
            this.label4.TabIndex = 19;
            this.label4.Text = "Date Published (MM/DD/YYYY)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(231, 765);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 31);
            this.label5.TabIndex = 20;
            this.label5.Text = "Publisher";
            // 
            // publisherBox
            // 
            this.publisherBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.publisherBox.Location = new System.Drawing.Point(521, 755);
            this.publisherBox.Name = "publisherBox";
            this.publisherBox.Size = new System.Drawing.Size(512, 54);
            this.publisherBox.TabIndex = 6;
            this.publisherBox.Text = "";
            // 
            // nextBtn
            // 
            this.nextBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nextBtn.Location = new System.Drawing.Point(721, 1043);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(117, 54);
            this.nextBtn.TabIndex = 22;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // middleNameBox
            // 
            this.middleNameBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.middleNameBox.AutoSize = true;
            this.middleNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleNameBox.Location = new System.Drawing.Point(229, 366);
            this.middleNameBox.Name = "middleNameBox";
            this.middleNameBox.Size = new System.Drawing.Size(180, 31);
            this.middleNameBox.TabIndex = 23;
            this.middleNameBox.Text = "Author Middle";
            // 
            // middleBox
            // 
            this.middleBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.middleBox.Location = new System.Drawing.Point(521, 356);
            this.middleBox.Name = "middleBox";
            this.middleBox.Size = new System.Drawing.Size(512, 54);
            this.middleBox.TabIndex = 3;
            this.middleBox.Text = "";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(231, 499);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 31);
            this.label6.TabIndex = 25;
            this.label6.Text = "Author Last";
            // 
            // lastBox
            // 
            this.lastBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lastBox.Location = new System.Drawing.Point(521, 489);
            this.lastBox.Name = "lastBox";
            this.lastBox.Size = new System.Drawing.Size(512, 54);
            this.lastBox.TabIndex = 4;
            this.lastBox.Text = "";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1450, 1229);
            this.Controls.Add(this.lastBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.middleBox);
            this.Controls.Add(this.middleNameBox);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.publisherBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.firstBox);
            this.Controls.Add(this.tagsBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.docTitleBox);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Quotidian: Citation Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox docTitleBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox tagsBox;
        private System.Windows.Forms.RichTextBox firstBox;
        private System.Windows.Forms.RichTextBox dateBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox publisherBox;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Label middleNameBox;
        private System.Windows.Forms.RichTextBox middleBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox lastBox;
    }
}