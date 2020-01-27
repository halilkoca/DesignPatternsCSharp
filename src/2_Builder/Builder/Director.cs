using _2_Builder.Interface;

namespace _2_Builder.Builder
{
    // Director sadece building adımlarını belirli bir sıra ile yürütmekten sorumludur.
    // Özel olarak üretilmesi istenen parçaları üretmesi işleri kolaylaştırır.
    // Açıkçası Director sınıfı isteğe bağlıdır.
    // Çünkü Client sınıfı Builder sınıfını direkt kontrol edebilir.
    public class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }

        // Director çeşitli ürün varvasyonları oluşturabilir.
        public void buildMinimalViableProduct() => this._builder.BuildPartA();

        public void buildFullFeaturedProduct()
        {
            this._builder.BuildPartA();
            this._builder.BuildPartB();
            this._builder.BuildPartC();
        }
    }
}
