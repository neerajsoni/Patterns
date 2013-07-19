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
    public partial class MyControl3 : UserControl
    {
        public MyControl3()
        {
            InitializeComponent();
        }

        EventBroker _broker;
        public void SetEventBroker(EventBroker broker)
        {
            _broker = broker;
            _broker.Register("MyEvent", new EventBroker.SubscriptionsCallback(OnMyEvent));
            _broker.Register("MyEvent2", new EventBroker.SubscriptionsCallback(OnMyEvent));
        }
        private void OnMyEvent(string arg)
        {
            //labelResult.Text = "Event triggered! " + arg;
            labelResult.Text += arg;
        }
    }
}
