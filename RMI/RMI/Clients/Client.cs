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
namespace Clients
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
            operation = (Operation)Activator.GetObject(typeof(Operation), "http://localhost:50501/Add","http://localhost:50501/mod");
            operation = (Operation)Activator.GetObject(typeof(Operation),"http://localhost:50501/div", "http://localhost:50501/mul");
            operation = (Operation)Activator.GetObject(typeof(Operation),  "http://localhost:50501/sub");


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            label3.Text = operation.Add(x, y).ToString();

        }

        

        private void mod_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            label3.Text = operation.mod(x, y).ToString();
        }

        

        private void mul_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            label3.Text = operation.mul(x, y).ToString();
        }

        private void div_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            label3.Text = operation.div(x, y).ToString();
        }

        private void sub_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            label3.Text = operation.sub(x, y).ToString();
        }
        private void Client_Load(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
