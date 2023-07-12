using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core.ib0t
{
    class CustomData
    {
        public ushort size { get; set; }
        public ushort count { get; set; }
        public String data { get; set; }
        public String sender { get; set; }

        public String toPacket()
        {
            return String.Format("{0},{1}:{2}{3}",this.sender.Length,this.data.Length,this.sender,this.data);
        }
    }
}
