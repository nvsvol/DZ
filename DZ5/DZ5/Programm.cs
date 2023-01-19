class Date
{
    private int year;
    private int month;
    private int day;
    private int[] daysInMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
 
    public Date(int year, int month, int day)
    {
        Year = year;
        Month = month;
        Day = day;
    }
 
    public int Year
    {
        get { return year; }
        set
        {
            if (value < 1)
                throw new ArgumentOutOfRangeException("Invalid year");
            year = value;
        }
    }
 
    public int Month
    {
        get { return month; }
        set
        {
            if (value < 1 || value > 12)
                throw new ArgumentOutOfRangeException("Invalid month");
            month = value;
        }
    }
 
    public int Day
    {
        get { return day; }
        set
        {
            if (value < 1 || value > DaysInMonth(year, month))
                throw new ArgumentOutOfRangeException("Invalid day");
            day = value;
        }
    }
 
    public void AddDays(int days)
    {
        for (int i = 0; i < days; i++)
        {
            if (day == DaysInMonth(year, month))
            {
                if (month == 12)
                {
                    year++;
                    month = 1;
                }
                else
                {
                    month++;
                }
                day = 1;
            }
            else
            {
                day++;
            }
        }
    }
 
    public void AddMonths(int months)
    {
        for (int i = 0; i < months; i++)
        {
            if (month == 12)
            {
                year++;
                month = 1;
            }
            else
            {
                month++;
            }
        }
    }
 
    public void AddYears(int years)
    {
        year += years;
    }
 
    private int DaysInMonth(int year, int month)
    {
        if (month == 2 && IsLeapYear(year))
        {
            return 29;
        }
        return daysInMonth[month];
    }
 
    private bool IsLeapYear(int year)
    {
        if (year % 4 != 0)
        {
            return false;
        }
        else if (year % 100 != 0)
        {
            return true;
        }
        else if (year % 400 != 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
