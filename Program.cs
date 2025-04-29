using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TesteAutomatizado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            // CENÁRIO 1
            Console.WriteLine("Cenário 1: Login com dados errados");
            driver.Navigate().GoToUrl("http://automationpractice.pl/index.php?controller=authentication&back=my-account");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("email")).SendKeys("email@errado.com");
            driver.FindElement(By.Id("passwd")).SendKeys("senha123");
            driver.FindElement(By.Id("SubmitLogin")).Click();
            Thread.Sleep(2000);
            Console.WriteLine(driver.FindElement(By.ClassName("alert-danger")).Text);

            // CENÁRIO 2
            Console.WriteLine("\nCenário 2: Campos vazios");
            driver.Navigate().GoToUrl("http://automationpractice.pl/index.php?controller=authentication&back=my-account");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("SubmitLogin")).Click();
            Thread.Sleep(2000);
            Console.WriteLine(driver.FindElement(By.ClassName("alert-danger")).Text);

            // CENÁRIO 3
            Console.WriteLine("\nCenário 3: E-mail sem @");
            driver.Navigate().GoToUrl("http://automationpractice.pl/index.php?controller=authentication&back=my-account");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("email")).SendKeys("emailsemarroba");
            driver.FindElement(By.Id("passwd")).SendKeys("senha123");
            driver.FindElement(By.Id("SubmitLogin")).Click();
            Thread.Sleep(2000);
            Console.WriteLine(driver.FindElement(By.ClassName("alert-danger")).Text);

            driver.Quit();
            Console.ReadLine();
        }
    }
}
