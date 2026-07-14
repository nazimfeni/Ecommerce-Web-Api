var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/", () => 
{
    return "API is working";

});

app.MapGet("/hello", () => 
{
    return "Hello Zarif";

});

app.MapPost("/hello", () => 
{
    return "Post Method Called";

});
app.MapPut("/hello", () => 
{
    return "Put Method Called";

});
app.MapDelete("/hello", () => 
{
    return "Delete Method Called";

});

app.Run();
