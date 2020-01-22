using _1_Abstract_Factory.Interface;

namespace _1_Abstract_Factory
{
    public class WindowsDialog : IDialog
    {
        public string GetDialog()
        {
            return "Windows Dialog Oluşturuldu";
        }
    }
}