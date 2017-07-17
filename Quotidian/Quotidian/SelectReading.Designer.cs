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
            this.selectReadingListBox = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.openReadingButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // selectReadingListBox
            // 
            this.selectReadingListBox.Location = new System.Drawing.Point(12, 29);
            this.selectReadingListBox.Name = "selectReadingListBox";
            this.selectReadingListBox.Size = new System.Drawing.Size(728, 517);
            this.selectReadingListBox.TabIndex = 6;
            // 
            // openReadingButton
            // 
            this.openReadingButton.Location = new System.Drawing.Point(533, 552);
            this.openReadingButton.Name = "openReadingButton";
            this.openReadingButton.Size = new System.Drawing.Size(207, 67);
            this.openReadingButton.TabIndex = 7;
            this.openReadingButton.Values.Text = "Open Selected";
            // 
            // SelectReading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 631);
            this.Controls.Add(this.openReadingButton);
            this.Controls.Add(this.selectReadingListBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SelectReading";
            this.Text = "Select Reading";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SelectReading_FormClosed);
            this.Load += new System.EventHandler(this.SelectReading_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonListBox selectReadingListBox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton openReadingButton;
    }
}