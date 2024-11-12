using GraphQL.Types;

namespace Channel;

public class ChannelSchema : Schema
{
    public ChannelSchema(StudentQuery studentQuery)
    {
        Query = studentQuery;
    }
}