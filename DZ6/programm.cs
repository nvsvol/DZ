class Person
{
    private string _firstName;
    private string _lastName;
    private int _age;
    private string _gender;

    public Person(string firstName, string lastName, int age, string gender)
    {
        _firstName = firstName;
        _lastName = lastName;
        _age = age;
        _gender = gender;
    }

    public string FirstName
    {
        get { return _firstName; }
    }

    public string LastName
    {
        get { return _lastName; }
    }

    public int Age
    {
        get { return _age; }
    }

    public string Gender
    {
        get { return _gender; }
    }

    public virtual double GetAverageIncome()
    {
        return 0;
    }

    public virtual double GetAverageExpense()
    {
        return 0;
    }
}

class Preschooler : Person
{
    public Preschooler(string firstName, string lastName, int age, string gender)
        : base(firstName, lastName, age, gender) { }

    public override double GetAverageIncome()
    {
        return 0;
    }

    public override double GetAverageExpense()
    {
        return 0;
    }
}

class Schoolchild : Person
{
    public Schoolchild(string firstName, string lastName, int age, string gender)
        : base(firstName, lastName, age, gender) { }

    public override double GetAverageIncome()
    {
        return 0;
    }

    public override double GetAverageExpense()
    {
        return 0;
    }
}

class Student : Person
{
    public Student(string firstName, string lastName, int age, string gender)
        : base(firstName, lastName, age, gender) { }

    public override double GetAverageIncome()
    {
        return 0;
    }

    public override double GetAverageExpense()
    {
        return 0;
    }
}

class Working : Person
{
    public Working(string firstName, string lastName, int age, string gender)
        : base(firstName, lastName, age, gender) { }

    public override double GetAverageIncome()
    {
        return 0;
    }

    public override double GetAverageExpense()
    {
        return 0;
    }
}
