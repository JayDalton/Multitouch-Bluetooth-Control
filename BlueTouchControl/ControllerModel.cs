using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Security.ExchangeActiveSyncProvisioning;
using Windows.System.Profile;
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

            // take ID from device-app
            var id1 = GetHardwareId();

            GetSystemInfo();

            // take id from BT-device
            var id2 = GetBluetoothId();
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

        private void GetSystemInfo()
        {
            var deviceInformation = new EasClientDeviceInformation();
            var Model = deviceInformation.SystemProductName;
            var Manufracturer = deviceInformation.SystemManufacturer;
            var Name = deviceInformation.FriendlyName;
            var OSName = deviceInformation.OperatingSystem;
        }

        private static string GetHardwareId()
        {
            if (Windows.Foundation.Metadata.ApiInformation.IsTypePresent("Windows.System.Profile.HardwareIdentification"))
            {
                var token = HardwareIdentification.GetPackageSpecificToken(null);
                var hardwareId = token.Id;
                var cert = token.Certificate;
                var sign = token.Signature;
                var dataReader = Windows.Storage.Streams.DataReader.FromBuffer(hardwareId);

                byte[] bytes = new byte[hardwareId.Length];
                dataReader.ReadBytes(bytes);

                return BitConverter.ToString(bytes).Replace("-", "");
            }

            throw new Exception("NO API FOR DEVICE ID PRESENT!");
        }

        private string GetBluetoothId()
        {
            return string.Empty;
        }

        #endregion Methods
    }
}
