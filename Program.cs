internal class Program
{
    private static void Main(string[] args)
    {
        StudentGroup group = new StudentGroup("Group 1", 3);

        group.AddStudent(new Student("John", "20", "1"));
        group.AddStudent(new Student("Jane", "19", "1"));
        group.AddStudent(new Student("Bob", "21", "2"));

        group.GetStudentsInfo();

        group.RemoveStudent(new Student("Jane", "19", "1"));

        group.GetStudentsInfo();

        group.RemoveStudent(new Student("Alice", "22", "3"));
    }

    public class Student 
    {
        public string Name;
        public string Age;
        public string Course;

        public Student(string name, string age, string course)
        {
            this.Name = name;
            this.Age = age;
            this.Course = course;
        }
   
    }

    public class StudentGroup
    {
        public string GroupName { get; set; }
        public int GroupSize { get; set; }
        public List<Student> Students { get; set; }

        public StudentGroup(string groupName, int groupSize)
        {
            GroupName = groupName;
            GroupSize = groupSize;
            Students = new List<Student>();
        }
        public void AddStudent(Student student)
        {
            if(Students.Count < GroupSize) 
            {
                Students.Add(student);
                Console.WriteLine($"{student.Name} added to group {GroupName}");
            }
            else
            {
                Console.WriteLine($"Group {GroupName} is already full. {student.Name} cannot be added.");
            }
        }

        public void RemoveStudent(Student student)
        {
            if(Students.Remove(student))
            {
                Console.WriteLine($"{student.Name} removed from group {GroupName}."); 
            }
            else
            {
                Console.WriteLine($"{student.Name} is not found in group {GroupName}.");
            }
            
        }

        public void GetStudentsInfo()
        {
            Console.WriteLine($"Group {GroupName} has {Students.Count} students:");
            foreach(Student student in Students)
            {
                Console.WriteLine($"{student.Name}, {student.Age} years old, {student.Course}");
            }
        }

    }
}