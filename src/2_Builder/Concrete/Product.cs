using System.Collections.Generic;
using System.Text;

namespace _2_Builder.Concrete
{
    public class Product
    {
        private List<object> _parts = new List<object>();

        public void Add(string part) => this._parts.Add(part);

        public string ListParts()
        {
            StringBuilder str = new StringBuilder();

            for (int i = 0; i < this._parts.Count; i++)
            {
                str.Append(this._parts[i] + ", ");
            }

            str.Remove(str.Length - 2, 2); // sondaki karakter temizlendi

            return "Ürün parçaları: " + str + "\n";
        }
    }
}
