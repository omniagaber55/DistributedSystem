using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using OperationaLibrary;
namespace Client
{
    public partial class Client : Form
    {
        Operation operation;

        public Client()
        {
            InitializeComponent();
            ConnectToServer();
        }
        void ConnectToServer()
        {
            HttpChannel channel = new HttpChannel();

            ChannelServices.RegisterChannel(channel, false);

            //Get object from server

            if (operation == null)
            {
                operation = (Operation)Activator.GetObject(typeof(Operation),
                    "http://localhost:50501/Add");
            }
        }

        private void Client_Load(object sender, EventArgs e)
        {

        }

    
    }
}
