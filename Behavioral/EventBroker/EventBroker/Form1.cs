using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EventBrokerPattern
{
    public partial class Form1 : Form
    {
        EventBroker _broker = new EventBroker();

        public Form1()
        {
            InitializeComponent();

            myControl1.SetEventBroker(_broker);
            myControl2.SetEventBroker(_broker);
            myControl3.SetEventBroker(_broker);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }
    }
}
