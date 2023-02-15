namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void StatisticsTestMax()
        {
            var employee = new Employee("Daniel", "XYZ");
            employee.AddGrade(2);
            employee.AddGrade(5);
            employee.AddGrade(4);
            var statistics = employee.GetStatistics();

            Assert.AreEqual(5, statistics.Max);
        }

        [Test]
        public void StatisticsTestMin()
        {
            var employee = new Employee("Daniel", "XYZ");
            employee.AddGrade(2);
            employee.AddGrade(5);
            employee.AddGrade(4);
            var statistics = employee.GetStatistics();

            Assert.AreEqual(2, statistics.Min);
        }

        [Test]
        public void StatisticsTestAverage()
        {
            var employee = new Employee("Daniel", "XYZ");
            employee.AddGrade(2);
            employee.AddGrade(5);
            employee.AddGrade(4);
            var statistics = employee.GetStatistics();

            Assert.AreEqual(Math.Round(3.67, 2), Math.Round(statistics.Average, 2));
        }
    }
}
