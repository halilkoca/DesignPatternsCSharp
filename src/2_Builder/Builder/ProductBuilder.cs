using _2_Builder.Concrete;
using _2_Builder.Interface;

namespace _2_Builder.Builder
{
    public class ProductBuilder : IBuilder
    {
        private Product _product = new Product();

        // Builder her yeni instance yapılınca 
        // boş bir ürün nesnesi üretilmelidir.
        public ProductBuilder() => this.Reset();

        public void Reset() => this._product = new Product();

        public void BuildPartA() => this._product.Add("A1 parça");

        public void BuildPartB() => this._product.Add("B1 parça");

        public void BuildPartC() => this._product.Add("C1 parça");

        // 
        public Product GetProduct()
        {
            Product result = this._product;

            this.Reset();

            return result;
        }
    }
}
