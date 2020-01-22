using _0_Util;
using _1_Abstract_Factory.AbstractFactory;
using _1_Abstract_Factory.Factory;
using _1_Abstract_Factory.Interface;

namespace _1_Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            "Merhaba Dünya!".WriteToConsole();
            "Abstract Factory Pattern Örneği\n".WriteToConsole();

            bool isMacosx = false;
            
            ToolFactory factory = isMacosx ?
                    factory = new MacosxFactory()
                    : factory = new WindowsFactory();
            
            IDialog dialog = factory.CreateDialog();
            dialog.GetDialog().WriteToConsole();

            IToolbar toolbar = factory.CreateToolbar();
            toolbar.GetToolbar().WriteToConsole();

            "\nDevam etmek için enter e basınız".WriteToConsole();
            System.Console.ReadLine();
        }
    }
}
