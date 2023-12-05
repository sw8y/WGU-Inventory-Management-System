using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XBYNUM_BFM1_TASK1
{
    public class Product
    {
        public static BindingList<Part> AssociatedParts = new BindingList<Part>();
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public void addAssociatedPart(Part associatedPart)
        {
            AssociatedParts.Add(associatedPart);
        }
        public bool removeAssociatedPart(int partID) 
        {
            Part partToRemove = lookupAssociatedPart(partID);
            AssociatedParts.Remove(partToRemove);
            return true; }
        public Part lookupAssociatedPart(int partID) 
        {
            Part part = AssociatedParts.SingleOrDefault(c => c.PartID == partID);
            return part;
        }
    }
}
