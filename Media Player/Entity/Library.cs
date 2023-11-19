using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Player.Entity
{
    public class Library
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Status { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
