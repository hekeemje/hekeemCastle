namespace Task3
{
    class WorkersFixSalary : Workers
    {

        public WorkersFixSalary(string name, double perMonth) :base(name)
        {
            AverageSalary = CountSalary(perMonth);
        }

        public override double CountSalary(double ratePerMonth)
        {
            return ratePerMonth;
        }
    }
}
