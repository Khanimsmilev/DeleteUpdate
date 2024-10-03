using delete_update.Entities.Concrete;
using static delete_update.Configuration.proDbContext;

class Program
{

    public static void AddData(SchoolContext context)
    {
        var teacher = new Teachers { Name = "Mr. Smith" };
        var group = new Group { Name = "Group A", Teacher = teacher };
        var student = new Student { Name = "John Doe", Group = group };

        context.Teachers.Add(teacher);
        context.Groups.Add(group);
        context.Students.Add(student);
        context.SaveChanges(); // Synchronous call
    }

    public static void UpdateStudent(SchoolContext context, int studentId, string newName)
    {
        var student = context.Students.Find(studentId);
        if (student != null)
        {
            student.Name = newName;
            context.SaveChanges(); // Synchronous call
        }
    }

    public static void DeleteStudent(SchoolContext context, int studentId)
    {
        var student = context.Students.Find(studentId);
        if (student != null)
        {
            context.Students.Remove(student);
            context.SaveChanges(); // Synchronous call
        }
    }

    public static void Main()
    {
        using var context = new SchoolContext();

        // Add data
        AddData(context);

        // Update a student
        UpdateStudent(context, 1, "Jane Doe");

        // Delete a student
        DeleteStudent(context, 1);
    }
}
