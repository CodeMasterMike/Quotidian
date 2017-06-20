namespace Quotidian
{
    partial class OpenProject
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
            this.selectProjectListBox = new System.Windows.Forms.ListBox();
            this.openProjectButton = new System.Windows.Forms.Button();
            this.newProjectButton = new System.Windows.Forms.Button();
            this.newProjectNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // selectProjectListBox
            // 
            this.selectProjectListBox.FormattingEnabled = true;
            this.selectProjectListBox.ItemHeight = 16;
            this.selectProjectListBox.Location = new System.Drawing.Point(12, 25);
            this.selectProjectListBox.Name = "selectProjectListBox";
            this.selectProjectListBox.ScrollAlwaysVisible = true;
            this.selectProjectListBox.Size = new System.Drawing.Size(484, 324);
            this.selectProjectListBox.TabIndex = 0;
            this.selectProjectListBox.SelectedIndexChanged += new System.EventHandler(this.selectProjectListBox_SelectedIndexChanged);
            // 
            // openProjectButton
            // 
            this.openProjectButton.Location = new System.Drawing.Point(372, 359);
            this.openProjectButton.Name = "openProjectButton";
            this.openProjectButton.Size = new System.Drawing.Size(124, 23);
            this.openProjectButton.TabIndex = 1;
            this.openProjectButton.Text = "Open Selected";
            this.openProjectButton.UseVisualStyleBackColor = true;
            this.openProjectButton.Click += new System.EventHandler(this.openProjectButton_Click);
            // 
            // newProjectButton
            // 
            this.newProjectButton.Location = new System.Drawing.Point(258, 359);
            this.newProjectButton.Name = "newProjectButton";
            this.newProjectButton.Size = new System.Drawing.Size(108, 23);
            this.newProjectButton.TabIndex = 2;
            this.newProjectButton.Text = "New Project";
            this.newProjectButton.UseVisualStyleBackColor = true;
            this.newProjectButton.Click += new System.EventHandler(this.newProjectButton_Click);
            // 
            // newProjectNameTextBox
            // 
            this.newProjectNameTextBox.Location = new System.Drawing.Point(13, 360);
            this.newProjectNameTextBox.Name = "newProjectNameTextBox";
            this.newProjectNameTextBox.Size = new System.Drawing.Size(239, 22);
            this.newProjectNameTextBox.TabIndex = 3;
            this.newProjectNameTextBox.Text = "Enter New Project Name Here";
            // 
            // OpenProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 395);
            this.Controls.Add(this.newProjectNameTextBox);
            this.Controls.Add(this.newProjectButton);
            this.Controls.Add(this.openProjectButton);
            this.Controls.Add(this.selectProjectListBox);
            this.Name = "OpenProject";
            this.Text = "Open Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox selectProjectListBox;
        private System.Windows.Forms.Button openProjectButton;
        private System.Windows.Forms.Button newProjectButton;
        private System.Windows.Forms.TextBox newProjectNameTextBox;
    }
}