using GraphQL.Types;

namespace Channel;

public class StudentType : ObjectGraphType<Student>
{
    public StudentType()
    {
        Name = "StudentType";
        Field(student => student.Id, typeof(IntGraphType));
        Field(x => x.Name, type: typeof(StringGraphType));
        Field(x => x.Age, type: typeof(IntGraphType));
        Field(x => x.Married, type: typeof(BooleanGraphType)).Description("if the student is Married");
    }
}