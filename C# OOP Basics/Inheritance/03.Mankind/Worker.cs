using System;
using System.Text;

public class Worker : Humman
{
    private decimal weekSalary;
    private decimal workHoursPerDay;

    public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay)
        : base(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = workHoursPerDay;
    }

    public decimal WeekSalary
    {
        get
        {
            return this.weekSalary;
        }

        private set
        {
            if (value <= 10)
            {
                throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
            }

            this.weekSalary = value;
        }
    }

    public decimal WorkHoursPerDay
    {
        get
        {
            return this.workHoursPerDay;
        }

        private set
        {
            if (value < 1 || value > 12)
            {
                throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
            }

            this.workHoursPerDay = value;
        }
    }

    public override string LastName
    {
        get
        {
            return base.LastName;
        }

        set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");
            }

            base.LastName = value;
        }
    }

    private decimal MoneyByHour()
    {
        return (this.WeekSalary / 5) / this.WorkHoursPerDay;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(base.ToString())
            .AppendFormat("Week Salary: {0:0.00}", this.WeekSalary)
            .AppendLine()
            .AppendFormat("Hours per day: {0:0.00}", this.WorkHoursPerDay)
            .AppendLine()
            .AppendFormat("Salary per hour: {0:0.00}", this.MoneyByHour());

        return sb.ToString().Trim();
    }
}