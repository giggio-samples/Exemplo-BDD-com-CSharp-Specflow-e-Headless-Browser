using SimpleBrowser;
using TechTalk.SpecFlow;

namespace Pedido.Specs.Features.Support
{
    [Binding]
    public class SimpleBrowserBindings 
    {

        [BeforeFeature("web")]
        public static void StartBrowser()
        {
            BaseStep.Browser = new Browser();
        }

        
    }
}
