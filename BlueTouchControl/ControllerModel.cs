using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;

namespace BlueTouchControl
{
    public class ControllerModel : NotificationBase
    {
        #region Fields

        bool progressing;
        Brush statusDisplay;
        string statusLabel;

        #endregion

        public ControllerModel()
        {

        }

        #region Properties

        public bool Progressing
        {
            get { return progressing; }
            set { SetProperty(ref progressing, value); }
        }

        public Brush Display
        {
            get { return statusDisplay; }
            set { SetProperty(ref statusDisplay, value); }
        }

        public string Label
        {
            get { return statusLabel; }
            set { SetProperty(ref statusLabel, value); }
        }


        public ObservableCollection<Shape> Shapes { get; set; }

        #endregion Properties

        #region Methods

        public void AddPointerEvent(uint id, ulong time, Point posi)
        {

        }
        
        #endregion Methods
    }
}
