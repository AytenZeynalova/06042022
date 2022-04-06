using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
  public   class Store
    {
        Product[] _products = new Product[0];
        public Product[] Products { get; set; }

        public void AddGroup(Product product)
        {
            Array.Resize(ref _products, _products.Length + 1);
            _products[_products.Length - 1] = product;
        }

        public Product [] RemoveProductByNo(int no)
        {
            Product[] products = new Product[0];

            for (int i = 0; i < _products.Length; i++)
            {
                if (no != _products[i].No)
                {
                    Array.Resize(ref products, products.Length + 1);
                    products[products.Length - 1] = _products[i];
                    _products = products;
                }
                
            }
            return _products;
        }

        public Product [] FilterProductsByType(ProductTypes type)
        {
            Product[] filterenProductTypes = new Product[0];
            for (int i = 0; i < _products.Length; i++)

            {
                if (type == _products[i].type)
                {
                    Array.Resize(ref filterenProductTypes, filterenProductTypes.Length + 1);
                    filterenProductTypes[filterenProductTypes.Length - 1] = _products[i];
                    _products = filterenProductTypes;
                }

            }
            return _products;


        }

        public Product[] FilterProductByName(string name)
        {
            Product[] filteredProductsName = new Product[0];
            for (int i = 0; i < _products.Length; i++)
            {
                if (name == _products[i].Name)
                {
                    Array.Resize(ref filteredProductsName, filteredProductsName.Length + 1);
                    filteredProductsName[filteredProductsName.Length - 1] = _products[i];
                    _products = filteredProductsName;
                }
            }
            return _products;
        }
    }
}
