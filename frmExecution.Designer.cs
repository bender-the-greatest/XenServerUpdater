namespace XenServerUpdater
{
    partial class frmExecution
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExecution));
            this.lblText = new System.Windows.Forms.Label();
            this.pbExecution = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(56, 13);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(171, 13);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Executing command, please wait...";
            // 
            // pbExecution
            // 
            this.pbExecution.Location = new System.Drawing.Point(12, 41);
            this.pbExecution.Name = "pbExecution";
            this.pbExecution.Size = new System.Drawing.Size(258, 23);
            this.pbExecution.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbExecution.TabIndex = 1;
            // 
            // frmExecution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 76);
            this.Controls.Add(this.pbExecution);
            this.Controls.Add(this.lblText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmExecution";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Executing command";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.ProgressBar pbExecution;
    }
}