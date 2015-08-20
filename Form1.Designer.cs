namespace XenServerUpdater
{
   partial class Form1
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
         this.gbXenLocation = new System.Windows.Forms.GroupBox();
         this.txtXenLocation = new System.Windows.Forms.TextBox();
         this.gbUpdateLocation = new System.Windows.Forms.GroupBox();
         this.txtPatchName = new System.Windows.Forms.TextBox();
         this.lblPatchName = new System.Windows.Forms.Label();
         this.btnBrowseUpdate = new System.Windows.Forms.Button();
         this.txtUpdateLocation = new System.Windows.Forms.TextBox();
         this.gbXenServer = new System.Windows.Forms.GroupBox();
         this.txtPass = new System.Windows.Forms.TextBox();
         this.lblPass = new System.Windows.Forms.Label();
         this.txtUser = new System.Windows.Forms.TextBox();
         this.lblUser = new System.Windows.Forms.Label();
         this.txtHost = new System.Windows.Forms.TextBox();
         this.lblName = new System.Windows.Forms.Label();
         this.btnUploadPatch = new System.Windows.Forms.Button();
         this.gbPatchId = new System.Windows.Forms.GroupBox();
         this.lblPatch = new System.Windows.Forms.Label();
         this.txtUuid = new System.Windows.Forms.TextBox();
         this.btnApplyPatch = new System.Windows.Forms.Button();
         this.btnVerify = new System.Windows.Forms.Button();
         this.gbXenOutput = new System.Windows.Forms.GroupBox();
         this.txtConsole = new System.Windows.Forms.TextBox();
         this.btnClearConsole = new System.Windows.Forms.Button();
         this.lblInfo = new System.Windows.Forms.Label();
         this.gbXenLocation.SuspendLayout();
         this.gbUpdateLocation.SuspendLayout();
         this.gbXenServer.SuspendLayout();
         this.gbPatchId.SuspendLayout();
         this.gbXenOutput.SuspendLayout();
         this.SuspendLayout();
         // 
         // gbXenLocation
         // 
         this.gbXenLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.gbXenLocation.Controls.Add(this.txtXenLocation);
         this.gbXenLocation.Location = new System.Drawing.Point(6, 144);
         this.gbXenLocation.Name = "gbXenLocation";
         this.gbXenLocation.Size = new System.Drawing.Size(599, 56);
         this.gbXenLocation.TabIndex = 2;
         this.gbXenLocation.TabStop = false;
         this.gbXenLocation.Text = "Xen Installation Directory";
         // 
         // txtXenLocation
         // 
         this.txtXenLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.txtXenLocation.Location = new System.Drawing.Point(7, 20);
         this.txtXenLocation.Name = "txtXenLocation";
         this.txtXenLocation.Size = new System.Drawing.Size(586, 20);
         this.txtXenLocation.TabIndex = 0;
         this.txtXenLocation.Text = "C:\\Program Files (x86)\\Citrix\\XenCenter";
         // 
         // gbUpdateLocation
         // 
         this.gbUpdateLocation.Controls.Add(this.txtPatchName);
         this.gbUpdateLocation.Controls.Add(this.lblPatchName);
         this.gbUpdateLocation.Controls.Add(this.btnBrowseUpdate);
         this.gbUpdateLocation.Controls.Add(this.txtUpdateLocation);
         this.gbUpdateLocation.Location = new System.Drawing.Point(5, 206);
         this.gbUpdateLocation.Name = "gbUpdateLocation";
         this.gbUpdateLocation.Size = new System.Drawing.Size(346, 88);
         this.gbUpdateLocation.TabIndex = 3;
         this.gbUpdateLocation.TabStop = false;
         this.gbUpdateLocation.Text = "Xen Update File";
         // 
         // txtPatchName
         // 
         this.txtPatchName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.txtPatchName.Location = new System.Drawing.Point(75, 53);
         this.txtPatchName.Name = "txtPatchName";
         this.txtPatchName.Size = new System.Drawing.Size(259, 20);
         this.txtPatchName.TabIndex = 3;
         // 
         // lblPatchName
         // 
         this.lblPatchName.AutoSize = true;
         this.lblPatchName.Location = new System.Drawing.Point(4, 56);
         this.lblPatchName.Name = "lblPatchName";
         this.lblPatchName.Size = new System.Drawing.Size(66, 13);
         this.lblPatchName.TabIndex = 2;
         this.lblPatchName.Text = "Patch Name";
         // 
         // btnBrowseUpdate
         // 
         this.btnBrowseUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.btnBrowseUpdate.Location = new System.Drawing.Point(312, 19);
         this.btnBrowseUpdate.Name = "btnBrowseUpdate";
         this.btnBrowseUpdate.Size = new System.Drawing.Size(28, 22);
         this.btnBrowseUpdate.TabIndex = 1;
         this.btnBrowseUpdate.Text = "...";
         this.btnBrowseUpdate.UseVisualStyleBackColor = true;
         this.btnBrowseUpdate.Click += new System.EventHandler(this.btnBrowseUpdate_Click);
         // 
         // txtUpdateLocation
         // 
         this.txtUpdateLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.txtUpdateLocation.Location = new System.Drawing.Point(7, 20);
         this.txtUpdateLocation.Name = "txtUpdateLocation";
         this.txtUpdateLocation.Size = new System.Drawing.Size(299, 20);
         this.txtUpdateLocation.TabIndex = 0;
         // 
         // gbXenServer
         // 
         this.gbXenServer.Controls.Add(this.txtPass);
         this.gbXenServer.Controls.Add(this.lblPass);
         this.gbXenServer.Controls.Add(this.txtUser);
         this.gbXenServer.Controls.Add(this.lblUser);
         this.gbXenServer.Controls.Add(this.txtHost);
         this.gbXenServer.Controls.Add(this.lblName);
         this.gbXenServer.Location = new System.Drawing.Point(6, 12);
         this.gbXenServer.Name = "gbXenServer";
         this.gbXenServer.Size = new System.Drawing.Size(207, 105);
         this.gbXenServer.TabIndex = 0;
         this.gbXenServer.TabStop = false;
         this.gbXenServer.Text = "Pool Master Information";
         // 
         // txtPass
         // 
         this.txtPass.Location = new System.Drawing.Point(74, 67);
         this.txtPass.Name = "txtPass";
         this.txtPass.Size = new System.Drawing.Size(113, 20);
         this.txtPass.TabIndex = 5;
         this.txtPass.UseSystemPasswordChar = true;
         // 
         // lblPass
         // 
         this.lblPass.AutoSize = true;
         this.lblPass.Location = new System.Drawing.Point(8, 70);
         this.lblPass.Name = "lblPass";
         this.lblPass.Size = new System.Drawing.Size(53, 13);
         this.lblPass.TabIndex = 4;
         this.lblPass.Text = "Password";
         // 
         // txtUser
         // 
         this.txtUser.Location = new System.Drawing.Point(74, 41);
         this.txtUser.Name = "txtUser";
         this.txtUser.Size = new System.Drawing.Size(113, 20);
         this.txtUser.TabIndex = 3;
         this.txtUser.Text = "root";
         // 
         // lblUser
         // 
         this.lblUser.AutoSize = true;
         this.lblUser.Location = new System.Drawing.Point(8, 44);
         this.lblUser.Name = "lblUser";
         this.lblUser.Size = new System.Drawing.Size(55, 13);
         this.lblUser.TabIndex = 2;
         this.lblUser.Text = "Username";
         // 
         // txtHost
         // 
         this.txtHost.Location = new System.Drawing.Point(74, 17);
         this.txtHost.Name = "txtHost";
         this.txtHost.Size = new System.Drawing.Size(113, 20);
         this.txtHost.TabIndex = 1;
         // 
         // lblName
         // 
         this.lblName.AutoSize = true;
         this.lblName.Location = new System.Drawing.Point(8, 20);
         this.lblName.Name = "lblName";
         this.lblName.Size = new System.Drawing.Size(55, 13);
         this.lblName.TabIndex = 0;
         this.lblName.Text = "Hostname";
         // 
         // btnUploadPatch
         // 
         this.btnUploadPatch.Location = new System.Drawing.Point(364, 223);
         this.btnUploadPatch.Name = "btnUploadPatch";
         this.btnUploadPatch.Size = new System.Drawing.Size(98, 23);
         this.btnUploadPatch.TabIndex = 4;
         this.btnUploadPatch.Text = "Upload Patch";
         this.btnUploadPatch.UseVisualStyleBackColor = true;
         this.btnUploadPatch.Click += new System.EventHandler(this.btnUploadPatch_Click);
         // 
         // gbPatchId
         // 
         this.gbPatchId.Controls.Add(this.lblPatch);
         this.gbPatchId.Controls.Add(this.txtUuid);
         this.gbPatchId.Location = new System.Drawing.Point(5, 300);
         this.gbPatchId.Name = "gbPatchId";
         this.gbPatchId.Size = new System.Drawing.Size(376, 65);
         this.gbPatchId.TabIndex = 5;
         this.gbPatchId.TabStop = false;
         this.gbPatchId.Text = "Patch UUID";
         // 
         // lblPatch
         // 
         this.lblPatch.AutoSize = true;
         this.lblPatch.Location = new System.Drawing.Point(9, 16);
         this.lblPatch.Name = "lblPatch";
         this.lblPatch.Size = new System.Drawing.Size(245, 13);
         this.lblPatch.TabIndex = 0;
         this.lblPatch.Text = "Paste from Command Output after uploading patch";
         // 
         // txtUuid
         // 
         this.txtUuid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.txtUuid.Location = new System.Drawing.Point(8, 32);
         this.txtUuid.Name = "txtUuid";
         this.txtUuid.Size = new System.Drawing.Size(348, 20);
         this.txtUuid.TabIndex = 1;
         // 
         // btnApplyPatch
         // 
         this.btnApplyPatch.Location = new System.Drawing.Point(387, 306);
         this.btnApplyPatch.Name = "btnApplyPatch";
         this.btnApplyPatch.Size = new System.Drawing.Size(75, 23);
         this.btnApplyPatch.TabIndex = 6;
         this.btnApplyPatch.Text = "Apply";
         this.btnApplyPatch.UseVisualStyleBackColor = true;
         this.btnApplyPatch.Click += new System.EventHandler(this.btnApplyPatch_Click);
         // 
         // btnVerify
         // 
         this.btnVerify.Location = new System.Drawing.Point(387, 335);
         this.btnVerify.Name = "btnVerify";
         this.btnVerify.Size = new System.Drawing.Size(75, 23);
         this.btnVerify.TabIndex = 7;
         this.btnVerify.Text = "Verify";
         this.btnVerify.UseVisualStyleBackColor = true;
         this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
         // 
         // gbXenOutput
         // 
         this.gbXenOutput.Controls.Add(this.txtConsole);
         this.gbXenOutput.Location = new System.Drawing.Point(5, 372);
         this.gbXenOutput.Name = "gbXenOutput";
         this.gbXenOutput.Size = new System.Drawing.Size(603, 189);
         this.gbXenOutput.TabIndex = 8;
         this.gbXenOutput.TabStop = false;
         this.gbXenOutput.Text = "Command Output";
         // 
         // txtConsole
         // 
         this.txtConsole.Dock = System.Windows.Forms.DockStyle.Fill;
         this.txtConsole.Location = new System.Drawing.Point(3, 16);
         this.txtConsole.Multiline = true;
         this.txtConsole.Name = "txtConsole";
         this.txtConsole.ReadOnly = true;
         this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both;
         this.txtConsole.Size = new System.Drawing.Size(597, 170);
         this.txtConsole.TabIndex = 0;
         // 
         // btnClearConsole
         // 
         this.btnClearConsole.Location = new System.Drawing.Point(517, 567);
         this.btnClearConsole.Name = "btnClearConsole";
         this.btnClearConsole.Size = new System.Drawing.Size(91, 23);
         this.btnClearConsole.TabIndex = 9;
         this.btnClearConsole.Text = "Clear Console";
         this.btnClearConsole.UseVisualStyleBackColor = true;
         this.btnClearConsole.Click += new System.EventHandler(this.btnClearConsole_Click);
         // 
         // lblInfo
         // 
         this.lblInfo.AutoSize = true;
         this.lblInfo.Location = new System.Drawing.Point(220, 13);
         this.lblInfo.Name = "lblInfo";
         this.lblInfo.Size = new System.Drawing.Size(382, 130);
         this.lblInfo.TabIndex = 1;
         this.lblInfo.Text = resources.GetString("lblInfo.Text");
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(617, 598);
         this.Controls.Add(this.lblInfo);
         this.Controls.Add(this.btnClearConsole);
         this.Controls.Add(this.gbXenOutput);
         this.Controls.Add(this.btnVerify);
         this.Controls.Add(this.btnApplyPatch);
         this.Controls.Add(this.gbPatchId);
         this.Controls.Add(this.btnUploadPatch);
         this.Controls.Add(this.gbXenServer);
         this.Controls.Add(this.gbUpdateLocation);
         this.Controls.Add(this.gbXenLocation);
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximumSize = new System.Drawing.Size(625, 625);
         this.MinimumSize = new System.Drawing.Size(625, 625);
         this.Name = "Form1";
         this.gbXenLocation.ResumeLayout(false);
         this.gbXenLocation.PerformLayout();
         this.gbUpdateLocation.ResumeLayout(false);
         this.gbUpdateLocation.PerformLayout();
         this.gbXenServer.ResumeLayout(false);
         this.gbXenServer.PerformLayout();
         this.gbPatchId.ResumeLayout(false);
         this.gbPatchId.PerformLayout();
         this.gbXenOutput.ResumeLayout(false);
         this.gbXenOutput.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.GroupBox gbXenLocation;
      private System.Windows.Forms.TextBox txtXenLocation;
      private System.Windows.Forms.GroupBox gbUpdateLocation;
      private System.Windows.Forms.Button btnBrowseUpdate;
      private System.Windows.Forms.TextBox txtUpdateLocation;
      private System.Windows.Forms.GroupBox gbXenServer;
      private System.Windows.Forms.TextBox txtPass;
      private System.Windows.Forms.Label lblPass;
      private System.Windows.Forms.TextBox txtUser;
      private System.Windows.Forms.Label lblUser;
      private System.Windows.Forms.TextBox txtHost;
      private System.Windows.Forms.Label lblName;
      private System.Windows.Forms.Button btnUploadPatch;
      private System.Windows.Forms.GroupBox gbPatchId;
      private System.Windows.Forms.Label lblPatch;
      private System.Windows.Forms.TextBox txtUuid;
      private System.Windows.Forms.Button btnApplyPatch;
      private System.Windows.Forms.TextBox txtPatchName;
      private System.Windows.Forms.Label lblPatchName;
      private System.Windows.Forms.Button btnVerify;
      private System.Windows.Forms.GroupBox gbXenOutput;
      private System.Windows.Forms.TextBox txtConsole;
      private System.Windows.Forms.Button btnClearConsole;
      private System.Windows.Forms.Label lblInfo;
   }
}

