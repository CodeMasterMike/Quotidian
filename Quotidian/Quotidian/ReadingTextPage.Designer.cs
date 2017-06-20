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
            this.pasteBtn = new System.Windows.Forms.Button();
            this.citationBtn = new System.Windows.Forms.Button();
            this.generatedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // readingText
            // 
            this.readingText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.readingText.Location = new System.Drawing.Point(98, 50);
            this.readingText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.readingText.Name = "readingText";
            this.readingText.Size = new System.Drawing.Size(672, 526);
            this.readingText.TabIndex = 0;
            this.readingText.Text = "";
            // 
            // pasteBtn
            // 
            this.pasteBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pasteBtn.Location = new System.Drawing.Point(227, 641);
            this.pasteBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pasteBtn.Name = "pasteBtn";
            this.pasteBtn.Size = new System.Drawing.Size(88, 43);
            this.pasteBtn.TabIndex = 9;
            this.pasteBtn.Text = "Paste";
            this.pasteBtn.UseVisualStyleBackColor = true;
            this.pasteBtn.Click += new System.EventHandler(this.pasteBtn_Click);
            // 
            // citationBtn
            // 
            this.citationBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.citationBtn.AutoSize = true;
            this.citationBtn.Location = new System.Drawing.Point(502, 641);
            this.citationBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.citationBtn.Name = "citationBtn";
            this.citationBtn.Size = new System.Drawing.Size(160, 43);
            this.citationBtn.TabIndex = 10;
            this.citationBtn.Text = "Generate Citation";
            this.citationBtn.UseVisualStyleBackColor = true;
            this.citationBtn.Click += new System.EventHandler(this.citationBtn_Click);
            // 
            // generatedLabel
            // 
            this.generatedLabel.AutoSize = true;
            this.generatedLabel.Location = new System.Drawing.Point(94, 717);
            this.generatedLabel.Name = "generatedLabel";
            this.generatedLabel.Size = new System.Drawing.Size(247, 20);
            this.generatedLabel.TabIndex = 11;
            this.generatedLabel.Text = "Generated Citation Appears Here";
            this.generatedLabel.Click += new System.EventHandler(this.generatedLabel_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(874, 915);
            this.Controls.Add(this.generatedLabel);
            this.Controls.Add(this.citationBtn);
            this.Controls.Add(this.pasteBtn);
            this.Controls.Add(this.readingText);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form4";
            this.Text = "Add Text";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox readingText;
        private System.Windows.Forms.Button pasteBtn;
        private System.Windows.Forms.Button citationBtn;
        private System.Windows.Forms.Label generatedLabel;
    }
}