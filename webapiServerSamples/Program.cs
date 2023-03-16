var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // this Use{Feature} are by convention extention methods middleware components that 
    // compose the request handling pipeline 
    app.UseSwagger();
    app.UseSwaggerUI();
}

// this Use{Feature} are by convention extention methods middleware components that 
// compose the request handling pipeline 
app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();
