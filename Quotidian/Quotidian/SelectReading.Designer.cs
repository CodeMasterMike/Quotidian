namespace Quotidian
{
    partial class SelectReading
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
            this.openReadingButton = new System.Windows.Forms.Button();
            this.selectReadingListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // openReadingButton
            // 
            this.openReadingButton.Location = new System.Drawing.Point(369, 370);
            this.openReadingButton.Name = "openReadingButton";
            this.openReadingButton.Size = new System.Drawing.Size(124, 23);
            this.openReadingButton.TabIndex = 5;
            this.openReadingButton.Text = "Open Selected";
            this.openReadingButton.UseVisualStyleBackColor = true;
            this.openReadingButton.Click += new System.EventHandler(this.openReadingButton_Click);
            // 
            // selectReadingListBox
            // 
            this.selectReadingListBox.FormattingEnabled = true;
            this.selectReadingListBox.ItemHeight = 16;
            this.selectReadingListBox.Location = new System.Drawing.Point(9, 36);
            this.selectReadingListBox.Name = "selectReadingListBox";
            this.selectReadingListBox.ScrollAlwaysVisible = true;
            this.selectReadingListBox.Size = new System.Drawing.Size(484, 324);
            this.selectReadingListBox.TabIndex = 4;
            this.selectReadingListBox.SelectedIndexChanged += new System.EventHandler(this.selectReadingListBox_SelectedIndexChanged);
            // 
            // SelectReading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 404);
            this.Controls.Add(this.openReadingButton);
            this.Controls.Add(this.selectReadingListBox);
            this.Name = "SelectReading";
            this.Text = "Select Reading";
            this.Load += new System.EventHandler(this.SelectReading_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button openReadingButton;
        private System.Windows.Forms.ListBox selectReadingListBox;
    }
}