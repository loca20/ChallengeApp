namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void AreTwoEmployeesNotEqual()
        {
            var employee1 = GetEmployee("Olga", "Kowalik", 23);
            var employee2 = GetEmployee("Olga", "Kowalik", 23);

            Assert.AreNotEqual(employee1, employee2);
        }

        [Test]
        public void AreNamesTwoEmployeesAreEqual()
        {
            var employee1 = GetEmployee("Olga", "Kowalik", 23);
            var employee2 = GetEmployee("Olga", "Kowalik", 23);

            Assert.AreEqual(employee1.Name, employee2.Name);
        }

        [Test]
        public void AreAgeOfEmployeesAreNotEqual()
        {
            int ageOfEmployee1 = 23;
            int ageOfEmployee2 = 28;

            Assert.AreNotEqual(ageOfEmployee1, ageOfEmployee2);
        }

        [Test]
        public void AreAgeOfEmployeesIsTheSame()
        {
            var employee1 = GetEmployee("Olga", "Kowalik", 23);
            var employee2 = GetEmployee("Olga", "Kowalik", 23);

            Assert.AreEqual(employee1.Age, employee2.Age);
        }
        private Employee GetEmployee(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }
    }
}
