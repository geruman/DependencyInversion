using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_inversion
{
    public class OrderService
    {
        public readonly IMailService mailService;
        public OrderService(IMailService mailService)
        {
            this.mailService = mailService;
        }
        public void Create(Order order)
        {
            mailService.Send(order);
           

        }
    }
}
