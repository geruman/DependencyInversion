using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_inversion
{
    public class SendGrindService : IMailService
    {
        public void Send(Order order)
        {
            Console.WriteLine("Sendgrid sending mail, much more professional than the competition.");
            Console.WriteLine("Order " + order.OrderName);
        }
    }
}
