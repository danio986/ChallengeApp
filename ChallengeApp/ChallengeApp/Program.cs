using ChallengeApp;

var employee = new Employee("Daniel", "XYZ");

employee.AddGrade("daniel");
employee.AddGrade(1000);
employee.AddGrade("5");
employee.AddGrade(5.6f);
employee.AddGrade(10.5);
employee.AddGrade(10);
employee.AddGrade(8);

var statistics1 = employee.GetStatisticsWithForEach();
Console.WriteLine("Statystyki dla pętli foreach:");
Console.WriteLine($"Average: {statistics1.Average:N2}");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}");
Console.WriteLine();

var statistics2 = employee.GetStatisticsWithFor();
Console.WriteLine("Statystyki dla pętli for:");
Console.WriteLine($"Average: {statistics2.Average:N2}");
Console.WriteLine($"Min: {statistics2.Min}");
Console.WriteLine($"Max: {statistics2.Max}");
Console.WriteLine();

var statistics3 = employee.GetStatisticsWithWhile();
Console.WriteLine("Statystyki dla pętli While:");
Console.WriteLine($"Average: {statistics3.Average:N2}");
Console.WriteLine($"Min: {statistics3.Min}");
Console.WriteLine($"Max: {statistics3.Max}");
Console.WriteLine();

var statistics4 = employee.GetStatisticsWithDoWhile();
Console.WriteLine("Statystyki dla pętli DoWhile:");
Console.WriteLine($"Average: {statistics4.Average:N2}");
Console.WriteLine($"Min: {statistics4.Min}");
Console.WriteLine($"Max: {statistics4.Max}");