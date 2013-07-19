using System;
using System.Windows.Forms;
using command.Properties;

namespace UICallback
{
	public partial class Form1 : Form
	{
        Command cmd;
        private delegate void UpdateStatus(TextBox tb, int data);

		public Form1()
		{
			InitializeComponent();
		}

		private void CmdInvoker(object o)
		{
            ((ICommand)o).Execute();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			cmd = new Command(10);
            cmd.IterativeStatusEvent = new CommandEvents.IterativeStatus(StatusUpdate1);
            cmd.IterativeStatusEvent += new CommandEvents.IterativeStatus(StatusUpdate2);

            System.Threading.ThreadPool.QueueUserWorkItem(CmdInvoker, cmd);
		}

        private void UpdateUI(TextBox tb, int data)
        {
            if (textBox1.InvokeRequired)
            {
                tb.Invoke(new UpdateStatus(UpdateUI), new object[] {tb, data });
            }
            else
            {
                tb.Text += data + Resources.TextSeparator;
            }
        }

        private void StatusUpdate1(int i)
        {
            UpdateUI(textBox1, i);
        }

        private void StatusUpdate2(int i)
        {
            System.Threading.Thread.Sleep(1000);
            UpdateUI(textBox2, i);
        }

	}
}
