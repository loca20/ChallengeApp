namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {
        private List<float> grades = new List<float>();
 
        public EmployeeInMemory(string name, string surname) 
            : base(name, surname)
        { 
        }
        public int IncorrectGradeCounter { get; private set; }
        public int CorrectGradeCounter { get; private set; }
        public int GradesCount
        {
            get { return grades.Count; }
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
                GradeAddedInfoDelegate();
            }
            else
            {
                IncorrectGradeCounter++;
                throw new Exception($"'{grade}' is invalid grade value. You can add a grade from 0 to 100.");
            }
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else if (char.TryParse(grade, out char result1))
            {
                this.AddGrade(result1);
            }
            else
            {
               IncorrectGradeCounter++;
                throw new Exception($"String '{grade}' can not be convert to float value.");
            }
        }
        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    this.AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    this.AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    this.AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    this.AddGrade(20);
                    break;
                default:
                    IncorrectGradeCounter++;
                    throw new Exception($"String '{grade}' can not be convert to float value. You can use only: A, B, C, D, E.");
            }
        }
        public override void AddGrade(double grade)
        {
            float valueInFloat = (float)grade;
            this.AddGrade(valueInFloat);
        }
        public override void AddGrade(long grade)
        {
            float valueInFloat = (float)grade;
            this.AddGrade(valueInFloat);
        }
        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.grades.Count;

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }

            return statistics;
        }
    }
}
