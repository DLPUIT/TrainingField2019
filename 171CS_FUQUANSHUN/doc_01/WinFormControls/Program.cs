﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormControls
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new NumUpDownForm());
            // Application.Run(new PicBoxForm());
            // Application.Run(new ProBarForm());
            // Application.Run(new TabConForm());
            Application.Run(new MainForm());
        }
    }
}
