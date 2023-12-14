namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void CheckMaxGrade()
        {
            var employee = new Employee("Anna", "Sowa");

            employee.AddGrade(4);
            employee.AddGrade(2);
            employee.AddGrade(3);
            employee.AddGrade(7);

            var result = employee.GetStatistics();

            Assert.AreEqual(7, result.Max);
        }

        [Test]
        public void CheckMinGrade()
        {
            var employee = new Employee("Anna", "Sowa");

            employee.AddGrade(4);
            employee.AddGrade(2);
            employee.AddGrade(3);
            employee.AddGrade(7);

            var result = employee.GetStatistics();

            Assert.AreEqual(2, result.Min);
        }

        [Test]
        public void CheckAverage()
        {
            var employee = new Employee("Anna", "Sowa");

            employee.AddGrade(4);
            employee.AddGrade(2);
            employee.AddGrade(3);
            employee.AddGrade(7);

            var result = employee.GetStatistics();

            Assert.AreEqual(4, result.Average);
        }
    }
}
