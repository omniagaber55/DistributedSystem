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

namespace Server
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
            startServer();
        }
        void startServer()
        {

            HttpChannel channel = new HttpChannel(50501);
            ChannelServices.RegisterChannel(channel, false);
            Type share = typeof(Operation);
            RemotingConfiguration.RegisterWellKnownServiceType(share, "Add", WellKnownObjectMode.SingleCall);
            RemotingConfiguration.RegisterWellKnownServiceType(share, "mod", WellKnownObjectMode.SingleCall);
            RemotingConfiguration.RegisterWellKnownServiceType(share, "sub", WellKnownObjectMode.SingleCall);
            RemotingConfiguration.RegisterWellKnownServiceType(share, "mul", WellKnownObjectMode.SingleCall);
            RemotingConfiguration.RegisterWellKnownServiceType(share, "div", WellKnownObjectMode.SingleCall);

        }

        private void Server_Load(object sender, EventArgs e)
        {

        }
        
    }
}
