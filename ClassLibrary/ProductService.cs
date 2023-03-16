using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ProductService
    {
        public List<Product> products = new List<Product>();
        public Product GetProdID(int prodid)
        {
            return products.FirstOrDefault(r => r.ID == prodid);
        }

        public void AddToList(int id, string name, int antal, decimal price)
        {
            var existing = products.FirstOrDefault(r => r.ID == id);
            if (existing == null)
                products.Add(new Product { ID = id, Name = name, antal = antal,price = price});
            else
            {
                existing.Add(antal);
            }
        }
        public int getUniqueProductsCount() => products.Count();
        public decimal Total()
        {
            return products.Sum(p => p.RowPrice());
        }

        public void RemoveProduct(int prodid, int antal)
        {
            var item = products.FirstOrDefault(r => r.ID == prodid);
            if (item == null) return;
            item.Remove(antal);
        }

        public int GetCountForProduct(int prodid)
        {
            var item = products.FirstOrDefault(r => r.ID == prodid);
            if (item == null) return 0;
            return item.antal;
        }

    }
}
