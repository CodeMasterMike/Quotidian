namespace Quotidian
{
    partial class ReadingTextPage
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
            this.pasteBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.openButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.readingText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // pasteBtn
            // 
            this.pasteBtn.Location = new System.Drawing.Point(98, 635);
            this.pasteBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pasteBtn.Name = "pasteBtn";
            this.pasteBtn.Size = new System.Drawing.Size(144, 49);
            this.pasteBtn.TabIndex = 13;
            this.pasteBtn.Values.Text = "Paste";
            this.pasteBtn.Click += new System.EventHandler(this.pasteBtn_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(596, 635);
            this.openButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(173, 49);
            this.openButton.TabIndex = 15;
            this.openButton.Values.Text = "Open Reading";
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // readingText
            // 
            this.readingText.Location = new System.Drawing.Point(98, 71);
            this.readingText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.readingText.Name = "readingText";
            this.readingText.Size = new System.Drawing.Size(672, 526);
            this.readingText.TabIndex = 0;
            this.readingText.Text = "";
            // 
            // ReadingTextPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(874, 838);
            this.Controls.Add(this.readingText);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.pasteBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "ReadingTextPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Text";
            this.Load += new System.EventHandler(this.ReadingTextPage_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonButton pasteBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton openButton;
        private System.Windows.Forms.RichTextBox readingText;
    }
}