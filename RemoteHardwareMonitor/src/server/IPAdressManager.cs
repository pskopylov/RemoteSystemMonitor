using System;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace RemoteHardwareMonitor.Src.Server
{
    class IPAdressManager
    {

        private const string ETHERNET_NAME = "Ethernet";

        public static string GetLocalIPAddress()
        {
            try
            {
                return NetworkInterface.GetAllNetworkInterfaces()
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

        private static bool IsEthernet(NetworkInterface network)
        {
            return network.NetworkInterfaceType == NetworkInterfaceType.Ethernet && network.Name.Contains(ETHERNET_NAME);
        }

        private static bool IsWireless(NetworkInterface network)
        {
            return network.NetworkInterfaceType == NetworkInterfaceType.Wireless80211;
        }

    }
}
