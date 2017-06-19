namespace Quotidian
{
    partial class Form4
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
            this.SuspendLayout();
            // 
            // readingText
            // 
            this.readingText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.readingText.Location = new System.Drawing.Point(131, 63);
            this.readingText.Name = "readingText";
            this.readingText.Size = new System.Drawing.Size(894, 656);
            this.readingText.TabIndex = 0;
            this.readingText.Text = "";
            // 
            // pasteBtn
            // 
            this.pasteBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pasteBtn.Location = new System.Drawing.Point(303, 801);
            this.pasteBtn.Name = "pasteBtn";
            this.pasteBtn.Size = new System.Drawing.Size(117, 54);
            this.pasteBtn.TabIndex = 9;
            this.pasteBtn.Text = "Paste";
            this.pasteBtn.UseVisualStyleBackColor = true;
            this.pasteBtn.Click += new System.EventHandler(this.pasteBtn_Click);
            // 
            // citationBtn
            // 
            this.citationBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.citationBtn.AutoSize = true;
            this.citationBtn.Location = new System.Drawing.Point(669, 801);
            this.citationBtn.Name = "citationBtn";
            this.citationBtn.Size = new System.Drawing.Size(213, 54);
            this.citationBtn.TabIndex = 10;
            this.citationBtn.Text = "Generate Citation";
            this.citationBtn.UseVisualStyleBackColor = true;
            this.citationBtn.Click += new System.EventHandler(this.citationBtn_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1166, 925);
            this.Controls.Add(this.citationBtn);
            this.Controls.Add(this.pasteBtn);
            this.Controls.Add(this.readingText);
            this.Name = "Form4";
            this.Text = "Add Text";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox readingText;
        private System.Windows.Forms.Button pasteBtn;
        private System.Windows.Forms.Button citationBtn;
    }
}