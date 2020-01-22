using _1_Abstract_Factory.Interface;
using System;

namespace _1_Abstract_Factory.Concrete
{
    public class WindowsToolbar : IToolbar
    {
        public string GetToolbar()
        {
            return "Windows Toolbar Oluşturuldu";
        }
    }
}
