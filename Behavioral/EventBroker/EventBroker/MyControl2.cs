using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EventBrokerPattern
{
    public partial class MyControl2 : UserControl
    {
        public MyControl2()
        {
            InitializeComponent();
        }

        EventBroker _broker;
        public void SetEventBroker(EventBroker broker)
        {
            _broker = broker;
            //_broker.Register("MyEvent", new MethodInvoker(OnMyEvent));
            _broker.Register("MyEvent", new EventBroker.SubscriptionsCallback(OnMyEvent));
        }
        private void OnMyEvent(string arg)
        {
            //labelResult.Text = "Event triggered! " + arg;
            labelResult.Text += arg;
            _broker.OnEvent("MyEvent2", "lbl,");
        }
    }
}
