using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// -----------------------------------------------------------------------
// <copyright file="$safeitemrootname$.cs" company="$registeredorganization$">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------
namespace Strategy
{
    /// <summary>
    /// Algo client
    /// </summary>
    public class CredCardProcessor
    {
        private IValidationStrategy validationStrategy;

        public CredCardProcessor(IValidationStrategy vs)
        {
            validationStrategy = vs;
        }

        //public IValidationStrategy ValidationStrategy
        //{
        //    get { return validationStrategy; }
        //    set { validationStrategy = value; }
        //}

        public void SubmitPayment(string number, double amount)
        {
            if(validationStrategy.IsValid(number))
            {
                Console.WriteLine("request payment from " + validationStrategy.GetType().Name + " card num " + number);
            }
            else
            {
                Console.WriteLine(validationStrategy.GetType().Name + " card num "  + number + " reject");
            }
        }
    }
}
