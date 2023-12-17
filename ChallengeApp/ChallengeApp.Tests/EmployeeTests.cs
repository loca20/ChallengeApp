namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void CheckAverage()
        {
            var employee = new Employee("Jan", "Kowalski");

            employee.AddGrade(20);
            employee.AddGrade("A");
            employee.AddGrade(30);
            employee.AddGrade(50);

            var result = employee.GetStatistics();

            Assert.AreEqual(50, result.Average);
        }

        [Test]
        public void CheckMinGrade()
        {
            var employee = new Employee("Jan", "Kowalski");

            employee.AddGrade(60);
            employee.AddGrade("e");
            employee.AddGrade(30);
            employee.AddGrade("D");

            var result = employee.GetStatistics();

            Assert.AreEqual(20, result.Min);
        }

        [Test]
        public void CheckMaxGrade()
        {
            var employee = new Employee("Jan", "Kowalski");

            employee.AddGrade(40);
            employee.AddGrade(20);
            employee.AddGrade("C");
            employee.AddGrade("a");

            var result = employee.GetStatistics();

            Assert.AreEqual(100, result.Max);
        }

        [Test]
        public void GradesCount()
        {
            var employee = new Employee("Jan", "Kowalski");

            employee.AddGrade(40);
            employee.AddGrade(20);
            employee.AddGrade("C");
            employee.AddGrade("a");

            var result = employee.GradesCount;

            Assert.AreEqual(4, result);
        }
    }
}