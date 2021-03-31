using System;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text.RegularExpressions;

namespace RemoteSystemMonitor.Src.Server
{
    class IPAdressManager
    {
        private const string LOCAL_GATEWAY_PATTERN = @"192.168.(0|1).1";

        public static string GetLocalIPAddress()
        {
            try
            {
                return NetworkInterface.GetAllNetworkInterfaces()
                    .Where(network => HasLocalGatewayAddress(network) && (IsEthernet(network) || IsWireless(network)))
                    .Select(network => network.GetIPProperties().UnicastAddresses)
                    .First()
                    .Where(ipInfo => IsInternetNetwork(ipInfo))
                    .First()
                    .Address.ToString();
            } catch (InvalidOperationException)
            {
                throw new Exception("No network adapters with an IPv4 address in the system!");
            }
        }

        private static bool HasLocalGatewayAddress(NetworkInterface network)
        {
            var gatewayInfo = network.GetIPProperties().GatewayAddresses.FirstOrDefault();
            if (gatewayInfo != null)
            {
                return Regex.Match(gatewayInfo.Address.ToString(), LOCAL_GATEWAY_PATTERN).Success;
            }
            return false;
        }

        private static bool IsEthernet(NetworkInterface network)
        {
            return network.NetworkInterfaceType == NetworkInterfaceType.Ethernet;
        }

        private static bool IsWireless(NetworkInterface network)
        {
            return network.NetworkInterfaceType == NetworkInterfaceType.Wireless80211;
        }

        private static bool IsInternetNetwork(UnicastIPAddressInformation ipInfo)
        {
            return ipInfo.Address.AddressFamily == AddressFamily.InterNetwork;
        }

    }
}
