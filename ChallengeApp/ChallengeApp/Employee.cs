namespace ChallengeApp;
public class Employee
{
    private List<float> grades = new List<float>();

    //Konstruktor - wywolywany zawsze przy tworzeniu nowego obiektu
    public Employee(string name, string surname)
    {
        this.Name = name;
        this.Surname = surname;
    }

    //Pola - parametry opisujace nasz obiekt
    public string Name { get; private set; }
    public string Surname { get; private set; }

    //Metoda - 
    public void AddGrade(float grade)
    {
        if (grade >= 0 && grade <= 100)
        {
            this.grades.Add(grade);
        }
        else
        {
            Console.WriteLine("Invalid grade value");
        }
    }

    public void AddGrade(string grade)
    {
        if (float.TryParse(grade, out float result))
        {
            this.AddGrade(result);
        }
        else
        {
            Console.WriteLine("String is not float");
        }
    }

    //public void AddGrade(double grade)
    //{
    //    float valueInFloat = (float)grade;
    //    this.AddGrade(valueInFloat);
    //}
    public void AddGrade(int grade)
    {
        float valueInFloat = (float)grade;
        this.AddGrade(valueInFloat);
    }

    //public void AddGrade(long grade)
    //{
    //    float valueInFloat = (float)grade;
    //    this.AddGrade(valueInFloat);
    //}




    public Statistics GetStatistics()
    {
        var statistics = new Statistics();
        statistics.Average = 0;
        statistics.Max = float.MinValue;
        statistics.Min = float.MaxValue;

        foreach (var grade in this.grades)
        {
            statistics.Max = Math.Max(statistics.Max, grade);
            statistics.Min = Math.Min(statistics.Min, grade);
            statistics.Average += grade;
        }

        statistics.Average /= this.grades.Count;
        //statistics.Average = statistics.Average / this.grades.Count;
        return statistics;
    }
}