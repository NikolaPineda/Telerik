using System;

namespace MobilePhone
{
    public class Battery
    {
        private uint howersIdle;
        private uint howersTalk;

        public Battery(string model)
            : this(model, 0, 0, 0)
        {
        }

        public Battery(string model, uint idle, uint talk) : this(model, idle, talk, 0)
        {
        }

        public Battery(string model, uint idle, uint talk, BatteryTypes batteryType)
        {
            Model = model;
            howersIdle = idle;
            howersTalk = talk;
            BatteryTipe = batteryType;
        }

        public BatteryTypes BatteryTipe { get; private set; }

        public string Model { get; set; }

        public uint Idle
        {
            get { return howersIdle; }
            set
            {
                try
                {
                    howersIdle = Convert.ToUInt32(value);
                }
                catch (Exception)
                {
                    throw new ArgumentException("Must be a numbers!");
                }
            }
        }

        public uint OnTalk
        {
            get { return howersTalk; }
            set
            {
                try
                {
                    howersTalk = Convert.ToUInt32(value);
                }
                catch (Exception)
                {
                    throw new ArgumentException("Must be a number!");
                }
            }
        }
    }
}