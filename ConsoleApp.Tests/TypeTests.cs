namespace ConsoleApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void IntTest()
        {
            //arrange
            int x = 5;
            int y = 5;

            //act

            //assert
            Assert.AreEqual(x, y);
        }

        [Test]
        public void StringTest()
        {
            string a = "hello";
            string b = "hello";

            Assert.AreEqual(a, b);
        }

        [Test]
        public void EmployeeTest()
        {
            var emp1 = new Employee("Krzysztof", "Broda", 20);
            var emp2 = new Employee("Krzysztof", "Broda", 20);

            //Assert.AreEqual(emp1, emp2);

            Assert.AreEqual(emp1.name, emp2.name);
            Assert.AreEqual(emp1.surname, emp2.surname);
            Assert.AreEqual(emp1.age, emp2.age);
        }
    }
}
