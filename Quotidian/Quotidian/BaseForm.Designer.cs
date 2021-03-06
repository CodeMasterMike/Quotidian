﻿using System;

namespace Quotidian
{
    partial class BaseForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newReadingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openReadingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProjectSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1556, 44);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openProjectToolStripMenuItem,
            this.saveProjectToolStripMenuItem,
            this.newReadingToolStripMenuItem,
            this.openReadingToolStripMenuItem,
            this.viewProjectSummaryToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 38);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openProjectToolStripMenuItem
            // 
            this.openProjectToolStripMenuItem.Name = "openProjectToolStripMenuItem";
            this.openProjectToolStripMenuItem.Size = new System.Drawing.Size(354, 38);
            this.openProjectToolStripMenuItem.Text = "New/Open Project";
            this.openProjectToolStripMenuItem.Click += new System.EventHandler(this.openProjectToolStripMenuItem_Click);
            // 
            // saveProjectToolStripMenuItem
            // 
            this.saveProjectToolStripMenuItem.Name = "saveProjectToolStripMenuItem";
            this.saveProjectToolStripMenuItem.Size = new System.Drawing.Size(354, 38);
            this.saveProjectToolStripMenuItem.Text = "Save Project";
            this.saveProjectToolStripMenuItem.Click += new System.EventHandler(this.saveProjectToolStripMenuItem_Click);
            // 
            // newReadingToolStripMenuItem
            // 
            this.newReadingToolStripMenuItem.Name = "newReadingToolStripMenuItem";
            this.newReadingToolStripMenuItem.Size = new System.Drawing.Size(354, 38);
            this.newReadingToolStripMenuItem.Text = "New Reading";
            this.newReadingToolStripMenuItem.Click += new System.EventHandler(this.newReadingToolStripMenuItem_Click);
            // 
            // openReadingToolStripMenuItem
            // 
            this.openReadingToolStripMenuItem.Name = "openReadingToolStripMenuItem";
            this.openReadingToolStripMenuItem.Size = new System.Drawing.Size(354, 38);
            this.openReadingToolStripMenuItem.Text = "Open Reading";
            this.openReadingToolStripMenuItem.Click += new System.EventHandler(this.openReadingToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDetailsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(67, 38);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addDetailsToolStripMenuItem
            // 
            this.addDetailsToolStripMenuItem.Name = "addDetailsToolStripMenuItem";
            this.addDetailsToolStripMenuItem.Size = new System.Drawing.Size(234, 38);
            this.addDetailsToolStripMenuItem.Text = "Edit Details";
            this.addDetailsToolStripMenuItem.Click += new System.EventHandler(this.addDetailsToolStripMenuItem_Click);
            // 
            // viewProjectSummaryToolStripMenuItem
            // 
            this.viewProjectSummaryToolStripMenuItem.Name = "viewProjectSummaryToolStripMenuItem";
            this.viewProjectSummaryToolStripMenuItem.Size = new System.Drawing.Size(354, 38);
            this.viewProjectSummaryToolStripMenuItem.Text = "View Project Summary";
            this.viewProjectSummaryToolStripMenuItem.Click += new System.EventHandler(this.viewProjectSummaryToolStripMenuItem_Click);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1556, 908);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "BaseForm";
            this.StateCommon.Back.Color1 = System.Drawing.SystemColors.GradientActiveCaption;
            this.Text = "BaseForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newReadingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openReadingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewProjectSummaryToolStripMenuItem;
    }
}