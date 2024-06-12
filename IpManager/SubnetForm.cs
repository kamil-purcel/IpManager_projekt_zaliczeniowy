using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IpManager
{
    public partial class SubnetForm : Form
    {
        public SubnetForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            string ipAddress = ipTextBox.Text.Trim();
            string subnetMask = maskTextBox.Text.Trim();

            if (!Validator.IsValidIpAddress(ipAddress) || !Validator.IsValidIpAddress(subnetMask))
            {
                MessageBox.Show("Invalid IP address or subnet mask format.");
                return;
            }

            CalculateSubnetRange(ipAddress, subnetMask);
        }
        private void CalculateSubnetRange(string ipAddress, string subnetMask)
        {
            IPAddress ip = IPAddress.Parse(ipAddress);
            IPAddress mask = IPAddress.Parse(subnetMask);

            byte[] ipBytes = ip.GetAddressBytes();
            byte[] maskBytes = mask.GetAddressBytes();

            byte[] networkBytes = new byte[4];
            byte[] broadcastBytes = new byte[4];

            for (int i = 0; i < 4; i++)
            {
                networkBytes[i] = (byte)(ipBytes[i] & maskBytes[i]);
                broadcastBytes[i] = (byte)(networkBytes[i] | ~maskBytes[i]);
            }

            IPAddress networkAddress = new IPAddress(networkBytes);
            IPAddress broadcastAddress = new IPAddress(broadcastBytes);

            labelNetwork.Text = $"Network: {networkAddress}";
            labelBroadcast.Text = $"Broadcast: {broadcastAddress}";
            string subnetRange = $"Network: {networkAddress}, Broadcast: {broadcastAddress}";

            byte[] firstUsableIpBytes = (byte[])networkBytes.Clone();
            firstUsableIpBytes[3] += 1;

            byte[] lastUsableIpBytes = (byte[])broadcastBytes.Clone();
            lastUsableIpBytes[3] -= 1;

            IPAddress firstUsableIp = new IPAddress(firstUsableIpBytes);
            IPAddress lastUsableIp = new IPAddress(lastUsableIpBytes);
            labelUsableRange.Text = $"Usable range: {firstUsableIp} - {lastUsableIp} ";

            int usableHosts = (int)Math.Pow(2, 32 - maskBytes.Sum(b => Convert.ToString(b, 2).Count(c => c == '1'))) - 2;
            labelUsableHosts.Text = $"Usable hosts: {usableHosts}";
        }
    }
}
