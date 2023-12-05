using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Diagnostics;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Runtime.Remoting.Messaging;

namespace XBYNUM_BFM1_TASK1
{

    public static class Inventory
    {
        public static BindingList<Product> AllProducts = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();

        // Products
        public static void addProduct(Product product) 
        { 
            AllProducts.Add(product); 
        }
        public static bool removeProduct(int ProductID) 
        {
            Product productToRemove = lookupProduct(ProductID);
            AllProducts.Remove(productToRemove);
            return true;
        }
        public static Product lookupProduct(int ProductID) 
        {
            Product product = AllProducts.Single(c => c.ProductID == ProductID);
            return product;
        }
        public static void updateProduct(int ProductID, Product product) 
        {
            Product modifiedData = lookupProduct(ProductID);
            removeProduct(modifiedData.ProductID);
            product.ProductID = ProductID;
            addProduct(product);
        }

        // Parts
        public static void addPart(Part part) 
        { 
            AllParts.Add(part); 
        }
        public static bool deletePart(Part part) 
        {
            AllParts.Remove(part);
            return true;
        }
        public static Part lookupPart(int PartID) 
        {
            Part item = AllParts.Single(c => c.PartID == PartID);
            return item;
        }   
        public static void updatePart(int PartID, Part part) 
        {
            Part modifiedData = lookupPart(PartID);
            deletePart(modifiedData);
            part.PartID = Convert.ToInt32(modifyPartForm.selectedPartID);
            addPart(part);
        }
    }
}
