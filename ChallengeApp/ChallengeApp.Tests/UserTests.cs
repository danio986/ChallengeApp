namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void CheckSumGradesOfEmployee()
        {
            //arrange
            var employee = new Employee("Daniel", "dsda", 12);
            employee.AddGrade(1);
            employee.AddGrade(1);
            employee.AddGrade(-5);

            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(6, result);

        }
        [Test]
        public void CheckSumGradesOfEmployee2()
        {
            //arrange
            var employee2 = new Employee("Natalia", "dsda", 12);
            employee2.AddGrade(10);
            employee2.AddGrade(5);
            employee2.AddGrade(-5);

            //act
            var result = employee2.Result;

            //assert
            Assert.AreEqual(10, result);

        }
    }
}