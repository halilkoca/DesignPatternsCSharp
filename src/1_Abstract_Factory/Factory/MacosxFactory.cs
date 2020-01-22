using _1_Abstract_Factory.AbstractFactory;
using _1_Abstract_Factory.Concrete;
using _1_Abstract_Factory.Interface;

namespace _1_Abstract_Factory.Factory
{
    public class MacosxFactory : ToolFactory
    {
        public override IDialog CreateDialog()
        {
            return new MacosxDialog();
        }

        public override IToolbar CreateToolbar()
        {
            return new MacosxToolbar();
        }
    }
}
