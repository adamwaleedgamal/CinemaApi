using Adam_Waleed_0522028_api.Data;
using Adam_Waleed_0522028_api.Repo.CateogiryRepo;
using Adam_Waleed_0522028_api.Repo.DirectorsRepo;
using Adam_Waleed_0522028_api.Repo.MoviesRepo;
using Adam_Waleed_0522028_api.Repo.NationalityDto;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var Configuration = builder.Configuration.GetConnectionString("MyConn");
builder.Services.AddDbContext<AppdbContext>(options => options.UseSqlServer(Configuration));

builder.Services.AddScoped<IMovies_Repo, Moivies_Repo>();
builder.Services.AddScoped<IDirectior_Repo , Direcotrs_Repo>();
builder.Services.AddScoped<ICateogiry_Repo, Cateogiry_Repo>();
builder.Services.AddScoped<INationality_Repo, Nationality_Repo>();



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
