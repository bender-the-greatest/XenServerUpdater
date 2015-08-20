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
    public partial class frmExecution : Form
    {
        private System.Diagnostics.ProcessStartInfo myPsi;
        public volatile string ReturnString { get; set; }

        /// <summary>
        /// Retained for compatibility with Designer. Do not use.
        /// </summary>
        public frmExecution()
        {
            InitializeComponent();
            this.ReturnString = string.Empty;
        }

        internal frmExecution(System.Diagnostics.ProcessStartInfo psi) : this()
        {
            if (psi == null) throw new ArgumentNullException("ProcessStartInfo cannot be null!");
            myPsi = psi;
        }

        /// <summary>
        /// Executes the command specified in the constructor.
        /// </summary>
        /// <param name="ignoreStdErr">Set to true if you don't care about error output.</param>
        /// <returns></returns>
        internal void ExecuteCommand(bool ignoreStdErr)
        {
            if (this.ReturnString == null) throw new Exception("ProcessStartInfo is null");

            System.Threading.Thread t = new System.Threading.Thread(delegate()
            {
                string output;
                System.Diagnostics.Process p = System.Diagnostics.Process.Start(myPsi);
                p.WaitForExit();

                while ((output = p.StandardOutput.ReadLine()) != null)
                    this.ReturnString += output + System.Environment.NewLine;
                this.ReturnString += System.Environment.NewLine;

                if (!ignoreStdErr){
                    while ((output = p.StandardError.ReadLine()) != null)
                        this.ReturnString += output + System.Environment.NewLine;
                    this.ReturnString += System.Environment.NewLine;
                }
            });
            // wait for the command to finish
            t.Join();
        }

        /// <summary>
        /// Execute the command specified in the constructor, ignoring StandardError.
        /// </summary>
        /// <returns></returns>
        internal string ExecuteCommand() { return this.ExecuteCommand(true); }
    }
}
