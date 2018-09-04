using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TextBox serverTime = new TextBox();
            serverTime.Location = new Point(25, 25);
            serverTime.Text = "Server Time";
            serverTime.ReadOnly = true;
            this.Controls.Add(serverTime);


            TextBox serverLocation = new TextBox();
            serverLocation.Location = new Point(25, 100);
            serverLocation.Text = "Server Location";
            serverLocation.ReadOnly = true;
            this.Controls.Add(serverLocation);

            TextBox displayServerTime = new TextBox();
            displayServerTime.Location = new Point(25, 50);
            displayServerTime.Text = DateTime.Now.ToString();
            displayServerTime.ReadOnly = true;
            this.Controls.Add(displayServerTime);

            TextBox displayServerLocation = new TextBox();
            displayServerLocation.Location = new Point(25, 125);
            displayServerLocation.Text = System.Environment.MachineName;
            displayServerLocation.ReadOnly = true;
            this.Controls.Add(displayServerLocation);

        }


    }
}
