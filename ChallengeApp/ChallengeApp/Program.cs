using ChallengeApp;

Employee user1 = new Employee("Daniel", "XYZ", 20);
Employee user2 = new Employee("Natalia", "XYZ", 21);
Employee user3 = new Employee("Piotr", "XYZ", 22);

user1.AddGrade(5);
user1.AddGrade(3);
user1.AddGrade(2);
user1.AddGrade(9);
user1.AddGrade(7);

user2.AddGrade(5);
user2.AddGrade(5);
user2.AddGrade(8);
user2.AddGrade(3);
user2.AddGrade(9);
user2.AddGrade(9);

user3.AddGrade(5);
user3.AddGrade(3);
user3.AddGrade(8);
user3.AddGrade(1);
user3.AddGrade(9);

List<Employee> users = new List<Employee>()
{
    user1, user2, user3
};

int maxResult = -1;
Employee userWithMaxResult = null;

foreach (var user in users)
{
    if (user.Result > maxResult)
    {
        maxResult = user.Result;
        userWithMaxResult = user;
    }
}

Console.WriteLine("Pracownik z najwyższą oceną to: " + userWithMaxResult.Name + " " + userWithMaxResult.Surname + ", lat: " + userWithMaxResult.Age);
Console.WriteLine("Wynik: " + userWithMaxResult.Result);