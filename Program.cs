using crudApiApp.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args); // create a builder
// db connections 
builder.Services.AddDbContext<PersonContext>( options => {
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    options.UseMySql(connectionString,ServerVersion.AutoDetect(connectionString));
});
var app = builder.Build(); 



app.Map("/" ,() => "Hello Henry");




app.Run();
