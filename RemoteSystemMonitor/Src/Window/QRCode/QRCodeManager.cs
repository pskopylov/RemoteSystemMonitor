using Newtonsoft.Json.Linq;
using RemoteSystemMonitor.Src.AppConfig;
using RemoteSystemMonitor.Src.Server;
using RemoteSystemMonitor.Src.Window.Data;
using System.Drawing;
using ZXing;
using ZXing.QrCode;

namespace RemoteSystemMonitor.Src.Window.QRCode
{
    class QRCodeManager
    {

        public static Bitmap Create()
        {
            var writer = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new QrCodeEncodingOptions
                {
                    Width = 125,
                    Height = 125,
                    Margin = 0
                }
            };

            return writer.Write(CreateJsonObject().ToString());
        }

        private static JToken CreateJsonObject()
        {
            string ip = IPAdressManager.GetLocalIPAddress();
            string port = ConfigManager.LoadConfig().Port;
            QRCodeData data = new QRCodeData()
            {
                Host = ip,
                Port = port
            };
            return JToken.FromObject(data);
        }

    }
}
