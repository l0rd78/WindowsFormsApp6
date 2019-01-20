using System;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using Titanium.Web.Proxy;
using Titanium.Web.Proxy.EventArguments;
using Titanium.Web.Proxy.Models;


namespace WindowsFormsApp6
{

    public partial class Form1 : Form
    {
        TWP cl = new TWP();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            cl.StopProxySrvr();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cl.CreateProxySrvr();
        }
    }
} 