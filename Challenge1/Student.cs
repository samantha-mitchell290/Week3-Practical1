namespace Challenge1
{
    class Student
    {
        private int studentId;
        private string name;
        private int age;

        private static int studentCount = 0;

        public int StudentId
        {
            get { return studentId; }
            private set {  studentId = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set {  age = value; }
        }

        public static int StudentCount
        {
            get { return studentCount; }
        }

        //Default contructor
        public Student()
        {
            name = "John Doe";
            age = 16;
            studentId = studentCount++;
        }
        //Custom constructor
        public Student(string  name, int age)
        {
            this.Name = name;
            this.Age = age;
            studentId = studentCount++;
        }

        public void Display()
        {
            Console.WriteLine($"Student's ID: {studentId} Name: {name} Age: {age}");
        }

        public int GetOlder()
        {
            age++;
            return age;
        }
    }
}
