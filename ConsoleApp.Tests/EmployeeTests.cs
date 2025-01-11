namespace ConsoleApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void SumTest()
        {
            //arrange
            var employee = new Employee("---", "---", 0);
            employee.AddMark(1);
            employee.AddMark(2);
            employee.AddMark(3);

            //act
            var result = employee.Result();

            //assert
            Assert.AreEqual(6, result);
        }

        [Test]
        public void SumTest2()
        {
            //arrange
            var employee = new Employee("---", "---", 0);
            employee.AddMark(5);
            employee.AddMark(5);
            employee.AddMark(-10);

            //act
            var result = employee.Result();

            //assert
            Assert.AreEqual(10, result);
        }

        [Test]
        public void SumTest3()
        {
            //arrange
            var employee = new Employee("---", "---", 0);
            employee.AddMark(0);
            employee.AddMark(-1);
            employee.AddMark(5);

            //act
            var result = employee.Result();

            //assert
            Assert.AreEqual(5, result);
        }

        [Test]
        public void SumTest4()
        {
            //arrange
            var employee = new Employee("---", "---", 0);

            //act
            var result = employee.Result();

            //assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void GetStatisticsTest()
        {
            var employee = new Employee("---", "---", 0);
            employee.AddMark(1);
            employee.AddMark(2);
            employee.AddMark(3);
            employee.AddMark(4);

            var stats = employee.GetStatistics();

            Assert.AreEqual(1, stats.min);
            Assert.AreEqual(4, stats.max);
            Assert.AreEqual(2.5, stats.average);
        }
    }
}
