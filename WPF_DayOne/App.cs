using FormMain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPF_DayOne
{
    public class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            //Resources.Add()
            
            base.OnStartup(e);

            BT_Window win = new ();
            win.ShowDialog();
        }
    }
}
