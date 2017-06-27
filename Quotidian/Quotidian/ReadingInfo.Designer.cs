namespace Quotidian
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
            this.middleNameBox = new System.Windows.Forms.Label();
            this.middleBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lastBox = new System.Windows.Forms.RichTextBox();
            this.addAuthorButton = new System.Windows.Forms.Button();
            this.authorList = new System.Windows.Forms.ListView();
            this.nxtButton = new System.Windows.Forms.Button();
            this.citationBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Document Title";
            // 
            // docTitleBox
            // 
            this.docTitleBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.docTitleBox.Location = new System.Drawing.Point(390, 72);
            this.docTitleBox.Margin = new System.Windows.Forms.Padding(2);
            this.docTitleBox.Name = "docTitleBox";
            this.docTitleBox.Size = new System.Drawing.Size(385, 44);
            this.docTitleBox.TabIndex = 1;
            this.docTitleBox.Text = "";
            this.docTitleBox.TextChanged += new System.EventHandler(this.docTitleBox_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Author First:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 505);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tags (Comma Separated)";
            // 
            // tagsBox
            // 
            this.tagsBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tagsBox.Location = new System.Drawing.Point(390, 498);
            this.tagsBox.Margin = new System.Windows.Forms.Padding(2);
            this.tagsBox.Name = "tagsBox";
            this.tagsBox.Size = new System.Drawing.Size(385, 44);
            this.tagsBox.TabIndex = 5;
            this.tagsBox.Text = "";
            // 
            // firstBox
            // 
            this.firstBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.firstBox.Location = new System.Drawing.Point(200, 183);
            this.firstBox.Margin = new System.Windows.Forms.Padding(2);
            this.firstBox.Name = "firstBox";
            this.firstBox.Size = new System.Drawing.Size(157, 44);
            this.firstBox.TabIndex = 2;
            this.firstBox.Text = "";
            // 
            // dateBox
            // 
            this.dateBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateBox.Location = new System.Drawing.Point(390, 710);
            this.dateBox.Margin = new System.Windows.Forms.Padding(2);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(385, 44);
            this.dateBox.TabIndex = 7;
            this.dateBox.Text = "";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 719);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(316, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Date Published (MM/DD/YYYY)";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(173, 612);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Publisher";
            // 
            // publisherBox
            // 
            this.publisherBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.publisherBox.Location = new System.Drawing.Point(390, 604);
            this.publisherBox.Margin = new System.Windows.Forms.Padding(2);
            this.publisherBox.Name = "publisherBox";
            this.publisherBox.Size = new System.Drawing.Size(385, 44);
            this.publisherBox.TabIndex = 6;
            this.publisherBox.Text = "";
            // 
            // nextBtn
            // 
            //this.nextBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            //this.nextBtn.Location = new System.Drawing.Point(541, 835);
            //this.nextBtn.Margin = new System.Windows.Forms.Padding(2);
            //this.nextBtn.Name = "nextBtn";
            //this.nextBtn.Size = new System.Drawing.Size(88, 44);
            //this.nextBtn.TabIndex = 22;
            //this.nextBtn.Text = "OK";
            //this.nextBtn.UseVisualStyleBackColor = true;
            //this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            this.publisherBox.Location = new System.Drawing.Point(606, 755);
            this.publisherBox.Name = "publisherBox";
            this.publisherBox.Size = new System.Drawing.Size(512, 54);
            this.publisherBox.TabIndex = 6;
            this.publisherBox.Text = "";
            // 
            // middleNameBox
            // 
            this.middleNameBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.middleNameBox.AutoSize = true;
            this.middleNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleNameBox.Location = new System.Drawing.Point(361, 192);
            this.middleNameBox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.middleNameBox.Name = "middleNameBox";
            this.middleNameBox.Size = new System.Drawing.Size(82, 25);
            this.middleNameBox.Text = "Middle:";
            // 
            // middleBox
            // 
            this.middleBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.middleBox.Location = new System.Drawing.Point(437, 183);
            this.middleBox.Margin = new System.Windows.Forms.Padding(2);
            this.middleBox.Name = "middleBox";
            this.middleBox.Size = new System.Drawing.Size(137, 44);
            this.middleBox.TabIndex = 3;
            this.middleBox.Text = "";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(578, 192);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "Last:";
            // 
            // lastBox
            // 
            this.lastBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lastBox.Location = new System.Drawing.Point(641, 183);
            this.lastBox.Margin = new System.Windows.Forms.Padding(2);
            this.lastBox.Name = "lastBox";
            this.lastBox.Size = new System.Drawing.Size(385, 44);
            this.lastBox.TabIndex = 4;
            this.lastBox.Text = "";
            // 
            // addAuthorButton
            // 
            this.addAuthorButton.Location = new System.Drawing.Point(825, 255);
            this.addAuthorButton.Name = "addAuthorButton";
            this.addAuthorButton.Size = new System.Drawing.Size(201, 35);
            this.addAuthorButton.TabIndex = 26;
            this.addAuthorButton.Text = "Add Author...";
            this.addAuthorButton.UseVisualStyleBackColor = true;
            this.addAuthorButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // authorList
            // 
            this.authorList.Location = new System.Drawing.Point(78, 255);
            this.authorList.Name = "authorList";
            this.authorList.Size = new System.Drawing.Size(697, 218);
            this.authorList.TabIndex = 27;
            this.authorList.UseCompatibleStateImageBehavior = false;
            // 
            // ReadingInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1088, 890);
            this.Controls.Add(this.authorList);
            this.Controls.Add(this.addAuthorButton);
            this.lastBox.Location = new System.Drawing.Point(606, 489);
            this.lastBox.Name = "lastBox";
            this.lastBox.Size = new System.Drawing.Size(512, 54);
            this.lastBox.TabIndex = 4;
            this.lastBox.Text = "";
            // 
            // nxtButton
            // 
            this.nxtButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nxtButton.Location = new System.Drawing.Point(1236, 972);
            this.nxtButton.Name = "nxtButton";
            this.nxtButton.Size = new System.Drawing.Size(189, 43);
            this.nxtButton.TabIndex = 26;
            this.nxtButton.Text = "Next";
            this.nxtButton.UseVisualStyleBackColor = false;
            this.nxtButton.Click += new System.EventHandler(this.nxtButton_Click);
            // 
            // citationBtn
            // 
            this.citationBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.citationBtn.Location = new System.Drawing.Point(772, 972);
            this.citationBtn.Name = "citationBtn";
            this.citationBtn.Size = new System.Drawing.Size(189, 43);
            this.citationBtn.TabIndex = 27;
            this.citationBtn.Text = "Generate Citation";
            this.citationBtn.UseVisualStyleBackColor = false;
            // 
            // ReadingInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1622, 1076);
            this.Controls.Add(this.citationBtn);
            this.Controls.Add(this.nxtButton);
            this.Controls.Add(this.lastBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.middleBox);
            this.Controls.Add(this.middleNameBox);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReadingInfo";
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
        private System.Windows.Forms.Label middleNameBox;
        private System.Windows.Forms.RichTextBox middleBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox lastBox;
        private System.Windows.Forms.Button addAuthorButton;
        private System.Windows.Forms.ListView authorList;
        private System.Windows.Forms.Button nxtButton;
        private System.Windows.Forms.Button citationBtn;
    }
}