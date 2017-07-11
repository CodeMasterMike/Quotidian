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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.middleNameBox = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nxtButton = new System.Windows.Forms.Button();
            this.citationBtn = new System.Windows.Forms.Button();
            this.authorList1 = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.authorNameLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.addAuthorButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.button1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.docTitleBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.firstBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.middleBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lastBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tagsBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.publisherBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.dateBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Document Title";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 31);
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
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 31);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tags (Comma Separated)";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 719);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(395, 31);
            this.label4.TabIndex = 19;
            this.label4.Text = "Date Published (MM/DD/YYYY)";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(173, 612);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 31);
            this.label5.TabIndex = 20;
            this.label5.Text = "Publisher";
            // 
            // middleNameBox
            // 
            this.middleNameBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.middleNameBox.AutoSize = true;
            this.middleNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleNameBox.Location = new System.Drawing.Point(565, 192);
            this.middleNameBox.Name = "middleNameBox";
            this.middleNameBox.Size = new System.Drawing.Size(101, 31);
            this.middleNameBox.TabIndex = 29;
            this.middleNameBox.Text = "Middle:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(864, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 31);
            this.label6.TabIndex = 25;
            this.label6.Text = "Last:";
            // 
            // nxtButton
            // 
            this.nxtButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nxtButton.Location = new System.Drawing.Point(1236, 972);
            this.nxtButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nxtButton.Name = "nxtButton";
            this.nxtButton.Size = new System.Drawing.Size(189, 42);
            this.nxtButton.TabIndex = 26;
            this.nxtButton.Text = "Next";
            this.nxtButton.UseVisualStyleBackColor = false;
            this.nxtButton.Click += new System.EventHandler(this.nxtButton_Click);
            // 
            // citationBtn
            // 
            this.citationBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.citationBtn.Location = new System.Drawing.Point(772, 972);
            this.citationBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.citationBtn.Name = "citationBtn";
            this.citationBtn.Size = new System.Drawing.Size(189, 42);
            this.citationBtn.TabIndex = 27;
            this.citationBtn.Text = "Generate Citation";
            this.citationBtn.UseVisualStyleBackColor = false;
            // 
            // authorList1
            // 
            this.authorList1.Location = new System.Drawing.Point(117, 302);
            this.authorList1.Name = "authorList1";
            this.authorList1.Size = new System.Drawing.Size(682, 182);
            this.authorList1.TabIndex = 30;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.authorNameLabel);
            this.kryptonPanel1.Location = new System.Drawing.Point(117, 262);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(682, 44);
            this.kryptonPanel1.TabIndex = 31;
            // 
            // authorNameLabel
            // 
            this.authorNameLabel.Location = new System.Drawing.Point(3, 4);
            this.authorNameLabel.Name = "authorNameLabel";
            this.authorNameLabel.Size = new System.Drawing.Size(162, 37);
            this.authorNameLabel.TabIndex = 32;
            this.authorNameLabel.Values.Text = "Author Name";
            // 
            // addAuthorButton
            // 
            this.addAuthorButton.Location = new System.Drawing.Point(839, 291);
            this.addAuthorButton.Name = "addAuthorButton";
            this.addAuthorButton.Size = new System.Drawing.Size(220, 55);
            this.addAuthorButton.TabIndex = 32;
            this.addAuthorButton.Values.Text = "Add Author";
            this.addAuthorButton.Click += new System.EventHandler(this.addAuthorButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(839, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 55);
            this.button1.TabIndex = 33;
            this.button1.Values.Text = "Remove Last";
            // 
            // docTitleBox
            // 
            this.docTitleBox.Location = new System.Drawing.Point(375, 75);
            this.docTitleBox.Name = "docTitleBox";
            this.docTitleBox.Size = new System.Drawing.Size(424, 36);
            this.docTitleBox.TabIndex = 34;
            // 
            // firstBox
            // 
            this.firstBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.firstBox.Location = new System.Drawing.Point(242, 192);
            this.firstBox.Name = "firstBox";
            this.firstBox.Size = new System.Drawing.Size(292, 36);
            this.firstBox.TabIndex = 35;
            // 
            // middleBox
            // 
            this.middleBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.middleBox.Location = new System.Drawing.Point(666, 192);
            this.middleBox.Name = "middleBox";
            this.middleBox.Size = new System.Drawing.Size(179, 36);
            this.middleBox.TabIndex = 36;
            // 
            // lastBox
            // 
            this.lastBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lastBox.Location = new System.Drawing.Point(944, 192);
            this.lastBox.Name = "lastBox";
            this.lastBox.Size = new System.Drawing.Size(309, 36);
            this.lastBox.TabIndex = 37;
            // 
            // tagsBox
            // 
            this.tagsBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tagsBox.Location = new System.Drawing.Point(455, 505);
            this.tagsBox.Name = "tagsBox";
            this.tagsBox.Size = new System.Drawing.Size(390, 36);
            this.tagsBox.TabIndex = 38;
            // 
            // publisherBox
            // 
            this.publisherBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.publisherBox.Location = new System.Drawing.Point(455, 612);
            this.publisherBox.Name = "publisherBox";
            this.publisherBox.Size = new System.Drawing.Size(390, 36);
            this.publisherBox.TabIndex = 39;
            // 
            // dateBox
            // 
            this.dateBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateBox.Location = new System.Drawing.Point(455, 719);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(390, 36);
            this.dateBox.TabIndex = 40;
            // 
            // ReadingInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1621, 1076);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.publisherBox);
            this.Controls.Add(this.tagsBox);
            this.Controls.Add(this.lastBox);
            this.Controls.Add(this.middleBox);
            this.Controls.Add(this.firstBox);
            this.Controls.Add(this.docTitleBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addAuthorButton);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.authorList1);
            this.Controls.Add(this.citationBtn);
            this.Controls.Add(this.nxtButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.middleNameBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ReadingInfo";
            this.Text = "Quotidian: Citation Info";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label middleNameBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button nxtButton;
        private System.Windows.Forms.Button citationBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox authorList1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel authorNameLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton addAuthorButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton button1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox docTitleBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox firstBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox middleBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox lastBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tagsBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox publisherBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox dateBox;
    }
}