using Bogcha.DataAccess.Repositories.WithdrawalRepositories;
using Bogcha.Domain.Entities;

var builder = WebApplication.CreateBuilder(args);
var repo = new WithdrawalRepository(builder.Configuration.GetConnectionString("DefaultConnection"));



var res = await repo.DeleteAsync(19);
Console.WriteLine(res);

// Add services to the container.

//builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

var app = builder.Build();




// Configure the HTTP request pipeline.

//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

app.Run();
