using ProjetoWebApiAtualizado.Interfaces;
using ProjetoWebApiAtualizado.Mappings;
using ProjetoWebApiAtualizado.Rest;
using ProjetoWebApiAtualizado.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IGeral, ParametrosApiRest>();
builder.Services.AddSingleton<IParametros, ParametrosService>();
builder.Services.AddAutoMapper(typeof(ParametrosMapping));


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





