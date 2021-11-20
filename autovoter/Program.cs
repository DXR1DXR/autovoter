using CefSharp.OffScreen;
using CefSharp;
using System;
using System.Threading.Tasks;

namespace autovoter
{
    class Program
    {
        static void Main(string[] args)
        {
            MainAsync().Wait();
            
        }

        private static async Task MainAsync()
        {
            ChromiumWebBrowser browser = new ChromiumWebBrowser();
            browser = new ChromiumWebBrowser("http://usynovite.mosreg.ru/konkurs-specialistov-organov-opeki-i-popechitelstva-2021-golosovanie");
            await browser.WaitForInitialLoadAsync();
            browser.ExecuteScriptAsync(@"document.getElementsByClassName('option')[1].innerText", true);
            browser.ExecuteScriptAsync(@"document.getElementsByClassName('option')[1].click()", true);
            //Console.WriteLine((await browser.EvaluateScriptAsync(@"document.getElementsByClassName('option')[1].textContent")).ToString()); 
            browser.ExecuteScriptAsync(@"document.getElementsByName('op')[0].click()", true);
            Console.ReadKey();
        }
    }
}
