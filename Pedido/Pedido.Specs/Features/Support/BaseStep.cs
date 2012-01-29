using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace Pedido.Specs.Features.Support
{
    [Binding]
    public class BaseStep
    {
        public static RemoteWebDriver FF { get; set; }
    }
}