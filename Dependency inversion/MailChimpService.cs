using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_inversion
{
    public class MailChimpService : IMailService
    {
        public void Send(Order order)
        {
            Console.WriteLine("ChimpMail chipsending emails...");
            Console.WriteLine("Order " + order.OrderName);
        }
    }
}
