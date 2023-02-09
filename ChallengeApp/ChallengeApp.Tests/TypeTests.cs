namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void TestReference()
        {
            //arrange
            var employee1 = GetEmployee("daniel", "dsda", 12);
            var employee2 = GetEmployee("daniel", "dsda", 13);

            //assert
            Assert.AreNotEqual(employee1, employee2);
        }

        private Employee GetEmployee(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }

        [Test]
        public void TestValueInt()
        {
            //arrange
            int number1 = 2;
            int number2 = 2;

            //assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void TestValueDouble()
        {
            //arrange
            double number1 = 2.3;
            double number2 = 2.3;

            //assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void TestValueFloat()
        {
            //arrange
            float number1 = 2.3F;
            float number2 = 1.3F;

            //assert
            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void TestImmutableString()
        {
            //arrange
            string number1 = "Daniel";
            string number2 = "Daniel";

            //assert
            Assert.AreEqual(number1, number2);
        }
    }
}
