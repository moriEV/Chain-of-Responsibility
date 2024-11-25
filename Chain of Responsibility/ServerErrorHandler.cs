using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    internal class ServerErrorHandler:Handler
    {
        public override void Handle(Request request)
        {
            if (request.Type == "Server Error")
            {
                Console.WriteLine("Sever Error");
            }
            else if (handler != null)
            {
                handler.Handle(request);
            }
        }
    }
}
