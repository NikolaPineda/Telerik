using System;

namespace StudentsAndWorkers
{
    public class Worker : Human
    {
        private byte workHoursPerDay;

        public Worker(string first, string last, decimal weekS, byte workHours) : base(first, last)
        {
            WeelSalary = weekS;
            workHoursPerDay = workHours;
        }

        public decimal WeelSalary { get; set; }

        public byte WorkHoursPerDay
        {
            get { return workHoursPerDay; }
            set
            {
                if (value > 16)
                {
                    throw new ArgumentOutOfRangeException("The worker can't work more than 16 hours!");
                }
                workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHower()
        {
            var salaryPerDay = WeelSalary/5;
            var result = salaryPerDay/Convert.ToDecimal(workHoursPerDay);
            return result;
        }

        public override string ToString()
        {
            return string.Format("First name:{0}, second name: {1}, money per hour: {2:0.00}", FirstName, LastName,
                MoneyPerHower());
        }
    }
}