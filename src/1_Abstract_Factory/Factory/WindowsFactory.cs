using _1_Abstract_Factory.AbstractFactory;
using _1_Abstract_Factory.Concrete;
using _1_Abstract_Factory.Interface;

namespace _1_Abstract_Factory.Factory
{
    public class WindowsFactory : ToolFactory
    {
        public override IDialog CreateDialog()
        {
            return new WindowsDialog();
        }

        public override IToolbar CreateToolbar()
        {
            return new WindowsToolbar();
        }
    }
}
