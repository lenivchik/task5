using Microsoft.EntityFrameworkCore;
using WebApplication1.Contexts;
using WebApplication1.Repos;

var builder = WebApplication.CreateBuilder();

// �������� ������ ����������� �� ����� ������������
string connection = builder.Configuration.GetConnectionString("DefaultConnection");

// ��������� �������� ApplicationContext � �������� ������� � ����������
builder.Services.AddDbContext<EFContext>(options => options.UseNpgsql(connection));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddMvc();
builder.Services.AddScoped<DrillBlockPointsRep>();
builder.Services.AddScoped<DrillBlockRep>();
builder.Services.AddScoped<HolePointsRep>();
builder.Services.AddScoped<HoleRep>();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();


app.MapControllers();

app.Run();