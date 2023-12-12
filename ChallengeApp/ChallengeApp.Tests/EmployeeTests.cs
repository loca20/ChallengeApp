namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void CheckSumOperationWithOnlyPositivePoints()
        {
            var employee = new Employee("Anna", "Sowa", 23);
            employee.AddScore(5);
            employee.AddScore(2);
            employee.AddScore(6);

            var result = employee.Result;

            Assert.AreEqual(13, result);
        }

        [Test]
        public void CheckSumOperationWithOnlyNegativePoints()
        {
            var employee = new Employee("Anna", "Sowa", 23);
            employee.AddScore(-3);
            employee.AddScore(-4);
            employee.AddScore(-1);

            var result = employee.Result;

            Assert.AreEqual(-8, result);
        }

        [Test]
        public void CheckSumOperationWithPositiveAndNegativePoints()
        {
            var employee = new Employee("Anna", "Sowa", 23);
            employee.AddScore(-8);
            employee.AddScore(4);
            employee.AddScore(6);

            var result = employee.Result;

            Assert.AreEqual(2, result);
        }
    }
}
