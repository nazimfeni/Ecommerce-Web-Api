var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

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
