using GraphQL.Types;

namespace Channel;

public class StudentQuery : ObjectGraphType
{
    public StudentQuery()
    {
        Name = "StudentQuery";
        Field<StudentType>("GetStudent")
            .Argument<IntGraphType>("Id")
            .Resolve(context => StudentGenerator.GetStudent());
        Field<ListGraphType<StudentType>>("GetStudents").Resolve(context => StudentGenerator.GetStudents());
    }
}