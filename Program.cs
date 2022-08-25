using System;

namespace ReadWriteini
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IniFile settingsIni = new IniFile (@".\\testdata.ini");

            string executionMode = settingsIni.Read ("BrowserName", "Browserinfo").ToLower (); //.Equals ("yes");
            Console.WriteLine (executionMode);

            settingsIni.Write("BrowserName", "IE", "Browserinfo");

            string WebdriverToUse = settingsIni.Read ("WebBrowserLocation", "Browserinfo").ToLower ();
            Console.WriteLine (WebdriverToUse);

            settingsIni.Write("TimeOut", "4000", "Browserinfo");

            string timeOut = settingsIni.Read ("TimeOut", "Browserinfo");
            Console.WriteLine (timeOut);

            settingsIni.Write("url", "www.google.com", "AppUnderTest");
            string appUrl = settingsIni.Read ("url", "AppUnderTest").ToLower ();
            Console.WriteLine (appUrl);
        }
    }
}
