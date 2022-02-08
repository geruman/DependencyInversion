using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_inversion
{
    class Program
    {
        static void Main(string[] args)
        {
            
            OrderService chimpService = new OrderService(new MailChimpService());
            OrderService gridService = new OrderService(new SendGrindService());
            chimpService.Create(new Order("Orden 1"));
            chimpService.Create(new Order("Orden 2"));
            chimpService.Create(new Order("Orden 3"));
            gridService.Create(new Order("Orden 4"));
            gridService.Create(new Order("Orden 5"));
            gridService.Create(new Order("Orden 6"));
            Console.ReadKey();

        }
    }
}
