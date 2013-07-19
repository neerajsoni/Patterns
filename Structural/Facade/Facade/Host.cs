using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// -----------------------------------------------------------------------
// <copyright file="$safeitemrootname$.cs" company="$registeredorganization$">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------
namespace Facade
{
    /// <summary>
    /// Facade
    /// </summary>
    public class Host
    {
        public Kitchen kitchen;
        public TableAssignment tableAssignment;
        public Service service;

        public TableAssignment TableAssignment
        {
            get { return tableAssignment; }
            set { tableAssignment = value; }
        }

        public Kitchen Kitchen
        {
            get { return kitchen; }
            set { kitchen = value; }
        }

        public Service Service
        {
            get { return service; }
            set { service = value; }
        }

        public void EntertainGuest()
        {
            Kitchen = new Kitchen();
            TableAssignment = new TableAssignment();
            Service = new Service();

            Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name);
            Service.CleanTable();
            TableAssignment.AllocateTable();
            Service.TakeOrder();
            Kitchen.CookFood();
            Service.DeliverOrder();
            Service.GenerateBill();
        }
    }
}
