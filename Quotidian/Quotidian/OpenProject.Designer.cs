﻿namespace Quotidian
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
            this.newProjectNameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.selectProjectListBox = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.newProjectButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.openProjectButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // newProjectNameTextBox
            // 
            this.newProjectNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.newProjectNameTextBox.Location = new System.Drawing.Point(139, 718);
            this.newProjectNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newProjectNameTextBox.Name = "newProjectNameTextBox";
            this.newProjectNameTextBox.Size = new System.Drawing.Size(492, 31);
            this.newProjectNameTextBox.TabIndex = 3;
            this.newProjectNameTextBox.Text = "Enter New Project Name Here";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1063, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Test1_Click);
            // 
            // selectProjectListBox
            // 
            this.selectProjectListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectProjectListBox.Location = new System.Drawing.Point(139, 54);
            this.selectProjectListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectProjectListBox.Name = "selectProjectListBox";
            this.selectProjectListBox.Size = new System.Drawing.Size(899, 604);
            this.selectProjectListBox.TabIndex = 5;
            this.selectProjectListBox.SelectedIndexChanged += new System.EventHandler(this.selectProjectListBox_SelectedIndexChanged);
            // 
            // newProjectButton
            // 
            this.newProjectButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.newProjectButton.Location = new System.Drawing.Point(659, 698);
            this.newProjectButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newProjectButton.Name = "newProjectButton";
            this.newProjectButton.Size = new System.Drawing.Size(172, 62);
            this.newProjectButton.TabIndex = 6;
            this.newProjectButton.Values.Text = "New Project";
            this.newProjectButton.Click += new System.EventHandler(this.newProjectButton_Click);
            // 
            // openProjectButton
            // 
            this.openProjectButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.openProjectButton.Location = new System.Drawing.Point(849, 698);
            this.openProjectButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.openProjectButton.Name = "openProjectButton";
            this.openProjectButton.Size = new System.Drawing.Size(188, 62);
            this.openProjectButton.TabIndex = 7;
            this.openProjectButton.Values.Text = "Open Selected";
            this.openProjectButton.Click += new System.EventHandler(this.openProjectButton_Click);
            // 
            // OpenProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 818);
            this.Controls.Add(this.openProjectButton);
            this.Controls.Add(this.newProjectButton);
            this.Controls.Add(this.selectProjectListBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.newProjectNameTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "OpenProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Open Project";
            this.Controls.SetChildIndex(this.newProjectNameTextBox, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.selectProjectListBox, 0);
            this.Controls.SetChildIndex(this.newProjectButton, 0);
            this.Controls.SetChildIndex(this.openProjectButton, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox newProjectNameTextBox;
        private System.Windows.Forms.Button button1;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox selectProjectListBox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton newProjectButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton openProjectButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}