using _1_Abstract_Factory.AbstractFactory;
using _1_Abstract_Factory.Factory;
using _1_Abstract_Factory.Interface;
using Xunit;

namespace _1_Abstract_Factory_Test
{
    public class UnitTest1
    {
        [Fact]
        public void Macosx_Uretimi()
        {
            ToolFactory factory = new MacosxFactory();

            IDialog dialog = factory.CreateDialog();
            dialog.GetDialog();

            IToolbar toolbar = factory.CreateToolbar();
            toolbar.GetToolbar();
        }

        [Fact]
        public void Windows_Uretimi()
        {
            ToolFactory factory = new WindowsFactory();

            IDialog dialog = factory.CreateDialog();
            dialog.GetDialog();

            IToolbar toolbar = factory.CreateToolbar();
            toolbar.GetToolbar();
        }
    }
}
