using Mesa.Shared.Domain.Abstractions.Repositories;
using Mesa.Shared.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<IUsersRepository, UsersRepository>();
var app = builder.Build();
app.Run();
