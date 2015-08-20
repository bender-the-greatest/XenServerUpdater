using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace XenServerUpdater
{
   static class Program
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main()
      {
         try
         {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
         }
         catch (Exception ex)
         {
            string logErrorMessage = null;
            if (!System.IO.Directory.Exists(Globals.ApplicationDataPath))
               try
               {
                  System.IO.Directory.CreateDirectory(Globals.ApplicationDataPath);
               }
               catch (System.IO.IOException ioex)
               {
                  logErrorMessage = string.Format("Error creating directory: {0}", ioex.Message);
               }

            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            builder.AppendLine("*************************************************************");
            builder.AppendLine(string.Format(" Time: {0}", DateTime.Now.ToString()));
            builder.AppendLine();
            builder.AppendLine(ex.ToString());
            builder.AppendLine("*************************************************************");
            builder.AppendLine();

            // if we are not null here then we were 
            if (logErrorMessage == null)
               try
               {
                  System.IO.File.WriteAllText(Globals.ApplicationDataPath + Globals.ErrorLog, builder.ToString());
               }
               catch (System.IO.IOException ioex)
               {
                  logErrorMessage = ioex.Message;
               }

            if (logErrorMessage != null)
               builder.AppendLine(string.Format("Could not log error to {1}: {0}", logErrorMessage, Globals.FullErrorLogPath));
            else
               builder.AppendLine(string.Format("This error has been logged to {0}", Globals.ApplicationDataPath, Globals.ErrorLog));

            MessageBox.Show(builder.ToString());
         }
      }
   }

   public static class Globals
   {
      private static string myApplicationDataPath = System.IO.Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "XenServerUpdater");
      private static string myErrorLog = "XenServerUpdaterErrors.log";

      public static string ApplicationDataPath
      {
         get { return myApplicationDataPath; }
      }

      public static string ErrorLog
      {
         get { return myErrorLog; }
      }

      public static string FullErrorLogPath
      {
         get { return System.IO.Path.Combine(myApplicationDataPath, myErrorLog); }
      }
   }
}
