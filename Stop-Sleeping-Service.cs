using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Stop_sleeping
{
    public partial class Service1 : ServiceBase
    {
        private static Timer timer;

        // Specifying the file name and path.
        private static string filePath = @"D:\timer.txt";

        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            // Create and configure the timer for 1 minute.
            timer = new Timer();
            timer.Elapsed += new ElapsedEventHandler(OnTimerElapsed);
            timer.Interval = 60000; // 60,000 milliseconds.
            timer.Enabled = true;

            // Start the timer!
            timer.Start();
        }
        private void OnTimerElapsed(object source, ElapsedEventArgs e)
        {
            // Get the current date and time
            string currentDateTime = DateTime.Now.ToString();

            try
            {
                // Append the current date and time to the file on D:\
                File.AppendAllText(filePath, currentDateTime + Environment.NewLine);
            }
            catch (Exception ex)
            {
                // Handle any errors.
                EventLog.WriteEntry("Stop_sleeping Service", "Error: " + ex.Message, EventLogEntryType.Error);
            }
        }

        // Stop the timer.
        protected override void OnStop()
        {         
            timer.Stop();
            timer.Dispose();
        }
    }
}
