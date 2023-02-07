namespace ChallengeApp;
public class Employee
{
    private List<int> grades = new List<int>();

    //Konstruktor
    public Employee(string name, string surname, int age)
    {
        this.Name = name;
        this.Surname = surname;
        this.Age = age;
    }
    //Pola
    public string Name { get; private set; }
    public string Surname { get; private set; }
    public int Age { get; private set; }
    public int Result
    {
        get
        {
            return this.grades.Sum();
        }
    }

    //Metoda
    public void AddGrade(int newgrade)
    {
        this.grades.Add(newgrade);
    }
}