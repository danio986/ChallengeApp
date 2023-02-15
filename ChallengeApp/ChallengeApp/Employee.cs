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
        this.grades.Add(grade);
    }
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