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

        [Test]
        public void StatisticsTestAverageLetter()
        {
            var employee = new Employee("Daniel", "XYZ");
            employee.AddGrade(60);
            employee.AddGrade(20);
            var statistics = employee.GetStatistics();

            Assert.AreEqual('C', statistics.AverageLetter);
        }

        [Test]
        public void AddGrade100IfInputLetterIsA()
        {
            var employee = new Employee("Daniel", "XYZ");
            employee.AddGrade('A');
            var statistics = employee.GetStatistics();

            Assert.AreEqual(100, statistics.Average);
        }
    }
}
