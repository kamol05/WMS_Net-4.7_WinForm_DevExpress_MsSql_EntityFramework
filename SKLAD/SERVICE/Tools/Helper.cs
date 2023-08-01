using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Windows.Forms;

namespace SKLAD.SERVICE.Tools
{
    public class Helper
    {
        public static Control GetInstance(string strFullyQualifiedName)
        {
            Type t = Type.GetType(strFullyQualifiedName);
            return (Control)Activator.CreateInstance(t);
        }

        public static string GetPcName()
        {
            return Environment.MachineName;
        }

        public static string GetAllLocalIPv4()
        {
            var _type = NetworkInterfaceType.Ethernet;
            List<string> ipAddrList = new List<string>();
            foreach (NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (item.NetworkInterfaceType == _type && item.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (UnicastIPAddressInformation ip in item.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            ipAddrList.Add(ip.Address.ToString());
                        }
                    }
                }
            }
            var strings = ipAddrList.ToArray();
            var theString = string.Join(" ", strings);
            return theString;
        }
    }
}
