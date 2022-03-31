using System;
using System.Globalization;

namespace Date{

    class Program06 {

        public static void App() {
            
            var pt = new CultureInfo("pt-PT");
            var br = new CultureInfo("pt-BR");
            var en = new CultureInfo("en-US");
            var de = new CultureInfo("de-DE");
            var cultureActual = CultureInfo.CurrentCulture;

            Console.WriteLine(DateTime.Now.ToString("D", cultureActual));
            Console.WriteLine(DateTime.Now.ToString("D", en));
            Console.WriteLine(DateTime.Now.ToString("D", de));
            
            

            
        }
    }
}