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
            this.readingsLabel = new System.Windows.Forms.Label();
            this.writingsLabel = new System.Windows.Forms.Label();
            this.openReadingBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.newReadingBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.openWritingBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.newWritingBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.readingsList = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.writingsList = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.SuspendLayout();
            // 
            // readingsLabel
            // 
            this.readingsLabel.AutoSize = true;
            this.readingsLabel.Location = new System.Drawing.Point(51, 52);
            this.readingsLabel.Name = "readingsLabel";
            this.readingsLabel.Size = new System.Drawing.Size(103, 25);
            this.readingsLabel.TabIndex = 17;
            this.readingsLabel.Text = "Readings";
            // 
            // writingsLabel
            // 
            this.writingsLabel.AutoSize = true;
            this.writingsLabel.Location = new System.Drawing.Point(770, 52);
            this.writingsLabel.Name = "writingsLabel";
            this.writingsLabel.Size = new System.Drawing.Size(90, 25);
            this.writingsLabel.TabIndex = 18;
            this.writingsLabel.Text = "Writings";
            // 
            // openReadingBtn
            // 
            this.openReadingBtn.Location = new System.Drawing.Point(56, 789);
            this.openReadingBtn.Name = "openReadingBtn";
            this.openReadingBtn.Size = new System.Drawing.Size(186, 79);
            this.openReadingBtn.TabIndex = 19;
            this.openReadingBtn.Values.Text = "Open Reading";
            this.openReadingBtn.Click += new System.EventHandler(this.openReadingBtn_Click);

            // 
            // newReadingBtn
            // 
            this.newReadingBtn.Location = new System.Drawing.Point(284, 789);
            this.newReadingBtn.Name = "newReadingBtn";
            this.newReadingBtn.Size = new System.Drawing.Size(186, 79);
            this.newReadingBtn.TabIndex = 20;
            this.newReadingBtn.Values.Text = "New Reading";
            this.newReadingBtn.Click += new System.EventHandler(this.newReadingBtn_Click);
            // 
            // openWritingBtn
            // 
            this.openWritingBtn.Location = new System.Drawing.Point(775, 789);
            this.openWritingBtn.Name = "openWritingBtn";
            this.openWritingBtn.Size = new System.Drawing.Size(186, 79);
            this.openWritingBtn.TabIndex = 21;
            this.openWritingBtn.Values.Text = "Open Writing";
            this.openWritingBtn.Click += new System.EventHandler(this.openWritingBtn_Click);
            // 
            // newWritingBtn
            // 
            this.newWritingBtn.Location = new System.Drawing.Point(1003, 789);
            this.newWritingBtn.Name = "newWritingBtn";
            this.newWritingBtn.Size = new System.Drawing.Size(186, 79);
            this.newWritingBtn.TabIndex = 22;
            this.newWritingBtn.Values.Text = "New Writing";
            this.newWritingBtn.Click += new System.EventHandler(this.newWritingBtn_Click);
            // 
            // readingsList
            // 
            this.readingsList.Location = new System.Drawing.Point(56, 94);
            this.readingsList.Name = "readingsList";
            this.readingsList.Size = new System.Drawing.Size(414, 679);
            this.readingsList.TabIndex = 23;
            // 
            // writingsList
            // 
            this.writingsList.Location = new System.Drawing.Point(775, 94);
            this.writingsList.Name = "writingsList";
            this.writingsList.Size = new System.Drawing.Size(414, 679);
            this.writingsList.TabIndex = 24;
            // 
            // ProjectSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1274, 905);
            this.Controls.Add(this.writingsList);
            this.Controls.Add(this.readingsList);
            this.Controls.Add(this.newWritingBtn);
            this.Controls.Add(this.openWritingBtn);
            this.Controls.Add(this.newReadingBtn);
            this.Controls.Add(this.openReadingBtn);
            this.Controls.Add(this.writingsLabel);
            this.Controls.Add(this.readingsLabel);
            this.Name = "ProjectSummary";
            this.Text = "Program Summary";
            this.Controls.SetChildIndex(this.readingsLabel, 0);
            this.Controls.SetChildIndex(this.writingsLabel, 0);
            this.Controls.SetChildIndex(this.openReadingBtn, 0);
            this.Controls.SetChildIndex(this.newReadingBtn, 0);
            this.Controls.SetChildIndex(this.openWritingBtn, 0);
            this.Controls.SetChildIndex(this.newWritingBtn, 0);
            this.Controls.SetChildIndex(this.readingsList, 0);
            this.Controls.SetChildIndex(this.writingsList, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label readingsLabel;
        private System.Windows.Forms.Label writingsLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton openReadingBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton newReadingBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton openWritingBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton newWritingBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox readingsList;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox writingsList;
    }
}