using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_01
{
    internal class Product02
    {
        public long ProductID { get; set; }
        public string? ProductName { get; set; }

        public override string ToString()
        {
            return $"ProductID:{ProductID},ProductName:{ProductName}";
        }
    }
}
