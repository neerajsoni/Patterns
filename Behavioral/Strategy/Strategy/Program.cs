using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            IValidationStrategy v = new VisaCard();
            IValidationStrategy m = new MasterCard();

            CredCardProcessor p1 = new CredCardProcessor(v);
            p1.SubmitPayment("5", 10);

            CredCardProcessor p2 = new CredCardProcessor(m);
            p2.SubmitPayment("5", 10);

            Console.ReadLine();
        }
    }
}
