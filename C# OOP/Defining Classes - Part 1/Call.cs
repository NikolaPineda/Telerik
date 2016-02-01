using System;

namespace MobilePhone
{
    public class Call
    {
        private static uint idVount = 1;
        private uint dailled;
        private DateTime date;
        private uint seconds;

        public Call(uint dailedX, uint secondsX)
        {
            seconds = secondsX;
            dailled = dailedX;
            ID = idVount++;
        }

        public uint Duration
        {
            get { return seconds; }
            set
            {
                try
                {
                    seconds = Convert.ToUInt32(value);
                }
                catch (Exception)
                {
                    throw new ArgumentException("Must be number!");
                }
            }
        }

        public uint Dailled
        {
            get { return dailled; }
            set
            {
                try
                {
                    dailled = Convert.ToUInt32(value);
                }
                catch (Exception)
                {
                    throw new ArgumentException("Must be number!");
                }
            }
        }

        public DateTime Date
        {
            get { return date; }
            set
            {
                try
                {
                    date = DateTime.Parse(value.ToString("ddMMyyyy hh:mm"));
                }
                catch (Exception)
                {
                    throw new ArgumentException("Must be DateTime!");
                }
            }
        }

        public uint ID { get; private set; }
    }
}