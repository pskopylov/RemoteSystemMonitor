using Newtonsoft.Json.Linq;
using RemoteSystemMonitor.Src.AppConfig;
using RemoteSystemMonitor.Src.Server;
using System.Drawing;
using ZXing;
using ZXing.QrCode;

namespace RemoteSystemMonitor.Src.QRCode
{
    class QRCodeManager
    {

        public static Bitmap Create(Config config)
        {
            var writer = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new QrCodeEncodingOptions
                {
                    Width = 166,
                    Height = 166,
                    Margin = 0
                }
            };

            return writer.Write(CreateJsonObject(config).ToString());
        }

        private static JToken CreateJsonObject(Config config)
        {
            string ip = IPAdressManager.GetLocalIPAddress();
            string port = config.Port;

            QRCodeData data = new QRCodeData()
            {
                Host = ip,
                Port = port
            };
            return JToken.FromObject(data);
        }

    }
}
