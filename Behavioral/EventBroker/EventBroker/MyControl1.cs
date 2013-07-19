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
    public partial class MyControl1 : UserControl
    {
        public MyControl1()
        {
            InitializeComponent();
        }

        EventBroker _broker;
        public void SetEventBroker(EventBroker broker)
        {
            _broker = broker;
        }
        //when user clicks button, fire the global event
        private void buttonTrigger_Click(object sender, EventArgs e)
        {
            if (_broker != null)
            {
                _broker.OnEvent("MyEvent", "btn,");
            }
        }
    }
}
