using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;

namespace Pedido.Specs.Features.Support
{
    [Binding]
    public class SeleniumBindings 
    {

        [BeforeFeature("web")]
        public static void StartBrowser()
        {
            BaseStep.FF = new FirefoxDriver();
        }

        [AfterFeature("web")]
        public static void StopBrowser()
        {
            BaseStep.FF.Quit();
        }
    }
}
