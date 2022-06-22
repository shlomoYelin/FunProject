using FunProject.Infrastructure;
using FunProject.Infrastructure.SignalR;
using FunProject.Persistence;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("http://localhost:4200")
                          .AllowAnyMethod()
                          .AllowAnyHeader()
                          .AllowCredentials();
                      });
});

// Add services to the container.
builder.Services.AddInrustractureLayerServices();
builder.Services.AddPersistanceLayerServices();



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSignalR();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

    using var serviceScope = app.Services.GetRequiredService<IServiceScopeFactory>().CreateScope();
    var sampleData = serviceScope.ServiceProvider.GetService<ISampleData>();
    sampleData?.SeedDataAsync();
}

app.UseCors(MyAllowSpecificOrigins);


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapHub<ChatHub>("/chatHub");


app.Run();
