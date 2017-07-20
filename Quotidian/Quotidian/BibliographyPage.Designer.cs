namespace Quotidian
{
    partial class BibliographyPage
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
            this.generatedBib = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // generatedBib
            // 
            this.generatedBib.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generatedBib.Location = new System.Drawing.Point(0, 0);
            this.generatedBib.MinimumSize = new System.Drawing.Size(20, 20);
            this.generatedBib.Name = "generatedBib";
            this.generatedBib.Size = new System.Drawing.Size(690, 778);
            this.generatedBib.TabIndex = 0;
            this.generatedBib.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.generatedBib_DocumentCompleted);
            // 
            // BibliographyPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(690, 778);
            this.Controls.Add(this.generatedBib);
            this.Name = "BibliographyPage";
            this.Text = "BibliographyPage";
            this.Load += new System.EventHandler(this.BibliographyPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser generatedBib;
    }
}