namespace Quotidian
{
    partial class ProjectSummary
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
            this.openReadingBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.newReadingBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.openWritingBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.newWritingBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.readingsList = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.writingsList = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.citeStyleType = new System.Windows.Forms.ComboBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.localDatabaseDataSet1 = new Quotidian.LocalDatabaseDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.localDatabaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // openReadingBtn
            // 
            this.openReadingBtn.Location = new System.Drawing.Point(8, 786);
            this.openReadingBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.openReadingBtn.Name = "openReadingBtn";
            this.openReadingBtn.Size = new System.Drawing.Size(186, 79);
            this.openReadingBtn.TabIndex = 19;
            this.openReadingBtn.Values.Text = "Open Reading";
            this.openReadingBtn.Click += new System.EventHandler(this.openReadingBtn_Click);
            // 
            // newReadingBtn
            // 
            this.newReadingBtn.Location = new System.Drawing.Point(238, 786);
            this.newReadingBtn.Name = "newReadingBtn";
            this.newReadingBtn.Size = new System.Drawing.Size(186, 79);
            this.newReadingBtn.TabIndex = 20;
            this.newReadingBtn.Values.Text = "New Reading";
            this.newReadingBtn.Click += new System.EventHandler(this.newReadingBtn_Click);
            // 
            // openWritingBtn
            // 
            this.openWritingBtn.Location = new System.Drawing.Point(536, 786);
            this.openWritingBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.openWritingBtn.Name = "openWritingBtn";
            this.openWritingBtn.Size = new System.Drawing.Size(186, 79);
            this.openWritingBtn.TabIndex = 21;
            this.openWritingBtn.Values.Text = "Open Writing";
            this.openWritingBtn.Click += new System.EventHandler(this.openWritingBtn_Click);
            // 
            // newWritingBtn
            // 
            this.newWritingBtn.Location = new System.Drawing.Point(764, 786);
            this.newWritingBtn.Name = "newWritingBtn";
            this.newWritingBtn.Size = new System.Drawing.Size(186, 79);
            this.newWritingBtn.TabIndex = 22;
            this.newWritingBtn.Values.Text = "New Writing";
            this.newWritingBtn.Click += new System.EventHandler(this.newWritingBtn_Click);
            // 
            // readingsList
            // 
            this.readingsList.Location = new System.Drawing.Point(10, 91);
            this.readingsList.Name = "readingsList";
            this.readingsList.Size = new System.Drawing.Size(414, 679);
            this.readingsList.TabIndex = 23;
            // 
            // writingsList
            // 
            this.writingsList.Location = new System.Drawing.Point(536, 91);
            this.writingsList.Name = "writingsList";
            this.writingsList.Size = new System.Drawing.Size(414, 679);
            this.writingsList.TabIndex = 24;
            // 
            // citeStyleType
            // 
            this.citeStyleType.FormattingEnabled = true;
            this.citeStyleType.Items.AddRange(new object[] {
            "MLA",
            "Chicago"});
            this.citeStyleType.Location = new System.Drawing.Point(415, 895);
            this.citeStyleType.Name = "citeStyleType";
            this.citeStyleType.Size = new System.Drawing.Size(132, 28);
            this.citeStyleType.TabIndex = 25;
            this.citeStyleType.Text = "Citation Style";
            this.citeStyleType.SelectedIndexChanged += new System.EventHandler(this.citeStyleType_SelectedIndexChanged);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(10, 56);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(87, 29);
            this.kryptonLabel1.TabIndex = 26;
            this.kryptonLabel1.Values.Text = "Readings";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(536, 56);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(81, 29);
            this.kryptonLabel2.TabIndex = 27;
            this.kryptonLabel2.Values.Text = "Writings";
            // 
            // localDatabaseDataSet1
            // 
            this.localDatabaseDataSet1.DataSetName = "LocalDatabaseDataSet";
            this.localDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ProjectSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(960, 952);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.citeStyleType);
            this.Controls.Add(this.writingsList);
            this.Controls.Add(this.readingsList);
            this.Controls.Add(this.newWritingBtn);
            this.Controls.Add(this.openWritingBtn);
            this.Controls.Add(this.newReadingBtn);
            this.Controls.Add(this.openReadingBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "ProjectSummary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Back.Color1 = System.Drawing.SystemColors.GradientActiveCaption;
            this.Text = "Project Summary";
            this.Controls.SetChildIndex(this.openReadingBtn, 0);
            this.Controls.SetChildIndex(this.newReadingBtn, 0);
            this.Controls.SetChildIndex(this.openWritingBtn, 0);
            this.Controls.SetChildIndex(this.newWritingBtn, 0);
            this.Controls.SetChildIndex(this.readingsList, 0);
            this.Controls.SetChildIndex(this.writingsList, 0);
            this.Controls.SetChildIndex(this.citeStyleType, 0);
            this.Controls.SetChildIndex(this.kryptonLabel1, 0);
            this.Controls.SetChildIndex(this.kryptonLabel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.localDatabaseDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonButton openReadingBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton newReadingBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton openWritingBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton newWritingBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox readingsList;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox writingsList;
        private System.Windows.Forms.ComboBox citeStyleType;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private LocalDatabaseDataSet localDatabaseDataSet1;
    }
}