using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
  public   class Product
    {
        private static int _no;

        public Product()
        {
            _no++;
            No = _no;
        }
        public int No { get { return _no; } set { } }
        public string Name { get; set; }
        public double Price { get; set; }
        public ProductTypes type { get; set; }

        public void Show()
        {
            Console.WriteLine($"no: {No}  name: {Name}  price: {Price}  type  :{type}");
        }
    }
}
