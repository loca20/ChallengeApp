namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();
        private int addGradeCounter = 0;

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
    
        public void AddGrade(float grade)
        {
            
            if(grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                this.addGradeCounter++;
                Console.WriteLine($"'{grade}' is invalid grade value. You can add a grade from 0 to 100.");
            }
           
        }

        public void AddGrade(string grade)
        {
            
            if (float.TryParse(grade, out float result)) 
            {
                this.AddGrade(result);
            }
            else
            {
                this.addGradeCounter++;
                Console.WriteLine($"String '{grade}' can not be convert to float value.");
            }
        }

        public void AddGrade(double grade)
        {
           float valueInFloat = (float)grade;
            this.AddGrade(valueInFloat);
        }
        public void AddGrade(long grade)
        {
            float valueInFloat = (float)grade;
            this.AddGrade(valueInFloat);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
        

            foreach(var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.grades.Count;
            statistics.Counter = this.grades.Count;

            return statistics;
        }

        public int GetAddGradeCounter()
        { return this.addGradeCounter; }
    }
}
