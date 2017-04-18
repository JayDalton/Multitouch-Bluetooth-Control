using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Die Elementvorlage "Leere Seite" wird unter https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x407 dokumentiert.

namespace BlueTouchControl
{
    /// <summary>
    /// Eine leere Seite, die eigenständig verwendet oder zu der innerhalb eines Rahmens navigiert werden kann.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        ControllerModel ViewModel { get; set; }

        public MainPage()
        {
            this.InitializeComponent();
            ViewModel = new ControllerModel();
        }

        private void CanvasPointerMoved(object sender, PointerRoutedEventArgs e)
        {
            if (sender is Canvas)
            {
                var pp = e.GetCurrentPoint(sender as Canvas);
                var kind = pp.Properties.PointerUpdateKind;
                if (kind == Windows.UI.Input.PointerUpdateKind.LeftButtonPressed)
                {

                }
                ViewModel.AddPointerEvent(
                    pp.PointerId,
                    pp.Timestamp,
                    pp.Position
                );

                //TouchPoint tp = e.GetTouchPoint(sender as Canvas);
                //addTouchEvent(new VMicroscopeBluetooth.TouchAction()
                //{
                //    ID = e.TouchDevice.Id,
                //    Time = e.Timestamp,
                //    Position = tp.Position,
                //    Touch = VMicroscopeBluetooth.TouchAction.Event.Enter
                //});

                e.Handled = true;
            }
        }

        private void CanvasPointerPressed(object sender, PointerRoutedEventArgs e)
        {

        }

        private void CanvasPointerReleased(object sender, PointerRoutedEventArgs e)
        {

        }

        private void SendTimeStampClick(object sender, RoutedEventArgs e)
        {

        }

        private void SendBenchmarkClick(object sender, RoutedEventArgs e)
        {

        }

        private void ConnectDeviceClick(object sender, RoutedEventArgs e)
        {

        }

        private void CloseApplicationClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }

        private void CanvasSizeChanged(object sender, SizeChangedEventArgs e)
        {
            var x = e.NewSize;
        }
    }
}
