﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Microsoft.Azure;
//using Microsoft.WindowsAzure.Storage;

namespace simulaciondig
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmSimulador());
            //CloudStorageAccount cloudstorage = CloudStorageAccount.Parse(
            //    CloudConfigurationManager.GetSetting("odanistiburcio_AzureStorageConnectionString"));
        }
    }
}
