using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Truphone.Domain
{
    public class Device : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public Brand Brand { get; set; }

        public Device()
        {
            Brand = new Brand();
        }
    }
}
