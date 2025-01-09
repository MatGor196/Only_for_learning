namespace ConsoleApp.Tests
{
    public class Tests
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
    }
}