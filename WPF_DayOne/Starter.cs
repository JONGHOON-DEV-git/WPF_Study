﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_DayOne
{
    public class Starter
    {
        [STAThread]
        public static void Main(string[] args)
        {
            App app = new();
            app.Run();
        }
    }
}
