using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    internal abstract class Handler
    {
        protected Handler handler;
        public void SetNextHandler(Handler handler)
        {
            this.handler = handler;
        }
        public abstract void Handle(Request request);
    }
}
