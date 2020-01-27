using _0_Util;
using _2_Builder.Builder;

namespace _2_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Builder Pattern karmaşık sınıfların nesne üretim sürecini Client'tan gizleyen bir pattern’dir.
            GenericExtensions.WriteToConsole("Merhaba Dünya!");
            GenericExtensions.WriteToConsole("Builder Pattern Örneği\n");

            // Client ilk olarak Director nesnesi alan 
            // ve üretime geçen Builder nesnesini oluşturur.
            // Oluşturulan nesneler Builder nesnesinden üretilmiş olur.
            var director = new Director();
            var builder = new ProductBuilder();
            director.Builder = builder;

            GenericExtensions.WriteToConsole("Temel ürün üretimi:");
            director.buildMinimalViableProduct();
            GenericExtensions.WriteToConsole(builder.GetProduct().ListParts());

            GenericExtensions.WriteToConsole("Full ürün üretimi:");
            director.buildFullFeaturedProduct();
            GenericExtensions.WriteToConsole(builder.GetProduct().ListParts());

            // Builder Pattern Director olmadan da kullanılabilir.
            GenericExtensions.WriteToConsole("Özel ürün üretimi:");
            builder.BuildPartA();
            builder.BuildPartC();
            GenericExtensions.WriteToConsole(builder.GetProduct().ListParts());

            "\nDevam etmek için enter e basınız".WriteToConsole();
            System.Console.ReadLine();
        }
    }
}
