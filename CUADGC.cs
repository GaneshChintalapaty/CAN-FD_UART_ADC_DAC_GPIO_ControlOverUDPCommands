using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAN_FD_UART_ADC_DAC_GPIO_ControlOverUDPCommands
{
    public partial class CUADGC : Form
    {
        public CUADGC()
        {
            InitializeComponent();
        }

        #region Global Variables
        /// <summary>
        /// Include All Global Variables here
        /// </summary>

        //Static int variables
        public static int port = 9876;  //Port number for this form
        //End Static int variables


        //sting Variables
        string BroadcastIP = "255.255.255.255";
        string data = "";   //String to store received data
        //End string variables

        //Variables and functions related to UDP protocol
        UdpClient Server = new UdpClient(port); //Form Server initialized, to receive data from other clients
        private delegate void UpdateStatusDelegate(byte[] status);  // Status delegate
        private UpdateStatusDelegate updateStatusDelegate = null;
        //EndVariables and functions related to UDP protocol
        #endregion

        #region Load CUADGC GUI
        /// <summary>
        /// The following funtion is called when the form is opening.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CUADGC_GUI_Load(object sender, EventArgs e)
        {
            // Initialise the delegate which updates the status
            this.updateStatusDelegate = new UpdateStatusDelegate(this.UpdateStatus);
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0)) //Create new socket
            {
                socket.Connect("8.8.8.8", 65530);   //Connect to DNS
                IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;   //Read the local EndPoint
            }
            try
            {
                Server.BeginReceive(new AsyncCallback(recv), null); //Start receiving data. If data received go to recv interuppt function
            }
            catch
            {
                MessageBox.Show("UDP Server Error");   //UDP Server Error
            }
        }
        #endregion

        #region Received UDP data and send to UpdateStatus function
        /// <summary>
        /// The following funtion is used to receive UDP data asyncronously. The received data is sent to UpdateStatus function.
        /// </summary>
        /// <param name="res"></param>
        void recv(IAsyncResult res)
        {
            IPEndPoint RemoteIP = new IPEndPoint(IPAddress.Any, 0); //Assign remote IP and receive data from any IP address
            byte[] received = Server.EndReceive(res, ref RemoteIP); //Once data received stop server and store the data
            this.Invoke(this.updateStatusDelegate, new object[] { received });
            Server.BeginReceive(new AsyncCallback(recv), null); //Begin to receive data
        }
        #endregion

        #region Deceipher received UDP data
        /// <summary>
        /// The following function is used to deceipher the received UDP data based on command ID received
        /// </summary>
        /// <param name="status"></param>
        private void UpdateStatus(byte[] status)
        {
            Boolean validateDataFrame = false;  //Boolean to verify checkSum
            byte[] checkSum = null; //Array to calculate checksum value
            UInt16 valueADC = 0;    //Variable to store received ADC value

            if ((status[0] == 0x12) && (status[1] == 0x34) && (status[7] == 0xFF))  //If header and footer bytes match
            {
                switch (status[3])   //Switch based on byte count
                {
                    case 0xA0:  //Positive ADC value
                        {
                            checkSum = new byte[7]; //Initilize array of 7 elements
                            Array.Copy(status, 0, checkSum, 0, 7);  //Copy all elements of status array to checkSum array except footer byte
                            validateDataFrame = checkSumValidation(checkSum);   //Validate received UDP Data Frame
                            if (validateDataFrame == true)
                            {
                                valueADC = (ushort)(((ushort)status[4] << 8) | ((ushort)status[5]));    //Calculate ADC value
                                label1.Text = "+" + valueADC;   //Represent the received data
                            }
                        }
                        break;
                    case 0xA1:  //Negative ADC value
                        {
                            checkSum = new byte[7]; //Initilize array of 7 elements
                            Array.Copy(status, 0, checkSum, 0, 7);  //Copy all elements of status array to checkSum array except footer byte
                            validateDataFrame = checkSumValidation(checkSum);   //Validate received UDP Data Frame
                            if (validateDataFrame == true)
                            {
                                valueADC = (ushort)(((ushort)status[4] << 8) | ((ushort)status[5]));    //Calculate ADC value
                                label1.Text = "-" + valueADC;   //Represent the received data
                            }
                        }
                        break;
                    default:
                        {
                            //Do Nothing...
                        }
                        break;
                }
            }
        }
        #endregion

        #region Check Sum Calculation
        /// <summary>
        /// The following function will calculate the checksum value, verify it with the received checksum byte and validates the UDP data frame
        /// </summary>
        /// <param name="bytesReceived"></param>
        /// <returns>boolean result</returns>
        private Boolean checkSumValidation(byte[] bytesReceived)
        {
            uint calculatedCheckSum = 0;
            for (uint i = 0; i < bytesReceived.Length - 1; i++)
            {
                calculatedCheckSum = calculatedCheckSum ^ bytesReceived[i]; //XOR all bytes except the checksum byte
            }

            if (calculatedCheckSum == bytesReceived[bytesReceived.Length - 1])
            {
                return true;    //If calculated checksum to equal to received checksum byte, then the data is valid
            }
            else
            {
                return false;   //If invalid UDP data frame received
            }
        }
        #endregion
    }
}
