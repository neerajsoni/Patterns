using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IWindowObject controlComponent = new ControlComponent();
            IWindowObject decorationA = new DecorationA(controlComponent);
            IWindowObject decorationB = new DecorationB(controlComponent);
            IWindowObject decorationC = new DecorationC(controlComponent);
            controlComponent.draw();
            decorationA.draw();
            decorationB.draw();
            decorationC.draw();
            Console.ReadLine();

        }
    }
}
