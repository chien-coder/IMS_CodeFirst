using MemberProjects_API.Data;
using MemberProjects_API.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


#region Connect Database
    builder.Services.AddDbContext<MyDbContext>(op =>
    {
        //op.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
        op.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
    });
    #endregion

#region Register Repository
builder.Services.AddScoped<IMemberProjectsManager, MemberProjectsManager>();
#endregion

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
