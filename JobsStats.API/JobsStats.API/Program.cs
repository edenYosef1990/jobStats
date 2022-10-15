using JobsStats.API.DB;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(
    options => options.AddPolicy(
        "AllowOrigin",
        builder => builder.WithOrigins("http://localhost:4200")
                          //.AllowAnyOrigin()
                          .AllowAnyMethod()
                          .AllowAnyHeader()
                          .AllowCredentials()
        ));
// Add services to the container.
builder.Services.AddDbContext<JobStatsDbContext>();
builder.Services.AddScoped<IJobStatisticsRepository, SqlJobStatisticsRepository>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("AllowOrigin");
app.UseAuthorization();

app.MapControllers();

app.Run();