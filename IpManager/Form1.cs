using IpManager.Models;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace IpManager
{
    public partial class Form1 : Form
    {
        private AppContext _context;
        private string cloumnToSort = "";
        private bool _sortAscending = true;

        public Form1()
        {
            InitializeComponent();
            _context = new AppContext();
            LoadDevices();
        }

        private void LoadDevices()
        {
            dataView.DataSource = _context.Devices.ToList();
        }

        private void AddDevice(string ipAddress, string hostname, bool isEnabled)
        {
            if (_context.Devices.Any(d => d.IpAddress == "0.0.0.0" || d.Hostname == "hostname to change"))
            {
                MessageBox.Show("To add a new device, all IP addresses must be different from '0.0.0.0' and hostnames different from 'hostname to change'.");
                return;
            }
            if (!Validator.IsValidIpAddress(ipAddress))
            {
                MessageBox.Show("Invalid IP address format.");
                return;
            }
            if (string.IsNullOrWhiteSpace(hostname))
            {
                MessageBox.Show("Hostname cannot be empty.");
                return;
            }
            if (_context.Devices.Any(d => d.IpAddress == ipAddress))
            {
                MessageBox.Show("This IP address already exists.");
                return;
            }
            if (_context.Devices.Any(d => d.Hostname == hostname))
            {
                MessageBox.Show("This hostname already exists.");
                return;
            }

            var device = new Device
            {
                IpAddress = ipAddress,
                Hostname = hostname,
                IsEnabled = isEnabled
            };

            _context.Devices.Add(device);
            _context.SaveChanges();
            LoadDevices();
        }

        private void RemoveSelectedDevices()
        {
            foreach (DataGridViewRow row in dataView.SelectedRows)
            {
                int deviceId = (int)row.Cells[0].Value;
                var device = _context.Devices.Find(deviceId);
                if (device != null)
                {
                    _context.Devices.Remove(device);
                }
            }
            _context.SaveChanges();
            LoadDevices();
        }

        private void SearchDevices()
        {
            string ipSearch = searchIp.Text.Trim();
            string hostnameSearch = searchHostname.Text.Trim();

            var devices = _context.Devices.AsQueryable();

            if (!string.IsNullOrEmpty(ipSearch))
            {
                devices = devices.Where(d => d.IpAddress.Contains(ipSearch));
            }

            if (!string.IsNullOrEmpty(hostnameSearch))
            {
                devices = devices.Where(d => d.Hostname.Contains(hostnameSearch));
            }

            dataView.DataSource = devices.ToList();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddDevice("0.0.0.0", "hostname to change", false);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            RemoveSelectedDevices();
        }

        private void dataView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataView.Rows[e.RowIndex];
            int deviceId = (int)row.Cells[0].Value;
            string ipAddress = row.Cells[1].Value.ToString();
            string hostname = row.Cells[2].Value.ToString();
            bool isEnabled = (bool)row.Cells[3].Value;

            if (!Validator.IsValidIpAddress(ipAddress))
            {
                MessageBox.Show("Invalid IP address format.");
                return;
            }
            if (string.IsNullOrWhiteSpace(hostname))
            {
                MessageBox.Show("Hostname cannot be empty.");
                return;
            }
            if (_context.Devices.Any(d => d.IpAddress == ipAddress && d.Id != deviceId))
            {
                MessageBox.Show("This IP address already exists.");
                return;
            }
            if (_context.Devices.Any(d => d.Hostname == hostname && d.Id != deviceId))
            {
                MessageBox.Show("This hostname already exists.");
                return;
            }

            var device = _context.Devices.Find(deviceId);
            if (device != null)
            {
                device.IpAddress = ipAddress;
                device.Hostname = hostname;
                device.IsEnabled = isEnabled;
                _context.SaveChanges();
            }
        }

        private void dataView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string columnName = dataView.Columns[e.ColumnIndex].DataPropertyName;
            var devices = _context.Devices.AsQueryable();

            if (columnName != cloumnToSort)
            {
                devices = devices.OrderBy(d => EF.Property<object>(d, columnName));
                cloumnToSort = columnName;
                _sortAscending = true;
            }
            else if (_sortAscending)
            {
                devices = devices.OrderBy(d => EF.Property<object>(d, columnName));
            }
            else
            {
                devices = devices.OrderByDescending(d => EF.Property<object>(d, columnName));
            }

            _sortAscending = !_sortAscending;
            dataView.DataSource = devices.ToList();
        }

        private void searchIp_TextChanged(object sender, EventArgs e)
        {
            SearchDevices();
        }

        private void searchHostname_TextChanged(object sender, EventArgs e)
        {
            SearchDevices();
        }

        private void subnetCalculatorButton_Click(object sender, EventArgs e)
        {
            SubnetForm subnetForm = new SubnetForm();
            subnetForm.ShowDialog();
        }
    }
}
