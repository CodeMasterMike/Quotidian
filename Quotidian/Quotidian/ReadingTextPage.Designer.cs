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
            this.readingText = new System.Windows.Forms.RichTextBox();
            this.generatedLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pasteBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.citationBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.openButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // readingText
            // 
            this.readingText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.readingText.Location = new System.Drawing.Point(131, 62);
            this.readingText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.readingText.Name = "readingText";
            this.readingText.Size = new System.Drawing.Size(895, 656);
            this.readingText.TabIndex = 0;
            this.readingText.Text = "";
            // 
            // generatedLabel
            // 
            this.generatedLabel.AutoSize = true;
            this.generatedLabel.Location = new System.Drawing.Point(125, 896);
            this.generatedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.generatedLabel.Name = "generatedLabel";
            this.generatedLabel.Size = new System.Drawing.Size(330, 25);
            this.generatedLabel.TabIndex = 11;
            this.generatedLabel.Text = "Generated Citation Appears Here";
            this.generatedLabel.Click += new System.EventHandler(this.generatedLabel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // pasteBtn
            // 
            this.pasteBtn.Location = new System.Drawing.Point(131, 794);
            this.pasteBtn.Name = "pasteBtn";
            this.pasteBtn.Size = new System.Drawing.Size(192, 61);
            this.pasteBtn.TabIndex = 13;
            this.pasteBtn.Values.Text = "Paste";
            this.pasteBtn.Click += new System.EventHandler(this.pasteBtn_Click);
            // 
            // citationBtn
            // 
            this.citationBtn.Location = new System.Drawing.Point(424, 794);
            this.citationBtn.Name = "citationBtn";
            this.citationBtn.Size = new System.Drawing.Size(270, 61);
            this.citationBtn.TabIndex = 14;
            this.citationBtn.Values.Text = "Generate Citation";
            this.citationBtn.Click += new System.EventHandler(this.citationBtn_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(795, 794);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(231, 61);
            this.openButton.TabIndex = 15;
            this.openButton.Values.Text = "Open Reading";
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // ReadingTextPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1165, 1144);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.citationBtn);
            this.Controls.Add(this.pasteBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.generatedLabel);
            this.Controls.Add(this.readingText);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ReadingTextPage";
            this.Text = "Add Text";
            this.Load += new System.EventHandler(this.ReadingTextPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox readingText;
        private System.Windows.Forms.Label generatedLabel;
        private System.Windows.Forms.Button button1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton pasteBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton citationBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton openButton;
    }
}