using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XBYNUM_BFM1_TASK1
{
    public abstract class Part
    {
        public int PartID { get; set; }
        public string Name { get ; set; }
        public decimal Price {  get; set; }
        public int InStock {  get; set; }
        public int Min {  get; set; }
        public int Max {  get; set; }
    }
   
}
