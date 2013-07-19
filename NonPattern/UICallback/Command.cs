namespace UICallback
{
    public class CommandEvents
	{
		public delegate void IterativeStatus(int i);
	}

    interface ICommand
    {
        void Execute();
    }

    class Command : ICommand
	{
        public CommandEvents.IterativeStatus IterativeStatusEvent;
        private int Size{get; set;}

        public Command(int size)
        {
            Size = size;
        }

		public void Execute()
		{
			for (var i = 0; i < Size; i++)
			{
				if (IterativeStatusEvent != null)
				{
				    IterativeStatusEvent.DynamicInvoke(i);
				}
			}
		}
    }
}
