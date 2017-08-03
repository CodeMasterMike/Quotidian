namespace Quotidian
{
    partial class ViewSearchResult
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
            this.readingTextBox = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.SuspendLayout();
            // 
            // readingTextBox
            // 
            this.readingTextBox.Location = new System.Drawing.Point(12, 12);
            this.readingTextBox.Name = "readingTextBox";
            this.readingTextBox.Size = new System.Drawing.Size(583, 404);
            this.readingTextBox.TabIndex = 0;
            this.readingTextBox.Text = "readingText";
            // 
            // ViewSearchResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 428);
            this.Controls.Add(this.readingTextBox);
            this.Name = "ViewSearchResult";
            this.Text = "Text Search Results";
            this.Load += new System.EventHandler(this.ViewSearchResult_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox readingTextBox;
    }
}