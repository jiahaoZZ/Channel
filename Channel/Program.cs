using Channel;
using GraphQL;
using GraphQL.Server;
using Microsoft.AspNetCore.Components;

var builder = WebApplication.CreateBuilder(args);
// any suggestions to improve this code are welcome
builder.Services.AddGraphQL(cfg =>
{
    cfg.AddSystemTextJson();
});

builder.Services.AddScoped<StudentQuery>();
builder.Services.AddScoped<ChannelSchema>();

var app = builder.Build();
app.UseGraphQL<ChannelSchema>();
app.UseGraphQLGraphiQL("/ui/graphql");

app.MapGet("/", () => "Hello World!");

app.Run();