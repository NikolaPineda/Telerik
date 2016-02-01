using System;

namespace MobilePhone
{
    internal class GSM_Start
    {
        private static void Main()
        {
            var premiumDisplay = new Display(4.5, ColorDepth._32Bit);
            var mediocreDisplay = new Display(3.5, ColorDepth._16Bit);
            var poorDisplay = new Display(2.5, ColorDepth._8bit);
            var premiumBattery = new Battery("Sanyo-SN532e", 120, 20, BatteryTypes.LiPol);
            var mediocreBattery = new Battery("Shanzungmang-2341", 80, 15, BatteryTypes.LiIon);
            var poorBattery = new Battery("Mistucura-1224fe", 40, 5, BatteryTypes.NiMh);

            var gsmArray = new GSM[4];
            gsmArray[0] = new GSM("LG-G6", "LG", 600, "Typcho", poorBattery, mediocreDisplay);
            gsmArray[1] = new GSM("Hwawei - G6", "Hwawei", 600.5, "Nikola", mediocreBattery, premiumDisplay);
            gsmArray[2] = new GSM("Nokia", "Lumia920", 500.50, "Gosho", premiumBattery, mediocreDisplay);
            gsmArray[3] = new GSM("Samsung-S4", "Samsung", 800, "Pena", premiumBattery, mediocreDisplay);
            foreach (var item in gsmArray)
            {
                Console.WriteLine(item);
                Console.WriteLine("New GSM");
            }
            Console.WriteLine(GSM.Iphone4S);

            GSMCallHistoryTest.TestHistory();
        }
    }
}