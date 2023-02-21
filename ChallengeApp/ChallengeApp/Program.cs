using ChallengeApp;

var employee = new Employee("Daniel", "XYZ");

employee.AddGrade("daniel");
employee.AddGrade(1000);
employee.AddGrade("5");
employee.AddGrade(5.6f);
employee.AddGrade(10.5);
employee.AddGrade(10);
employee.AddGrade(8);

var statistics = employee.GetStatisticsWithForEach();
Console.WriteLine("Statystyki dla pętli foreach:");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine();