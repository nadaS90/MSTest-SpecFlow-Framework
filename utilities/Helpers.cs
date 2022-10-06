using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SpecFlowBasics.utilities
{
}
//{
    //public class Helpers
    //{

     //   public static void failureScreenSoot(IWebDriver driver, String screenSotName)
       // {
           /* ITakesScreenshot takesScreenshot = driver as ITakesScreenshot;
            var screenshot = takesScreenshot.GetScreenshot();
            string screenshotFilePath = Path.Combine(ScreeeenShots + "_screenshot.png");
            screenshot.SaveAsFile(screenshotFilePath, OpenQA.Selenium.ScreenshotImageFormat.Png);

            //This next line fails because we don't have ScenarioContext while in [BeforeFeature]
            var testContext = ScenarioContext.Current.ScenarioContainer.Resolve<TestContext>();
            testContext.AddResultFile(screenshotFilePath);
           

           Path destination = Path("./ScreenShots", screenSotName + ".PNG");
           try
           {
               Directory.CreateDirectory(destination.GetType().ToString());
                FileStream out = new FileStream(destination.ToString());
           }
           catch (Exception e)
           {
               Console.WriteLine(e);
               throw;
           }
        }*/

       // public static string ScreeeenShots { get; set; }
    

