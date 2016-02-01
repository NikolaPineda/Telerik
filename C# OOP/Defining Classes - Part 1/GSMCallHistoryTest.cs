using System;

namespace MobilePhone
{
    internal static class GSMCallHistoryTest
    {
        public static void TestHistory()
        {
            var nokia = new GSM("Nokia", "Lumia920", 500.50, "Gosho",
                new Battery("Mistucura-1224fe", 40, 5, BatteryTypes.NiMh), new Display(3.5, ColorDepth._16Bit));

            nokia.AddCallHistory(0888124122, 210);
            nokia.AddCallHistory(0888124122, 40);
            nokia.AddCallHistory(0888124122, 80);
            nokia.AddCallHistory(0919125121, 600);
            nokia.AddCallHistory(0919125121, 10);

            nokia.ShowCalls();
            Console.WriteLine("The price of all calls is - {0}", nokia.CalculatePriceForTalk(0.37m));
            nokia.RemuveLongestCall();
            Console.WriteLine("The price of all calls is - {0}", nokia.CalculatePriceForTalk(0.37m));
            nokia.ClearCallHistory();
            nokia.ShowCalls();
        }
    }
}