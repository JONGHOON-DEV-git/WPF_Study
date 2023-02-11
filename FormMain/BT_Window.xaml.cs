using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FormMain
{
    /// <summary>
    /// BT_Window.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class BT_Window : Window
    {
        public BT_Window()
        {
            InitializeComponent();

            grid1.MouseLeftButtonDown += Grid1_MouseLeftButtonDown;
            txb1.MouseLeftButtonDown += Txb1_MouseLeftButtonDown;
            this.MouseLeftButtonDown += BT_Window_mouseLeftButtonDown;

            grid1.PreviewMouseLeftButtonDown += Grid1_PreviewMouseLeftButtonDown;
            txb1.PreviewMouseLeftButtonDown += Txb1_PreviewMouseLeftButtonDown;
            this.PreviewMouseLeftButtonDown += BT_Window_PreviewMouseLeftButtonDown;
        }

        private void BT_Window_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            e.Handled = true; //여기서 후속 이벤트를 차단함.
        }

        private void Txb1_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
        }

        private void Grid1_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
        }

        private void Txb1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void Grid1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
        }

        private void BT_Window_mouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
        }
    }
}
