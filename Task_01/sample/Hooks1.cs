using BoDi;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
namespace sample
{
    [Binding]
    public sealed class Hooks1
    {
        private readonly IObjectContainer _container;

        public Hooks1(IObjectContainer _container)
        {
            this._container= _container;
        }

        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        //[BeforeFeature]
        //public static void BeforeFeature() 
        //{
        //    Console.WriteLine("I am at before feature");

        //}

        //[AfterFeature]
        //public static void AfterFeature() 
        //{ Console.WriteLine("I am at after feature"); }
        
        //[BeforeScenarioBlock]
        //public void BeforeScenarioBlock()
        //{
        //    Console.WriteLine("I at before scenario block");
        //}

        //[AfterScenarioBlock]
        //public void AfterScenarioBlock()
        //{
        //    Console.WriteLine("I am at the after scenario block");
        //}

        [BeforeScenario("@tag1")]
        public void BeforeScenarioWithTag()
        {
            // Example of filtering hooks using tags. (in this case, this 'before scenario' hook will execute if the feature/scenario contains the tag '@tag1')
            // See https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html?highlight=hooks#tag-scoping

            //TODO: implement logic that has to run before executing each scenario
            Console.WriteLine("I am at tag1");
        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            // Example of ordering the execution of hooks
            // See https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html?highlight=order#hook-execution-order

            //TODO: implement logic that has to run before executing each scenario
            Console.WriteLine("I am at Before scenario with order 1");
            IWebDriver driver = new ChromeDriver();
            _container.RegisterInstanceAs<IWebDriver>(driver);
        }
        //[BeforeScenario(Order = 2)]
        //public void FirstBeforeScenario2()
        //{
        //    // Example of ordering the execution of hooks
        //    // See https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html?highlight=order#hook-execution-order

        //    //TODO: implement logic that has to run before executing each scenario
        //    Console.WriteLine("I am at Before scenario with order 2");
        //}

        [AfterScenario(Order =1)]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
            Console.WriteLine("I am at the after scenario 1");
            var driver1 = _container.Resolve<IWebDriver>();
            if(driver1 != null)
            {
                driver1.Quit();
            }
            
        }
        //[AfterScenario(Order = 2)]
        //public void AfterScenario2()
        //{
        //    //TODO: implement logic that has to run after executing each scenario
        //    Console.WriteLine("I am at the after scenario 2");
        //}
    }
}