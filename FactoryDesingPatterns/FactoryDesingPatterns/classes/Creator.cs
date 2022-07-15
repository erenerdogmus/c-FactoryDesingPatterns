using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesingPatterns.classes
{
    public class Creator
    {
        public IProduct FactoryMethod(ProductType productType)
        {
            IProduct product = null;

            switch (productType)
            {
                case ProductType.Product1:
                    product = new IProduct1();
                    break;

                case ProductType.Product2:
                    product = new Product2();
                    break;

                case ProductType.Product3:
                    product = new IProduct3();
                    break;
            }
            return product;
        }
    }
}
