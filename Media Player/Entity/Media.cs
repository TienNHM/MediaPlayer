using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Player.Entity
{
    public class Media
    {
        public string Name { get; set; }
        public string FilePath { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
