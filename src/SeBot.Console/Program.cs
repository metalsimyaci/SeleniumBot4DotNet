// See https://aka.ms/new-console-template for more information
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeBot.Console
{
    public class Program
    {
        public const string DRIVER_PATH = @"D:\Tools\\ChromeDriver\";
        public const string DRIVER_VERSION = @"96.0.4664.45";

        public static void Main(string[] args)
        {
            var driver = new ChromeDriver($@"{DRIVER_PATH}{DRIVER_VERSION}\");

            try
            {
                driver.Navigate().GoToUrl("https://google.com");
                driver.Manage().Window.Maximize();
                var textBox = driver.FindElement(By.CssSelector(@"input[type=Text]"));
                if(textBox != null)
                {
                    textBox.SendKeys("Hasan URAL");
                    textBox.Submit();
                }

                System.Console.ReadKey();
            }
            catch(Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
            finally
            {
                driver?.Close();
            }
        }


    }

}