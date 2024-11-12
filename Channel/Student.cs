namespace Channel;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public bool Married { get; set; }
}

public static class StudentGenerator
{
    public static Student GetStudent() => new Student
    {
        Id = 1,
        Name = "James",
        Age = 21,
        Married = false
    };

    public static List<Student> GetStudents() => [
        new()
        {
            Id = 1,
            Name = "James",
            Age = 21,
            Married = false
        },
        new()
        {
            Id = 2,
            Name = "Jacob",
            Age = 27,
            Married = false
        }
    ];
}