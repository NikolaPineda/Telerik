using System;
using System.Collections.Generic;

namespace MobilePhone
{
    public class GSM
    {
        public static readonly GSM iphone4S = new GSM("IPhone-4S", "Apple", 1200, "Tosho",
            new Battery("sanyo-321r54D", 120, 14, BatteryTypes.LiPol), new Display(4.5, ColorDepth._32Bit));

        private readonly List<Call> listOfCalls = new List<Call>();
        private double price;

        public GSM(string modelX, string manufX) : this(modelX, manufX, 50, null, null, null)
        {
        }

        public GSM(string modelX, string manufX, string ownerX) : this(modelX, manufX, 50, ownerX, null, null)
        {
        }

        public GSM(string modelX, string manufX, double priceX, string ownerX, Battery gsmBattery, Display gsmDisplay)
        {
            Model = modelX;
            Manufaturer = manufX;
            Price = priceX;
            OwnerName = ownerX;
            GsmBattery = gsmBattery;
            GsmDisplay = gsmDisplay;
        }

        public Battery GsmBattery { get; }
        public Display GsmDisplay { get; }
        //!!!!

        public static GSM Iphone4S
        {
            get
            {
                return iphone4S;
            }
        }

        public string Manufaturer { get; }

        public string OwnerName { get; set; }

        public string Model { get; set; }

        public double Price
        {
            get { return price; }
            set
            {
                try
                {
                    price = Convert.ToDouble(value);
                }
                catch (Exception)
                {
                    throw new ArgumentException("The price must be a number!!!");
                }
            }
        }

        public List<Call> CallHistory
        {
            get { return new List<Call>(listOfCalls); }
        }

        // Methods
        public override string ToString()
        {
            return
                string.Format(
                    "Model-{0}, Manufacturer-{1}, Price-{2}, Owner-{3}, Battery tipe-{4}, Battery Idle-{5}, Battery talk-{6} , Display size-{7}, Display colors - {8}",
                    Model, Manufaturer, Price, OwnerName, GsmBattery.BatteryTipe, GsmBattery.Idle, GsmBattery.OnTalk,
                    GsmDisplay.Size, GsmDisplay.Color);
        }

        internal void ClearCallHistory()
        {
            listOfCalls.Clear();
        }

        internal void AddCallHistory(uint phoneNumber, uint durationOfSeconds)
        {
            listOfCalls.Add(new Call(phoneNumber, durationOfSeconds));
        }

        internal void RemuveCallHistory(uint callID)
        {
            for (var i = 0; i < listOfCalls.Count; i++)
            {
                if (callID == listOfCalls[i].Duration)
                {
                    listOfCalls.Remove(listOfCalls[i]);
                }
            }
        }

        internal decimal CalculatePriceForTalk(decimal priceOfMinute)
        {
            decimal sum = 0;
            for (var i = 0; i < listOfCalls.Count; i++)
            {
                sum += listOfCalls[i].Duration;
            }
            return sum;
        }

        internal void ShowCalls()
        {
            if (listOfCalls.Count > 0)
            {
                foreach (var item in listOfCalls)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Call history is empty!");
            }
        }

        internal void RemuveLongestCall()
        {
            uint max = 0;
            for (var i = 0; i < listOfCalls.Count; i++)
            {
                if (listOfCalls[i].Duration > max)
                {
                    max = listOfCalls[i].Duration;
                }
            }
            RemuveCallHistory(max);
        }
    }
}