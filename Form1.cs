using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XenServerUpdater
{
   public partial class Form1 : Form
   {
      OpenFileDialog ofd;

      public Form1()
      {
         InitializeComponent();
         txtConsole.Font = new Font(FontFamily.GenericMonospace, txtConsole.Font.Size);

         base.Text = string.Format("XenServer Updater v{0} (for Zen Server 6.2)", System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString(2));

         ofd = new OpenFileDialog();
         ofd.Title = "Select XenServer Update file...";
         ofd.Filter = "XenServer Update Files|*.xsupdate|All Files|*.*";
         ofd.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
      }

      private void btnBrowseUpdate_Click(object sender, EventArgs e)
      {
         if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
         {
            txtUpdateLocation.Text = ofd.FileName;
            ofd.InitialDirectory = System.IO.Path.GetDirectoryName(ofd.FileName);
            txtPatchName.Text = System.IO.Path.GetFileNameWithoutExtension(ofd.FileName);
         }
      }

      private void btnUploadPatch_Click(object sender, EventArgs e)
      {
         string hostname = txtHost.Text.Trim();
         string user = txtUser.Text.Trim();
         string pass = txtPass.Text.Trim();
         string xeCommand = System.IO.Path.Combine(txtXenLocation.Text.Trim(), "xe.exe");
         string updateFile = txtUpdateLocation.Text;

         // create process start info
         System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo(xeCommand, 
            string.Format("patch-upload -s {0} -u {1} -pw {2} file-name=\"{3}\"", hostname, user, pass, updateFile));
         psi.RedirectStandardOutput = true;
         psi.RedirectStandardError = true;
         psi.UseShellExecute = false;
         psi.CreateNoWindow = true;

         // execute command
         System.Diagnostics.Process xe = null;
         try
         {
            xe = System.Diagnostics.Process.Start(psi);
            xe.WaitForExit();
         }
         catch (Exception ex)
         {
            MessageBox.Show(string.Format("Error executing command: {0}{0}{1}", System.Environment.NewLine, ex.ToString()));
            return;
         }
         
         // read output
         string output;
         while ((output = xe.StandardOutput.ReadLine()) != null)
            txtConsole.Text += output + System.Environment.NewLine;
         txtConsole.Text += System.Environment.NewLine;

         // read stderr
         while ((output = xe.StandardError.ReadLine()) != null)
            txtConsole.Text += string.Format("StdErr: {0}{1}", output, System.Environment.NewLine);
         txtConsole.Text += System.Environment.NewLine;
      }

      private void btnApplyPatch_Click(object sender, EventArgs e)
      {
         string hostname = txtHost.Text.Trim();
         string user = txtUser.Text.Trim();
         string pass = txtPass.Text.Trim();
         string xeCommand = System.IO.Path.Combine(txtXenLocation.Text.Trim(), "xe.exe");
         string uuid = txtUuid.Text.Trim();

         // create process start info
         System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo(xeCommand,
            string.Format("-s {0} -u {1} -pw {2} patch-pool-apply uuid={3}", hostname, user, pass, uuid));
         psi.RedirectStandardOutput = true;
         psi.RedirectStandardError = true;
         psi.UseShellExecute = false;
         psi.CreateNoWindow = true;

         // execute command
         System.Diagnostics.Process xe = null;
         try
         {
            xe = System.Diagnostics.Process.Start(psi);
            xe.WaitForExit();
         }
         catch (Exception ex)
         {
            MessageBox.Show(string.Format("Error executing command: {0}{0}{1}", System.Environment.NewLine, ex.ToString()));
            return;
         }

         //read output
         string output;
         while ((output = xe.StandardOutput.ReadLine()) != null)
            txtConsole.Text += output + System.Environment.NewLine;
         txtConsole.Text += System.Environment.NewLine;

         // read stderr
         while ((output = xe.StandardError.ReadLine()) != null)
            txtConsole.Text += string.Format("StdErr: {0}{1}", output, System.Environment.NewLine);
         txtConsole.Text += System.Environment.NewLine;

         // show message box
         MessageBox.Show("The command completed. If there are no errors in the Command Output, use the Verify button to make sure the patch applied.");
      }

      private void btnVerify_Click(object sender, EventArgs e)
      {
         string hostname = txtHost.Text.Trim();
         string user = txtUser.Text.Trim();
         string pass = txtPass.Text.Trim();
         string xeCommand = System.IO.Path.Combine(txtXenLocation.Text.Trim(), "xe.exe");
         string patchName = txtPatchName.Text.Trim();

         // create process start info
         System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo(xeCommand,
            string.Format("patch-list -s {0} -u {1} -pw {2} name-label={3}", hostname, user, pass, patchName));
         psi.RedirectStandardOutput = true;
         psi.RedirectStandardError = true;
         psi.UseShellExecute = false;
         psi.CreateNoWindow = true;

         // execute command
         System.Diagnostics.Process xe = null;
         try
         {
            xe = System.Diagnostics.Process.Start(psi);
            xe.WaitForExit();
         }
         catch (Exception ex)
         {
            MessageBox.Show(string.Format("Error executing command: {0}{0}{1}", System.Environment.NewLine, ex.ToString()));
            return;
         }

         // read output
         string output;
         while ((output = xe.StandardOutput.ReadLine()) != null)
            txtConsole.Text += output + System.Environment.NewLine;
         txtConsole.Text += System.Environment.NewLine;

         // read stderr
         while ((output = xe.StandardError.ReadLine()) != null)
            txtConsole.Text += string.Format("StdErr: {0}{1}", output, System.Environment.NewLine);
         txtConsole.Text += System.Environment.NewLine;
      }

      private void btnClearConsole_Click(object sender, EventArgs e)
      {
         txtConsole.Clear();
      }
   }
}
