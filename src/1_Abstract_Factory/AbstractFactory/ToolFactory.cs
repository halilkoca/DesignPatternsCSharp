using _1_Abstract_Factory.Interface;

namespace _1_Abstract_Factory.AbstractFactory
{
    public abstract class ToolFactory
    {
        public abstract IToolbar CreateToolbar();
        public abstract IDialog CreateDialog();
    }
}
