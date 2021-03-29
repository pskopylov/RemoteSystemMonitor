using System;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace RemoteHardwareMonitor.Src.Server
{
    class IPAdressManager
    {

        public static string GetLocalIPAddress()
        {
            try
            {
                return NetworkInterface.GetAllNetworkInterfaces()
                    .Where(network => HasGatewayAddress(network))
                    .Where(network => IsEthernet(network) || IsWireless(network))
                    .Select(network => network.GetIPProperties().UnicastAddresses)
                    .First()
                    .Where(ipInfo => ipInfo.Address.AddressFamily == AddressFamily.InterNetwork)
                    .First()
                    .Address.ToString();
            } catch (InvalidOperationException)
            {
                throw new Exception("No network adapters with an IPv4 address in the system!");
            }
        }

        private static bool HasGatewayAddress(NetworkInterface network)
        {
            return network.GetIPProperties().GatewayAddresses.FirstOrDefault() != null;
        }

        private static bool IsEthernet(NetworkInterface network)
        {
            return network.NetworkInterfaceType == NetworkInterfaceType.Ethernet;
        }

        private static bool IsWireless(NetworkInterface network)
        {
            return network.NetworkInterfaceType == NetworkInterfaceType.Wireless80211;
        }

    }
}
