using Authen.Repository.Behaviours;
using Authen.Repository.Interface;
using Authen.Services.Behaviours;
using Authen.Services.Interface;
using BaseServices.Action;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddServiceAction();
builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<IUserServices, UserServices>();
builder.Services.AddScoped<IInformationRepository, InformationRepository>();
builder.Services.AddScoped<IInformationServices, InformationServices>();
builder.Services.AddCors();
builder.WebHost.UseIISIntegration();

var app = builder.Build();
app.Services.ApplyDatabaseMigrations();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseSwagger();
app.UseSwaggerUI();
app.UseCors(op => op.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
