namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        private List<float> grades = new List<float>();

        public Supervisor(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int IncorrectGradeCounter { get; private set; }
        public int CorrectGradeCounter { get; private set; }
        public int GradesCount
        {
            get { return grades.Count; }
        }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                IncorrectGradeCounter++;
                throw new Exception($"'{grade}' is invalid grade value. You can add a grade from 0 to 100.");
            }

        }

        public void AddGrade(string grade)
        {
            if (grade == "6" ||
                grade == "6-" ||
                grade == "-6" ||
                grade == "+5" ||
                grade == "5+" ||
                grade == "5" ||
                grade == "-5" ||
                grade == "5-" ||
                grade == "+4" ||
                grade == "4+" ||
                grade == "4" ||
                grade == "-4" ||
                grade == "4-" ||
                grade == "+3" ||
                grade == "3+" ||
                grade == "3" ||
                grade == "-3" ||
                grade == "3-" ||
                grade == "+2" ||
                grade == "2+" ||
                grade == "2" ||
                grade == "-2" ||
                grade == "2-" ||
                grade == "+1" ||
                grade == "1+" ||
                grade == "1")
            {
                switch (grade)
                {
                    case "6":
                        this.AddGrade(100);
                        break;
                    case "6-":
                    case "-6":
                        this.AddGrade(95);
                        break;
                    case "5+":
                    case "+5":
                        this.AddGrade(85);
                        break;
                    case "5":
                        this.AddGrade(80);
                        break;
                    case "5-":
                    case "-5":
                        this.AddGrade(75);
                        break;
                    case "4+":
                    case "+4":
                        this.AddGrade(65);
                        break;
                    case "4":
                        this.AddGrade(60);
                        break;
                    case "4-":
                    case "-4":
                        this.AddGrade(55);
                        break;
                    case "3+":
                    case "+3":
                        this.AddGrade(45);
                        break;
                    case "3":
                        this.AddGrade(40);
                        break;
                    case "3-":
                    case "-3":
                        this.AddGrade(35);
                        break;
                    case "2+":
                    case "+2":
                        this.AddGrade(25);
                        break;
                    case "2":
                        this.AddGrade(20);
                        break;
                    case "2-":
                    case "-2":
                        this.AddGrade(15);
                        break;
                    case "1+":
                    case "+1":
                        this.AddGrade(5);
                        break;
                    case "1":
                        this.AddGrade(0);
                        break;
                    default:
                        if (float.TryParse(grade, out float result))
                        {
                            this.AddGrade(result);
                        }
                        break;
                }
            }
            else if (float.TryParse(grade, out float result))
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
        public void AddGrade(char grade)
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
