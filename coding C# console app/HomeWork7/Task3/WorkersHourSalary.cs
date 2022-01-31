namespace Task3
{
    class WorkersHourSalary : Workers
    {
        public WorkersHourSalary(string name, double ratePerHour) : base(name)
        {
            AverageSalary = CountSalary(ratePerHour);
        }

        public override double CountSalary(double perHour)
        {
            return 20.8 * 8 * perHour;
        }
    }
}
