var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();
app.Run();

