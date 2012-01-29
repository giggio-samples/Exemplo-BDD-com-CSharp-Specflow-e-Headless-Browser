using SimpleBrowser;
using TechTalk.SpecFlow;

namespace Pedido.Specs.Features.Support
{
    [Binding]
    public class BaseStep
    {
        public static Browser Browser { get; set; }
    }
}