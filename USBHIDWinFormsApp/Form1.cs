using System.Diagnostics;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Enumeration;
using Windows.Devices.HumanInterfaceDevice;
using Windows.Foundation;
using Windows.Storage;
using Windows.Storage.Streams;

namespace USBHIDWinFormsApp
{
    public partial class Form1 : Form
    {
        HidDevice device;

        // Enumerate HID devices
        private async void enumerateHidDevices()
        {
            ushort vendorId = 0xC251;
            ushort productId = 0x4501; ;//0x4C01;//0x4301;//0x4511;
            ushort usagePage = 0xFF00;
            ushort usageId = 0x0001;

            // Create a selector that gets a HID device using VID/PID and a 
            // VendorDefined usage
            string selector = HidDevice.GetDeviceSelector(usagePage, usageId, vendorId, productId);

            // Enumerate devices using the selector
            var devices = await DeviceInformation.FindAllAsync(selector);

            if (devices.Count > 0)
            {
                // Open the target HID device
                device = await HidDevice.FromIdAsync(devices.ElementAt(0).Id, FileAccessMode.ReadWrite);

                // At this point the device is available to communicate with
                // So we can send/receive HID reports from it or 
                // query it for control descriptions
                USBFound.Text = "Device Found";
                registerForEvents();
            }
            else
            {
                // There were no HID devices that met the selector criteria
                USBFound.Text = "Device Not Found";
            }
        }

        public Form1()
        {
            InitializeComponent();
        }


        private void searchHidButton_Click(object sender, EventArgs e)
        {
            enumerateHidDevices();
        }

        private async void sendOutputReportAsync(byte reportId, byte firstByte)
        {
            var outputReport = device.CreateOutputReport(reportId);
            byte[] data = [reportId, firstByte];
            outputReport.Data = data.AsBuffer();
            Debug.WriteLine("Sending output report");
            uint bytesWritten = await device.SendOutputReportAsync(outputReport);
        }

        private void LED1_Click(object sender, EventArgs e)
        {
            byte led_1_byte = (byte)0x0;
            sendOutputReportAsync(0x00, led_1_byte);
        }

        private void LED2_Click(object sender, EventArgs e)
        {
            byte led_2_byte = (byte)0x1;
            sendOutputReportAsync(0x01, led_2_byte);
        }

        private void LED3_Click(object sender, EventArgs e)
        {
            byte led_3_byte = (byte)0x2;
            sendOutputReportAsync(0x03, led_3_byte);
        }

        private void LED4_Click(object sender, EventArgs e)
        {
            byte led_4_byte = (byte)0x3;
            sendOutputReportAsync(0x03, led_4_byte);
        }

        private void LED5_Click(object sender, EventArgs e)
        {
            byte led_5_byte = (byte)0x4;
            sendOutputReportAsync(0x04, led_5_byte);
        }

        private void LED6_Click(object sender, EventArgs e)
        {
            byte led_6_byte = (byte)0x5;
            sendOutputReportAsync(0x05, led_6_byte);
        }

        private void LED7_Click(object sender, EventArgs e)
        {
            byte led_7_byte = (byte)0x6;
            sendOutputReportAsync(0x06, led_7_byte);
        }

        private void LED8_Click(object sender, EventArgs e)
        {
            byte led_8_byte = (byte)0x7;
            sendOutputReportAsync(0x07, led_8_byte);
        }

        private void Device_InputReportReceived(object sender, HidInputReportReceivedEventArgs e)
        {
            Debug.WriteLine("Input report received");
            Debug.WriteLine(e.Report.Data.ToArray());
        }

        private void registerForEvents()
        {
            device.InputReportReceived += (sender, e) =>
            {
                Debug.WriteLine("Input report received");
                var data = e.Report.Data.ToArray();

                byte dk_state = data[1];
                int adc_state = data[1] >> 4;

                bool dk1 = (dk_state & 0x01) != 0;
                bool dk2 = (dk_state & 0x02) != 0;
                bool dk3 = (dk_state & 0x04) != 0;
                bool dk4 = (dk_state & 0x08) != 0;

                this.Invoke(new Action(() =>
                {
                    DK1.Checked = dk1;
                    DK2.Checked = dk2;
                    DK3.Checked = dk3;
                    DK4.Checked = dk4;
                    ADC.Text = adc_state.ToString();
                }));
            };
        }
    }
}