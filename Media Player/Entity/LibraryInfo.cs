using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Player.Entity
{
    public class LibraryInfo
    {
        public int Id { get; set; }
        public string LibraryCode { get; set; }
        public string MediaCode { get; set; }
        public string Status {  get; set; }

        public override string ToString()
        {
            return $"{this.LibraryCode}_{this.MediaCode}";
        }
    }
}
